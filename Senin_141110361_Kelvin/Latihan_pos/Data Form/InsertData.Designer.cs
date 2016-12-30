namespace Latihan_pos
{
    partial class InsertData
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
            this.InsertTabControl = new MetroFramework.Controls.MetroTabControl();
            this.InsertBarangPage = new System.Windows.Forms.TabPage();
            this.InsertCustomerPage = new System.Windows.Forms.TabPage();
            this.InsertSupplierPage = new System.Windows.Forms.TabPage();
            this.InsertTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(64)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(32)))));
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
            // InsertTabControl
            // 
            this.InsertTabControl.Controls.Add(this.InsertBarangPage);
            this.InsertTabControl.Controls.Add(this.InsertCustomerPage);
            this.InsertTabControl.Controls.Add(this.InsertSupplierPage);
            this.InsertTabControl.Location = new System.Drawing.Point(20, 80);
            this.InsertTabControl.Multiline = true;
            this.InsertTabControl.Name = "InsertTabControl";
            this.InsertTabControl.SelectedIndex = 0;
            this.InsertTabControl.Size = new System.Drawing.Size(320, 320);
            this.InsertTabControl.Style = MetroFramework.MetroColorStyle.Green;
            this.InsertTabControl.TabIndex = 0;
            this.InsertTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InsertTabControl.UseSelectable = true;
            // 
            // InsertBarangPage
            // 
            this.InsertBarangPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.InsertBarangPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.InsertBarangPage.Location = new System.Drawing.Point(4, 38);
            this.InsertBarangPage.Name = "InsertBarangPage";
            this.InsertBarangPage.Size = new System.Drawing.Size(312, 278);
            this.InsertBarangPage.TabIndex = 0;
            this.InsertBarangPage.Text = "  Barang  ";
            // 
            // InsertCustomerPage
            // 
            this.InsertCustomerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.InsertCustomerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.InsertCustomerPage.Location = new System.Drawing.Point(4, 38);
            this.InsertCustomerPage.Name = "InsertCustomerPage";
            this.InsertCustomerPage.Size = new System.Drawing.Size(312, 278);
            this.InsertCustomerPage.TabIndex = 1;
            this.InsertCustomerPage.Text = "  Customer  ";
            // 
            // InsertSupplierPage
            // 
            this.InsertSupplierPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.InsertSupplierPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(64)))));
            this.InsertSupplierPage.Location = new System.Drawing.Point(4, 38);
            this.InsertSupplierPage.Name = "InsertSupplierPage";
            this.InsertSupplierPage.Size = new System.Drawing.Size(312, 278);
            this.InsertSupplierPage.TabIndex = 2;
            this.InsertSupplierPage.Text = "  Supplier  ";
            // 
            // InsertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.InsertTabControl);
            this.Controls.Add(this.Back);
            this.Name = "InsertData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Insert";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.InsertData_Load);
            this.InsertTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroTabControl InsertTabControl;
        private System.Windows.Forms.TabPage InsertBarangPage;
        private System.Windows.Forms.TabPage InsertCustomerPage;
        private System.Windows.Forms.TabPage InsertSupplierPage;
    }
}