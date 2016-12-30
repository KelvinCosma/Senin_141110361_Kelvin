namespace Latihan_pos
{
    partial class TransactionList
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
            this.TransactionListTabControl = new MetroFramework.Controls.MetroTabControl();
            this.DatabasePembelianPage = new System.Windows.Forms.TabPage();
            this.DatabasePenjualanPage = new System.Windows.Forms.TabPage();
            this.DatabaseDetailPembelianPage = new System.Windows.Forms.TabPage();
            this.DatabaseDetailPenjualanPage = new System.Windows.Forms.TabPage();
            this.TransactionListTabControl.SuspendLayout();
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
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TransactionListTabControl
            // 
            this.TransactionListTabControl.Controls.Add(this.DatabasePembelianPage);
            this.TransactionListTabControl.Controls.Add(this.DatabaseDetailPembelianPage);
            this.TransactionListTabControl.Controls.Add(this.DatabasePenjualanPage);
            this.TransactionListTabControl.Controls.Add(this.DatabaseDetailPenjualanPage);
            this.TransactionListTabControl.Location = new System.Drawing.Point(20, 80);
            this.TransactionListTabControl.Multiline = true;
            this.TransactionListTabControl.Name = "TransactionListTabControl";
            this.TransactionListTabControl.SelectedIndex = 0;
            this.TransactionListTabControl.Size = new System.Drawing.Size(600, 320);
            this.TransactionListTabControl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TransactionListTabControl.TabIndex = 0;
            this.TransactionListTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransactionListTabControl.UseSelectable = true;
            // 
            // DatabasePembelianPage
            // 
            this.DatabasePembelianPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabasePembelianPage.ForeColor = System.Drawing.Color.Yellow;
            this.DatabasePembelianPage.Location = new System.Drawing.Point(4, 38);
            this.DatabasePembelianPage.Name = "DatabasePembelianPage";
            this.DatabasePembelianPage.Size = new System.Drawing.Size(592, 278);
            this.DatabasePembelianPage.TabIndex = 1;
            this.DatabasePembelianPage.Text = "  Pembelian  ";
            // 
            // DatabasePenjualanPage
            // 
            this.DatabasePenjualanPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabasePenjualanPage.ForeColor = System.Drawing.Color.Yellow;
            this.DatabasePenjualanPage.Location = new System.Drawing.Point(4, 38);
            this.DatabasePenjualanPage.Name = "DatabasePenjualanPage";
            this.DatabasePenjualanPage.Size = new System.Drawing.Size(592, 278);
            this.DatabasePenjualanPage.TabIndex = 0;
            this.DatabasePenjualanPage.Text = "  Penjualan  ";
            // 
            // DatabaseDetailPembelianPage
            // 
            this.DatabaseDetailPembelianPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabaseDetailPembelianPage.ForeColor = System.Drawing.Color.Yellow;
            this.DatabaseDetailPembelianPage.Location = new System.Drawing.Point(4, 38);
            this.DatabaseDetailPembelianPage.Name = "DatabaseDetailPembelianPage";
            this.DatabaseDetailPembelianPage.Size = new System.Drawing.Size(592, 278);
            this.DatabaseDetailPembelianPage.TabIndex = 2;
            this.DatabaseDetailPembelianPage.Text = "Detail Pembelian";
            // 
            // DatabaseDetailPenjualanPage
            // 
            this.DatabaseDetailPenjualanPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabaseDetailPenjualanPage.ForeColor = System.Drawing.Color.Yellow;
            this.DatabaseDetailPenjualanPage.Location = new System.Drawing.Point(4, 38);
            this.DatabaseDetailPenjualanPage.Name = "DatabaseDetailPenjualanPage";
            this.DatabaseDetailPenjualanPage.Size = new System.Drawing.Size(592, 278);
            this.DatabaseDetailPenjualanPage.TabIndex = 3;
            this.DatabaseDetailPenjualanPage.Text = "Detail Penjualan";
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.TransactionListTabControl);
            this.Controls.Add(this.Back);
            this.Name = "TransactionList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Transaction List";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TransactionList_Load);
            this.TransactionListTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroTabControl TransactionListTabControl;
        private System.Windows.Forms.TabPage DatabasePembelianPage;
        private System.Windows.Forms.TabPage DatabasePenjualanPage;
        private System.Windows.Forms.TabPage DatabaseDetailPembelianPage;
        private System.Windows.Forms.TabPage DatabaseDetailPenjualanPage;
    }
}