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
    public partial class InsertData : MetroFramework.Forms.MetroForm
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void InsertData_Load(object sender, EventArgs e)
        {
            InsertTabControl.SelectedTab = InsertBarangPage;

            #region InsertBarang
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

            Button InsertBarang = new Button();
            InsertBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            InsertBarang.Text = "Insert";
            InsertBarang.Location = new Point(192, 224);
            InsertBarang.Size = new Size(96, 32);
            InsertBarang.BackColor = Color.FromArgb(16, 80, 32);
            InsertBarang.ForeColor = Color.FromArgb(16, 16, 16);
            InsertBarang.FlatStyle = FlatStyle.Flat;
            InsertBarang.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            InsertBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            InsertBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            InsertBarang.Click += new EventHandler(InsertBarang_Click);

            InsertBarangPage.Controls.Add(LBarang1);
            InsertBarangPage.Controls.Add(LBarang2);
            InsertBarangPage.Controls.Add(LBarang3);
            InsertBarangPage.Controls.Add(LBarang4);
            InsertBarangPage.Controls.Add(LBarang5);

            InsertBarangPage.Controls.Add(TBarang1);
            InsertBarangPage.Controls.Add(TBarang2);
            InsertBarangPage.Controls.Add(TBarang3);
            InsertBarangPage.Controls.Add(TBarang4);
            InsertBarangPage.Controls.Add(TBarang5);

            InsertBarangPage.Controls.Add(InsertBarang);
            #endregion

            #region InsertCustomer
            MetroLabel LCustomer1 = new MetroLabel();
            LCustomer1.Font = new Font("Segoe UI", 12F);
            LCustomer1.Text = "Nama";
            LCustomer1.Location = new Point(32, 48);
            LCustomer1.UseCustomBackColor = LCustomer1.UseCustomForeColor = true;

            MetroLabel LCustomer2 = new MetroLabel();
            LCustomer2.Font = new Font("Segoe UI", 12F);
            LCustomer2.Text = "Alamat";
            LCustomer2.Location = new Point(32, 80);
            LCustomer2.UseCustomBackColor = LCustomer2.UseCustomForeColor = true;

            MetroLabel LCustomer3 = new MetroLabel();
            LCustomer3.Font = new Font("Segoe UI", 12F);
            LCustomer3.Text = "Kode Pos";
            LCustomer3.Location = new Point(32, 112);
            LCustomer3.UseCustomBackColor = LCustomer3.UseCustomForeColor = true;

            MetroLabel LCustomer4 = new MetroLabel();
            LCustomer4.Font = new Font("Segoe UI", 12F);
            LCustomer4.Text = "No. Telepon";
            LCustomer4.Location = new Point(32, 144);
            LCustomer4.UseCustomBackColor = LCustomer4.UseCustomForeColor = true;

            MetroLabel LCustomer5 = new MetroLabel();
            LCustomer5.Font = new Font("Segoe UI", 12F);
            LCustomer5.Text = "Email";
            LCustomer5.Location = new Point(32, 176);
            LCustomer5.UseCustomBackColor = LCustomer5.UseCustomForeColor = true;

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

            Button InsertCustomer = new Button();
            InsertCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            InsertCustomer.Text = "Insert";
            InsertCustomer.Location = new Point(192, 224);
            InsertCustomer.Size = new Size(96, 32);
            InsertCustomer.BackColor = Color.FromArgb(16, 80, 32);
            InsertCustomer.ForeColor = Color.FromArgb(16, 16, 16);
            InsertCustomer.FlatStyle = FlatStyle.Flat;
            InsertCustomer.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            InsertCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            InsertCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            InsertCustomer.Click += new EventHandler(InsertCustomer_Click);

            InsertCustomerPage.Controls.Add(LCustomer1);
            InsertCustomerPage.Controls.Add(LCustomer2);
            InsertCustomerPage.Controls.Add(LCustomer3);
            InsertCustomerPage.Controls.Add(LCustomer4);
            InsertCustomerPage.Controls.Add(LCustomer5);

            InsertCustomerPage.Controls.Add(TCustomer1);
            InsertCustomerPage.Controls.Add(TCustomer2);
            InsertCustomerPage.Controls.Add(TCustomer3);
            InsertCustomerPage.Controls.Add(TCustomer4);
            InsertCustomerPage.Controls.Add(TCustomer5);

            InsertCustomerPage.Controls.Add(InsertCustomer);
            #endregion

            #region InsertSupplier   
            MetroLabel LSupplier1 = new MetroLabel();
            LSupplier1.Font = new Font("Segoe UI", 12F);
            LSupplier1.Text = "Nama";
            LSupplier1.Location = new Point(32, 48);
            LSupplier1.UseCustomBackColor = LSupplier1.UseCustomForeColor = true;

            MetroLabel LSupplier2 = new MetroLabel();
            LSupplier2.Font = new Font("Segoe UI", 12F);
            LSupplier2.Text = "Alamat";
            LSupplier2.Location = new Point(32, 80);
            LSupplier2.UseCustomBackColor = LSupplier2.UseCustomForeColor = true;

            MetroLabel LSupplier3 = new MetroLabel();
            LSupplier3.Font = new Font("Segoe UI", 12F);
            LSupplier3.Text = "Kode Pos";
            LSupplier3.Location = new Point(32, 112);
            LSupplier3.UseCustomBackColor = LSupplier3.UseCustomForeColor = true;

            MetroLabel LSupplier4 = new MetroLabel();
            LSupplier4.Font = new Font("Segoe UI", 12F);
            LSupplier4.Text = "No. Telepon";
            LSupplier4.Location = new Point(32, 144);
            LSupplier4.UseCustomBackColor = LSupplier4.UseCustomForeColor = true;

            MetroLabel LSupplier5 = new MetroLabel();
            LSupplier5.Font = new Font("Segoe UI", 12F);
            LSupplier5.Text = "Email";
            LSupplier5.Location = new Point(32, 176);
            LSupplier5.UseCustomBackColor = LSupplier5.UseCustomForeColor = true;

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

            Button InsertSupplier = new Button();
            InsertSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            InsertSupplier.Text = "Insert";
            InsertSupplier.Location = new Point(192, 224);
            InsertSupplier.Size = new Size(96, 32);
            InsertSupplier.BackColor = Color.FromArgb(16, 80, 32);
            InsertSupplier.ForeColor = Color.FromArgb(16, 16, 16);
            InsertSupplier.FlatStyle = FlatStyle.Flat;
            InsertSupplier.FlatAppearance.BorderColor = Color.FromArgb(32, 160, 64);
            InsertSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 224, 128);
            InsertSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 96);
            InsertSupplier.Click += new EventHandler(InsertSupplier_Click);

            InsertSupplierPage.Controls.Add(LSupplier1);
            InsertSupplierPage.Controls.Add(LSupplier2);
            InsertSupplierPage.Controls.Add(LSupplier3);
            InsertSupplierPage.Controls.Add(LSupplier4);
            InsertSupplierPage.Controls.Add(LSupplier5);

            InsertSupplierPage.Controls.Add(TSupplier1);
            InsertSupplierPage.Controls.Add(TSupplier2);
            InsertSupplierPage.Controls.Add(TSupplier3);
            InsertSupplierPage.Controls.Add(TSupplier4);
            InsertSupplierPage.Controls.Add(TSupplier5);

            InsertSupplierPage.Controls.Add(InsertSupplier);
            #endregion
        }

        private void InsertBarang_Click(object sender, EventArgs e)
        {
            Class.Barang newBarang = new Class.Barang();
            foreach (Control item in InsertBarangPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TBarang1") { newBarang.Kode(item.Text); }
                        else if (item.Tag.ToString() == "TBarang2") { newBarang.Nama(item.Text); }
                        else if (item.Tag.ToString() == "TBarang3") { newBarang.JumlahAwal(int.Parse(item.Text)); }
                        else if (item.Tag.ToString() == "TBarang4") { newBarang.HargaHPP(decimal.Parse(item.Text)); }
                        else if (item.Tag.ToString() == "TBarang5") { newBarang.HargaJual(decimal.Parse(item.Text)); }
                    }
                }
            }
            try {
                newBarang.Insert();
                MessageBox.Show(String.Concat("Product with code (", newBarang.getKode(), ") has been added successfully."));
                foreach (Control item in InsertBarangPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void InsertCustomer_Click(object sender, EventArgs e)
        {
            Class.Customer newCustomer = new Class.Customer();
            foreach (Control item in InsertCustomerPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TCustomer1") { newCustomer.Nama(item.Text); }
                        else if (item.Tag.ToString() == "TCustomer2") { newCustomer.Alamat(item.Text); }
                        else if (item.Tag.ToString() == "TCustomer3") { newCustomer.KodePos(item.Text); }
                        else if (item.Tag.ToString() == "TCustomer4") { newCustomer.NomorTelepon(item.Text); }
                        else if (item.Tag.ToString() == "TCustomer5") { newCustomer.Email(item.Text); }
                    }
                }
            }
            try {
                newCustomer.Insert();
                MessageBox.Show(String.Concat("Customer with email (", newCustomer.getEmail(), ") has been added successfully."));
                foreach (Control item in InsertCustomerPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            Class.Supplier newSupplier = new Class.Supplier();
            foreach (Control item in InsertSupplierPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TSupplier1") { newSupplier.Nama(item.Text); }
                        else if (item.Tag.ToString() == "TSupplier2") { newSupplier.Alamat(item.Text); }
                        else if (item.Tag.ToString() == "TSupplier3") { newSupplier.KodePos(item.Text); }
                        else if (item.Tag.ToString() == "TSupplier4") { newSupplier.NomorTelepon(item.Text); }
                        else if (item.Tag.ToString() == "TSupplier5") { newSupplier.Email(item.Text); }
                    }
                }
            }
            try {
                newSupplier.Insert();
                MessageBox.Show(String.Concat("Supplier with email (", newSupplier.getEmail(), ") has been added successfully."));
                foreach (Control item in InsertSupplierPage.Controls) { if (item is MetroTextBox) { item.Text = ""; } }
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
