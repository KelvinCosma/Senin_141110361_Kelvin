namespace Latihan_pos
{
    partial class AddTransaction
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
            this.Back = new System.Windows.Forms.Button();
            this.AddTransactionTabControl = new MetroFramework.Controls.MetroTabControl();
            this.AddPembelianPage = new System.Windows.Forms.TabPage();
            this.AddPenjualanPage = new System.Windows.Forms.TabPage();
            this.AddTransactionTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Back.Location = new System.Drawing.Point(48, 424);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(256, 32);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddTransactionTabControl
            // 
            this.AddTransactionTabControl.Controls.Add(this.AddPembelianPage);
            this.AddTransactionTabControl.Controls.Add(this.AddPenjualanPage);
            this.AddTransactionTabControl.Location = new System.Drawing.Point(20, 80);
            this.AddTransactionTabControl.Multiline = true;
            this.AddTransactionTabControl.Name = "AddTransactionTabControl";
            this.AddTransactionTabControl.SelectedIndex = 0;
            this.AddTransactionTabControl.Size = new System.Drawing.Size(320, 320);
            this.AddTransactionTabControl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.AddTransactionTabControl.TabIndex = 0;
            this.AddTransactionTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddTransactionTabControl.UseSelectable = true;
            // 
            // AddPembelianPage
            // 
            this.AddPembelianPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.AddPembelianPage.ForeColor = System.Drawing.Color.Yellow;
            this.AddPembelianPage.Location = new System.Drawing.Point(4, 38);
            this.AddPembelianPage.Name = "AddPembelianPage";
            this.AddPembelianPage.Size = new System.Drawing.Size(312, 278);
            this.AddPembelianPage.TabIndex = 1;
            this.AddPembelianPage.Text = "  Pembelian  ";
            // 
            // AddPenjualanPage
            // 
            this.AddPenjualanPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.AddPenjualanPage.ForeColor = System.Drawing.Color.Yellow;
            this.AddPenjualanPage.Location = new System.Drawing.Point(4, 38);
            this.AddPenjualanPage.Name = "AddPenjualanPage";
            this.AddPenjualanPage.Size = new System.Drawing.Size(312, 278);
            this.AddPenjualanPage.TabIndex = 0;
            this.AddPenjualanPage.Text = "  Penjualan  ";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.AddTransactionTabControl);
            this.Controls.Add(this.Back);
            this.Name = "AddTransaction";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Add Transaction";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.AddTransactionTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroTabControl AddTransactionTabControl;
        private System.Windows.Forms.TabPage AddPembelianPage;
        private System.Windows.Forms.TabPage AddPenjualanPage;
    }
}