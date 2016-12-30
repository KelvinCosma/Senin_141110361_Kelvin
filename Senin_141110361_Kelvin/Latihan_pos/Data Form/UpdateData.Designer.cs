namespace Latihan_pos
{
    partial class UpdateData
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
            this.UpdateTabControl = new MetroFramework.Controls.MetroTabControl();
            this.UpdateBarangPage = new System.Windows.Forms.TabPage();
            this.UpdateCustomerPage = new System.Windows.Forms.TabPage();
            this.UpdateSupplierPage = new System.Windows.Forms.TabPage();
            this.UpdateTabControl.SuspendLayout();
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
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UpdateTabControl
            // 
            this.UpdateTabControl.Controls.Add(this.UpdateBarangPage);
            this.UpdateTabControl.Controls.Add(this.UpdateCustomerPage);
            this.UpdateTabControl.Controls.Add(this.UpdateSupplierPage);
            this.UpdateTabControl.Location = new System.Drawing.Point(20, 80);
            this.UpdateTabControl.Multiline = true;
            this.UpdateTabControl.Name = "UpdateTabControl";
            this.UpdateTabControl.SelectedIndex = 0;
            this.UpdateTabControl.Size = new System.Drawing.Size(320, 320);
            this.UpdateTabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.UpdateTabControl.TabIndex = 0;
            this.UpdateTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateTabControl.UseSelectable = true;
            // 
            // UpdateBarangPage
            // 
            this.UpdateBarangPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.UpdateBarangPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.UpdateBarangPage.Location = new System.Drawing.Point(4, 38);
            this.UpdateBarangPage.Name = "UpdateBarangPage";
            this.UpdateBarangPage.Size = new System.Drawing.Size(312, 278);
            this.UpdateBarangPage.TabIndex = 1;
            this.UpdateBarangPage.Text = "  Barang  ";
            // 
            // UpdateCustomerPage
            // 
            this.UpdateCustomerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.UpdateCustomerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.UpdateCustomerPage.Location = new System.Drawing.Point(4, 38);
            this.UpdateCustomerPage.Name = "UpdateCustomerPage";
            this.UpdateCustomerPage.Size = new System.Drawing.Size(312, 278);
            this.UpdateCustomerPage.TabIndex = 0;
            this.UpdateCustomerPage.Text = "  Customer  ";
            // 
            // UpdateSupplierPage
            // 
            this.UpdateSupplierPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.UpdateSupplierPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.UpdateSupplierPage.Location = new System.Drawing.Point(4, 38);
            this.UpdateSupplierPage.Name = "UpdateSupplierPage";
            this.UpdateSupplierPage.Size = new System.Drawing.Size(312, 278);
            this.UpdateSupplierPage.TabIndex = 2;
            this.UpdateSupplierPage.Text = "  Supplier  ";
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.UpdateTabControl);
            this.Controls.Add(this.Back);
            this.Name = "UpdateData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Update";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UpdateData_Load);
            this.UpdateTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroTabControl UpdateTabControl;
        private System.Windows.Forms.TabPage UpdateCustomerPage;
        private System.Windows.Forms.TabPage UpdateBarangPage;
        private System.Windows.Forms.TabPage UpdateSupplierPage;
    }
}