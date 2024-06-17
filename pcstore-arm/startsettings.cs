using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pcstore_arm
{
    public partial class startsettings : Form
    {
        string configFilePath = "etc\\configs\\db.txt"; // Путь к файлу конфигурации
        string themeFilePath = "etc\\configs\\theme.txt";


        string currentTheme;
        themes Themes = new themes();


        private readonly IConnect connectionProvider;
        private NpgsqlConnection connection;

        public startsettings(IConnect connectionProvider)
        {
            InitializeComponent();
            this.connectionProvider = connectionProvider;
            connection = connectionProvider.GetConnection();
        }

        private void startsettings_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadThemes();

            if (currentTheme == "light")
            {
                Themes.ApplyLightTheme(this);
            }
            else
            {
                Themes.ApplyBlueTheme(this);
            }
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

        private void LoadThemes()
        {
            // Загрузите текущую тему из файла и установите соответствующие чекбоксы
            currentTheme = File.ReadAllText(themeFilePath);

            lighttheme_checkBox.CheckedChanged -= lighttheme_checkBox_CheckedChanged;
            darktheme_checkBox.CheckedChanged -= darktheme_checkBox_CheckedChanged;

            if (currentTheme == "light")
            {
                lighttheme_checkBox.Checked = true;
                darktheme_checkBox.Checked = false;
            }
            else if (currentTheme == "dark")
            {
                darktheme_checkBox.Checked = true;
                lighttheme_checkBox.Checked = false;
            }

            lighttheme_checkBox.CheckedChanged += lighttheme_checkBox_CheckedChanged;
            darktheme_checkBox.CheckedChanged += darktheme_checkBox_CheckedChanged;
        }

        /////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////////////////

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
        /////////////////////////////////////////////////////////////////////////////////
        private void lighttheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lighttheme_checkBox.Checked)
            {
                UpdateTheme("light");
                darktheme_checkBox.CheckedChanged -= darktheme_checkBox_CheckedChanged;
                darktheme_checkBox.Checked = false;
                darktheme_checkBox.CheckedChanged += darktheme_checkBox_CheckedChanged;

                // Применить светлую тему к форме
                Themes.ApplyLightTheme(this);
            }
        }

        private void darktheme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (darktheme_checkBox.Checked)
            {
                UpdateTheme("dark");
                lighttheme_checkBox.CheckedChanged -= lighttheme_checkBox_CheckedChanged;
                lighttheme_checkBox.Checked = false;
                lighttheme_checkBox.CheckedChanged += lighttheme_checkBox_CheckedChanged;

                // Применить темную тему к форме
                Themes.ApplyBlueTheme(this);
            }
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
                MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}"); // Отображение сообщения об ошибке
            }
        }
        /////////////////////////////////////////////////////////////////////////////////
        private void set_button_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(configFilePath, $"{ip_textBox.Text}\n{port_textBox.Text}\n{db_textBox.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файле конфигурации: {ex.Message}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
