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
    public partial class DeleteData : MetroFramework.Forms.MetroForm
    {
        public DeleteData()
        {
            InitializeComponent();
        }

        private void DeleteData_Load(object sender, EventArgs e)
        {
            DeleteTabControl.SelectedTab = DeleteBarangPage;

            #region DeleteBarang
            MetroLabel LBarang0 = new MetroLabel();
            LBarang0.Font = new Font("Segoe UI", 12F);
            LBarang0.Text = "ID";
            LBarang0.Location = new Point(32, 16);
            LBarang0.UseCustomBackColor = LBarang0.UseCustomForeColor = true;

            MetroLabel LBarang1 = new MetroLabel();
            LBarang1.Font = new Font("Segoe UI", 12F);
            LBarang1.Text = "Kode";
            LBarang1.Location = new Point(32, 48);
            LBarang1.UseCustomBackColor = LBarang1.UseCustomForeColor = true;

            MetroLabel LBarang2 = new MetroLabel();
            LBarang2.Font = new Font("Segoe UI", 12F);
            LBarang2.Text = "Nama";
            LBarang2.Location = new Point(32, 80);
            LBarang2.UseCustomBackColor = LBarang2.UseCustomForeColor = true;

            MetroLabel LBarang3 = new MetroLabel();
            LBarang3.Font = new Font("Segoe UI", 12F);
            LBarang3.Text = "Jumlah Awal";
            LBarang3.Location = new Point(32, 112);
            LBarang3.UseCustomBackColor = LBarang3.UseCustomForeColor = true;

            MetroLabel LBarang4 = new MetroLabel();
            LBarang4.Font = new Font("Segoe UI", 12F);
            LBarang4.Text = "Harga Hpp";
            LBarang4.Location = new Point(32, 144);
            LBarang4.UseCustomBackColor = LBarang4.UseCustomForeColor = true;

            MetroLabel LBarang5 = new MetroLabel();
            LBarang5.Font = new Font("Segoe UI", 12F);
            LBarang5.Text = "Harga Jual";
            LBarang5.Location = new Point(32, 176);
            LBarang5.UseCustomBackColor = LBarang5.UseCustomForeColor = true;

            MetroTextBox TBarang0 = new MetroTextBox();
            TBarang0.Font = new Font("Segoe UI", 8F);
            TBarang0.Location = new Point(144, 16);
            TBarang0.Size = new Size(144, 24);
            TBarang0.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang0.BackColor = Color.FromArgb(64, 64, 64);
            TBarang0.UseCustomBackColor = TBarang0.UseCustomForeColor = true;
            TBarang0.ReadOnly = true; TBarang0.Enabled = false;
            TBarang0.Tag = "TBarang0";

            MetroTextBox TBarang1 = new MetroTextBox();
            TBarang1.Font = new Font("Segoe UI", 8F);
            TBarang1.Location = new Point(144, 48);
            TBarang1.Size = new Size(144, 24);
            TBarang1.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang1.UseCustomBackColor = TBarang1.UseCustomForeColor = true;
            TBarang1.Tag = "TBarang1";

            MetroTextBox TBarang2 = new MetroTextBox();
            TBarang2.Font = new Font("Segoe UI", 8F);
            TBarang2.Location = new Point(144, 80);
            TBarang2.Size = new Size(144, 24);
            TBarang2.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang2.UseCustomBackColor = TBarang2.UseCustomForeColor = true;
            TBarang2.Tag = "TBarang2";

            MetroTextBox TBarang3 = new MetroTextBox();
            TBarang3.Font = new Font("Segoe UI", 8F);
            TBarang3.Location = new Point(144, 112);
            TBarang3.Size = new Size(144, 24);
            TBarang3.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang3.UseCustomBackColor = TBarang3.UseCustomForeColor = true;
            TBarang3.Tag = "TBarang3";

            MetroTextBox TBarang4 = new MetroTextBox();
            TBarang4.Font = new Font("Segoe UI", 8F);
            TBarang4.Location = new Point(144, 144);
            TBarang4.Size = new Size(144, 24);
            TBarang4.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang4.UseCustomBackColor = TBarang4.UseCustomForeColor = true;
            TBarang4.Tag = "TBarang4";

            MetroTextBox TBarang5 = new MetroTextBox();
            TBarang5.Font = new Font("Segoe UI", 8F);
            TBarang5.Location = new Point(144, 176);
            TBarang5.Size = new Size(144, 24);
            TBarang5.ForeColor = Color.FromArgb(32, 160, 64);
            TBarang5.UseCustomBackColor = TBarang5.UseCustomForeColor = true;
            TBarang5.Tag = "TBarang5";

            Button SearchIDBarang = new Button();
            SearchIDBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            SearchIDBarang.Text = "Browse ID";
            SearchIDBarang.Location = new Point(32, 224);
            SearchIDBarang.Size = new Size(96, 32);
            SearchIDBarang.BackColor = Color.FromArgb(16, 96, 112);
            SearchIDBarang.ForeColor = Color.FromArgb(16, 16, 16);
            SearchIDBarang.FlatStyle = FlatStyle.Flat;
            SearchIDBarang.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            SearchIDBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            SearchIDBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            SearchIDBarang.Click += new EventHandler(SearchIDBarang_Click);

            Button DeleteBarang = new Button();
            DeleteBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            DeleteBarang.Text = "Delete";
            DeleteBarang.Location = new Point(192, 224);
            DeleteBarang.Size = new Size(96, 32);
            DeleteBarang.BackColor = Color.FromArgb(16, 80, 32);
            DeleteBarang.ForeColor = Color.FromArgb(16, 16, 16);
            DeleteBarang.FlatStyle = FlatStyle.Flat;
            DeleteBarang.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            DeleteBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            DeleteBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            DeleteBarang.Click += new EventHandler(DeleteBarang_Click);

            DeleteBarangPage.Controls.Add(LBarang0);
            DeleteBarangPage.Controls.Add(LBarang1);
            DeleteBarangPage.Controls.Add(LBarang2);
            DeleteBarangPage.Controls.Add(LBarang3);
            DeleteBarangPage.Controls.Add(LBarang4);
            DeleteBarangPage.Controls.Add(LBarang5);

            DeleteBarangPage.Controls.Add(TBarang0);
            DeleteBarangPage.Controls.Add(TBarang1);
            DeleteBarangPage.Controls.Add(TBarang2);
            DeleteBarangPage.Controls.Add(TBarang3);
            DeleteBarangPage.Controls.Add(TBarang4);
            DeleteBarangPage.Controls.Add(TBarang5);

            DeleteBarangPage.Controls.Add(SearchIDBarang);
            DeleteBarangPage.Controls.Add(DeleteBarang);
            #endregion

            #region DeleteCustomer
            MetroLabel LCustomer0 = new MetroLabel();
            LCustomer0.Font = new Font("Segoe UI", 12F);
            LCustomer0.Text = "ID";
            LCustomer0.Location = new Point(32, 16);
            LCustomer0.UseCustomBackColor = LCustomer0.UseCustomForeColor = true;

            MetroLabel LCustomer1 = new MetroLabel();
            LCustomer1.Font = new Font("Segoe UI", 12F);
            LCustomer1.Text = "Kode";
            LCustomer1.Location = new Point(32, 48);
            LCustomer1.UseCustomBackColor = LCustomer1.UseCustomForeColor = true;

            MetroLabel LCustomer2 = new MetroLabel();
            LCustomer2.Font = new Font("Segoe UI", 12F);
            LCustomer2.Text = "Nama";
            LCustomer2.Location = new Point(32, 80);
            LCustomer2.UseCustomBackColor = LCustomer2.UseCustomForeColor = true;

            MetroLabel LCustomer3 = new MetroLabel();
            LCustomer3.Font = new Font("Segoe UI", 12F);
            LCustomer3.Text = "Jumlah Awal";
            LCustomer3.Location = new Point(32, 112);
            LCustomer3.UseCustomBackColor = LCustomer3.UseCustomForeColor = true;

            MetroLabel LCustomer4 = new MetroLabel();
            LCustomer4.Font = new Font("Segoe UI", 12F);
            LCustomer4.Text = "Harga Hpp";
            LCustomer4.Location = new Point(32, 144);
            LCustomer4.UseCustomBackColor = LCustomer4.UseCustomForeColor = true;

            MetroLabel LCustomer5 = new MetroLabel();
            LCustomer5.Font = new Font("Segoe UI", 12F);
            LCustomer5.Text = "Harga Jual";
            LCustomer5.Location = new Point(32, 176);
            LCustomer5.UseCustomBackColor = LCustomer5.UseCustomForeColor = true;

            MetroTextBox TCustomer0 = new MetroTextBox();
            TCustomer0.Font = new Font("Segoe UI", 8F);
            TCustomer0.Location = new Point(144, 16);
            TCustomer0.Size = new Size(144, 24);
            TCustomer0.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer0.BackColor = Color.FromArgb(64, 64, 64);
            TCustomer0.UseCustomBackColor = TCustomer0.UseCustomForeColor = true;
            TCustomer0.ReadOnly = true; TCustomer0.Enabled = false;
            TCustomer0.Tag = "TCustomer0";

            MetroTextBox TCustomer1 = new MetroTextBox();
            TCustomer1.Font = new Font("Segoe UI", 8F);
            TCustomer1.Location = new Point(144, 48);
            TCustomer1.Size = new Size(144, 24);
            TCustomer1.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer1.UseCustomBackColor = TCustomer1.UseCustomForeColor = true;
            TCustomer1.Tag = "TCustomer1";

            MetroTextBox TCustomer2 = new MetroTextBox();
            TCustomer2.Font = new Font("Segoe UI", 8F);
            TCustomer2.Location = new Point(144, 80);
            TCustomer2.Size = new Size(144, 24);
            TCustomer2.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer2.UseCustomBackColor = TCustomer2.UseCustomForeColor = true;
            TCustomer2.Tag = "TCustomer2";

            MetroTextBox TCustomer3 = new MetroTextBox();
            TCustomer3.Font = new Font("Segoe UI", 8F);
            TCustomer3.Location = new Point(144, 112);
            TCustomer3.Size = new Size(144, 24);
            TCustomer3.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer3.UseCustomBackColor = TCustomer3.UseCustomForeColor = true;
            TCustomer3.Tag = "TCustomer3";

            MetroTextBox TCustomer4 = new MetroTextBox();
            TCustomer4.Font = new Font("Segoe UI", 8F);
            TCustomer4.Location = new Point(144, 144);
            TCustomer4.Size = new Size(144, 24);
            TCustomer4.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer4.UseCustomBackColor = TCustomer4.UseCustomForeColor = true;
            TCustomer4.Tag = "TCustomer4";

            MetroTextBox TCustomer5 = new MetroTextBox();
            TCustomer5.Font = new Font("Segoe UI", 8F);
            TCustomer5.Location = new Point(144, 176);
            TCustomer5.Size = new Size(144, 24);
            TCustomer5.ForeColor = Color.FromArgb(32, 160, 64);
            TCustomer5.UseCustomBackColor = TCustomer5.UseCustomForeColor = true;
            TCustomer5.Tag = "TCustomer5";

            Button SearchIDCustomer = new Button();
            SearchIDCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            SearchIDCustomer.Text = "Browse ID";
            SearchIDCustomer.Location = new Point(32, 224);
            SearchIDCustomer.Size = new Size(96, 32);
            SearchIDCustomer.BackColor = Color.FromArgb(16, 96, 112);
            SearchIDCustomer.ForeColor = Color.FromArgb(16, 16, 16);
            SearchIDCustomer.FlatStyle = FlatStyle.Flat;
            SearchIDCustomer.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            SearchIDCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            SearchIDCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            SearchIDCustomer.Click += new EventHandler(SearchIDCustomer_Click);

            Button DeleteCustomer = new Button();
            DeleteCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            DeleteCustomer.Text = "Delete";
            DeleteCustomer.Location = new Point(192, 224);
            DeleteCustomer.Size = new Size(96, 32);
            DeleteCustomer.BackColor = Color.FromArgb(16, 80, 32);
            DeleteCustomer.ForeColor = Color.FromArgb(16, 16, 16);
            DeleteCustomer.FlatStyle = FlatStyle.Flat;
            DeleteCustomer.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            DeleteCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            DeleteCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            DeleteCustomer.Click += new EventHandler(DeleteCustomer_Click);

            DeleteCustomerPage.Controls.Add(LCustomer0);
            DeleteCustomerPage.Controls.Add(LCustomer1);
            DeleteCustomerPage.Controls.Add(LCustomer2);
            DeleteCustomerPage.Controls.Add(LCustomer3);
            DeleteCustomerPage.Controls.Add(LCustomer4);
            DeleteCustomerPage.Controls.Add(LCustomer5);

            DeleteCustomerPage.Controls.Add(TCustomer0);
            DeleteCustomerPage.Controls.Add(TCustomer1);
            DeleteCustomerPage.Controls.Add(TCustomer2);
            DeleteCustomerPage.Controls.Add(TCustomer3);
            DeleteCustomerPage.Controls.Add(TCustomer4);
            DeleteCustomerPage.Controls.Add(TCustomer5);

            DeleteCustomerPage.Controls.Add(SearchIDCustomer);
            DeleteCustomerPage.Controls.Add(DeleteCustomer);
            #endregion

            #region DeleteSupplier
            MetroLabel LSupplier0 = new MetroLabel();
            LSupplier0.Font = new Font("Segoe UI", 12F);
            LSupplier0.Text = "ID";
            LSupplier0.Location = new Point(32, 16);
            LSupplier0.UseCustomBackColor = LSupplier0.UseCustomForeColor = true;

            MetroLabel LSupplier1 = new MetroLabel();
            LSupplier1.Font = new Font("Segoe UI", 12F);
            LSupplier1.Text = "Kode";
            LSupplier1.Location = new Point(32, 48);
            LSupplier1.UseCustomBackColor = LSupplier1.UseCustomForeColor = true;

            MetroLabel LSupplier2 = new MetroLabel();
            LSupplier2.Font = new Font("Segoe UI", 12F);
            LSupplier2.Text = "Nama";
            LSupplier2.Location = new Point(32, 80);
            LSupplier2.UseCustomBackColor = LSupplier2.UseCustomForeColor = true;

            MetroLabel LSupplier3 = new MetroLabel();
            LSupplier3.Font = new Font("Segoe UI", 12F);
            LSupplier3.Text = "Jumlah Awal";
            LSupplier3.Location = new Point(32, 112);
            LSupplier3.UseCustomBackColor = LSupplier3.UseCustomForeColor = true;

            MetroLabel LSupplier4 = new MetroLabel();
            LSupplier4.Font = new Font("Segoe UI", 12F);
            LSupplier4.Text = "Harga Hpp";
            LSupplier4.Location = new Point(32, 144);
            LSupplier4.UseCustomBackColor = LSupplier4.UseCustomForeColor = true;

            MetroLabel LSupplier5 = new MetroLabel();
            LSupplier5.Font = new Font("Segoe UI", 12F);
            LSupplier5.Text = "Harga Jual";
            LSupplier5.Location = new Point(32, 176);
            LSupplier5.UseCustomBackColor = LSupplier5.UseCustomForeColor = true;

            MetroTextBox TSupplier0 = new MetroTextBox();
            TSupplier0.Font = new Font("Segoe UI", 8F);
            TSupplier0.Location = new Point(144, 16);
            TSupplier0.Size = new Size(144, 24);
            TSupplier0.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier0.BackColor = Color.FromArgb(64, 64, 64);
            TSupplier0.UseCustomBackColor = TSupplier0.UseCustomForeColor = true;
            TSupplier0.ReadOnly = true; TSupplier0.Enabled = false;
            TSupplier0.Tag = "TSupplier0";

            MetroTextBox TSupplier1 = new MetroTextBox();
            TSupplier1.Font = new Font("Segoe UI", 8F);
            TSupplier1.Location = new Point(144, 48);
            TSupplier1.Size = new Size(144, 24);
            TSupplier1.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier1.UseCustomBackColor = TSupplier1.UseCustomForeColor = true;
            TSupplier1.Tag = "TSupplier1";

            MetroTextBox TSupplier2 = new MetroTextBox();
            TSupplier2.Font = new Font("Segoe UI", 8F);
            TSupplier2.Location = new Point(144, 80);
            TSupplier2.Size = new Size(144, 24);
            TSupplier2.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier2.UseCustomBackColor = TSupplier2.UseCustomForeColor = true;
            TSupplier2.Tag = "TSupplier2";

            MetroTextBox TSupplier3 = new MetroTextBox();
            TSupplier3.Font = new Font("Segoe UI", 8F);
            TSupplier3.Location = new Point(144, 112);
            TSupplier3.Size = new Size(144, 24);
            TSupplier3.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier3.UseCustomBackColor = TSupplier3.UseCustomForeColor = true;
            TSupplier3.Tag = "TSupplier3";

            MetroTextBox TSupplier4 = new MetroTextBox();
            TSupplier4.Font = new Font("Segoe UI", 8F);
            TSupplier4.Location = new Point(144, 144);
            TSupplier4.Size = new Size(144, 24);
            TSupplier4.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier4.UseCustomBackColor = TSupplier4.UseCustomForeColor = true;
            TSupplier4.Tag = "TSupplier4";

            MetroTextBox TSupplier5 = new MetroTextBox();
            TSupplier5.Font = new Font("Segoe UI", 8F);
            TSupplier5.Location = new Point(144, 176);
            TSupplier5.Size = new Size(144, 24);
            TSupplier5.ForeColor = Color.FromArgb(32, 160, 64);
            TSupplier5.UseCustomBackColor = TSupplier5.UseCustomForeColor = true;
            TSupplier5.Tag = "TSupplier5";

            Button SearchIDSupplier = new Button();
            SearchIDSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            SearchIDSupplier.Text = "Browse ID";
            SearchIDSupplier.Location = new Point(32, 224);
            SearchIDSupplier.Size = new Size(96, 32);
            SearchIDSupplier.BackColor = Color.FromArgb(16, 96, 112);
            SearchIDSupplier.ForeColor = Color.FromArgb(16, 16, 16);
            SearchIDSupplier.FlatStyle = FlatStyle.Flat;
            SearchIDSupplier.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            SearchIDSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            SearchIDSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            SearchIDSupplier.Click += new EventHandler(SearchIDSupplier_Click);

            Button DeleteSupplier = new Button();
            DeleteSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            DeleteSupplier.Text = "Delete";
            DeleteSupplier.Location = new Point(192, 224);
            DeleteSupplier.Size = new Size(96, 32);
            DeleteSupplier.BackColor = Color.FromArgb(16, 80, 32);
            DeleteSupplier.ForeColor = Color.FromArgb(16, 16, 16);
            DeleteSupplier.FlatStyle = FlatStyle.Flat;
            DeleteSupplier.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            DeleteSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            DeleteSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            DeleteSupplier.Click += new EventHandler(DeleteSupplier_Click);

            DeleteSupplierPage.Controls.Add(LSupplier0);
            DeleteSupplierPage.Controls.Add(LSupplier1);
            DeleteSupplierPage.Controls.Add(LSupplier2);
            DeleteSupplierPage.Controls.Add(LSupplier3);
            DeleteSupplierPage.Controls.Add(LSupplier4);
            DeleteSupplierPage.Controls.Add(LSupplier5);

            DeleteSupplierPage.Controls.Add(TSupplier0);
            DeleteSupplierPage.Controls.Add(TSupplier1);
            DeleteSupplierPage.Controls.Add(TSupplier2);
            DeleteSupplierPage.Controls.Add(TSupplier3);
            DeleteSupplierPage.Controls.Add(TSupplier4);
            DeleteSupplierPage.Controls.Add(TSupplier5);

            DeleteSupplierPage.Controls.Add(SearchIDSupplier);
            DeleteSupplierPage.Controls.Add(DeleteSupplier);
            #endregion
        }

        private void DeleteBarang_Click(object sender, EventArgs e)
        {
            Class.Barang newBarang = new Class.Barang();
            foreach (Control item in DeleteBarangPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TBarang0") { newBarang.ID(int.Parse(item.Text)); }
                    }
                }
            }
            try {
                newBarang.Delete();
                MessageBox.Show(String.Concat("Product has been deleted successfully."));
                foreach (Control item in DeleteBarangPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            Class.Customer newCustomer = new Class.Customer();
            foreach (Control item in DeleteCustomerPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TCustomer0") { newCustomer.ID(int.Parse(item.Text)); }
                    }
                }
            }
            try {
                newCustomer.Delete();
                MessageBox.Show(String.Concat("Customer has been deleted successfully."));
                foreach (Control item in DeleteCustomerPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            Class.Supplier newSupplier = new Class.Supplier();
            foreach (Control item in DeleteSupplierPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TSupplier0") { newSupplier.ID(int.Parse(item.Text)); }
                    }
                }
            }
            try {
                newSupplier.Delete();
                MessageBox.Show(String.Concat("Supplier has been deleted successfully."));
                foreach (Control item in DeleteSupplierPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void SearchIDBarang_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("barang");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();
            foreach (Control item in DeleteBarangPage.Controls)
            {
                if (item is MetroTextBox)
                {
                    if (datas.Count > 0)
                    {
                        if (item.Tag.ToString() == "TBarang0") { item.Text = datas["barang_id"]; }
                        if (item.Tag.ToString() == "TBarang1") { item.Text = datas["kode"]; }
                        if (item.Tag.ToString() == "TBarang2") { item.Text = datas["nama"]; }
                        if (item.Tag.ToString() == "TBarang3") { item.Text = datas["jumlah_awal"]; }
                        if (item.Tag.ToString() == "TBarang4") { item.Text = datas["harga_HPP"]; }
                        if (item.Tag.ToString() == "TBarang5") { item.Text = datas["harga_jual"]; }
                    }
                }
            }
        }

        private void SearchIDCustomer_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("customer");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();
            foreach (Control item in DeleteCustomerPage.Controls)
            {
                if (item is MetroTextBox)
                {
                    if (datas.Count > 0)
                    {
                        if (item.Tag.ToString() == "TCustomer0") { item.Text = datas["customer_id"]; }
                        if (item.Tag.ToString() == "TCustomer1") { item.Text = datas["nama"]; }
                        if (item.Tag.ToString() == "TCustomer2") { item.Text = datas["alamat"]; }
                        if (item.Tag.ToString() == "TCustomer3") { item.Text = datas["kode_pos"]; }
                        if (item.Tag.ToString() == "TCustomer4") { item.Text = datas["nomor_telepon"]; }
                        if (item.Tag.ToString() == "TCustomer5") { item.Text = datas["email"]; }
                    }
                }
            }
        }

        private void SearchIDSupplier_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("supplier");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();
            foreach (Control item in DeleteSupplierPage.Controls)
            {
                if (item is MetroTextBox)
                {
                    if (datas.Count > 0)
                    {
                        if (item.Tag.ToString() == "TSupplier0") { item.Text = datas["supplier_id"]; }
                        if (item.Tag.ToString() == "TSupplier1") { item.Text = datas["nama"]; }
                        if (item.Tag.ToString() == "TSupplier2") { item.Text = datas["alamat"]; }
                        if (item.Tag.ToString() == "TSupplier3") { item.Text = datas["kode_pos"]; }
                        if (item.Tag.ToString() == "TSupplier4") { item.Text = datas["nomor_telepon"]; }
                        if (item.Tag.ToString() == "TSupplier5") { item.Text = datas["email"]; }
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
