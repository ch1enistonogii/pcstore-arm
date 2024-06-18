namespace pcstore_arm
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            set_button = new Button();
            setdefault_linkLabel = new LinkLabel();
            db_pictureBox = new PictureBox();
            port_pictureBox = new PictureBox();
            ip_pictureBox = new PictureBox();
            db_textBox = new TextBox();
            port_textBox = new TextBox();
            ip_textBox = new TextBox();
            tabPage2 = new TabPage();
            panel8 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            lighttheme_checkBox = new CheckBox();
            panel6 = new Panel();
            bluetheme_checkBox = new CheckBox();
            panel7 = new Panel();
            greentheme_checkBox = new CheckBox();
            panel4 = new Panel();
            pinktheme_checkBox = new CheckBox();
            panel5 = new Panel();
            panel3 = new Panel();
            tabPage3 = new TabPage();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            website_textBox = new TextBox();
            phone_textBox = new TextBox();
            address_textBox = new TextBox();
            name_textBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)db_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)port_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ip_pictureBox).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(500, 537);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(set_button);
            tabPage1.Controls.Add(setdefault_linkLabel);
            tabPage1.Controls.Add(db_pictureBox);
            tabPage1.Controls.Add(port_pictureBox);
            tabPage1.Controls.Add(ip_pictureBox);
            tabPage1.Controls.Add(db_textBox);
            tabPage1.Controls.Add(port_textBox);
            tabPage1.Controls.Add(ip_textBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(492, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Настройка БД";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // set_button
            // 
            set_button.Location = new Point(126, 305);
            set_button.Name = "set_button";
            set_button.Size = new Size(200, 35);
            set_button.TabIndex = 9;
            set_button.Text = "Применить";
            set_button.UseVisualStyleBackColor = true;
            set_button.Click += set_button_Click;
            // 
            // setdefault_linkLabel
            // 
            setdefault_linkLabel.ActiveLinkColor = Color.Gray;
            setdefault_linkLabel.AutoSize = true;
            setdefault_linkLabel.LinkColor = Color.Black;
            setdefault_linkLabel.Location = new Point(126, 345);
            setdefault_linkLabel.Name = "setdefault_linkLabel";
            setdefault_linkLabel.Size = new Size(153, 15);
            setdefault_linkLabel.TabIndex = 10;
            setdefault_linkLabel.TabStop = true;
            setdefault_linkLabel.Text = "Настройки по умолчанию";
            setdefault_linkLabel.LinkClicked += setdefault_linkLabel_LinkClicked;
            // 
            // db_pictureBox
            // 
            db_pictureBox.Cursor = Cursors.Hand;
            db_pictureBox.Image = Properties.Resources.help;
            db_pictureBox.Location = new Point(332, 256);
            db_pictureBox.Name = "db_pictureBox";
            db_pictureBox.Size = new Size(35, 35);
            db_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            db_pictureBox.TabIndex = 15;
            db_pictureBox.TabStop = false;
            db_pictureBox.Click += db_pictureBox_Click;
            // 
            // port_pictureBox
            // 
            port_pictureBox.Cursor = Cursors.Hand;
            port_pictureBox.Image = Properties.Resources.help;
            port_pictureBox.Location = new Point(332, 202);
            port_pictureBox.Name = "port_pictureBox";
            port_pictureBox.Size = new Size(35, 35);
            port_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            port_pictureBox.TabIndex = 14;
            port_pictureBox.TabStop = false;
            port_pictureBox.Click += port_pictureBox_Click;
            // 
            // ip_pictureBox
            // 
            ip_pictureBox.Cursor = Cursors.Hand;
            ip_pictureBox.Image = Properties.Resources.help;
            ip_pictureBox.Location = new Point(332, 148);
            ip_pictureBox.Name = "ip_pictureBox";
            ip_pictureBox.Size = new Size(35, 35);
            ip_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ip_pictureBox.TabIndex = 13;
            ip_pictureBox.TabStop = false;
            ip_pictureBox.Click += ip_pictureBox_Click;
            // 
            // db_textBox
            // 
            db_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            db_textBox.ForeColor = SystemColors.WindowFrame;
            db_textBox.Location = new Point(126, 256);
            db_textBox.MaximumSize = new Size(200, 35);
            db_textBox.MinimumSize = new Size(200, 35);
            db_textBox.Name = "db_textBox";
            db_textBox.Size = new Size(200, 35);
            db_textBox.TabIndex = 12;
            db_textBox.TabStop = false;
            db_textBox.Text = "postgres";
            // 
            // port_textBox
            // 
            port_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            port_textBox.ForeColor = SystemColors.WindowFrame;
            port_textBox.Location = new Point(126, 202);
            port_textBox.MaximumSize = new Size(200, 35);
            port_textBox.MinimumSize = new Size(200, 35);
            port_textBox.Name = "port_textBox";
            port_textBox.Size = new Size(200, 35);
            port_textBox.TabIndex = 11;
            port_textBox.TabStop = false;
            port_textBox.Text = "5432";
            // 
            // ip_textBox
            // 
            ip_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ip_textBox.ForeColor = SystemColors.WindowFrame;
            ip_textBox.Location = new Point(126, 148);
            ip_textBox.MaximumSize = new Size(200, 35);
            ip_textBox.MinimumSize = new Size(200, 35);
            ip_textBox.Name = "ip_textBox";
            ip_textBox.Size = new Size(200, 35);
            ip_textBox.TabIndex = 8;
            ip_textBox.TabStop = false;
            ip_textBox.Text = "localhost";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel9);
            tabPage2.Controls.Add(lighttheme_checkBox);
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(bluetheme_checkBox);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(greentheme_checkBox);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(pinktheme_checkBox);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(492, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Внешний вид";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Location = new Point(245, 344);
            panel8.Name = "panel8";
            panel8.Size = new Size(40, 40);
            panel8.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(199, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(40, 40);
            panel2.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Location = new Point(199, 344);
            panel9.Name = "panel9";
            panel9.Size = new Size(40, 40);
            panel9.TabIndex = 14;
            // 
            // lighttheme_checkBox
            // 
            lighttheme_checkBox.AutoSize = true;
            lighttheme_checkBox.Location = new Point(199, 106);
            lighttheme_checkBox.Name = "lighttheme_checkBox";
            lighttheme_checkBox.Size = new Size(99, 19);
            lighttheme_checkBox.TabIndex = 8;
            lighttheme_checkBox.Text = "Светлая тема";
            lighttheme_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Location = new Point(245, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(40, 40);
            panel6.TabIndex = 18;
            // 
            // bluetheme_checkBox
            // 
            bluetheme_checkBox.AutoSize = true;
            bluetheme_checkBox.Location = new Point(199, 177);
            bluetheme_checkBox.Name = "bluetheme_checkBox";
            bluetheme_checkBox.Size = new Size(100, 19);
            bluetheme_checkBox.TabIndex = 9;
            bluetheme_checkBox.Text = "Голубая тема";
            bluetheme_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Location = new Point(199, 273);
            panel7.Name = "panel7";
            panel7.Size = new Size(40, 40);
            panel7.TabIndex = 15;
            // 
            // greentheme_checkBox
            // 
            greentheme_checkBox.AutoSize = true;
            greentheme_checkBox.Location = new Point(199, 248);
            greentheme_checkBox.Name = "greentheme_checkBox";
            greentheme_checkBox.Size = new Size(100, 19);
            greentheme_checkBox.TabIndex = 10;
            greentheme_checkBox.Text = "Зеленая тема";
            greentheme_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Location = new Point(245, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(40, 40);
            panel4.TabIndex = 19;
            // 
            // pinktheme_checkBox
            // 
            pinktheme_checkBox.AutoSize = true;
            pinktheme_checkBox.Location = new Point(199, 319);
            pinktheme_checkBox.Name = "pinktheme_checkBox";
            pinktheme_checkBox.Size = new Size(99, 19);
            pinktheme_checkBox.TabIndex = 11;
            pinktheme_checkBox.Text = "Розовая тема";
            pinktheme_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Location = new Point(199, 202);
            panel5.Name = "panel5";
            panel5.Size = new Size(40, 40);
            panel5.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(245, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(40, 40);
            panel3.TabIndex = 13;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(website_textBox);
            tabPage3.Controls.Add(phone_textBox);
            tabPage3.Controls.Add(address_textBox);
            tabPage3.Controls.Add(name_textBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(492, 509);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Компания";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(19, 415);
            button1.Name = "button1";
            button1.Size = new Size(454, 32);
            button1.TabIndex = 17;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(19, 305);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 16;
            label4.Text = "Веб-сайт:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(19, 216);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 15;
            label3.Text = "Контактный номер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(19, 130);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Адрес:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 13;
            label1.Text = "Название компании:";
            // 
            // website_textBox
            // 
            website_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            website_textBox.ForeColor = SystemColors.WindowFrame;
            website_textBox.Location = new Point(19, 328);
            website_textBox.Name = "website_textBox";
            website_textBox.Size = new Size(454, 32);
            website_textBox.TabIndex = 12;
            website_textBox.TabStop = false;
            website_textBox.Text = "coopiestool.com";
            // 
            // phone_textBox
            // 
            phone_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            phone_textBox.ForeColor = SystemColors.WindowFrame;
            phone_textBox.Location = new Point(19, 239);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(454, 32);
            phone_textBox.TabIndex = 11;
            phone_textBox.TabStop = false;
            phone_textBox.Text = "+77771234567";
            // 
            // address_textBox
            // 
            address_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            address_textBox.ForeColor = SystemColors.WindowFrame;
            address_textBox.Location = new Point(19, 153);
            address_textBox.Name = "address_textBox";
            address_textBox.Size = new Size(454, 32);
            address_textBox.TabIndex = 10;
            address_textBox.TabStop = false;
            address_textBox.Text = "ЗКО, г.Уральск, ул. Пушкина, дом 14, кв 88";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            name_textBox.ForeColor = SystemColors.WindowFrame;
            name_textBox.Location = new Point(19, 69);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(454, 32);
            name_textBox.TabIndex = 9;
            name_textBox.TabStop = false;
            name_textBox.Text = "ТОО \"Coopie`s Tool\"";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 561);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += settings_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)db_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)port_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ip_pictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button set_button;
        private LinkLabel setdefault_linkLabel;
        private PictureBox db_pictureBox;
        private PictureBox port_pictureBox;
        private PictureBox ip_pictureBox;
        private TextBox db_textBox;
        private TextBox port_textBox;
        private TextBox ip_textBox;
        private TextBox name_textBox;
        private TextBox website_textBox;
        private TextBox phone_textBox;
        private TextBox address_textBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Panel panel7;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private CheckBox pinktheme_checkBox;
        private CheckBox greentheme_checkBox;
        private CheckBox bluetheme_checkBox;
        private CheckBox lighttheme_checkBox;
    }
}