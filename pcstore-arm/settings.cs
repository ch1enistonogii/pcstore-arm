using Npgsql;
using System;
using System.IO;
using System.Windows.Forms;

namespace pcstore_arm
{
    public partial class settings : Form
    {
        string configFilePath = "etc\\configs\\db.txt"; // Путь к файлу конфигурации
        string themeFilePath = "etc\\configs\\theme.txt";
        string companyFilePath = "etc\\configs\\company.txt";

        themes Themes = new themes();
        string currentTheme;

        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;

        public settings(IConnect connectionProvider)
        {
            InitializeComponent();
            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadCompanyConfig();
            LoadThemes();
            currentTheme = Themes.LoadTheme();
            ApplyCurrentTheme();
        }

        private void LoadConfig()
        {
            if (File.Exists(configFilePath) && File.ReadAllLines(configFilePath).Length > 0)
            {
                try
                {
                    string[] lines = File.ReadAllLines(configFilePath);
                    ip_textBox.Text = lines[0];
                    port_textBox.Text = lines[1];
                    db_textBox.Text = lines[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении данных из файла: {ex.Message}");
                }
            }
        }

        private void LoadCompanyConfig()
        {
            if (File.Exists(companyFilePath) && File.ReadAllLines(companyFilePath).Length > 0)
            {
                try
                {
                    string[] lines = File.ReadAllLines(companyFilePath);
                    name_textBox.Text = lines[0];
                    address_textBox.Text = lines[1];
                    phone_textBox.Text = lines[2];
                    website_textBox.Text = lines[3];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении данных из файла: {ex.Message}");
                }
            }
        }

        private void LoadThemes()
        {
            // Загрузите текущую тему из файла и установите соответствующие чекбоксы
            currentTheme = File.ReadAllText(themeFilePath).Trim();

            lighttheme_checkBox.CheckedChanged -= lighttheme_checkBox_CheckedChanged;
            bluetheme_checkBox.CheckedChanged -= bluetheme_checkBox_CheckedChanged;
            greentheme_checkBox.CheckedChanged -= greentheme_checkBox_CheckedChanged;
            pinktheme_checkBox.CheckedChanged -= pinktheme_checkBox_CheckedChanged;

            switch (currentTheme)
            {
                case "light":
                    lighttheme_checkBox.Checked = true;
                    break;
                case "blue":
                    bluetheme_checkBox.Checked = true;
                    break;
                case "green":
                    greentheme_checkBox.Checked = true;
                    break;
                case "pink":
                    pinktheme_checkBox.Checked = true;
                    break;
            }

            lighttheme_checkBox.CheckedChanged += lighttheme_checkBox_CheckedChanged;
            bluetheme_checkBox.CheckedChanged += bluetheme_checkBox_CheckedChanged;
            greentheme_checkBox.CheckedChanged += greentheme_checkBox_CheckedChanged;
            pinktheme_checkBox.CheckedChanged += pinktheme_checkBox_CheckedChanged;
        }

        private void ApplyCurrentTheme()
        {
            switch (currentTheme)
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
            }
        }

        private void lighttheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lighttheme_checkBox.Checked)
            {
                UpdateTheme("light");
                UncheckOtherThemes("light");
                Themes.ApplyLightTheme(this);
            }
        }

        private void bluetheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bluetheme_checkBox.Checked)
            {
                UpdateTheme("blue");
                UncheckOtherThemes("blue");
                Themes.ApplyBlueTheme(this);
            }
        }

        private void greentheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (greentheme_checkBox.Checked)
            {
                UpdateTheme("green");
                UncheckOtherThemes("green");
                Themes.ApplyGreenTheme(this);
            }
        }

        private void pinktheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pinktheme_checkBox.Checked)
            {
                UpdateTheme("pink");
                UncheckOtherThemes("pink");
                Themes.ApplyPinkTheme(this);
            }
        }

        private void UncheckOtherThemes(string selectedTheme)
        {
            lighttheme_checkBox.CheckedChanged -= lighttheme_checkBox_CheckedChanged;
            bluetheme_checkBox.CheckedChanged -= bluetheme_checkBox_CheckedChanged;
            greentheme_checkBox.CheckedChanged -= greentheme_checkBox_CheckedChanged;
            pinktheme_checkBox.CheckedChanged -= pinktheme_checkBox_CheckedChanged;

            lighttheme_checkBox.Checked = selectedTheme == "light";
            bluetheme_checkBox.Checked = selectedTheme == "blue";
            greentheme_checkBox.Checked = selectedTheme == "green";
            pinktheme_checkBox.Checked = selectedTheme == "pink";

            lighttheme_checkBox.CheckedChanged += lighttheme_checkBox_CheckedChanged;
            bluetheme_checkBox.CheckedChanged += bluetheme_checkBox_CheckedChanged;
            greentheme_checkBox.CheckedChanged += greentheme_checkBox_CheckedChanged;
            pinktheme_checkBox.CheckedChanged += pinktheme_checkBox_CheckedChanged;
        }

        private void UpdateTheme(string theme)
        {
            try
            {
                File.WriteAllText(themeFilePath, theme);
                currentTheme = theme;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}");
            }
        }

        private void ip_pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо вписать IP адрес сервера базы данных\n" +
                "Например: 192.168.1.2\n" +
                "По умолчанию: 127.0.0.1 или localhost",
                "Выбор пути");
        }

        private void port_pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо указать порт сервера\n" +
                "По умолчанию: 5432",
                "Выбор порта");
        }

        private void db_pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо выбрать нужную базу данных на сервере",
                "Выбор базы данных");
        }

        private void setdefault_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуть настройки подключения по умолчанию? Будут применены следующие параметры:\n" +
                "\tIP: localhost\n" +
                "\tПорт: 5432\n" +
                "\tБаза данных: postgres",
                "Настройки по умолчанию",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ip_textBox.Text = "localhost";
                port_textBox.Text = "5432";
                db_textBox.Text = "postgres";
                try
                {
                    File.WriteAllText(configFilePath, $"{ip_textBox.Text}\n{port_textBox.Text}\n{db_textBox.Text}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}");
                }
            }
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(configFilePath, $"{ip_textBox.Text}\n{port_textBox.Text}\n{db_textBox.Text}");
                MessageBox.Show($"Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(companyFilePath, $"{name_textBox.Text}\n{address_textBox.Text}\n{phone_textBox.Text}\n{website_textBox.Text}");
                MessageBox.Show($"Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}");
            }
        }
    }
}