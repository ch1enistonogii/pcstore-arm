using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcstore_arm
{
    public partial class instructions : Form
    {
        public instructions(IConnect connectionProvider)
        {
            InitializeComponent();
        }

        private void instructions_Load(object sender, EventArgs e)
        {
            SetStartRichTextBoxText();
            SetSetupRichTextBoxText();
            SetEndRichTextBoxText();
        }

        private void SetStartRichTextBoxText()
        {
            start_richTextBox.Clear();

            AppendFormattedText(start_richTextBox, "Программа позволяет автоматизировать процесс продажи компьютерной техники, периферии и аксессуаров.\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox, "Перед началом работы с программой необходимо выполнить несколько важных шагов:\n\n", FontStyle.Bold);

            AppendFormattedText(start_richTextBox, "1. Установка пакета PostgreSQL:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "Для хранения данных о каталоге товаров, истории покупок и другой информации программа использует базу данных PostgreSQL. " +
                "Вам потребуется установить пакет PostgreSQL 16, который можно найти в папке с программой или скачать с официального сайта " +
                "https://www.postgresql.org/download/.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "2. Развертывание базы данных:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "После установки PostgreSQL необходимо создать и развернуть базу данных, которая будет использоваться программой. Вы можете сделать это " +
                "локально на своем компьютере или на сервере. Инструкции по развертыванию базы данных можно найти в документации к программе или на " +
                "специализированных сайтах.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "3. Настройка удаленного доступа к базе данных (пропустить, если база данных локальная):\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "Если вы развернули базу данных на сервере, вам потребуется настроить удаленный доступ к ней с вашего компьютера. Это может быть сделано " +
                "с помощью различных методов, таких как настройка брандмауэра, VPN или SSH-туннелирования.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "4. Запуск программы и настройка:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "Запустите программу \"Касса для продаж компьютерной техники\". В меню \"Настройки\" укажите путь к вашей базе данных.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "5. Ввод данных для входа:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "Программа использует систему аутентификации для защиты данных. Вам потребуется ввести имя пользователя и пароль для доступа к программе.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "6. Работа с программой:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "После успешного входа в программу вы сможете работать с каталогом товаров, добавлять новые товары, совершать продажи, просматривать " +
                "историю покупок и выполнять другие операции.\n\n", FontStyle.Regular);

            AppendFormattedText(start_richTextBox, "С помощью программы \"Касса для продаж компьютерной техники\" вы сможете:\n\n", FontStyle.Bold);
            AppendFormattedText(start_richTextBox,
                "\t- Увеличить скорость и эффективность работы вашего магазина.\n" +
                "\t- Снизить риск ошибок при оформлении заказов.\n" +
                "\t- Улучшить контроль над складскими запасами.\n" +
                "\t- Получить доступ к подробной истории продаж.\n" +
                "\t- Повысить уровень обслуживания клиентов.\n", FontStyle.Regular);
        }


        private void SetSetupRichTextBoxText()
        {
            setup_richTextBox.Clear();

            AppendFormattedText(setup_richTextBox, "Пошаговая установка PostgreSQL:\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox, "1) Скачать установочный файл:\n\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox,
                "\tПерейдите на официальный сайт PostgreSQL: https://www.postgresql.org/download/windows/\n" +
                "\tСкачайте последнюю версию установочного файла.\n\n", FontStyle.Regular);

            AppendFormattedText(setup_richTextBox, "2) Запустить установочный файл:\n\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox,
                "\tДважды щелкните на скачанный установочный файл для запуска мастера установки.\n\n", FontStyle.Regular);

            AppendFormattedText(setup_richTextBox, "3) Следовать инструкциям мастера установки:\n\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox,
                "\tВыберите язык установки и нажмите \"OK\".\n" +
                "\tНажмите \"Next\" на стартовом экране.\n" +
                "\tВыберите каталог установки и нажмите \"Next\".\n" +
                "\tВыберите компоненты для установки и нажмите \"Next\".\n" +
                "\tУкажите каталог данных и нажмите \"Next\".\n" +
                "\tУкажите пароль суперпользователя PostgreSQL (по умолчанию postgres) и нажмите \"Next\".\n" +
                "\tУкажите порт сервера (по умолчанию 5432) и нажмите \"Next\".\n" +
                "\tВыберите местоположение и нажмите \"Next\".\n" +
                "\tНажмите \"Next\" для начала установки.\n\n", FontStyle.Regular);

            AppendFormattedText(setup_richTextBox, "4) Завершение установки:\n\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox,
                "\tПосле завершения установки нажмите \"Finish\".\n\n", FontStyle.Regular);

            AppendFormattedText(setup_richTextBox, "5) Запуск pgAdmin:\n\n", FontStyle.Bold);
            AppendFormattedText(setup_richTextBox,
                "\tУстановщик также установит pgAdmin, графический интерфейс для управления базами данных PostgreSQL.\n" +
                "\tНайдите и запустите pgAdmin из меню \"Пуск\".\n\n", FontStyle.Regular);

            AppendFormattedText(setup_richTextBox, "Пакет для работы установлен, теперь необходимо развернуть саму базу данных и ее структуру.\n", FontStyle.Italic);
        }

        private void SetEndRichTextBoxText()
        {
            end_richTextBox.Clear();

            AppendFormattedText(end_richTextBox, "Пошаговое развертывание структуры базы данных:\n", FontStyle.Bold);

            AppendFormattedText(end_richTextBox, "1) Открыть клиент PgAdmin:\n\n", FontStyle.Bold);
            AppendFormattedText(end_richTextBox,
                "\tЗапустите PgAdmin на вашем компьютере.\n\n", FontStyle.Regular);

            AppendFormattedText(end_richTextBox, "2) Развернуть ветку Servers в левой панели:\n\n", FontStyle.Bold);
            AppendFormattedText(end_richTextBox,
                "\tВ левой панели PgAdmin найдите ветку Servers и нажмите на неё.\n" +
                "\tРазверните ветку PostgreSQL под Servers.\n" +
                "\tРазверните ветку Databases.\n" +
                "\tРазверните ветку вашей базы данных.\n\n", FontStyle.Regular);

            AppendFormattedText(end_richTextBox, "3) Открыть окно Query Tool:\n\n", FontStyle.Bold);
            AppendFormattedText(end_richTextBox,
                "\tНажмите комбинацию клавиш Alt + Shift + Q, чтобы открыть окно Query Tool.\n\n", FontStyle.Regular);

            AppendFormattedText(end_richTextBox, "4) Вставить и выполнить SQL-скрипт:\n\n", FontStyle.Bold);
            AppendFormattedText(end_richTextBox,
                "\tОткройте файл sqldb.txt и скопируйте его содержимое.\n" +
                "\tВставьте скопированный текст в окно Query Tool.\n" +
                "\tНажмите клавишу F5 для выполнения скрипта.\n" +
                "\tУбедитесь, что в нижнем окне вывода не появилось ошибок.\n\n", FontStyle.Regular);

            AppendFormattedText(end_richTextBox, "5) Закрыть программу:\n\n", FontStyle.Bold);
            AppendFormattedText(end_richTextBox,
                "\tПосле успешного выполнения скрипта закройте PgAdmin.\n\n", FontStyle.Regular);
        }

        private void AppendFormattedText(RichTextBox richTextBox, string text, FontStyle style)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, style);
            richTextBox.AppendText(text);
            richTextBox.SelectionFont = richTextBox.Font;
        }
    }
}
