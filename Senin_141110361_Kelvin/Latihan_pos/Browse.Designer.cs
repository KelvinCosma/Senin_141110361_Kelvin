namespace Latihan_pos
{
    partial class Browse
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
            this.Filter = new MetroFramework.Controls.MetroLabel();
            this.TextFilter = new MetroFramework.Controls.MetroTextBox();
            this.dgvDatabaseBrowse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
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
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.Location = new System.Drawing.Point(32, 80);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(38, 19);
            this.Filter.TabIndex = 13;
            this.Filter.Text = "Filter";
            this.Filter.UseCustomBackColor = true;
            this.Filter.UseCustomForeColor = true;
            // 
            // TextFilter
            // 
            // 
            // 
            // 
            this.TextFilter.CustomButton.Image = null;
            this.TextFilter.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.TextFilter.CustomButton.Name = "";
            this.TextFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextFilter.CustomButton.TabIndex = 1;
            this.TextFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextFilter.CustomButton.UseSelectable = true;
            this.TextFilter.CustomButton.Visible = false;
            this.TextFilter.Lines = new string[0];
            this.TextFilter.Location = new System.Drawing.Point(144, 80);
            this.TextFilter.MaxLength = 32767;
            this.TextFilter.Name = "TextFilter";
            this.TextFilter.PasswordChar = '\0';
            this.TextFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextFilter.SelectedText = "";
            this.TextFilter.SelectionLength = 0;
            this.TextFilter.SelectionStart = 0;
            this.TextFilter.ShortcutsEnabled = true;
            this.TextFilter.Size = new System.Drawing.Size(188, 23);
            this.TextFilter.TabIndex = 14;
            this.TextFilter.UseCustomBackColor = true;
            this.TextFilter.UseCustomForeColor = true;
            this.TextFilter.UseSelectable = true;
            this.TextFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextFilter.TextChanged += new System.EventHandler(this.TextFilter_TextChanged);
            // 
            // dgvDatabaseBrowse
            // 
            this.dgvDatabaseBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseBrowse.Location = new System.Drawing.Point(32, 128);
            this.dgvDatabaseBrowse.Name = "dgvDatabaseBrowse";
            this.dgvDatabaseBrowse.Size = new System.Drawing.Size(300, 272);
            this.dgvDatabaseBrowse.TabIndex = 15;
            this.dgvDatabaseBrowse.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabaseBrowse_Click);
            this.dgvDatabaseBrowse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabaseBrowse_Click);
            // 
            // Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.dgvDatabaseBrowse);
            this.Controls.Add(this.TextFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Back);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Name = "Browse";
            this.Text = "Browse";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Browse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private MetroFramework.Controls.MetroLabel Filter;
        private MetroFramework.Controls.MetroTextBox TextFilter;
        private System.Windows.Forms.DataGridView dgvDatabaseBrowse;
    }
}