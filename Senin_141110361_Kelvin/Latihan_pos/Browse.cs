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
using MySql.Data.MySqlClient;

namespace Latihan_pos
{
    public partial class Browse : MetroFramework.Forms.MetroForm
    {
        private string tableName;
        private Dictionary<string, string> data;
        private DataTable dt;
        public Browse(string tableName) {
            InitializeComponent();
            this.tableName = tableName;
            if (tableName == "barang") { dgvDatabaseBrowse.DataSource = Class.Barang.SelectAll(); }
            else if (tableName == "customer") { dgvDatabaseBrowse.DataSource = Class.Customer.SelectAll(); }
            else if (tableName == "supplier") { dgvDatabaseBrowse.DataSource = Class.Supplier.SelectAll(); }
            else if (tableName == "purchase") { dgvDatabaseBrowse.DataSource = Class.Pembelian.SelectAll(); }
            else if (tableName == "sale") { dgvDatabaseBrowse.DataSource = Class.Penjualan.SelectAll(); }
            dgvDatabaseBrowse.Refresh();
            data = new Dictionary<string, string> { };
            dt = (DataTable)dgvDatabaseBrowse.DataSource;
        }

        public Dictionary<string, string> getData() { return this.data; }

        private void Browse_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);

            Back.Location = new Point(this.Size.Width / 2 - Back.Size.Width / 2, this.Size.Height - Back.Size.Height - 24);
            Filter.Font = new Font("Segoe UI", 12F);
            TextFilter.Size = new Size(this.Size.Width - 144 - 32, 24);
            dgvDatabaseBrowse.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvDatabaseBrowse.Size = new Size(this.Size.Width - 64, 520);

        }

        private void TextFilter_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string filter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatabaseBrowse.DataSource;
            foreach (DataColumn dc in dt.Columns) {
                if (i > 0) { filter += " or "; }
                filter += dc.ColumnName + " like '%" + TextFilter.Text + "%'";
                i++;
            }
            bs.Filter = filter;
            Console.WriteLine(bs.Filter);
            dgvDatabaseBrowse.DataSource = bs;
        }

        private void dgvDatabaseBrowse_Click(object sender, DataGridViewCellEventArgs e)
        {
            data = new Dictionary<string, string> { };
            foreach (DataGridViewColumn col in dgvDatabaseBrowse.Columns) {
                data.Add(col.Name, dgvDatabaseBrowse[col.Index, e.RowIndex].Value.ToString());
            }
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
