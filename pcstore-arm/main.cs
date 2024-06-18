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
    }
}
