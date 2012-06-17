namespace Modelmayhem_Assistant
{
    partial class mainwin
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwin));
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залогинитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьПосылатьСообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Text = "Modelmayhem Assistant";
            // ненавижу толстых людей
            this._notifyIcon.Visible = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "DO IT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendtext);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 160);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(313, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(267, 230);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(313, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(140, 87);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(64, 24);
            this.buttonlogin.TabIndex = 9;
            this.buttonlogin.Text = "LOGIN";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.loginOnSite);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Кильнуть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.killThread);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.exitProgram);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.залогинитьсяToolStripMenuItem,
            this.начатьПосылатьСообщенияToolStripMenuItem,
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // залогинитьсяToolStripMenuItem
            // 
            this.залогинитьсяToolStripMenuItem.Name = "залогинитьсяToolStripMenuItem";
            this.залогинитьсяToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.залогинитьсяToolStripMenuItem.Text = "Залогиниться";
            this.залогинитьсяToolStripMenuItem.Click += new System.EventHandler(this.loginOnSite);
            // 
            // начатьПосылатьСообщенияToolStripMenuItem
            // 
            this.начатьПосылатьСообщенияToolStripMenuItem.Name = "начатьПосылатьСообщенияToolStripMenuItem";
            this.начатьПосылатьСообщенияToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.начатьПосылатьСообщенияToolStripMenuItem.Text = "Начать посылать сообщения";
            this.начатьПосылатьСообщенияToolStripMenuItem.Click += new System.EventHandler(this.sendtext);
            // 
            // киньлутьПотокПосылающийСообщенияToolStripMenuItem
            // 
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem.Name = "киньлутьПотокПосылающийСообщенияToolStripMenuItem";
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem.Text = "Киньлуть поток, посылающий сообщения";
            this.киньлутьПотокПосылающийСообщенияToolStripMenuItem.Click += new System.EventHandler(this.killThread);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.руководствоToolStripMenuItem,
            this.оПрограмеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.changelogWindowShow);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.aboutProgram);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Modelmayhem Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залогинитьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьПосылатьСообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem киньлутьПотокПосылающийСообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
    }
}

