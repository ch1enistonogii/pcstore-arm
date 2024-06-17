using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcstore_arm
{
    public partial class redactor : Form
    {
        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;
        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private string query = "SELECT * FROM public.catalog";

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
        }

        private void LoadProducts(string query)
        {
            try
            {
                DataTable newDataTable = new DataTable();
                dataAdapter.SelectCommand = new NpgsqlCommand(query, connection);

                dataAdapter.Fill(newDataTable);

                // Проверяем, есть ли необходимые колонки в newDataTable
                if (newDataTable.Columns.Contains("id"))
                    newDataTable.Columns["id"].ColumnName = "ID";
                if (newDataTable.Columns.Contains("img"))
                    newDataTable.Columns["img"].ColumnName = "Изображение";
                if (newDataTable.Columns.Contains("name"))
                    newDataTable.Columns["name"].ColumnName = "Название";
                if (newDataTable.Columns.Contains("cost"))
                    newDataTable.Columns["cost"].ColumnName = "Цена";
                if (newDataTable.Columns.Contains("category"))
                    newDataTable.Columns["category"].ColumnName = "Категория";
                if (newDataTable.Columns.Contains("description"))
                    newDataTable.Columns["description"].ColumnName = "Описание";
                if (newDataTable.Columns.Contains("quantity"))
                    newDataTable.Columns["quantity"].ColumnName = "Количество";

                dataGridView1.DataSource = newDataTable;

                dataGridView1.Columns["Название"].Width = 220;
                dataGridView1.Columns["Категория"].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
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

                        int targetWidth = 75;
                        int targetHeight = 75;

                        Image scaledImage = new Bitmap(image, targetWidth, targetHeight);

                        e.Value = scaledImage;
                        dataGridView1.Rows[e.RowIndex].Height = scaledImage.Height;
                    }
                }
            }
        }


        private void UpdateCatalogData(int productId, string columnName, object newValue)
        {
            string updateQuery = $"UPDATE public.catalog SET {columnName} = @newValue WHERE id = @productId";
            using (var command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("newValue", newValue);
                command.Parameters.AddWithValue("productId", productId);
                command.ExecuteNonQuery();
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
                    query += " WHERE category = 'Без категории'";
                    break;
            }
            LoadProducts(query);
        }
    }
}