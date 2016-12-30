namespace Latihan_pos
{
    partial class DataList
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
            this.DataListTabControl = new MetroFramework.Controls.MetroTabControl();
            this.DatabaseBarangPage = new System.Windows.Forms.TabPage();
            this.DatabaseCustomerPage = new System.Windows.Forms.TabPage();
            this.DatabaseSupplierPage = new System.Windows.Forms.TabPage();
            this.DataListTabControl.SuspendLayout();
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
            // DataListTabControl
            // 
            this.DataListTabControl.Controls.Add(this.DatabaseBarangPage);
            this.DataListTabControl.Controls.Add(this.DatabaseCustomerPage);
            this.DataListTabControl.Controls.Add(this.DatabaseSupplierPage);
            this.DataListTabControl.Location = new System.Drawing.Point(20, 80);
            this.DataListTabControl.Multiline = true;
            this.DataListTabControl.Name = "DataListTabControl";
            this.DataListTabControl.SelectedIndex = 2;
            this.DataListTabControl.Size = new System.Drawing.Size(320, 320);
            this.DataListTabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.DataListTabControl.TabIndex = 0;
            this.DataListTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DataListTabControl.UseSelectable = true;
            // 
            // DatabaseBarangPage
            // 
            this.DatabaseBarangPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabaseBarangPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DatabaseBarangPage.Location = new System.Drawing.Point(4, 38);
            this.DatabaseBarangPage.Name = "DatabaseBarangPage";
            this.DatabaseBarangPage.Size = new System.Drawing.Size(312, 278);
            this.DatabaseBarangPage.TabIndex = 0;
            this.DatabaseBarangPage.Text = "  Barang  ";
            // 
            // DatabaseCustomerPage
            // 
            this.DatabaseCustomerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabaseCustomerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DatabaseCustomerPage.Location = new System.Drawing.Point(4, 38);
            this.DatabaseCustomerPage.Name = "DatabaseCustomerPage";
            this.DatabaseCustomerPage.Size = new System.Drawing.Size(312, 278);
            this.DatabaseCustomerPage.TabIndex = 1;
            this.DatabaseCustomerPage.Text = "  Customer  ";
            // 
            // DatabaseSupplierPage
            // 
            this.DatabaseSupplierPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DatabaseSupplierPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DatabaseSupplierPage.Location = new System.Drawing.Point(4, 38);
            this.DatabaseSupplierPage.Name = "DatabaseSupplierPage";
            this.DatabaseSupplierPage.Size = new System.Drawing.Size(312, 278);
            this.DatabaseSupplierPage.TabIndex = 2;
            this.DatabaseSupplierPage.Text = "  Supplier  ";
            // 
            // DataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.DataListTabControl);
            this.Controls.Add(this.Back);
            this.Name = "DataList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Data List";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DataList_Load);
            this.DataListTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroTabControl DataListTabControl;
        private System.Windows.Forms.TabPage DatabaseBarangPage;
        private System.Windows.Forms.TabPage DatabaseCustomerPage;
        private System.Windows.Forms.TabPage DatabaseSupplierPage;
    }
}