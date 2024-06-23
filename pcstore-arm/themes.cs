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
                    string[] lines = File.ReadAllLines(themeConfig);

                    if (lines.Length > 0 && !string.IsNullOrEmpty(lines[0]))
                    {
                        return lines[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении данных из файла: {ex.Message}");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void ApplyLightTheme(Form form)
        {
            form.BackColor = Color.White;

            form.ForeColor = Color.Black;

            // Применение светлой темы ко всем элементам управления на форме
            foreach (Control control in form.Controls)
            {
                ApplyLightThemeToControl(control);
            }
        }

        public void ApplyLightThemeToControl(Control control)
        {
            control.BackColor = Color.WhiteSmoke;

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

            form.ForeColor = Color.Black;

            foreach (Control control in form.Controls)
            {
                ApplyBlueThemeToControl(control);
            }
        }

        public void ApplyBlueThemeToControl(Control control)
        {
            control.BackColor = Color.FromArgb(240, 248, 255);

            control.ForeColor = Color.Black;

            foreach (Control childControl in control.Controls)
            {
                ApplyBlueThemeToControl(childControl);
            }
        }

        public void ApplyGreenTheme(Form form)
        {
            form.BackColor = Color.FromArgb(144, 238, 144);

            form.ForeColor = Color.DarkGreen;

            foreach (Control control in form.Controls)
            {
                ApplyGreenThemeToControl(control);
            }
        }

        public void ApplyGreenThemeToControl(Control control)
        {
            control.BackColor = Color.Honeydew;

            control.ForeColor = Color.DarkGreen;

            foreach (Control childControl in control.Controls)
            {
                ApplyGreenThemeToControl(childControl);
            }
        }

        public void ApplyPinkTheme(Form form)
        {
            form.BackColor = Color.FromArgb(255, 182, 193);

            form.ForeColor = Color.DarkRed;

            foreach (Control control in form.Controls)
            {
                ApplyPinkThemeToControl(control);
            }
        }

        public void ApplyPinkThemeToControl(Control control)
        {
            control.BackColor = Color.LavenderBlush;

            control.ForeColor = Color.DarkRed;

            foreach (Control childControl in control.Controls)
            {
                ApplyPinkThemeToControl(childControl);
            }
        }
    }
}