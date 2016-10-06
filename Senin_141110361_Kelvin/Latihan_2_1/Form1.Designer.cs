namespace Latihan_2_1
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
            this.Month = new System.Windows.Forms.DomainUpDown();
            this.Date = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Bold = new System.Windows.Forms.Button();
            this.De_Bold = new System.Windows.Forms.Button();
            this.Birth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            this.SuspendLayout();
            // 
            // Month
            // 
            this.Month.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Month.Location = new System.Drawing.Point(120, 20);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(120, 20);
            this.Month.TabIndex = 0;
            this.Month.Text = "Month";
            this.Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Month.SelectedItemChanged += new System.EventHandler(this.Month_SelectedItemChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(40, 20);
            this.Date.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Date.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(60, 20);
            this.Date.TabIndex = 1;
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(40, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 2;
            // 
            // Bold
            // 
            this.Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bold.Location = new System.Drawing.Point(270, 15);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(100, 30);
            this.Bold.TabIndex = 3;
            this.Bold.Text = "Bold";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // De_Bold
            // 
            this.De_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.De_Bold.Location = new System.Drawing.Point(400, 15);
            this.De_Bold.Name = "De_Bold";
            this.De_Bold.Size = new System.Drawing.Size(100, 30);
            this.De_Bold.TabIndex = 4;
            this.De_Bold.Text = "De-Bold";
            this.De_Bold.UseVisualStyleBackColor = true;
            this.De_Bold.Click += new System.EventHandler(this.De_Bold_Click);
            // 
            // Birth
            // 
            this.Birth.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Location = new System.Drawing.Point(40, 379);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(458, 24);
            this.Birth.TabIndex = 5;
            this.Birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.De_Bold);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Month);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown Month;
        private System.Windows.Forms.NumericUpDown Date;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Bold;
        private System.Windows.Forms.Button De_Bold;
        private System.Windows.Forms.Label Birth;
    }
}

