namespace pcstore_arm
{
    partial class main
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
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            cashbox_panel = new Panel();
            label1 = new Label();
            cashbox_pictureBox = new PictureBox();
            storage_panel = new Panel();
            label2 = new Label();
            storage_pictureBox = new PictureBox();
            settings_panel = new Panel();
            label3 = new Label();
            settings_pictureBox = new PictureBox();
            check_panel = new Panel();
            check_label = new Label();
            check_pictureBox = new PictureBox();
            reboot_panel = new Panel();
            reboot_label = new Label();
            reboot_pictureBox = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            cashbox_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashbox_pictureBox).BeginInit();
            storage_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storage_pictureBox).BeginInit();
            settings_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settings_pictureBox).BeginInit();
            check_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)check_pictureBox).BeginInit();
            reboot_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reboot_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(218, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 540);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(546, 512);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Подключение к БД";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 506);
            panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(546, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Настройка";
            // 
            // tabPage3
            // 
            tabPage3.AutoScroll = true;
            tabPage3.BackColor = Color.Transparent;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(546, 493);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Работа с кассой";
            // 
            // tabPage4
            // 
            tabPage4.AutoScroll = true;
            tabPage4.BackColor = Color.Transparent;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(546, 493);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Работа со складом";
            // 
            // cashbox_panel
            // 
            cashbox_panel.Controls.Add(label1);
            cashbox_panel.Controls.Add(cashbox_pictureBox);
            cashbox_panel.Cursor = Cursors.Hand;
            cashbox_panel.Location = new Point(5, 11);
            cashbox_panel.Name = "cashbox_panel";
            cashbox_panel.Size = new Size(207, 66);
            cashbox_panel.TabIndex = 0;
            cashbox_panel.Click += cashbox_panel_Click;
            cashbox_panel.Paint += cashbox_panel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "Касса";
            label1.Click += cashbox_panel_Click;
            // 
            // cashbox_pictureBox
            // 
            cashbox_pictureBox.Location = new Point(3, 3);
            cashbox_pictureBox.Name = "cashbox_pictureBox";
            cashbox_pictureBox.Size = new Size(62, 60);
            cashbox_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cashbox_pictureBox.TabIndex = 0;
            cashbox_pictureBox.TabStop = false;
            cashbox_pictureBox.Click += cashbox_panel_Click;
            // 
            // storage_panel
            // 
            storage_panel.Controls.Add(label2);
            storage_panel.Controls.Add(storage_pictureBox);
            storage_panel.Cursor = Cursors.Hand;
            storage_panel.Location = new Point(5, 83);
            storage_panel.Name = "storage_panel";
            storage_panel.Size = new Size(207, 66);
            storage_panel.TabIndex = 1;
            storage_panel.Click += storage_panel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 16);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 1;
            label2.Text = "Склад";
            label2.Click += storage_panel_Click;
            // 
            // storage_pictureBox
            // 
            storage_pictureBox.Location = new Point(3, 3);
            storage_pictureBox.Name = "storage_pictureBox";
            storage_pictureBox.Size = new Size(62, 60);
            storage_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            storage_pictureBox.TabIndex = 0;
            storage_pictureBox.TabStop = false;
            storage_pictureBox.Click += storage_panel_Click;
            // 
            // settings_panel
            // 
            settings_panel.Controls.Add(label3);
            settings_panel.Controls.Add(settings_pictureBox);
            settings_panel.Cursor = Cursors.Hand;
            settings_panel.Location = new Point(5, 227);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new Size(207, 66);
            settings_panel.TabIndex = 1;
            settings_panel.Click += settings_panel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 16);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 2;
            label3.Text = "Настройки";
            label3.Click += settings_panel_Click;
            // 
            // settings_pictureBox
            // 
            settings_pictureBox.Location = new Point(3, 3);
            settings_pictureBox.Name = "settings_pictureBox";
            settings_pictureBox.Size = new Size(62, 60);
            settings_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            settings_pictureBox.TabIndex = 0;
            settings_pictureBox.TabStop = false;
            settings_pictureBox.Click += settings_panel_Click;
            // 
            // check_panel
            // 
            check_panel.Controls.Add(check_label);
            check_panel.Controls.Add(check_pictureBox);
            check_panel.Cursor = Cursors.Hand;
            check_panel.Location = new Point(5, 155);
            check_panel.Name = "check_panel";
            check_panel.Size = new Size(207, 66);
            check_panel.TabIndex = 3;
            check_panel.Click += check_panel_Click;
            // 
            // check_label
            // 
            check_label.AutoSize = true;
            check_label.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            check_label.Location = new Point(70, 16);
            check_label.Name = "check_label";
            check_label.Size = new Size(112, 31);
            check_label.TabIndex = 2;
            check_label.Text = "Выписка";
            check_label.Click += check_panel_Click;
            // 
            // check_pictureBox
            // 
            check_pictureBox.Location = new Point(3, 3);
            check_pictureBox.Name = "check_pictureBox";
            check_pictureBox.Size = new Size(62, 60);
            check_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            check_pictureBox.TabIndex = 0;
            check_pictureBox.TabStop = false;
            check_pictureBox.Click += check_panel_Click;
            // 
            // reboot_panel
            // 
            reboot_panel.Controls.Add(reboot_label);
            reboot_panel.Controls.Add(reboot_pictureBox);
            reboot_panel.Cursor = Cursors.Hand;
            reboot_panel.Location = new Point(5, 299);
            reboot_panel.Name = "reboot_panel";
            reboot_panel.Size = new Size(207, 66);
            reboot_panel.TabIndex = 3;
            reboot_panel.Click += reboot_panel_Click;
            // 
            // reboot_label
            // 
            reboot_label.AutoSize = true;
            reboot_label.Font = new Font("Segoe UI", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            reboot_label.Location = new Point(70, 16);
            reboot_label.Name = "reboot_label";
            reboot_label.Size = new Size(96, 31);
            reboot_label.TabIndex = 2;
            reboot_label.Text = "Рестарт";
            reboot_label.Click += reboot_panel_Click;
            // 
            // reboot_pictureBox
            // 
            reboot_pictureBox.Location = new Point(3, 3);
            reboot_pictureBox.Name = "reboot_pictureBox";
            reboot_pictureBox.Size = new Size(62, 60);
            reboot_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            reboot_pictureBox.TabIndex = 0;
            reboot_pictureBox.TabStop = false;
            reboot_pictureBox.Click += reboot_panel_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(reboot_panel);
            Controls.Add(check_panel);
            Controls.Add(settings_panel);
            Controls.Add(storage_panel);
            Controls.Add(cashbox_panel);
            Controls.Add(tabControl1);
            MinimumSize = new Size(800, 600);
            Name = "main";
            Text = "Главное меню";
            Load += main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            cashbox_panel.ResumeLayout(false);
            cashbox_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashbox_pictureBox).EndInit();
            storage_panel.ResumeLayout(false);
            storage_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storage_pictureBox).EndInit();
            settings_panel.ResumeLayout(false);
            settings_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settings_pictureBox).EndInit();
            check_panel.ResumeLayout(false);
            check_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)check_pictureBox).EndInit();
            reboot_panel.ResumeLayout(false);
            reboot_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reboot_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private VScrollBar vScrollBar1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Panel cashbox_panel;
        private PictureBox cashbox_pictureBox;
        private Panel storage_panel;
        private PictureBox storage_pictureBox;
        private Panel settings_panel;
        private PictureBox settings_pictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel check_panel;
        private Label check_label;
        private PictureBox check_pictureBox;
        private Panel reboot_panel;
        private Label reboot_label;
        private PictureBox reboot_pictureBox;
    }
}