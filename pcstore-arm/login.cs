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
    public partial class login : Form, IConnect
    {
        string configFilePath = "etc\\configs\\db.txt"; // Путь к файлу конфигурации

        private NpgsqlConnection connection; // Переменная для хранения подключения к базе данных Npgsql
        public NpgsqlConnection GetConnection() => connection; // Реализация метода интерфейса IConnectionProvider для получения существующего подключения

        themes Themes = new themes(); // Создание экземпляра класса "Темы"
        string currentTheme;

        public login()
        {
            InitializeComponent(); // Инициализация компонентов формы авторизации
        }

        private void login_Load(object sender, EventArgs e)
        {
            currentTheme = Themes.LoadTheme(); // Загрузка актуальной темы из конфиг файла

            if (currentTheme == "light")
            {
                Themes.ApplyLightTheme(this); // Применение светлой темы
            }
            else if (currentTheme == "blue")
            {
                Themes.ApplyBlueTheme(this); // Применение голубой темы
            }
            else if (currentTheme == "green")
            {
                Themes.ApplyGreenTheme(this); // Применение зелёной темы
            }
            else if (currentTheme == "pink")
            {
                Themes.ApplyPinkTheme(this); // Применение розовой темы
            }
        }

        private void settings_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы "Первоначальные настройки"

            startsettings startsettingsForm = new startsettings(this);
            startsettingsForm.Show();
        }

        private void OpenMenu()
        {
            // Открытие формы кассы

            main mainForm = new main(this); // Создание экземпляра формы кассы, передавая ссылку на текущий объект login
            this.Hide(); // Скрыть форму авторизации
            mainForm.FormClosed += (s, args) => this.Close(); // Подписаться на событие закрытия формы кассы, чтобы закрыть форму авторизации при закрытии кассы
            mainForm.Show(); // Отобразить форму кассы
        }

        private void user_textBox_Click(object sender, EventArgs e)
        {
            // Обработчик события нажатия на поле "Пользователь"

            password_textBox.Text = ""; // Очистка поля
        }

        private void password_textBox_Click(object sender, EventArgs e)
        {
            // Обработчик события нажатия на поле "Пароль"

            user_textBox.Text = ""; // Очистка поля
        }
        private NpgsqlConnection CreateConnection()
        {
            // Функция создания подключения к базе данных

            try
            {
                string[] lines = File.ReadAllLines(configFilePath); // Чтение строк из файла конфигурации
                string connectionString = $"Server={lines[0]};Port={lines[1]};Database={lines[2]};User Id={user_textBox.Text};Password={password_textBox.Text}"; // Формирование строки подключения на основе данных из формы
                return new NpgsqlConnection(connectionString); // Создание подключения к базе данных
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании подключения из файла: {ex.Message}");
                return null;
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            // Обработчик нажатия кнопки "Войти"

            connection = CreateConnection(); // Создание подключения
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open(); // Открытие подключения
                }

                if (connection.State == ConnectionState.Open)
                {
                    OpenMenu(); // Открытия формы "Меню"
                }
                else
                {
                    MessageBox.Show("Не удалось установить подключение к базе данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            // Обработчик события изменения текста
    
            password_textBox.PasswordChar = '●'; // Замена пароля на символы
        }

        private void instructions_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы "Помощь"

            instructions instructionsForm = new instructions(this);
            instructionsForm.Show();
        }
    }
}