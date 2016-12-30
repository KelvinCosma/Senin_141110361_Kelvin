namespace Latihan_pos
{
    partial class DeleteData
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
            this.DeleteTabControl = new MetroFramework.Controls.MetroTabControl();
            this.DeleteBarangPage = new System.Windows.Forms.TabPage();
            this.DeleteCustomerPage = new System.Windows.Forms.TabPage();
            this.DeleteSupplierPage = new System.Windows.Forms.TabPage();
            this.Back = new System.Windows.Forms.Button();
            this.DeleteTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteTabControl
            // 
            this.DeleteTabControl.Controls.Add(this.DeleteBarangPage);
            this.DeleteTabControl.Controls.Add(this.DeleteCustomerPage);
            this.DeleteTabControl.Controls.Add(this.DeleteSupplierPage);
            this.DeleteTabControl.Location = new System.Drawing.Point(20, 80);
            this.DeleteTabControl.Multiline = true;
            this.DeleteTabControl.Name = "DeleteTabControl";
            this.DeleteTabControl.SelectedIndex = 2;
            this.DeleteTabControl.Size = new System.Drawing.Size(320, 320);
            this.DeleteTabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.DeleteTabControl.TabIndex = 0;
            this.DeleteTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteTabControl.UseSelectable = true;
            // 
            // DeleteBarangPage
            // 
            this.DeleteBarangPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DeleteBarangPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DeleteBarangPage.Location = new System.Drawing.Point(4, 38);
            this.DeleteBarangPage.Name = "DeleteBarangPage";
            this.DeleteBarangPage.Size = new System.Drawing.Size(312, 278);
            this.DeleteBarangPage.TabIndex = 0;
            this.DeleteBarangPage.Text = "  Barang  ";
            // 
            // DeleteCustomerPage
            // 
            this.DeleteCustomerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DeleteCustomerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DeleteCustomerPage.Location = new System.Drawing.Point(4, 38);
            this.DeleteCustomerPage.Name = "DeleteCustomerPage";
            this.DeleteCustomerPage.Size = new System.Drawing.Size(312, 278);
            this.DeleteCustomerPage.TabIndex = 1;
            this.DeleteCustomerPage.Text = "  Customer  ";
            // 
            // DeleteSupplierPage
            // 
            this.DeleteSupplierPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DeleteSupplierPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.DeleteSupplierPage.Location = new System.Drawing.Point(4, 38);
            this.DeleteSupplierPage.Name = "DeleteSupplierPage";
            this.DeleteSupplierPage.Size = new System.Drawing.Size(312, 278);
            this.DeleteSupplierPage.TabIndex = 2;
            this.DeleteSupplierPage.Text = "  Supplier  ";
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
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteTabControl);
            this.Name = "DeleteData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Delete";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DeleteData_Load);
            this.DeleteTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl DeleteTabControl;
        private System.Windows.Forms.TabPage DeleteBarangPage;
        private System.Windows.Forms.TabPage DeleteCustomerPage;
        private System.Windows.Forms.TabPage DeleteSupplierPage;
        private System.Windows.Forms.Button Back;
    }
}