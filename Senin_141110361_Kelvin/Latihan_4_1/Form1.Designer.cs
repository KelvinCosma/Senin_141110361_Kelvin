namespace Latihan_4_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FontFamily_comboBox = new System.Windows.Forms.ComboBox();
            this.Color_comboBox = new System.Windows.Forms.ComboBox();
            this.BackColor_comboBox = new System.Windows.Forms.ComboBox();
            this.FontSize_comboBox = new System.Windows.Forms.ComboBox();
            this.Font_Style = new System.Windows.Forms.Label();
            this.Size1 = new System.Windows.Forms.Label();
            this.Font_Family = new System.Windows.Forms.Label();
            this.Fore_Color = new System.Windows.Forms.Label();
            this.Back_Color = new System.Windows.Forms.Label();
            this.Bold_Button = new System.Windows.Forms.CheckBox();
            this.Italic_Button = new System.Windows.Forms.CheckBox();
            this.Underline_Button = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 269);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FontFamily_comboBox
            // 
            this.FontFamily_comboBox.FormattingEnabled = true;
            this.FontFamily_comboBox.IntegralHeight = false;
            this.FontFamily_comboBox.Location = new System.Drawing.Point(145, 54);
            this.FontFamily_comboBox.Name = "FontFamily_comboBox";
            this.FontFamily_comboBox.Size = new System.Drawing.Size(105, 21);
            this.FontFamily_comboBox.TabIndex = 2;
            this.FontFamily_comboBox.SelectedIndexChanged += new System.EventHandler(this.FontFamily_comboBox_SelectedIndexChanged);
            // 
            // Color_comboBox
            // 
            this.Color_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Color_comboBox.DropDownWidth = 200;
            this.Color_comboBox.FormattingEnabled = true;
            this.Color_comboBox.IntegralHeight = false;
            this.Color_comboBox.Location = new System.Drawing.Point(256, 54);
            this.Color_comboBox.Name = "Color_comboBox";
            this.Color_comboBox.Size = new System.Drawing.Size(105, 21);
            this.Color_comboBox.TabIndex = 3;
            this.Color_comboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Color_comboBox_DrawItem);
            this.Color_comboBox.SelectedIndexChanged += new System.EventHandler(this.Color_comboBox_SelectedIndexChanged);
            // 
            // BackColor_comboBox
            // 
            this.BackColor_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BackColor_comboBox.DropDownWidth = 200;
            this.BackColor_comboBox.FormattingEnabled = true;
            this.BackColor_comboBox.IntegralHeight = false;
            this.BackColor_comboBox.Location = new System.Drawing.Point(367, 54);
            this.BackColor_comboBox.Name = "BackColor_comboBox";
            this.BackColor_comboBox.Size = new System.Drawing.Size(105, 21);
            this.BackColor_comboBox.TabIndex = 7;
            this.BackColor_comboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.BackColor_comboBox_DrawItem);
            this.BackColor_comboBox.SelectedIndexChanged += new System.EventHandler(this.BackColor_comboBox_SelectedIndexChanged);
            // 
            // FontSize_comboBox
            // 
            this.FontSize_comboBox.DropDownHeight = 80;
            this.FontSize_comboBox.FormattingEnabled = true;
            this.FontSize_comboBox.IntegralHeight = false;
            this.FontSize_comboBox.Location = new System.Drawing.Point(104, 54);
            this.FontSize_comboBox.Name = "FontSize_comboBox";
            this.FontSize_comboBox.Size = new System.Drawing.Size(35, 21);
            this.FontSize_comboBox.TabIndex = 8;
            this.FontSize_comboBox.SelectedIndexChanged += new System.EventHandler(this.FontSize_comboBox_SelectedIndexChanged);
            // 
            // Font_Style
            // 
            this.Font_Style.Location = new System.Drawing.Point(12, 30);
            this.Font_Style.Name = "Font_Style";
            this.Font_Style.Size = new System.Drawing.Size(85, 15);
            this.Font_Style.TabIndex = 9;
            this.Font_Style.Text = "Font Style";
            this.Font_Style.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Size
            // 
            this.Size1.Location = new System.Drawing.Point(101, 30);
            this.Size1.Name = "Size";
            this.Size1.Size = new System.Drawing.Size(38, 15);
            this.Size1.TabIndex = 9;
            this.Size1.Text = "Size";
            this.Size1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Font_Family
            // 
            this.Font_Family.Location = new System.Drawing.Point(142, 30);
            this.Font_Family.Name = "Font_Family";
            this.Font_Family.Size = new System.Drawing.Size(108, 15);
            this.Font_Family.TabIndex = 9;
            this.Font_Family.Text = "Font Family";
            this.Font_Family.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fore_Color
            // 
            this.Fore_Color.Location = new System.Drawing.Point(253, 30);
            this.Fore_Color.Name = "Fore_Color";
            this.Fore_Color.Size = new System.Drawing.Size(108, 15);
            this.Fore_Color.TabIndex = 9;
            this.Fore_Color.Text = "Fore Color";
            this.Fore_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_Color
            // 
            this.Back_Color.Location = new System.Drawing.Point(364, 30);
            this.Back_Color.Name = "Back_Color";
            this.Back_Color.Size = new System.Drawing.Size(108, 15);
            this.Back_Color.TabIndex = 9;
            this.Back_Color.Text = "Back Color";
            this.Back_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bold_Button
            // 
            this.Bold_Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Bold_Button.Image = ((System.Drawing.Image)(resources.GetObject("Bold_Button.Image")));
            this.Bold_Button.Location = new System.Drawing.Point(10, 52);
            this.Bold_Button.Name = "Bold_Button";
            this.Bold_Button.Size = new System.Drawing.Size(23, 23);
            this.Bold_Button.TabIndex = 10;
            this.Bold_Button.UseVisualStyleBackColor = true;
            this.Bold_Button.Click += new System.EventHandler(this.Bold_Button_Click);
            // 
            // Italic_Button
            // 
            this.Italic_Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Italic_Button.Image = ((System.Drawing.Image)(resources.GetObject("Italic_Button.Image")));
            this.Italic_Button.Location = new System.Drawing.Point(39, 52);
            this.Italic_Button.Name = "Italic_Button";
            this.Italic_Button.Size = new System.Drawing.Size(23, 23);
            this.Italic_Button.TabIndex = 10;
            this.Italic_Button.UseVisualStyleBackColor = true;
            this.Italic_Button.Click += new System.EventHandler(this.Italic_Button_Click);
            // 
            // Underline_Button
            // 
            this.Underline_Button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Underline_Button.Image = ((System.Drawing.Image)(resources.GetObject("Underline_Button.Image")));
            this.Underline_Button.Location = new System.Drawing.Point(68, 52);
            this.Underline_Button.Name = "Underline_Button";
            this.Underline_Button.Size = new System.Drawing.Size(23, 23);
            this.Underline_Button.TabIndex = 10;
            this.Underline_Button.UseVisualStyleBackColor = true;
            this.Underline_Button.Click += new System.EventHandler(this.Underline_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.Underline_Button);
            this.Controls.Add(this.Italic_Button);
            this.Controls.Add(this.Bold_Button);
            this.Controls.Add(this.Back_Color);
            this.Controls.Add(this.Fore_Color);
            this.Controls.Add(this.Font_Family);
            this.Controls.Add(this.Size1);
            this.Controls.Add(this.Font_Style);
            this.Controls.Add(this.FontSize_comboBox);
            this.Controls.Add(this.BackColor_comboBox);
            this.Controls.Add(this.Color_comboBox);
            this.Controls.Add(this.FontFamily_comboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox FontFamily_comboBox;
        private System.Windows.Forms.ComboBox Color_comboBox;
        private System.Windows.Forms.ComboBox BackColor_comboBox;
        private System.Windows.Forms.ComboBox FontSize_comboBox;
        private System.Windows.Forms.Label Font_Style;
        private System.Windows.Forms.Label Size1;
        private System.Windows.Forms.Label Font_Family;
        private System.Windows.Forms.Label Fore_Color;
        private System.Windows.Forms.Label Back_Color;
        private System.Windows.Forms.CheckBox Bold_Button;
        private System.Windows.Forms.CheckBox Italic_Button;
        private System.Windows.Forms.CheckBox Underline_Button;
    }
}

