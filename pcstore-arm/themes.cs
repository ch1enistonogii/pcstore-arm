using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Изменение фона формы
            form.BackColor = Color.FromArgb(206, 220, 235);

            // Изменение цвета текста формы
            form.ForeColor = Color.Black;

            // Применение темной темы ко всем элементам управления на форме
            foreach (Control control in form.Controls)
            {
                ApplyBlueThemeToControl(control);
            }
        }

        public void ApplyBlueThemeToControl(Control control)
        {
            // Изменение фона элемента управления
            control.BackColor = Color.White;

            // Изменение цвета текста элемента управления
            control.ForeColor = Color.Black;

            // Применение темной темы ко всем дочерним элементам управления
            foreach (Control childControl in control.Controls)
            {
                ApplyBlueThemeToControl(childControl);
            }
        }
    }
}