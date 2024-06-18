using Npgsql;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pcstore_arm
{
    public partial class redactor : Form
    {
        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;

        themes Themes = new themes();
        string currentTheme;

        private string query = "SELECT * FROM public.catalog";

        private string insertQuery = "INSERT INTO public.catalog(id, img, name, cost, category, description, quantity) " +
                                     "VALUES (@id, @img, @name, @cost, @category, @description, @quantity)";

        public redactor(IConnect connectionProvider)
        {
            InitializeComponent();
            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();
            dataAdapter = new NpgsqlDataAdapter();
            dataTable = new DataTable();

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void redactor_Load(object sender, EventArgs e)
        {
            LoadProducts(query);

            currentTheme = Themes.LoadTheme();
            ApplyTheme(currentTheme);
        }

        private void LoadProducts(string query)
        {
            try
            {
                DataTable newDataTable = new DataTable();
                dataAdapter.SelectCommand = new NpgsqlCommand(query, connection);

                dataAdapter.Fill(newDataTable);

                MapColumns(newDataTable);

                dataGridView1.DataSource = newDataTable;

                SetDataGridViewColumnWidths();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void MapColumns(DataTable dataTable)
        {
            if (dataTable.Columns.Contains("id"))
                dataTable.Columns["id"].ColumnName = "ID";
            if (dataTable.Columns.Contains("img"))
                dataTable.Columns["img"].ColumnName = "Изображение";
            if (dataTable.Columns.Contains("name"))
                dataTable.Columns["name"].ColumnName = "Название";
            if (dataTable.Columns.Contains("cost"))
                dataTable.Columns["cost"].ColumnName = "Цена";
            if (dataTable.Columns.Contains("category"))
                dataTable.Columns["category"].ColumnName = "Категория";
            if (dataTable.Columns.Contains("description"))
                dataTable.Columns["description"].ColumnName = "Описание";
            if (dataTable.Columns.Contains("quantity"))
                dataTable.Columns["quantity"].ColumnName = "Количество";
        }

        private void SetDataGridViewColumnWidths()
        {
            dataGridView1.Columns["Изображение"].Width = 125;
            dataGridView1.Columns["Название"].Width = 300;
            dataGridView1.Columns["Категория"].Width = 100;
            dataGridView1.Columns["Описание"].Width = 400;
        }

        private void ApplyTheme(string themeName)
        {
            switch (themeName)
            {
                case "light":
                    Themes.ApplyLightTheme(this);
                    break;
                case "blue":
                    Themes.ApplyBlueTheme(this);
                    break;
                case "green":
                    Themes.ApplyGreenTheme(this);
                    break;
                case "pink":
                    Themes.ApplyPinkTheme(this);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Изображение") && e.RowIndex >= 0)
            {
                byte[] byteArray = e.Value as byte[];

                if (byteArray != null && byteArray.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(byteArray))
                    {
                        Image image = Image.FromStream(ms);

                        int targetWidth = 125;
                        int targetHeight = 125;

                        Image scaledImage = new Bitmap(image, targetWidth, targetHeight);

                        e.Value = scaledImage;
                        dataGridView1.Rows[e.RowIndex].Height = scaledImage.Height;
                    }
                }
            }
        }

        private void sorting_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sorting_comboBox.Text)
            {
                case "ID  (Возрастание)":
                    query = "SELECT * FROM public.catalog ORDER BY id ASC";
                    break;
                case "Название  (Возрастание)":
                    query = "SELECT * FROM public.catalog ORDER BY name ASC";
                    break;
                case "Цена  (Возрастание)":
                    query = "SELECT * FROM public.catalog ORDER BY cost ASC";
                    break;
                case "Категория  (Возрастание)":
                    query = "SELECT * FROM public.catalog ORDER BY category ASC";
                    break;
                case "Количество  (Возрастание)":
                    query = "SELECT * FROM public.catalog ORDER BY quantity ASC";
                    break;
                case "ID  (Убывание)":
                    query = "SELECT * FROM public.catalog ORDER BY id DESC";
                    break;
                case "Название  (Убывание)":
                    query = "SELECT * FROM public.catalog ORDER BY name DESC";
                    break;
                case "Цена  (Убывание)":
                    query = "SELECT * FROM public.catalog ORDER BY cost DESC";
                    break;
                case "Категория  (Убывание)":
                    query = "SELECT * FROM public.catalog ORDER BY category DESC";
                    break;
                case "Количество  (Убывание)":
                    query = "SELECT * FROM public.catalog ORDER BY quantity DESC";
                    break;
                case "Без сортировки":
                    query = "SELECT * FROM public.catalog";
                    break;
            }
            LoadProducts(query);
        }

        private void category_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM public.catalog";

            switch (category_comboBox.Text)
            {
                case "Системные блоки":
                    query += " WHERE category = 'Системные блоки'";
                    break;
                case "Ноутбуки":
                    query += " WHERE category = 'Ноутбуки'";
                    break;
                case "Мыши":
                    query += " WHERE category = 'Мыши'";
                    break;
                case "Клавиатуры":
                    query += " WHERE category = 'Клавиатуры'";
                    break;
                case "Накопители":
                    query += " WHERE category = 'Накопители'";
                    break;
                case "Кабели":
                    query += " WHERE category = 'Кабели'";
                    break;
                case "МФУ":
                    query += " WHERE category = 'МФУ'";
                    break;
                case "Без категории":
                    query = "SELECT * FROM public.catalog";
                    break;
            }
            LoadProducts(query);
        }

        private void search_pictureBox_Click(object sender, EventArgs e)
        {
            if (search_textBox.Text != "Поиск" || search_pictureBox.Text.Length > 1)
            {
                query = $"SELECT * FROM public.catalog WHERE name ILIKE '%{search_textBox.Text}%';";
                LoadProducts(query);
            }
        }

        private void delete_pictureBox_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                string deleteQuery = $"DELETE FROM public.catalog WHERE id = @productId";
                using (var command = new NpgsqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("productId", productId);
                    command.ExecuteNonQuery();
                }

                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_pictureBox_Click(object sender, EventArgs e)
        {
            LoadProducts(query);
        }

        private void img_textBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_textBox.Text = openFileDialog.FileName;
            }
        }


        private void description_textBox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(description_textBox.Text, description_textBox.Font);
            description_textBox.Width = Math.Max(200, size.Width + 10);  // Минимальная ширина 200, добавляем 10 для отступов
            description_textBox.Height = Math.Max(20, size.Height + 10); // Минимальная высота 20, добавляем 10 для отступов
        }

        private void addData_button_Click(object sender, EventArgs e)
        {
            // Проверка наличия всех необходимых данных
            if (string.IsNullOrWhiteSpace(id_textBox.Text) ||
                string.IsNullOrWhiteSpace(img_textBox.Text) ||
                string.IsNullOrWhiteSpace(name_textBox.Text) ||
                string.IsNullOrWhiteSpace(price_textBox.Text) ||
                string.IsNullOrWhiteSpace(category_textBox.Text) ||
                string.IsNullOrWhiteSpace(description_textBox.Text) ||
                string.IsNullOrWhiteSpace(quantity_textBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для добавления новой записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Считываем значения из текстбоксов
            int id;
            if (!int.TryParse(id_textBox.Text, out id))
            {
                MessageBox.Show("Неверный формат ID");
                return;
            }

            string imgPath = img_textBox.Text; // Путь к изображению
            string name = name_textBox.Text; // Название товара
            decimal price;
            if (!decimal.TryParse(price_textBox.Text, out price))
            {
                MessageBox.Show("Неверный формат цены");
                return;
            }

            string category = category_textBox.Text; // Категория товара
            string description = description_textBox.Text; // Описание товара
            int quantity;
            if (!int.TryParse(quantity_textBox.Text, out quantity))
            {
                MessageBox.Show("Неверный формат количества");
                return;
            }

            try
            {
                byte[] imageBytes = File.ReadAllBytes(imgPath);

                using (var command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@img", imageBytes);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cost", price);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();

                    // Обновляем отображаемую таблицу
                    LoadProducts(query);

                    // Очищаем поля ввода
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            id_textBox.Text = "ID";
            img_textBox.Text = "Путь то изображения";
            name_textBox.Text = "Название";
            price_textBox.Text = "Цена";
            category_textBox.Text = "Категория";
            description_textBox.Text = "Описание";
            quantity_textBox.Text = "Количество";
        }

        private void открытьМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainForm = new main(connectionProvider);
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void перезапускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;
            Process.Start(exePath);
            Application.Exit();
        }

        private void открытьКассуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog catalogForm = new catalog(connectionProvider);
            catalogForm.Show();
        }

        private void перейтиВКассуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog catalogForm = new catalog(connectionProvider);
            this.Hide();
            catalogForm.FormClosed += (s, args) => this.Close();
            catalogForm.Show();
        }

        private void открытьИсториюПокупокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history historyForm = new history(connectionProvider);
            historyForm.Show();
        }

        private void перейтиВИсториюПокупокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history historyForm = new history(connectionProvider);
            this.Hide();
            historyForm.FormClosed += (s, args) => this.Close();
            historyForm.Show();
        }

        private void открытьРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void перейтиВРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProducts(query);
        }
    }
}