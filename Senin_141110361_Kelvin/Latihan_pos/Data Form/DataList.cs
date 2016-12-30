using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Latihan_pos
{
    public partial class DataList : MetroFramework.Forms.MetroForm
    {
        public DataList()
        {
            InitializeComponent();
        }

        private void DataList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);

            DataListTabControl.Location = new Point(26, 80);
            DataListTabControl.Size = new Size(this.Size.Width - 52, this.Size.Height - 80 - 80);
            DataListTabControl.SelectedTab = DatabaseBarangPage;

            Back.Location = new Point(this.Size.Width / 2 - Back.Size.Width / 2, this.Size.Height - Back.Size.Height - 24);

            MetroLabel FilterBarang = new MetroLabel();
            FilterBarang.Font = new Font("Segoe UI", 12F);
            FilterBarang.Text = "Filter";
            FilterBarang.Location = new Point(32, 16);
            FilterBarang.UseCustomBackColor = FilterBarang.UseCustomForeColor = true;

            MetroTextBox TextFilterBarang = new MetroTextBox();
            TextFilterBarang.Font = new Font("Segoe UI", 8F);
            TextFilterBarang.Location = new Point(144, 16);
            TextFilterBarang.Size = new Size(DataListTabControl.Size.Width - 144 - 32, 24);
            TextFilterBarang.ForeColor = Color.FromArgb(32, 160, 64);
            TextFilterBarang.UseCustomBackColor = TextFilterBarang.UseCustomForeColor = true;
            TextFilterBarang.TextChanged += new EventHandler(TextFilterBarang_TextChanged);

            DataGridView dgvDatabaseBarang = new DataGridView();
            dgvDatabaseBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseBarang.Location = new Point(32, 64);
            dgvDatabaseBarang.Size = new Size(DataListTabControl.Size.Width - 64, 432);

            DatabaseBarangPage.Controls.Add(FilterBarang);
            DatabaseBarangPage.Controls.Add(TextFilterBarang);
            DatabaseBarangPage.Controls.Add(dgvDatabaseBarang);

            MetroLabel FilterCustomer = new MetroLabel();
            FilterCustomer.Font = new Font("Segoe UI", 12F);
            FilterCustomer.Text = "Filter";
            FilterCustomer.Location = new Point(32, 16);
            FilterCustomer.UseCustomBackColor = FilterCustomer.UseCustomForeColor = true;

            MetroTextBox TextFilterCustomer = new MetroTextBox();
            TextFilterCustomer.Font = new Font("Segoe UI", 8F);
            TextFilterCustomer.Location = new Point(144, 16);
            TextFilterCustomer.Size = new Size(DataListTabControl.Size.Width - 144 - 32, 24);
            TextFilterCustomer.ForeColor = Color.FromArgb(32, 160, 64);
            TextFilterCustomer.UseCustomBackColor = TextFilterCustomer.UseCustomForeColor = true;
            TextFilterCustomer.TextChanged += new EventHandler(TextFilterCustomer_TextChanged);

            DataGridView dgvDatabaseCustomer = new DataGridView();
            dgvDatabaseCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseCustomer.Location = new Point(32, 64);
            dgvDatabaseCustomer.Size = new Size(DataListTabControl.Size.Width - 64, 432);

            DatabaseCustomerPage.Controls.Add(FilterCustomer);
            DatabaseCustomerPage.Controls.Add(TextFilterCustomer);
            DatabaseCustomerPage.Controls.Add(dgvDatabaseCustomer);

            MetroLabel FilterSupplier = new MetroLabel();
            FilterSupplier.Font = new Font("Segoe UI", 12F);
            FilterSupplier.Text = "Filter";
            FilterSupplier.Location = new Point(32, 16);
            FilterSupplier.UseCustomBackColor = FilterSupplier.UseCustomForeColor = true;

            MetroTextBox TextFilterSupplier = new MetroTextBox();
            TextFilterSupplier.Font = new Font("Segoe UI", 8F);
            TextFilterSupplier.Location = new Point(144, 16);
            TextFilterSupplier.Size = new Size(DataListTabControl.Size.Width - 144 - 32, 24);
            TextFilterSupplier.ForeColor = Color.FromArgb(32, 160, 64);
            TextFilterSupplier.UseCustomBackColor = TextFilterSupplier.UseCustomForeColor = true;
            TextFilterSupplier.TextChanged += new EventHandler(TextFilterSupplier_TextChanged);

            DataGridView dgvDatabaseSupplier = new DataGridView();
            dgvDatabaseSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseSupplier.Location = new Point(32, 64);
            dgvDatabaseSupplier.Size = new Size(DataListTabControl.Size.Width - 64, 432);

            DatabaseSupplierPage.Controls.Add(FilterSupplier);
            DatabaseSupplierPage.Controls.Add(TextFilterSupplier);
            DatabaseSupplierPage.Controls.Add(dgvDatabaseSupplier);
        }

        private void TextFilterBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextFilterCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextFilterSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
