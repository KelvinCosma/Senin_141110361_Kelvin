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
        private DataTable dtBarang;
        private DataTable dtCustomer;
        private DataTable dtSupplier;

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
            TextFilterBarang.Tag = "Filter Barang";

            DataGridView dgvDatabaseBarang = new DataGridView();
            dgvDatabaseBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseBarang.Location = new Point(32, 64);
            dgvDatabaseBarang.Size = new Size(DataListTabControl.Size.Width - 64, 432);
            dgvDatabaseBarang.Tag = "Database Barang";

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
            TextFilterCustomer.Tag = "Filter Customer";

            DataGridView dgvDatabaseCustomer = new DataGridView();
            dgvDatabaseCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseCustomer.Location = new Point(32, 64);
            dgvDatabaseCustomer.Size = new Size(DataListTabControl.Size.Width - 64, 432);
            dgvDatabaseCustomer.Tag = "Database Customer";

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
            TextFilterSupplier.Tag = "Filter Supplier";

            DataGridView dgvDatabaseSupplier = new DataGridView();
            dgvDatabaseSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseSupplier.Location = new Point(32, 64);
            dgvDatabaseSupplier.Size = new Size(DataListTabControl.Size.Width - 64, 432);
            dgvDatabaseSupplier.Tag = "Database Supplier";

            DatabaseSupplierPage.Controls.Add(FilterSupplier);
            DatabaseSupplierPage.Controls.Add(TextFilterSupplier);
            DatabaseSupplierPage.Controls.Add(dgvDatabaseSupplier);

            dgvDatabaseBarang.DataSource = Class.Barang.SelectAll();
            dgvDatabaseBarang.Refresh();
            dgvDatabaseCustomer.DataSource = Class.Customer.SelectAll();
            dgvDatabaseCustomer.Refresh();
            dgvDatabaseSupplier.DataSource = Class.Supplier.SelectAll();
            dgvDatabaseSupplier.Refresh();

            dtBarang = (DataTable)dgvDatabaseBarang.DataSource;
            dtCustomer = (DataTable)dgvDatabaseCustomer.DataSource;
            dtSupplier = (DataTable)dgvDatabaseSupplier.DataSource;
        }

        private void TextFilterBarang_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterBarang = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabaseBarangPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Barang") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
            foreach (Control item in DatabaseBarangPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Filter Barang") { textFilterBarang = item.Text; }
                }
            }
            foreach (DataColumn dc in dtBarang.Columns) {
                if (i > 0) { filter += " or "; }
                filter += dc.ColumnName + " like '%" + textFilterBarang + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabaseBarangPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Barang") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
        }

        private void TextFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterCustomer = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabaseCustomerPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Customer") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
            foreach (Control item in DatabaseCustomerPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Filter Customer") { textFilterCustomer = item.Text; }
                }
            }
            foreach (DataColumn dc in dtCustomer.Columns) {
                if (i > 0) { filter += " or "; }
                filter += dc.ColumnName + " like '%" + textFilterCustomer + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabaseCustomerPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Customer") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
        }

        private void TextFilterSupplier_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterSupplier = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabaseSupplierPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Supplier") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
            foreach (Control item in DatabaseSupplierPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Filter Supplier") { textFilterSupplier = item.Text; }
                }
            }
            foreach (DataColumn dc in dtSupplier.Columns) {
                if (i > 0) { filter += " or "; }
                filter += dc.ColumnName + " like '%" + textFilterSupplier + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabaseSupplierPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Database Supplier") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
