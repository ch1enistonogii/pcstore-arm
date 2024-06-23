namespace pcstore_arm
{
    partial class login
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
            password_textBox = new TextBox();
            user_textBox = new TextBox();
            connect_button = new Button();
            settings_linkLabel = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            instructions_linkLabel = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            password_textBox.ForeColor = Color.Black;
            password_textBox.Location = new Point(72, 81);
            password_textBox.MaximumSize = new Size(200, 35);
            password_textBox.MinimumSize = new Size(200, 35);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(200, 35);
            password_textBox.TabIndex = 0;
            password_textBox.TabStop = false;
            password_textBox.Text = "Пароль";
            password_textBox.Click += user_textBox_Click;
            password_textBox.TextChanged += password_textBox_TextChanged;
            // 
            // user_textBox
            // 
            user_textBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            user_textBox.ForeColor = Color.Black;
            user_textBox.Location = new Point(72, 40);
            user_textBox.MaximumSize = new Size(200, 35);
            user_textBox.MinimumSize = new Size(200, 35);
            user_textBox.Name = "user_textBox";
            user_textBox.Size = new Size(200, 35);
            user_textBox.TabIndex = 0;
            user_textBox.TabStop = false;
            user_textBox.Text = "Имя пользователя";
            user_textBox.Click += password_textBox_Click;
            // 
            // connect_button
            // 
            connect_button.BackColor = Color.White;
            connect_button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            connect_button.Location = new Point(51, 127);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(200, 30);
            connect_button.TabIndex = 2;
            connect_button.Text = "Войти";
            connect_button.UseVisualStyleBackColor = false;
            connect_button.Click += connect_button_Click;
            // 
            // settings_linkLabel
            // 
            settings_linkLabel.ActiveLinkColor = Color.Gray;
            settings_linkLabel.AutoSize = true;
            settings_linkLabel.ForeColor = SystemColors.ActiveCaptionText;
            settings_linkLabel.LinkColor = Color.Gray;
            settings_linkLabel.Location = new Point(81, 166);
            settings_linkLabel.Name = "settings_linkLabel";
            settings_linkLabel.Size = new Size(67, 15);
            settings_linkLabel.TabIndex = 3;
            settings_linkLabel.TabStop = true;
            settings_linkLabel.Text = "Настройки";
            settings_linkLabel.LinkClicked += settings_linkLabel_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(instructions_linkLabel);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(settings_linkLabel);
            panel1.Controls.Add(connect_button);
            panel1.Controls.Add(user_textBox);
            panel1.Controls.Add(password_textBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 213);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(81, 81, 81);
            label1.Location = new Point(146, 165);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 7;
            label1.Text = "|";
            // 
            // instructions_linkLabel
            // 
            instructions_linkLabel.ActiveLinkColor = Color.Gray;
            instructions_linkLabel.AutoSize = true;
            instructions_linkLabel.ForeColor = SystemColors.ActiveCaptionText;
            instructions_linkLabel.LinkColor = Color.Gray;
            instructions_linkLabel.Location = new Point(153, 166);
            instructions_linkLabel.Name = "instructions_linkLabel";
            instructions_linkLabel.Size = new Size(56, 15);
            instructions_linkLabel.TabIndex = 6;
            instructions_linkLabel.TabStop = true;
            instructions_linkLabel.Text = "Помощь";
            instructions_linkLabel.LinkClicked += instructions_linkLabel_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(31, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(31, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(304, 213);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(320, 320);
            MinimumSize = new Size(250, 195);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добро пожаловать!";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox password_textBox;
        private TextBox user_textBox;
        private Button connect_button;
        private LinkLabel settings_linkLabel;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel instructions_linkLabel;
    }
}