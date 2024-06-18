using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcstore_arm
{
    public class themes
    {
        string themeConfig = "etc\\configs\\theme.txt";

        public string LoadTheme()
        {
            if (File.Exists(themeConfig) && File.ReadAllLines(themeConfig).Length > 0)
            {
                try
                {
                    // Прочитать все строки файла
                    string[] lines = File.ReadAllLines(themeConfig);

                    // Проверить, пуста ли первая строка
                    if (lines.Length > 0 && !string.IsNullOrEmpty(lines[0]))
                    {
                        return lines[0]; // Вернуть первую непустую строку
                    }
                    else
                    {
                        // Обработать случай пустой первой строки или отсутствия строк
                        return null; // Или предоставить тему по умолчанию
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении данных из файла: {ex.Message}");
                    return null; // Или предоставить тему по умолчанию при ошибке
                }
            }
            else
            {
                // Обработать случай отсутствия файла
                return null; // Или предоставить тему по умолчанию
            }
        }

        public void ApplyLightTheme(Form form)
        {
            // Изменение фона формы
            form.BackColor = Color.White;

            // Изменение цвета текста формы
            form.ForeColor = Color.Black;

            // Применение светлой темы ко всем элементам управления на форме
            foreach (Control control in form.Controls)
            {
                ApplyLightThemeToControl(control);
            }
        }

        public void ApplyLightThemeToControl(Control control)
        {
            // Изменение фона элемента управления
            control.BackColor = Color.WhiteSmoke;

            // Изменение цвета текста элемента управления
            control.ForeColor = Color.Black;

            // Применение светлой темы ко всем дочерним элементам управления
            foreach (Control childControl in control.Controls)
            {
                ApplyLightThemeToControl(childControl);
            }
        }

        public void ApplyBlueTheme(Form form)
        {
            form.BackColor = Color.FromArgb(173, 216, 230);

            // Изменение цвета текста формы
            form.ForeColor = Color.Black;

            foreach (Control control in form.Controls)
            {
                ApplyBlueThemeToControl(control);
            }
        }

        public void ApplyBlueThemeToControl(Control control)
        {
            control.BackColor = Color.FromArgb(240, 248, 255); // AliceBlue

            control.ForeColor = Color.Black;

            foreach (Control childControl in control.Controls)
            {
                ApplyBlueThemeToControl(childControl);
            }
        }

        public void ApplyGreenTheme(Form form)
        {
            // Изменение фона формы
            form.BackColor = Color.FromArgb(144, 238, 144);

            // Изменение цвета текста формы
            form.ForeColor = Color.DarkGreen;

            // Применение зеленой темы ко всем элементам управления на форме
            foreach (Control control in form.Controls)
            {
                ApplyGreenThemeToControl(control);
            }
        }

        public void ApplyGreenThemeToControl(Control control)
        {
            // Изменение фона элемента управления
            control.BackColor = Color.Honeydew;

            // Изменение цвета текста элемента управления
            control.ForeColor = Color.DarkGreen;

            // Применение зеленой темы ко всем дочерним элементам управления
            foreach (Control childControl in control.Controls)
            {
                ApplyGreenThemeToControl(childControl);
            }
        }

        public void ApplyPinkTheme(Form form)
        {
            // Изменение фона формы
            form.BackColor = Color.FromArgb(255, 182, 193);

            // Изменение цвета текста формы
            form.ForeColor = Color.DarkRed;

            // Применение розовой темы ко всем элементам управления на форме
            foreach (Control control in form.Controls)
            {
                ApplyPinkThemeToControl(control);
            }
        }

        public void ApplyPinkThemeToControl(Control control)
        {
            // Изменение фона элемента управления
            control.BackColor = Color.LavenderBlush;

            // Изменение цвета текста элемента управления
            control.ForeColor = Color.DarkRed;

            // Применение розовой темы ко всем дочерним элементам управления
            foreach (Control childControl in control.Controls)
            {
                ApplyPinkThemeToControl(childControl);
            }
        }
    }
}