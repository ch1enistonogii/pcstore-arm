namespace pcstore_arm
{
    partial class catalog
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
            category_comboBox = new ComboBox();
            sorting_comboBox = new ComboBox();
            search_pictureBox = new PictureBox();
            search_textBox = new TextBox();
            order_button = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            открытьМенюToolStripMenuItem = new ToolStripMenuItem();
            обновитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            перезапускToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            открытьКассуToolStripMenuItem = new ToolStripMenuItem();
            перейтиВКассуToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            открытьРедакторToolStripMenuItem = new ToolStripMenuItem();
            перейтиВРедакторToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripDropDownButton4 = new ToolStripDropDownButton();
            открытьИсториюПокупокToolStripMenuItem = new ToolStripMenuItem();
            перейтиВИсториюПокупокToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_pictureBox).BeginInit();
            tabPage2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 410);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Каталог";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(category_comboBox);
            panel1.Controls.Add(sorting_comboBox);
            panel1.Controls.Add(search_pictureBox);
            panel1.Controls.Add(search_textBox);
            panel1.Controls.Add(order_button);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(536, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 376);
            panel1.TabIndex = 1;
            // 
            // category_comboBox
            // 
            category_comboBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            category_comboBox.FormattingEnabled = true;
            category_comboBox.Items.AddRange(new object[] { "Системные блоки", "Ноутбуки", "Мыши", "Клавиатуры", "Накопители", "Кабели", "МФУ", "Без категории" });
            category_comboBox.Location = new Point(7, 86);
            category_comboBox.Name = "category_comboBox";
            category_comboBox.Size = new Size(215, 31);
            category_comboBox.TabIndex = 8;
            category_comboBox.Text = "Категория";
            category_comboBox.SelectedIndexChanged += category_comboBox_SelectedIndexChanged;
            // 
            // sorting_comboBox
            // 
            sorting_comboBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sorting_comboBox.FormattingEnabled = true;
            sorting_comboBox.Items.AddRange(new object[] { "ID  (Возрастание)", "Название  (Возрастание)", "Цена  (Возрастание)", "Категория  (Возрастание)", "Количество  (Возрастание)", "ID  (Убывание)", "Название  (Убывание)", "Цена  (Убывание)", "Категория  (Убывание)", "Количество  (Убывание)", "Без сортировки" });
            sorting_comboBox.Location = new Point(7, 49);
            sorting_comboBox.Name = "sorting_comboBox";
            sorting_comboBox.Size = new Size(215, 31);
            sorting_comboBox.TabIndex = 3;
            sorting_comboBox.Text = "Сортировать по";
            sorting_comboBox.SelectedIndexChanged += sorting_comboBox_SelectedIndexChanged;
            // 
            // search_pictureBox
            // 
            search_pictureBox.Cursor = Cursors.Hand;
            search_pictureBox.Location = new Point(187, 8);
            search_pictureBox.Name = "search_pictureBox";
            search_pictureBox.Size = new Size(35, 35);
            search_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            search_pictureBox.TabIndex = 2;
            search_pictureBox.TabStop = false;
            search_pictureBox.Click += search_pictureBox_Click;
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            search_textBox.ForeColor = Color.Black;
            search_textBox.Location = new Point(7, 11);
            search_textBox.MaximumSize = new Size(180, 30);
            search_textBox.MinimumSize = new Size(180, 30);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(180, 30);
            search_textBox.TabIndex = 1;
            search_textBox.TabStop = false;
            search_textBox.Text = "Поиск";
            // 
            // order_button
            // 
            order_button.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            order_button.Location = new Point(7, 123);
            order_button.Name = "order_button";
            order_button.Size = new Size(215, 52);
            order_button.TabIndex = 0;
            order_button.Text = ">>> Купить <<<";
            order_button.UseVisualStyleBackColor = true;
            order_button.Click += order_button_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(524, 360);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel2);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Корзина";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(603, 376);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(612, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 376);
            panel2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator1, toolStripDropDownButton2, toolStripSeparator2, toolStripDropDownButton3, toolStripSeparator3, toolStripDropDownButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { открытьМенюToolStripMenuItem, обновитьДанныеToolStripMenuItem, перезапускToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.menu;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // открытьМенюToolStripMenuItem
            // 
            открытьМенюToolStripMenuItem.Name = "открытьМенюToolStripMenuItem";
            открытьМенюToolStripMenuItem.Size = new Size(172, 22);
            открытьМенюToolStripMenuItem.Text = "Перейти в меню";
            открытьМенюToolStripMenuItem.Click += открытьМенюToolStripMenuItem_Click;
            // 
            // обновитьДанныеToolStripMenuItem
            // 
            обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            обновитьДанныеToolStripMenuItem.Size = new Size(172, 22);
            обновитьДанныеToolStripMenuItem.Text = "Обновить данные";
            обновитьДанныеToolStripMenuItem.Click += обновитьДанныеToolStripMenuItem_Click;
            // 
            // перезапускToolStripMenuItem
            // 
            перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            перезапускToolStripMenuItem.Size = new Size(172, 22);
            перезапускToolStripMenuItem.Text = "Перезапуск";
            перезапускToolStripMenuItem.Click += перезапускToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { открытьКассуToolStripMenuItem, перейтиВКассуToolStripMenuItem });
            toolStripDropDownButton2.Image = Properties.Resources.order;
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(29, 22);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // открытьКассуToolStripMenuItem
            // 
            открытьКассуToolStripMenuItem.Name = "открытьКассуToolStripMenuItem";
            открытьКассуToolStripMenuItem.Size = new Size(163, 22);
            открытьКассуToolStripMenuItem.Text = "Открыть кассу";
            открытьКассуToolStripMenuItem.Click += открытьКассуToolStripMenuItem_Click;
            // 
            // перейтиВКассуToolStripMenuItem
            // 
            перейтиВКассуToolStripMenuItem.Name = "перейтиВКассуToolStripMenuItem";
            перейтиВКассуToolStripMenuItem.Size = new Size(163, 22);
            перейтиВКассуToolStripMenuItem.Text = "Перейти в кассу";
            перейтиВКассуToolStripMenuItem.Click += перейтиВКассуToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { открытьРедакторToolStripMenuItem, перейтиВРедакторToolStripMenuItem });
            toolStripDropDownButton3.Image = Properties.Resources.pen;
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(29, 22);
            toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // открытьРедакторToolStripMenuItem
            // 
            открытьРедакторToolStripMenuItem.Name = "открытьРедакторToolStripMenuItem";
            открытьРедакторToolStripMenuItem.Size = new Size(183, 22);
            открытьРедакторToolStripMenuItem.Text = "Открыть редактор";
            открытьРедакторToolStripMenuItem.Click += открытьРедакторToolStripMenuItem_Click;
            // 
            // перейтиВРедакторToolStripMenuItem
            // 
            перейтиВРедакторToolStripMenuItem.Name = "перейтиВРедакторToolStripMenuItem";
            перейтиВРедакторToolStripMenuItem.Size = new Size(183, 22);
            перейтиВРедакторToolStripMenuItem.Text = "Перейти в редактор";
            перейтиВРедакторToolStripMenuItem.Click += перейтиВРедакторToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton4
            // 
            toolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton4.DropDownItems.AddRange(new ToolStripItem[] { открытьИсториюПокупокToolStripMenuItem, перейтиВИсториюПокупокToolStripMenuItem });
            toolStripDropDownButton4.Image = Properties.Resources.check2;
            toolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            toolStripDropDownButton4.Size = new Size(29, 22);
            toolStripDropDownButton4.Text = "toolStripDropDownButton4";
            // 
            // открытьИсториюПокупокToolStripMenuItem
            // 
            открытьИсториюПокупокToolStripMenuItem.Name = "открытьИсториюПокупокToolStripMenuItem";
            открытьИсториюПокупокToolStripMenuItem.Size = new Size(231, 22);
            открытьИсториюПокупокToolStripMenuItem.Text = "Открыть историю покупок";
            открытьИсториюПокупокToolStripMenuItem.Click += открытьИсториюПокупокToolStripMenuItem_Click;
            // 
            // перейтиВИсториюПокупокToolStripMenuItem
            // 
            перейтиВИсториюПокупокToolStripMenuItem.Name = "перейтиВИсториюПокупокToolStripMenuItem";
            перейтиВИсториюПокупокToolStripMenuItem.Size = new Size(231, 22);
            перейтиВИсториюПокупокToolStripMenuItem.Text = "Перейти в историю покупок";
            перейтиВИсториюПокупокToolStripMenuItem.Click += перейтиВИсториюПокупокToolStripMenuItem_Click;
            // 
            // catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(tabControl1);
            Name = "catalog";
            Text = "catalog";
            Load += catalog_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_pictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private ToolStrip toolStrip1;
        private Button order_button;
        private TextBox search_textBox;
        private PictureBox search_pictureBox;
        private ComboBox sorting_comboBox;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem открытьМенюToolStripMenuItem;
        private ToolStripMenuItem перезапускToolStripMenuItem;
        private ToolStripMenuItem открытьКассуToolStripMenuItem;
        private ToolStripMenuItem перейтиВКассуToolStripMenuItem;
        private ToolStripMenuItem открытьРедакторToolStripMenuItem;
        private ToolStripMenuItem перейтиВРедакторToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripMenuItem открытьИсториюПокупокToolStripMenuItem;
        private ToolStripMenuItem перейтиВИсториюПокупокToolStripMenuItem;
        private ToolStripMenuItem обновитьДанныеToolStripMenuItem;
        private ComboBox category_comboBox;
    }
}