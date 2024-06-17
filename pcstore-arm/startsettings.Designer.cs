namespace pcstore_arm
{
    partial class startsettings
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            darktheme_checkBox = new CheckBox();
            lighttheme_checkBox = new CheckBox();
            groupBox1 = new GroupBox();
            set_button = new Button();
            setdefault_linkLabel = new LinkLabel();
            db_pictureBox = new PictureBox();
            port_pictureBox = new PictureBox();
            ip_pictureBox = new PictureBox();
            db_textBox = new TextBox();
            port_textBox = new TextBox();
            ip_textBox = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)db_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)port_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ip_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 407);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(darktheme_checkBox);
            groupBox2.Controls.Add(lighttheme_checkBox);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(282, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 399);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Внешний вид";
            // 
            // darktheme_checkBox
            // 
            darktheme_checkBox.AutoSize = true;
            darktheme_checkBox.Location = new Point(23, 61);
            darktheme_checkBox.Name = "darktheme_checkBox";
            darktheme_checkBox.Size = new Size(108, 19);
            darktheme_checkBox.TabIndex = 1;
            darktheme_checkBox.Text = "Небесная тема";
            darktheme_checkBox.UseVisualStyleBackColor = true;
            darktheme_checkBox.CheckedChanged += darktheme_checkBox_CheckedChanged;
            // 
            // lighttheme_checkBox
            // 
            lighttheme_checkBox.AutoSize = true;
            lighttheme_checkBox.Checked = true;
            lighttheme_checkBox.CheckState = CheckState.Checked;
            lighttheme_checkBox.Location = new Point(23, 36);
            lighttheme_checkBox.Name = "lighttheme_checkBox";
            lighttheme_checkBox.Size = new Size(99, 19);
            lighttheme_checkBox.TabIndex = 0;
            lighttheme_checkBox.Text = "Светлая тема";
            lighttheme_checkBox.UseVisualStyleBackColor = true;
            lighttheme_checkBox.CheckedChanged += lighttheme_checkBox_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(set_button);
            groupBox1.Controls.Add(setdefault_linkLabel);
            groupBox1.Controls.Add(db_pictureBox);
            groupBox1.Controls.Add(port_pictureBox);
            groupBox1.Controls.Add(ip_pictureBox);
            groupBox1.Controls.Add(db_textBox);
            groupBox1.Controls.Add(port_textBox);
            groupBox1.Controls.Add(ip_textBox);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подключение к базе данных";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // set_button
            // 
            set_button.Location = new Point(19, 192);
            set_button.Name = "set_button";
            set_button.Size = new Size(200, 35);
            set_button.TabIndex = 2;
            set_button.Text = "Применить";
            set_button.UseVisualStyleBackColor = true;
            set_button.Click += set_button_Click;
            // 
            // setdefault_linkLabel
            // 
            setdefault_linkLabel.ActiveLinkColor = Color.Gray;
            setdefault_linkLabel.AutoSize = true;
            setdefault_linkLabel.LinkColor = Color.Black;
            setdefault_linkLabel.Location = new Point(19, 232);
            setdefault_linkLabel.Name = "setdefault_linkLabel";
            setdefault_linkLabel.Size = new Size(153, 15);
            setdefault_linkLabel.TabIndex = 2;
            setdefault_linkLabel.TabStop = true;
            setdefault_linkLabel.Text = "Настройки по умолчанию";
            setdefault_linkLabel.LinkClicked += setdefault_linkLabel_LinkClicked;
            // 
            // db_pictureBox
            // 
            db_pictureBox.Cursor = Cursors.Hand;
            db_pictureBox.Image = Properties.Resources.help;
            db_pictureBox.Location = new Point(225, 143);
            db_pictureBox.Name = "db_pictureBox";
            db_pictureBox.Size = new Size(35, 35);
            db_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            db_pictureBox.TabIndex = 7;
            db_pictureBox.TabStop = false;
            db_pictureBox.Click += db_pictureBox_Click;
            // 
            // port_pictureBox
            // 
            port_pictureBox.Cursor = Cursors.Hand;
            port_pictureBox.Image = Properties.Resources.help;
            port_pictureBox.Location = new Point(225, 89);
            port_pictureBox.Name = "port_pictureBox";
            port_pictureBox.Size = new Size(35, 35);
            port_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            port_pictureBox.TabIndex = 6;
            port_pictureBox.TabStop = false;
            port_pictureBox.Click += port_pictureBox_Click;
            // 
            // ip_pictureBox
            // 
            ip_pictureBox.Cursor = Cursors.Hand;
            ip_pictureBox.Image = Properties.Resources.help;
            ip_pictureBox.Location = new Point(225, 35);
            ip_pictureBox.Name = "ip_pictureBox";
            ip_pictureBox.Size = new Size(35, 35);
            ip_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ip_pictureBox.TabIndex = 5;
            ip_pictureBox.TabStop = false;
            ip_pictureBox.Click += ip_pictureBox_Click;
            // 
            // db_textBox
            // 
            db_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            db_textBox.ForeColor = SystemColors.WindowFrame;
            db_textBox.Location = new Point(19, 143);
            db_textBox.MaximumSize = new Size(200, 35);
            db_textBox.MinimumSize = new Size(200, 35);
            db_textBox.Name = "db_textBox";
            db_textBox.Size = new Size(200, 35);
            db_textBox.TabIndex = 3;
            db_textBox.TabStop = false;
            db_textBox.Text = "postgres";
            // 
            // port_textBox
            // 
            port_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            port_textBox.ForeColor = SystemColors.WindowFrame;
            port_textBox.Location = new Point(19, 89);
            port_textBox.MaximumSize = new Size(200, 35);
            port_textBox.MinimumSize = new Size(200, 35);
            port_textBox.Name = "port_textBox";
            port_textBox.Size = new Size(200, 35);
            port_textBox.TabIndex = 2;
            port_textBox.TabStop = false;
            port_textBox.Text = "5432";
            // 
            // ip_textBox
            // 
            ip_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ip_textBox.ForeColor = SystemColors.WindowFrame;
            ip_textBox.Location = new Point(19, 35);
            ip_textBox.MaximumSize = new Size(200, 35);
            ip_textBox.MinimumSize = new Size(200, 35);
            ip_textBox.Name = "ip_textBox";
            ip_textBox.Size = new Size(200, 35);
            ip_textBox.TabIndex = 1;
            ip_textBox.TabStop = false;
            ip_textBox.Text = "localhost";
            // 
            // startsettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 416);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "startsettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += startsettings_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)db_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)port_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ip_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox darktheme_checkBox;
        private CheckBox lighttheme_checkBox;
        private TextBox db_textBox;
        private TextBox port_textBox;
        private TextBox ip_textBox;
        private PictureBox db_pictureBox;
        private PictureBox port_pictureBox;
        private PictureBox ip_pictureBox;
        private LinkLabel setdefault_linkLabel;
        private Button set_button;
    }
}