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
    public partial class TransactionList : MetroFramework.Forms.MetroForm
    {
        private DataTable dtPembelian;
        private DataTable dtDetailPembelian;
        private DataTable dtPenjualan;
        private DataTable dtDetailPenjualan;

        public TransactionList()
        {
            InitializeComponent();
        }

        private void TransactionList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);

            TransactionListTabControl.Location = new Point(26, 80);
            TransactionListTabControl.Size = new Size(this.Size.Width - 52, this.Size.Height - 80 - 80);
            TransactionListTabControl.SelectedTab = DatabasePembelianPage;

            Back.Location = new Point(this.Size.Width / 2 - Back.Size.Width / 2, this.Size.Height - Back.Size.Height - 24);

            MetroLabel FilterPembelian = new MetroLabel();
            FilterPembelian.Font = new Font("Segoe UI", 12F);
            FilterPembelian.Text = "Filter";
            FilterPembelian.Location = new Point(32, 16);
            FilterPembelian.UseCustomBackColor = FilterPembelian.UseCustomForeColor = true;

            MetroTextBox TextFilterPembelian = new MetroTextBox();
            TextFilterPembelian.Font = new Font("Segoe UI", 8F);
            TextFilterPembelian.Location = new Point(144, 16);
            TextFilterPembelian.Size = new Size(TransactionListTabControl.Size.Width - 144 - 32, 24);
            TextFilterPembelian.ForeColor = Color.FromArgb(255, 255, 0);
            TextFilterPembelian.UseCustomBackColor = TextFilterPembelian.UseCustomForeColor = true;
            TextFilterPembelian.TextChanged += new EventHandler(TextFilterPembelian_TextChanged);
            TextFilterPembelian.Tag = "Filter Pembelian";

            DataGridView dgvDatabasePembelian = new DataGridView();
            dgvDatabasePembelian.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabasePembelian.Location = new Point(32, 64);
            dgvDatabasePembelian.Size = new Size(TransactionListTabControl.Size.Width - 64, 432);
            dgvDatabasePembelian.Tag = "Pembelian";

            DatabasePembelianPage.Controls.Add(FilterPembelian);
            DatabasePembelianPage.Controls.Add(TextFilterPembelian);
            DatabasePembelianPage.Controls.Add(dgvDatabasePembelian);

            MetroLabel FilterDetailPembelian = new MetroLabel();
            FilterDetailPembelian.Font = new Font("Segoe UI", 12F);
            FilterDetailPembelian.Text = "Filter";
            FilterDetailPembelian.Location = new Point(32, 16);
            FilterDetailPembelian.UseCustomBackColor = FilterDetailPembelian.UseCustomForeColor = true;

            MetroTextBox TextFilterDetailPembelian = new MetroTextBox();
            TextFilterDetailPembelian.Font = new Font("Segoe UI", 8F);
            TextFilterDetailPembelian.Location = new Point(144, 16);
            TextFilterDetailPembelian.Size = new Size(TransactionListTabControl.Size.Width - 144 - 32, 24);
            TextFilterDetailPembelian.ForeColor = Color.FromArgb(255, 255, 0);
            TextFilterDetailPembelian.UseCustomBackColor = TextFilterDetailPembelian.UseCustomForeColor = true;
            TextFilterDetailPembelian.TextChanged += new EventHandler(TextFilterDetailPembelian_TextChanged);
            TextFilterDetailPembelian.Tag = "Filter Detail Pembelian";

            DataGridView dgvDatabaseDetailPembelian = new DataGridView();
            dgvDatabaseDetailPembelian.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseDetailPembelian.Location = new Point(32, 64);
            dgvDatabaseDetailPembelian.Size = new Size(TransactionListTabControl.Size.Width - 64, 432);
            dgvDatabaseDetailPembelian.Tag = "Detail Pembelian";

            DatabaseDetailPembelianPage.Controls.Add(FilterDetailPembelian);
            DatabaseDetailPembelianPage.Controls.Add(TextFilterDetailPembelian);
            DatabaseDetailPembelianPage.Controls.Add(dgvDatabaseDetailPembelian);

            MetroLabel FilterPenjualan = new MetroLabel();
            FilterPenjualan.Font = new Font("Segoe UI", 12F);
            FilterPenjualan.Text = "Filter";
            FilterPenjualan.Location = new Point(32, 16);
            FilterPenjualan.UseCustomBackColor = FilterPenjualan.UseCustomForeColor = true;

            MetroTextBox TextFilterPenjualan = new MetroTextBox();
            TextFilterPenjualan.Font = new Font("Segoe UI", 8F);
            TextFilterPenjualan.Location = new Point(144, 16);
            TextFilterPenjualan.Size = new Size(TransactionListTabControl.Size.Width - 144 - 32, 24);
            TextFilterPenjualan.ForeColor = Color.FromArgb(255, 255, 0);
            TextFilterPenjualan.UseCustomBackColor = TextFilterPenjualan.UseCustomForeColor = true;
            TextFilterPenjualan.TextChanged += new EventHandler(TextFilterPenjualan_TextChanged);
            TextFilterPenjualan.Tag = "Filter Penjualan";

            DataGridView dgvDatabasePenjualan = new DataGridView();
            dgvDatabasePenjualan.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabasePenjualan.Location = new Point(32, 64);
            dgvDatabasePenjualan.Size = new Size(TransactionListTabControl.Size.Width - 64, 432);
            dgvDatabasePenjualan.Tag = "Penjualan";

            DatabasePenjualanPage.Controls.Add(FilterPenjualan);
            DatabasePenjualanPage.Controls.Add(TextFilterPenjualan);
            DatabasePenjualanPage.Controls.Add(dgvDatabasePenjualan);

            MetroLabel FilterDetailPenjualan = new MetroLabel();
            FilterDetailPenjualan.Font = new Font("Segoe UI", 12F);
            FilterDetailPenjualan.Text = "Filter";
            FilterDetailPenjualan.Location = new Point(32, 16);
            FilterDetailPenjualan.UseCustomBackColor = FilterDetailPenjualan.UseCustomForeColor = true;

            MetroTextBox TextFilterDetailPenjualan = new MetroTextBox();
            TextFilterDetailPenjualan.Font = new Font("Segoe UI", 8F);
            TextFilterDetailPenjualan.Location = new Point(144, 16);
            TextFilterDetailPenjualan.Size = new Size(TransactionListTabControl.Size.Width - 144 - 32, 24);
            TextFilterDetailPenjualan.ForeColor = Color.FromArgb(255, 255, 0);
            TextFilterDetailPenjualan.UseCustomBackColor = TextFilterDetailPenjualan.UseCustomForeColor = true;
            TextFilterDetailPenjualan.TextChanged += new EventHandler(TextFilterDetailPenjualan_TextChanged);
            TextFilterDetailPenjualan.Tag = "Filter Detail Penjualan";

            DataGridView dgvDatabaseDetailPenjualan = new DataGridView();
            dgvDatabaseDetailPenjualan.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseDetailPenjualan.Location = new Point(32, 64);
            dgvDatabaseDetailPenjualan.Size = new Size(TransactionListTabControl.Size.Width - 64, 432);
            dgvDatabaseDetailPenjualan.Tag = "Detail Penjualan";

            DatabaseDetailPenjualanPage.Controls.Add(FilterDetailPenjualan);
            DatabaseDetailPenjualanPage.Controls.Add(TextFilterDetailPenjualan);
            DatabaseDetailPenjualanPage.Controls.Add(dgvDatabaseDetailPenjualan);

            dgvDatabasePembelian.DataSource = Class.Pembelian.SelectAll();
            dgvDatabasePembelian.Refresh();
            dgvDatabaseDetailPembelian.DataSource = Class.DetailPembelian.SelectAll();
            dgvDatabaseDetailPembelian.Refresh();
            dgvDatabasePenjualan.DataSource = Class.Penjualan.SelectAll();
            dgvDatabasePenjualan.Refresh();
            dgvDatabaseDetailPenjualan.DataSource = Class.DetailPenjualan.SelectAll();
            dgvDatabaseDetailPenjualan.Refresh();

            dtPembelian = (DataTable)dgvDatabasePembelian.DataSource;
            dtDetailPembelian = (DataTable)dgvDatabaseDetailPembelian.DataSource;
            dtPenjualan = (DataTable)dgvDatabasePenjualan.DataSource;
            dtDetailPenjualan = (DataTable)dgvDatabaseDetailPenjualan.DataSource;
        }

        private void TextFilterPembelian_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterPembelian = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabasePembelianPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Pembelian") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }

            foreach (Control item in DatabasePembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "Filter Pembelian") { textFilterPembelian = item.Text; }
                }
            }

            foreach (DataColumn dc in dtPembelian.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + textFilterPembelian + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabasePembelianPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Pembelian") { (item as DataGridView).DataSource = bs; }
                }
            }
        }

        private void TextFilterDetailPembelian_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterDetailPembelian = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabaseDetailPembelianPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Detail Pembelian") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }

            foreach (Control item in DatabaseDetailPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "Filter Detail Pembelian") { textFilterDetailPembelian = item.Text; }
                }
            }

            foreach (DataColumn dc in dtDetailPembelian.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + textFilterDetailPembelian + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabaseDetailPembelianPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Detail Pembelian") { (item as DataGridView).DataSource = bs; }
                }
            }
        }

        private void TextFilterPenjualan_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterPenjualan = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabasePenjualanPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Penjualan") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }

            foreach (Control item in DatabasePenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "Filter Penjualan") { textFilterPenjualan = item.Text; }
                }
            }

            foreach (DataColumn dc in dtPenjualan.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + textFilterPenjualan + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabasePenjualanPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Penjualan") { (item as DataGridView).DataSource = bs; }
                }
            }
        }

        private void TextFilterDetailPenjualan_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "", textFilterDetailPenjualan = "";
            BindingSource bs = new BindingSource();
            foreach (Control item in DatabaseDetailPenjualanPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Detail Penjualan") { bs.DataSource = (item as DataGridView).DataSource; }
                }
            }

            foreach (Control item in DatabaseDetailPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "Filter Detail Penjualan") { textFilterDetailPenjualan = item.Text; }
                }
            }

            foreach (DataColumn dc in dtDetailPenjualan.Columns)
            {
                if (i > 0)
                {
                    filter += " or ";
                }
                filter += dc.ColumnName + " like '%" + textFilterDetailPenjualan + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            foreach (Control item in DatabaseDetailPenjualanPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "Detail Penjualan") { (item as DataGridView).DataSource = bs; }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
