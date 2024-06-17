using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace pcstore_arm
{
    public partial class history : Form
    {
        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;

        themes Themes = new themes();
        string currentTheme;

        public history(IConnect connectionProvider)
        {
            InitializeComponent();
            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();

            currentTheme = Themes.LoadTheme();
            if (currentTheme == "light")
            {
                Themes.ApplyLightTheme(this);
            }
            else
            {
                Themes.ApplyBlueTheme(this);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void history_Load(object sender, EventArgs e)
        {
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            flowLayoutPanelHistory.Controls.Clear();

            string query = "SELECT id, \"time\", sum, list FROM public.history";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    DateTime orderTime = reader.GetDateTime(1);
                    decimal orderSum = reader.GetDecimal(2);
                    string orderList = reader.GetString(3);

                    Panel receiptPanel = new Panel();
                    receiptPanel.Size = new Size(290, 90);
                    receiptPanel.BorderStyle = BorderStyle.FixedSingle;
                    receiptPanel.Margin = new Padding(5);

                    Label orderIdLabel = new Label();
                    orderIdLabel.Text = $"Заказ №{orderId}";
                    orderIdLabel.Location = new Point(10, 10);
                    orderIdLabel.AutoSize = true;
                    receiptPanel.Controls.Add(orderIdLabel);

                    Label orderTimeLabel = new Label();
                    orderTimeLabel.Text = $"Дата: {orderTime}";
                    orderTimeLabel.Location = new Point(10, 30);
                    orderTimeLabel.AutoSize = true;
                    receiptPanel.Controls.Add(orderTimeLabel);

                    Label orderSumLabel = new Label();
                    orderSumLabel.Text = $"Сумма: ₸{orderSum:0.00}";
                    orderSumLabel.Location = new Point(10, 50);
                    orderSumLabel.AutoSize = true;
                    receiptPanel.Controls.Add(orderSumLabel);

                    Button viewButton = new Button();
                    viewButton.Text = "Просмотр";
                    viewButton.Location = new Point(200, 10);
                    viewButton.Size = new Size(80, 30);
                    viewButton.Click += (sender, e) => ViewReceipt(orderId, orderList);
                    receiptPanel.Controls.Add(viewButton);

                    Button printButton = new Button();
                    printButton.Text = "Печать";
                    printButton.Location = new Point(200, 50);
                    printButton.Size = new Size(80, 30);
                    printButton.Click += (sender, e) => PrintReceipt(orderId, orderSum, orderList);
                    receiptPanel.Controls.Add(printButton);

                    flowLayoutPanelHistory.Controls.Add(receiptPanel);
                }
            }
        }

        private void ViewReceipt(int orderId, string orderList)
        {
            // Разбор списка товаров
            var orderItems = orderList.Split(',').Select(item =>
            {
                var parts = item.Split(':');
                return new { ProductId = int.Parse(parts[0]), Quantity = int.Parse(parts[1]) };
            }).ToList();

            // Формирование SQL запроса для получения информации о товарах
            string ids = string.Join(",", orderItems.Select(item => item.ProductId));
            string query = $"SELECT id, name, cost FROM public.catalog WHERE id IN ({ids})";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            var productDetails = new Dictionary<int, (string Name, decimal Cost)>();

            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int productId = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    decimal productCost = reader.GetDecimal(2);

                    productDetails[productId] = (productName, productCost);
                }
            }

            // Формирование сообщения для отображения в MessageBox
            string message = $"Заказ №{orderId}\n";
            message += $"Список товаров:\n";

            foreach (var item in orderItems)
            {
                if (productDetails.ContainsKey(item.ProductId))
                {
                    var product = productDetails[item.ProductId];
                    message += $"Товар: {product.Name}, Количество: {item.Quantity}, Цена за штуку: ₸{product.Cost:0.00}, Всего: ₸{item.Quantity * product.Cost:0.00}\n";
                }
            }

            MessageBox.Show(message, "Детали заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintReceipt(int orderId, decimal orderSum, string orderList)
        {
            string receipt = $"Заказ №{orderId}\n";
            receipt += $"Дата: {DateTime.Now}\n";
            receipt += $"Сумма: ₸{orderSum:0.00}\n";
            receipt += $"\nСписок товаров: {orderList}\n";

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => PrintPageHandler(sender, e, receipt);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e, string receipt)
        {
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            foreach (string line in receipt.Split('\n'))
            {
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineHeight;
            }
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

        }

        private void перейтиВИсториюПокупокToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
