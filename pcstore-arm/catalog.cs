using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.DirectoryServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace pcstore_arm
{
    public partial class catalog : Form
    {
        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;

        private int catalog_count = 0;
        private int list_count = 0;

        private List<int> selectedProducts = new List<int>();
        private Dictionary<int, int> productQuantities = new Dictionary<int, int>();
        private Dictionary<int, int> productStock = new Dictionary<int, int>(); // Для хранения доступного количества товаров

        private string query = "SELECT * FROM public.catalog";

        themes Themes = new themes();
        string currentTheme;

        public catalog(IConnect connectionProvider)
        {
            InitializeComponent();

            currentTheme = Themes.LoadTheme();
            if (currentTheme == "light")
            {
                Themes.ApplyLightTheme(this);
            }
            else
            {
                Themes.ApplyBlueTheme(this);
            }

            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();
            dataAdapter = new NpgsqlDataAdapter();

            search_pictureBox.ImageLocation = "etc\\icons\\default\\search.png";

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            LoadProducts(query);
        }

        private void ClearCart()
        {
            selectedProducts.Clear();
            productQuantities.Clear(); // Очистите словарь количества
            flowLayoutPanel2.Controls.Clear();
            tabPage2.Text = "Корзина (0)"; // Сброс текста вкладки
        }

        private void LoadProducts(string query)
        {
            flowLayoutPanel1.Controls.Clear();

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    byte[] productImageBytes = reader.IsDBNull(1) ? null : (byte[])reader["img"];
                    string productName = reader.GetString(2);
                    decimal productPrice = reader.GetDecimal(3);
                    string productCategory = reader.GetString(4);
                    string productDescription = reader.GetString(5);
                    int productQuantity = reader.GetInt32(6);

                    // Сохранить доступное количество товара в словарь
                    productStock[productId] = productQuantity;

                    Panel productPanel = new Panel();
                    productPanel.Size = new Size(500, 220);
                    productPanel.BorderStyle = BorderStyle.FixedSingle;
                    productPanel.Margin = new Padding(5);

                    if (productImageBytes != null && productImageBytes.Length > 0)
                    {
                        PictureBox productImagePictureBox = new PictureBox();
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(productImageBytes))
                            {
                                productImagePictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        productImagePictureBox.Size = new Size(100, 100);
                        productImagePictureBox.Location = new Point(10, 10);
                        productImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        productPanel.Controls.Add(productImagePictureBox);
                    }

                    Label productNameLabel = new Label();
                    productNameLabel.Text = productName;
                    productNameLabel.Location = new Point(115, 10);
                    productNameLabel.AutoSize = true;
                    productPanel.Controls.Add(productNameLabel);

                    Label productPriceLabel = new Label();
                    productPriceLabel.Text = $"Цена: ₸{productPrice:0.00}";
                    productPriceLabel.Location = new Point(115, 30);
                    productPriceLabel.AutoSize = true;
                    productPanel.Controls.Add(productPriceLabel);

                    Label productCategoryLabel = new Label();
                    productCategoryLabel.Text = $"Категория: {productCategory}";
                    productCategoryLabel.Location = new Point(115, 50);
                    productCategoryLabel.AutoSize = true;
                    productPanel.Controls.Add(productCategoryLabel);

                    Label productQuantityLabel = new Label();
                    productQuantityLabel.Text = $"Количество: {productQuantity}";
                    productQuantityLabel.Location = new Point(115, 70);
                    productQuantityLabel.AutoSize = true;
                    productPanel.Controls.Add(productQuantityLabel);

                    Label productDescriptionLabel = new Label();
                    productDescriptionLabel.Text = $"Описание: {productDescription}";
                    productDescriptionLabel.Location = new Point(115, 90);
                    productDescriptionLabel.AutoSize = true;
                    productDescriptionLabel.MaximumSize = new Size(350, 0);
                    productPanel.Controls.Add(productDescriptionLabel);

                    Button addButton = new Button();
                    addButton.Text = "Добавить";
                    addButton.Location = new Point(10, 120);
                    addButton.Size = new Size(100, 50);
                    addButton.Click += (sender, e) => AddToCart(productId);
                    productPanel.Controls.Add(addButton);

                    flowLayoutPanel1.Controls.Add(productPanel);
                }
            }
        }

        private void AddToCart(int productId)
        {
            if (productQuantities.ContainsKey(productId))
            {
                if (productQuantities[productId] < productStock[productId])
                {
                    productQuantities[productId]++;
                }
                else
                {
                    MessageBox.Show($"Невозможно добавить больше товаров. Доступное количество: {productStock[productId]}.");
                    return;
                }
            }
            else
            {
                productQuantities[productId] = 1;
            }

            selectedProducts.Add(productId);
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            flowLayoutPanel2.Controls.Clear();

            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Корзина пуста");
                tabPage2.Text = "Корзина";
                return;
            }

            string ids = string.Join(",", selectedProducts.Distinct());
            string query = $"SELECT id, img, name, cost, category, description, quantity FROM public.catalog WHERE id IN ({ids})";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    byte[] productImageBytes = reader.IsDBNull(1) ? null : (byte[])reader["img"];
                    string productName = reader.GetString(2);
                    decimal productPrice = reader.GetDecimal(3);
                    string productCategory = reader.GetString(4);
                    string productDescription = reader.GetString(5);
                    int productQuantity = productQuantities[productId];

                    Panel productPanel = new Panel();
                    productPanel.Size = new Size(500, 220);
                    productPanel.BorderStyle = BorderStyle.FixedSingle;
                    productPanel.Margin = new Padding(5);

                    if (productImageBytes != null && productImageBytes.Length > 0)
                    {
                        PictureBox productImagePictureBox = new PictureBox();
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(productImageBytes))
                            {
                                productImagePictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        productImagePictureBox.Size = new Size(100, 100);
                        productImagePictureBox.Location = new Point(10, 10);
                        productImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        productPanel.Controls.Add(productImagePictureBox);
                    }

                    Label productNameLabel = new Label();
                    productNameLabel.Text = productName;
                    productNameLabel.Location = new Point(115, 10);
                    productNameLabel.AutoSize = true;
                    productPanel.Controls.Add(productNameLabel);

                    Label productPriceLabel = new Label();
                    productPriceLabel.Text = $"Цена: ₸{productPrice:0.00}";
                    productPriceLabel.Location = new Point(115, 30);
                    productPriceLabel.AutoSize = true;
                    productPanel.Controls.Add(productPriceLabel);

                    Label productCategoryLabel = new Label();
                    productCategoryLabel.Text = $"Категория: {productCategory}";
                    productCategoryLabel.Location = new Point(115, 50);
                    productCategoryLabel.AutoSize = true;
                    productPanel.Controls.Add(productCategoryLabel);

                    Label productQuantityLabel = new Label();
                    productQuantityLabel.Text = $"Количество: {productQuantity}";
                    productQuantityLabel.Location = new Point(115, 70);
                    productQuantityLabel.AutoSize = true;
                    productPanel.Controls.Add(productQuantityLabel);

                    Label productDescriptionLabel = new Label();
                    productDescriptionLabel.Text = $"Описание: {productDescription}";
                    productDescriptionLabel.Location = new Point(115, 90);
                    productDescriptionLabel.AutoSize = true;
                    productDescriptionLabel.MaximumSize = new Size(350, 0);
                    productPanel.Controls.Add(productDescriptionLabel);

                    Button removeButton = new Button();
                    removeButton.Text = "Удалить";
                    removeButton.Location = new Point(10, 120);
                    removeButton.Size = new Size(100, 50);
                    removeButton.Click += (sender, e) => RemoveFromCart(productId);
                    productPanel.Controls.Add(removeButton);

                    flowLayoutPanel2.Controls.Add(productPanel);
                }
                tabPage2.Text = $"Корзина ({selectedProducts.Distinct().Count()})";
            }
        }

        private void RemoveFromCart(int productId)
        {
            if (productQuantities.ContainsKey(productId))
            {
                productQuantities[productId]--;
                if (productQuantities[productId] <= 0)
                {
                    productQuantities.Remove(productId);
                    selectedProducts.RemoveAll(id => id == productId);
                }
            }
            LoadShoppingList();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            // Собрать информацию о заказе
            var orderItems = selectedProducts
                .Distinct()
                .ToDictionary(
                    id => id,
                    id => (Quantity: productQuantities[id], Price: GetProductPrice(id))
                );

            // Рассчитать сумму заказа
            decimal orderSum = orderItems.Sum(item => item.Value.Price * item.Value.Quantity);

            // Создать запрос для вставки заказа в таблицу history
            string insertQuery = "INSERT INTO public.history(id, \"time\", sum, list) VALUES (@id, @time, @sum, @list)";

            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // Генерировать уникальный идентификатор заказа
                    int orderId = GenerateOrderId();

                    // Вставить заказ в базу данных
                    using (var command = new NpgsqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("id", orderId);
                        command.Parameters.AddWithValue("time", DateTime.Now);
                        command.Parameters.AddWithValue("sum", orderSum);
                        command.Parameters.AddWithValue("list", string.Join(",", orderItems.Select(item => $"{item.Key}:{item.Value.Quantity}")));

                        command.ExecuteNonQuery();
                    }

                    // Обновить количество товаров в базе данных
                    foreach (var item in orderItems)
                    {
                        UpdateProductQuantity(item.Key, item.Value.Quantity);
                    }

                    // Завершить транзакцию
                    transaction.Commit();

                    // Вывести чек на печать
                    PrintReceipt(orderId, orderSum, orderItems);

                    // Очистить корзину
                    ClearCart();
                }
                catch (Exception ex)
                {
                    // Откатить транзакцию в случае ошибки
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}");
                }
                LoadProducts(query);
            }
        }

        private void UpdateProductQuantity(int productId, int quantitySold)
        {
            string updateQuery = "UPDATE public.catalog SET quantity = quantity - @quantitySold WHERE id = @productId";
            using (var command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("quantitySold", quantitySold);
                command.Parameters.AddWithValue("productId", productId);
                command.ExecuteNonQuery();
            }
        }

        private decimal GetProductPrice(int productId)
        {
            string query = "SELECT cost FROM public.catalog WHERE id = @id";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("id", productId);
                return (decimal)command.ExecuteScalar();
            }
        }

        private int GenerateOrderId()
        {
            string query = "SELECT nextval('public.history_id_seq')";
            using (var command = new NpgsqlCommand(query, connection))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void PrintReceipt(int orderId, decimal orderSum, Dictionary<int, (int Quantity, decimal Price)> orderItems)
        {
            // Сгенерировать текст чека
            string receipt = $"Заказ №{orderId}\n";
            receipt += $"Дата: {DateTime.Now}\n";
            receipt += $"Сумма: ₸{orderSum:0.00}\n";
            receipt += "\nСписок товаров:\n";
            foreach (var item in orderItems)
            {
                receipt += $"Товар ID: {item.Key}, Количество: {item.Value.Quantity}, Цена: ₸{item.Value.Price:0.00}, Всего: ₸{item.Value.Price * item.Value.Quantity:0.00}\n";
            }

            // Создать объект PrintDocument и назначить обработчик события PrintPage
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => PrintPageHandler(sender, e, receipt);

            // Показать PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Напечатать документ
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e, string receipt)
        {
            // Настроить шрифт и положение для печати
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Печатать текст чека построчно
            foreach (string line in receipt.Split('\n'))
            {
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }
        }

        private void search_pictureBox_Click(object sender, EventArgs e)
        {
            if (search_textBox.Text != "Поиск" || search_pictureBox.Text.Length > 1)
            {
                query = $"SELECT * FROM public.catalog WHERE name ILIKE '%{search_textBox.Text}%';";
                LoadProducts(query);
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
            }

            LoadProducts(query);
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
            redactor redactorForm = new redactor(connectionProvider);
            redactorForm.Show();
        }

        private void перейтиВРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redactor redactorForm = new redactor(connectionProvider);
            this.Hide();
            redactorForm.FormClosed += (s, args) => this.Close();
            redactorForm.Show();
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProducts(query);
        }
    }
}