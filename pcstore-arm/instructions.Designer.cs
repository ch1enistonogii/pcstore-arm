namespace pcstore_arm
{
    partial class instructions
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
            start_richTextBox = new RichTextBox();
            tabPage2 = new TabPage();
            setup_richTextBox = new RichTextBox();
            tabPage3 = new TabPage();
            end_richTextBox = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(start_richTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Начало работы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // start_richTextBox
            // 
            start_richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            start_richTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            start_richTextBox.Location = new Point(6, 6);
            start_richTextBox.Name = "start_richTextBox";
            start_richTextBox.Size = new Size(756, 386);
            start_richTextBox.TabIndex = 0;
            start_richTextBox.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(setup_richTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Установка программ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // setup_richTextBox
            // 
            setup_richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            setup_richTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            setup_richTextBox.Location = new Point(6, 6);
            setup_richTextBox.Name = "setup_richTextBox";
            setup_richTextBox.Size = new Size(756, 386);
            setup_richTextBox.TabIndex = 1;
            setup_richTextBox.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(end_richTextBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Развертывание Базы Данных";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // end_richTextBox
            // 
            end_richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            end_richTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            end_richTextBox.Location = new Point(6, 6);
            end_richTextBox.Name = "end_richTextBox";
            end_richTextBox.Size = new Size(756, 386);
            end_richTextBox.TabIndex = 1;
            end_richTextBox.Text = "";
            // 
            // instructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "instructions";
            Text = "Помощь";
            Load += instructions_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox start_richTextBox;
        private RichTextBox setup_richTextBox;
        private RichTextBox end_richTextBox;
    }
}