namespace pcstore_arm
{
    partial class redactor
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            refresh_pictureBox = new PictureBox();
            delete_pictureBox = new PictureBox();
            category_comboBox = new ComboBox();
            sorting_comboBox = new ComboBox();
            search_pictureBox = new PictureBox();
            search_textBox = new TextBox();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            category_textBox = new ComboBox();
            addData_button = new Button();
            description_textBox = new TextBox();
            price_textBox = new TextBox();
            quantity_textBox = new TextBox();
            name_textBox = new TextBox();
            img_textBox = new TextBox();
            id_textBox = new TextBox();
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)delete_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator1, toolStripDropDownButton2, toolStripSeparator2, toolStripDropDownButton3, toolStripSeparator3, toolStripDropDownButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
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
            открытьМенюToolStripMenuItem.Size = new Size(180, 22);
            открытьМенюToolStripMenuItem.Text = "Перейти в меню";
            открытьМенюToolStripMenuItem.Click += открытьМенюToolStripMenuItem_Click;
            // 
            // обновитьДанныеToolStripMenuItem
            // 
            обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            обновитьДанныеToolStripMenuItem.Size = new Size(180, 22);
            обновитьДанныеToolStripMenuItem.Text = "Обновить данные";
            обновитьДанныеToolStripMenuItem.Click += обновитьДанныеToolStripMenuItem_Click;
            // 
            // перезапускToolStripMenuItem
            // 
            перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            перезапускToolStripMenuItem.Size = new Size(180, 22);
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
            открытьКассуToolStripMenuItem.Size = new Size(180, 22);
            открытьКассуToolStripMenuItem.Text = "Открыть кассу";
            открытьКассуToolStripMenuItem.Click += открытьКассуToolStripMenuItem_Click;
            // 
            // перейтиВКассуToolStripMenuItem
            // 
            перейтиВКассуToolStripMenuItem.Name = "перейтиВКассуToolStripMenuItem";
            перейтиВКассуToolStripMenuItem.Size = new Size(180, 22);
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
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(13, 34);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 410);
            tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Просмотр и редактирование";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(refresh_pictureBox);
            panel1.Controls.Add(delete_pictureBox);
            panel1.Controls.Add(category_comboBox);
            panel1.Controls.Add(sorting_comboBox);
            panel1.Controls.Add(search_pictureBox);
            panel1.Controls.Add(search_textBox);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(539, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 376);
            panel1.TabIndex = 1;
            // 
            // refresh_pictureBox
            // 
            refresh_pictureBox.Cursor = Cursors.Hand;
            refresh_pictureBox.Image = Properties.Resources.refresh;
            refresh_pictureBox.Location = new Point(134, 141);
            refresh_pictureBox.Name = "refresh_pictureBox";
            refresh_pictureBox.Size = new Size(50, 50);
            refresh_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            refresh_pictureBox.TabIndex = 9;
            refresh_pictureBox.TabStop = false;
            refresh_pictureBox.Click += refresh_pictureBox_Click;
            // 
            // delete_pictureBox
            // 
            delete_pictureBox.Cursor = Cursors.Hand;
            delete_pictureBox.Image = Properties.Resources.delete;
            delete_pictureBox.Location = new Point(42, 141);
            delete_pictureBox.Name = "delete_pictureBox";
            delete_pictureBox.Size = new Size(50, 50);
            delete_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            delete_pictureBox.TabIndex = 8;
            delete_pictureBox.TabStop = false;
            delete_pictureBox.Click += delete_pictureBox_Click;
            // 
            // category_comboBox
            // 
            category_comboBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            category_comboBox.FormattingEnabled = true;
            category_comboBox.Items.AddRange(new object[] { "Системные блоки", "Ноутбуки", "Мыши", "Клавиатуры", "Накопители", "Кабели", "МФУ", "Без категории" });
            category_comboBox.Location = new Point(7, 87);
            category_comboBox.Name = "category_comboBox";
            category_comboBox.Size = new Size(215, 31);
            category_comboBox.TabIndex = 7;
            category_comboBox.Text = "Категория";
            category_comboBox.SelectedIndexChanged += category_comboBox_SelectedIndexChanged;
            // 
            // sorting_comboBox
            // 
            sorting_comboBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sorting_comboBox.FormattingEnabled = true;
            sorting_comboBox.Items.AddRange(new object[] { "ID  (Возрастание)", "Название  (Возрастание)", "Цена  (Возрастание)", "Категория  (Возрастание)", "Количество  (Возрастание)", "ID  (Убывание)", "Название  (Убывание)", "Цена  (Убывание)", "Категория  (Убывание)", "Количество  (Убывание)", "Без сортировки" });
            sorting_comboBox.Location = new Point(7, 50);
            sorting_comboBox.Name = "sorting_comboBox";
            sorting_comboBox.Size = new Size(215, 31);
            sorting_comboBox.TabIndex = 6;
            sorting_comboBox.Text = "Сортировать по";
            sorting_comboBox.SelectedIndexChanged += sorting_comboBox_SelectedIndexChanged;
            // 
            // search_pictureBox
            // 
            search_pictureBox.Cursor = Cursors.Hand;
            search_pictureBox.Image = Properties.Resources.search;
            search_pictureBox.Location = new Point(187, 9);
            search_pictureBox.Name = "search_pictureBox";
            search_pictureBox.Size = new Size(35, 35);
            search_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            search_pictureBox.TabIndex = 5;
            search_pictureBox.TabStop = false;
            search_pictureBox.Click += search_pictureBox_Click;
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            search_textBox.ForeColor = Color.Black;
            search_textBox.Location = new Point(7, 12);
            search_textBox.MaximumSize = new Size(180, 30);
            search_textBox.MinimumSize = new Size(180, 30);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(180, 30);
            search_textBox.TabIndex = 4;
            search_textBox.TabStop = false;
            search_textBox.Text = "Поиск";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(524, 370);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(category_textBox);
            tabPage2.Controls.Add(addData_button);
            tabPage2.Controls.Add(description_textBox);
            tabPage2.Controls.Add(price_textBox);
            tabPage2.Controls.Add(quantity_textBox);
            tabPage2.Controls.Add(name_textBox);
            tabPage2.Controls.Add(img_textBox);
            tabPage2.Controls.Add(id_textBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавление товара";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // category_textBox
            // 
            category_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            category_textBox.FormattingEnabled = true;
            category_textBox.Items.AddRange(new object[] { "Системные блоки", "Ноутбуки", "Мыши", "Клавиатуры", "Накопители", "Кабели", "МФУ" });
            category_textBox.Location = new Point(280, 31);
            category_textBox.Name = "category_textBox";
            category_textBox.Size = new Size(200, 31);
            category_textBox.TabIndex = 13;
            category_textBox.Text = "Категория";
            // 
            // addData_button
            // 
            addData_button.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            addData_button.Location = new Point(527, 31);
            addData_button.Name = "addData_button";
            addData_button.Size = new Size(216, 47);
            addData_button.TabIndex = 12;
            addData_button.Text = ">>> Добавить <<<";
            addData_button.UseVisualStyleBackColor = true;
            addData_button.Click += addData_button_Click;
            // 
            // description_textBox
            // 
            description_textBox.AcceptsReturn = true;
            description_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            description_textBox.ForeColor = Color.Black;
            description_textBox.Location = new Point(34, 215);
            description_textBox.MinimumSize = new Size(200, 31);
            description_textBox.Multiline = true;
            description_textBox.Name = "description_textBox";
            description_textBox.Size = new Size(200, 31);
            description_textBox.TabIndex = 11;
            description_textBox.TabStop = false;
            description_textBox.Text = "Описание";
            description_textBox.WordWrap = false;
            description_textBox.TextChanged += description_textBox_TextChanged;
            // 
            // price_textBox
            // 
            price_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            price_textBox.ForeColor = Color.Black;
            price_textBox.Location = new Point(34, 150);
            price_textBox.MinimumSize = new Size(180, 30);
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(200, 31);
            price_textBox.TabIndex = 9;
            price_textBox.TabStop = false;
            price_textBox.Text = "Цена";
            // 
            // quantity_textBox
            // 
            quantity_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            quantity_textBox.ForeColor = Color.Black;
            quantity_textBox.Location = new Point(280, 90);
            quantity_textBox.MinimumSize = new Size(180, 30);
            quantity_textBox.Name = "quantity_textBox";
            quantity_textBox.Size = new Size(200, 31);
            quantity_textBox.TabIndex = 8;
            quantity_textBox.TabStop = false;
            quantity_textBox.Text = "Количество";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            name_textBox.ForeColor = Color.Black;
            name_textBox.Location = new Point(34, 90);
            name_textBox.MinimumSize = new Size(180, 30);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(200, 31);
            name_textBox.TabIndex = 7;
            name_textBox.TabStop = false;
            name_textBox.Text = "Название";
            // 
            // img_textBox
            // 
            img_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            img_textBox.ForeColor = Color.Black;
            img_textBox.Location = new Point(280, 150);
            img_textBox.MinimumSize = new Size(180, 30);
            img_textBox.Name = "img_textBox";
            img_textBox.Size = new Size(200, 31);
            img_textBox.TabIndex = 6;
            img_textBox.TabStop = false;
            img_textBox.Text = "Путь до изображения";
            img_textBox.DoubleClick += img_textBox_DoubleClick;
            // 
            // id_textBox
            // 
            id_textBox.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            id_textBox.ForeColor = Color.Black;
            id_textBox.Location = new Point(34, 31);
            id_textBox.MinimumSize = new Size(180, 30);
            id_textBox.Name = "id_textBox";
            id_textBox.Size = new Size(200, 31);
            id_textBox.TabIndex = 5;
            id_textBox.TabStop = false;
            id_textBox.Text = "ID";
            // 
            // redactor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(toolStrip1);
            Name = "redactor";
            Text = "redactor";
            Load += redactor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)refresh_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)delete_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem открытьМенюToolStripMenuItem;
        private ToolStripMenuItem обновитьДанныеToolStripMenuItem;
        private ToolStripMenuItem перезапускToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem открытьКассуToolStripMenuItem;
        private ToolStripMenuItem перейтиВКассуToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem открытьРедакторToolStripMenuItem;
        private ToolStripMenuItem перейтиВРедакторToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripMenuItem открытьИсториюПокупокToolStripMenuItem;
        private ToolStripMenuItem перейтиВИсториюПокупокToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Panel panel1;
        private ComboBox sorting_comboBox;
        private PictureBox search_pictureBox;
        private TextBox search_textBox;
        private ComboBox category_comboBox;
        private PictureBox refresh_pictureBox;
        private PictureBox delete_pictureBox;
        private TextBox name_textBox;
        private TextBox img_textBox;
        private TextBox id_textBox;
        private TextBox quantity_textBox;
        private TextBox description_textBox;
        private TextBox price_textBox;
        private Button addData_button;
        private ComboBox category_textBox;
    }
}