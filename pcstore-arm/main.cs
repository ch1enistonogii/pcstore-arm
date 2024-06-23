using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace pcstore_arm
{
    public partial class main : Form
    {
        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;

        themes Themes = new themes();
        string currentTheme;

        public main(IConnect connectionProvider)
        {
            InitializeComponent();
            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();
        }

        private void main_Load(object sender, EventArgs e)
        {
            PictureBoxLoad();

            currentTheme = Themes.LoadTheme();
            if (currentTheme == "light")
            {
                Themes.ApplyLightTheme(this);
            }
            else if (currentTheme == "blue")
            {
                Themes.ApplyBlueTheme(this);
            }
            else if (currentTheme == "green")
            {
                Themes.ApplyGreenTheme(this);
            }
            else if (currentTheme == "pink")
            {
                Themes.ApplyPinkTheme(this);
            }

            StartRichTextBoxLoad();
            SettingsRichTextBoxLoad();
            CashboxRichTextBoxLoad();
            StorageRichTextBoxLoad();
        }

        private void PictureBoxLoad()
        {
            cashbox_pictureBox.ImageLocation = "etc\\icons\\default\\cashbox.png";
            storage_pictureBox.ImageLocation = "etc\\icons\\default\\storage.png";
            check_pictureBox.ImageLocation = "etc\\icons\\default\\check.png";
            settings_pictureBox.ImageLocation = "etc\\icons\\default\\settings.png";
            reboot_pictureBox.ImageLocation = "etc\\icons\\default\\reboot.png";
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("adfasfd");
        }

        private void cashbox_panel_Click(object sender, EventArgs e)
        {
            catalog catalogForm = new catalog(connectionProvider);
            this.Hide();
            catalogForm.FormClosed += (s, args) => this.Close();
            catalogForm.Show();
        }

        private void storage_panel_Click(object sender, EventArgs e)
        {
            redactor redactorForm = new redactor(connectionProvider);
            this.Hide();
            redactorForm.FormClosed += (s, args) => this.Close();
            redactorForm.Show();
        }

        private void settings_panel_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings(connectionProvider);
            settingsForm.Show();
        }

        private void reboot_panel_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;
            Process.Start(exePath);
            Application.Exit();
        }

        private void check_panel_Click(object sender, EventArgs e)
        {
            history historyForm = new history(connectionProvider);
            this.Hide();
            historyForm.FormClosed += (s, args) => this.Close();
            historyForm.Show();
        }

        private void cashbox_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void StartRichTextBoxLoad()
        {
            start_richTextBox.Clear();

            AppendFormattedText(start_richTextBox, "Краткий справочник по программе\n", FontStyle.Bold);

            AppendFormattedText(start_richTextBox, "\nДобро пожаловать в нашу программу! Это краткий справочник, который поможет вам понять основные функции и возможности данного программного обеспечения.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "Назначение программы:\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "Программа предназначена для обработки заказов и редактирования базы данных. Она обеспечивает удобный интерфейс для управления заказами, товарами на складе и настройками системы.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "Основные окна программы:\n", FontStyle.Bold);

            AppendFormattedText(start_richTextBox, "1. Касса:\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "Это окно предназначено для обработки продаж и управления заказами. Здесь вы можете создавать новые заказы, обрабатывать платежи и распечатывать чеки.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "2. Склад:\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "Это окно используется для редактирования данных о товарах. Вы можете добавлять новые позиции в базу данных, обновлять информацию о существующих товарах и управлять складскими запасами.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "3. Выписка:\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "В этом окне выводится история покупок, и вы можете перепечатать чек. Это позволяет удобно отслеживать все произведенные продажи и, при необходимости, повторно распечатать чеки для клиентов.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "4. Настройки:\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "В этом окне находятся все настройки программы. Здесь вы можете конфигурировать параметры системы, настраивать внешний вид и учетные данные.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "Надеемся, что наша программа поможет вам эффективно управлять вашими заказами и складом. Приятной работы!\n", FontStyle.Italic);
        }

        private void SettingsRichTextBoxLoad()
        {
            settings_richTextBox.Clear();

            AppendFormattedText(settings_richTextBox, "Окно настроек\n", FontStyle.Bold);

            AppendFormattedText(settings_richTextBox, "\nЭто окно настроек, в котором вы можете изменить параметры программы в соответствии с вашими требованиями.\n\n", FontStyle.Regular);

            AppendFormattedText(settings_richTextBox, "Настройка подключения к базе данных:\n", FontStyle.Bold);
            AppendFormattedText(settings_richTextBox, "Здесь вы можете редактировать путь подключения к базе данных. Изменения вступят в силу после перезапуска программы.\n\n", FontStyle.Regular);

            AppendFormattedText(settings_richTextBox, "Настройка внешнего вида программы:\n", FontStyle.Bold);
            AppendFormattedText(settings_richTextBox, "Вы можете выбрать одну из четырёх тем по цвету для внешнего вида программы: светлая, голубая, зеленая и розовая. Эти настройки помогут сделать интерфейс программы более приятным для ваших глаз.\n\n", FontStyle.Regular);

            AppendFormattedText(settings_richTextBox, "Настройка учетных данных компании:\n", FontStyle.Bold);
            AppendFormattedText(settings_richTextBox, "Здесь вы можете ввести или изменить учетные данные вашей компании, такие как название, адрес, контактный номер и вебсайт. Эти данные будут печататься на чеках, предоставляя вашим клиентам необходимую информацию.\n\n", FontStyle.Regular);

            AppendFormattedText(settings_richTextBox, "Настройте программу под свои нужды и наслаждайтесь её использованием!\n", FontStyle.Italic);
        }

        private void CashboxRichTextBoxLoad()
        {
            cashbox_richTextBox.Clear();

            AppendFormattedText(cashbox_richTextBox, "Окно работы с кассой\n", FontStyle.Bold);

            AppendFormattedText(cashbox_richTextBox, "\nДобро пожаловать в окно работы с кассой! Здесь вы можете управлять процессом продаж и оформлением заказов.\n\n", FontStyle.Regular);

            AppendFormattedText(cashbox_richTextBox, "Каталог товаров:\n", FontStyle.Bold);
            AppendFormattedText(cashbox_richTextBox, "В каталоге отображаются только те товары, которые есть в наличии. Если какого-то товара нет, вам необходимо добавить его количество в окне \"Склад\". Таким образом, вы всегда будете иметь актуальную информацию о доступных товарах.\n\n", FontStyle.Regular);

            AppendFormattedText(cashbox_richTextBox, "Поиск и фильтрация:\n", FontStyle.Bold);
            AppendFormattedText(cashbox_richTextBox, "Для удобства работы с каталогом вы можете выполнять поиск товаров по названию или другим параметрам. Также можно выводить определённые категории товаров, чтобы быстрее находить нужные позиции. Кроме того, вы можете сортировать товары по тегам как по возрастанию, так и по убыванию, чтобы легче ориентироваться в ассортименте.\n\n", FontStyle.Regular);

            AppendFormattedText(cashbox_richTextBox, "Оформление заказа:\n", FontStyle.Bold);
            AppendFormattedText(cashbox_richTextBox, "Когда вы готовы оформить заказ, нажмите кнопку \"Оформить\". Вам будет предложено напечатать чек. Даже если вы решите отказаться от печати, заказ всё равно будет оформлен и добавлен в историю покупок. Это позволяет вам легко отслеживать все завершённые заказы и поддерживать учёт продаж.\n\n", FontStyle.Regular);

            AppendFormattedText(cashbox_richTextBox, "Дополнительная информация:\n", FontStyle.Bold);
            AppendFormattedText(cashbox_richTextBox, "Работа с кассой максимально упрощена для вашего удобства. Интерфейс интуитивно понятен и позволяет быстро выполнять все необходимые действия. Мы постарались сделать так, чтобы процесс продажи был быстрым и приятным для вас и ваших клиентов.\n\n", FontStyle.Regular);

            AppendFormattedText(cashbox_richTextBox, "Желаем успешных продаж и хорошего настроения!\n", FontStyle.Italic);
        }

        private void StorageRichTextBoxLoad()
        {
            storage_richTextBox.Clear();

            AppendFormattedText(storage_richTextBox, "Окно \"Склад\"\n", FontStyle.Bold);

            AppendFormattedText(storage_richTextBox, "\nДобро пожаловать в окно \"Склад\"! Здесь вы можете управлять данными о товарах, доступных в вашем магазине.\n\n", FontStyle.Regular);

            AppendFormattedText(storage_richTextBox, "Редактирование данных:\n", FontStyle.Bold);
            AppendFormattedText(storage_richTextBox, "В этом окне вы можете редактировать количество товаров, их актуальные цены, названия и другие параметры. Это позволяет вам поддерживать актуальную информацию о всех позициях, доступных на складе.\n\n", FontStyle.Regular);

            AppendFormattedText(storage_richTextBox, "Добавление и удаление товаров:\n", FontStyle.Bold);
            AppendFormattedText(storage_richTextBox, "Кроме редактирования, вы также можете добавлять новые товары и удалять ненужные позиции. Это упрощает процесс управления ассортиментом и позволяет быстро реагировать на изменения в потребностях вашего бизнеса.\n\n", FontStyle.Regular);

            AppendFormattedText(storage_richTextBox, "Поиск и фильтрация:\n", FontStyle.Bold);
            AppendFormattedText(storage_richTextBox, "Для удобства работы со складом вы можете выполнять поиск товаров по различным параметрам, выводить определённые категории товаров и сортировать их по тегам как по возрастанию, так и по убыванию. Это помогает быстро находить нужные позиции и эффективно управлять складскими запасами.\n\n", FontStyle.Regular);

            AppendFormattedText(storage_richTextBox, "Дополнительная информация:\n", FontStyle.Bold);
            AppendFormattedText(storage_richTextBox, "Интерфейс окна \"Склад\" интуитивно понятен и упрощает процесс управления данными. Мы постарались сделать так, чтобы работа с программой была удобной и приятной. Если у вас возникнут вопросы или потребуется помощь, не стесняйтесь обращаться к нашему справочному разделу или службе поддержки.\n\n", FontStyle.Regular);

            AppendFormattedText(storage_richTextBox, "Успешного управления вашим складом!\n", FontStyle.Italic);
        }

        private void AppendFormattedText(RichTextBox richTextBox, string text, FontStyle style)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, style);

            richTextBox.AppendText(text);

            richTextBox.SelectionFont = richTextBox.Font;
        }

    }
}
