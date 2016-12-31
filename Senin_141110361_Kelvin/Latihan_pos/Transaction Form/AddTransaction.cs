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
    public partial class AddTransaction : MetroFramework.Forms.MetroForm
    {
        private int id_barang_penjualan;
        private int id_barang_pembelian;
        private int id_customer;
        private int id_supplier;
        public AddTransaction()
        {
            InitializeComponent();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);

            AddTransactionTabControl.Location = new Point(26, 80);
            AddTransactionTabControl.Size = new Size(this.Size.Width - 52, this.Size.Height - 80 - 80);
            AddTransactionTabControl.SelectedTab = AddPembelianPage;

            Back.Location = new Point(this.Size.Width / 2 - Back.Size.Width / 2, this.Size.Height - Back.Size.Height - 24);

            #region AddPembelian
            MetroLabel LPembelian0 = new MetroLabel();
            LPembelian0.Font = new Font("Segoe UI", 12F);
            LPembelian0.Text = "Kode";
            LPembelian0.Location = new Point(32, 16);
            LPembelian0.UseCustomBackColor = LPembelian0.UseCustomForeColor = true;

            MetroLabel LPembelian1 = new MetroLabel();
            LPembelian1.Font = new Font("Segoe UI", 12F);
            LPembelian1.Text = "Supplier";
            LPembelian1.Location = new Point(32, 48);
            LPembelian1.UseCustomBackColor = LPembelian1.UseCustomForeColor = true;

            MetroLabel LPembelian2 = new MetroLabel();
            LPembelian2.Font = new Font("Segoe UI", 12F);
            LPembelian2.Text = "Barang";
            LPembelian2.Location = new Point(32, 80);
            LPembelian2.UseCustomBackColor = LPembelian2.UseCustomForeColor = true;

            MetroLabel LPembelian3 = new MetroLabel();
            LPembelian3.Font = new Font("Segoe UI", 12F);
            LPembelian3.Text = "Harga Barang";
            LPembelian3.Location = new Point(32, 112);
            LPembelian3.UseCustomBackColor = LPembelian3.UseCustomForeColor = true;

            MetroLabel LPembelian4 = new MetroLabel();
            LPembelian4.Font = new Font("Segoe UI", 12F);
            LPembelian4.Text = "Kuantitas";
            LPembelian4.Location = new Point(32, 144);
            LPembelian4.UseCustomBackColor = LPembelian4.UseCustomForeColor = true;

            MetroLabel LPembelian5 = new MetroLabel();
            LPembelian5.Font = new Font("Segoe UI", 12F);
            LPembelian5.Text = "SubTotal Harga";
            LPembelian5.Location = new Point(32, 176);
            LPembelian5.UseCustomBackColor = LPembelian5.UseCustomForeColor = true;

            MetroLabel LPembelian6 = new MetroLabel();
            LPembelian6.Font = new Font("Segoe UI", 12F);
            LPembelian6.Text = "Total Harga";
            LPembelian6.Location = new Point(888, 480);
            LPembelian6.UseCustomBackColor = LPembelian6.UseCustomForeColor = true;

            MetroTextBox TPembelian0 = new MetroTextBox();
            TPembelian0.Font = new Font("Segoe UI", 8F);
            TPembelian0.Location = new Point(144, 16);
            TPembelian0.Size = new Size(144, 24);
            TPembelian0.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian0.UseCustomBackColor = TPembelian0.UseCustomForeColor = true;
            TPembelian0.Tag = "TPembelian0";

            MetroTextBox TPembelian1 = new MetroTextBox();
            TPembelian1.Font = new Font("Segoe UI", 8F);
            TPembelian1.Location = new Point(144, 48);
            TPembelian1.Size = new Size(144, 24);
            TPembelian1.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian1.BackColor = Color.FromArgb(64, 64, 64);
            TPembelian1.UseCustomBackColor = TPembelian1.UseCustomForeColor = true;
            TPembelian1.ReadOnly = true; TPembelian1.Enabled = false;
            TPembelian1.Tag = "TPembelian1";

            MetroTextBox TPembelian2 = new MetroTextBox();
            TPembelian2.Font = new Font("Segoe UI", 8F);
            TPembelian2.Location = new Point(144, 80);
            TPembelian2.Size = new Size(144, 24);
            TPembelian2.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian2.BackColor = Color.FromArgb(64, 64, 64);
            TPembelian2.UseCustomBackColor = TPembelian2.UseCustomForeColor = true;
            TPembelian2.ReadOnly = true; TPembelian2.Enabled = false;
            TPembelian2.Tag = "TPembelian2";

            MetroTextBox TPembelian3 = new MetroTextBox();
            TPembelian3.Font = new Font("Segoe UI", 8F);
            TPembelian3.Location = new Point(144, 112);
            TPembelian3.Size = new Size(144, 24);
            TPembelian3.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian3.UseCustomBackColor = TPembelian3.UseCustomForeColor = true;
            TPembelian3.Tag = "TPembelian3";
            TPembelian3.TextChanged += new EventHandler(HargaBarangPembelian_TextChanged);

            MetroTextBox TPembelian4 = new MetroTextBox();
            TPembelian4.Font = new Font("Segoe UI", 8F);
            TPembelian4.Location = new Point(144, 144);
            TPembelian4.Size = new Size(144, 24);
            TPembelian4.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian4.UseCustomBackColor = TPembelian4.UseCustomForeColor = true;
            TPembelian4.Tag = "TPembelian4";
            TPembelian4.TextChanged += new EventHandler(KuantitasPembelian_TextChanged);

            MetroTextBox TPembelian5 = new MetroTextBox();
            TPembelian5.Font = new Font("Segoe UI", 8F);
            TPembelian5.Location = new Point(144, 176);
            TPembelian5.Size = new Size(144, 24);
            TPembelian5.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian5.BackColor = Color.FromArgb(64, 64, 64);
            TPembelian5.UseCustomBackColor = TPembelian5.UseCustomForeColor = true;
            TPembelian5.ReadOnly = true; TPembelian5.Enabled = false;
            TPembelian5.Tag = "TPembelian5";

            MetroTextBox TPembelian6 = new MetroTextBox();
            TPembelian6.Font = new Font("Segoe UI", 8F);
            TPembelian6.Location = new Point(994, 480);
            TPembelian6.Size = new Size(288, 24);
            TPembelian6.ForeColor = Color.FromArgb(255, 255, 0);
            TPembelian6.BackColor = Color.FromArgb(64, 64, 64);
            TPembelian6.UseCustomBackColor = TPembelian6.UseCustomForeColor = true;
            TPembelian6.ReadOnly = true; TPembelian6.Enabled = false;
            TPembelian6.Tag = "TPembelian6";

            Button BrowsePembelianCode = new Button();
            BrowsePembelianCode.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePembelianCode.Text = "Browse Code";
            BrowsePembelianCode.Location = new Point(320, 20);
            BrowsePembelianCode.Size = new Size(160, 32);
            BrowsePembelianCode.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePembelianCode.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePembelianCode.FlatStyle = FlatStyle.Flat;
            BrowsePembelianCode.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePembelianCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePembelianCode.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePembelianCode.Click += new EventHandler(BrowsePembelianCode_Click);

            Button BrowsePembelianSupplier = new Button();
            BrowsePembelianSupplier.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePembelianSupplier.Text = "Browse Supplier";
            BrowsePembelianSupplier.Location = new Point(320, 68);
            BrowsePembelianSupplier.Size = new Size(160, 32);
            BrowsePembelianSupplier.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePembelianSupplier.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePembelianSupplier.FlatStyle = FlatStyle.Flat;
            BrowsePembelianSupplier.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePembelianSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePembelianSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePembelianSupplier.Click += new EventHandler(BrowsePembelianSupplier_Click);

            Button BrowsePembelianProduct = new Button();
            BrowsePembelianProduct.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePembelianProduct.Text = "Browse Product";
            BrowsePembelianProduct.Location = new Point(320, 116);
            BrowsePembelianProduct.Size = new Size(160, 32);
            BrowsePembelianProduct.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePembelianProduct.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePembelianProduct.FlatStyle = FlatStyle.Flat;
            BrowsePembelianProduct.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePembelianProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePembelianProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePembelianProduct.Click += new EventHandler(BrowsePembelianProduct_Click);

            Button AddHargaPembelian = new Button();
            AddHargaPembelian.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            AddHargaPembelian.Text = "Add";
            AddHargaPembelian.Location = new Point(320, 164);
            AddHargaPembelian.Size = new Size(160, 32);
            AddHargaPembelian.BackColor = Color.FromArgb(128, 128, 0);
            AddHargaPembelian.ForeColor = Color.FromArgb(16, 16, 16);
            AddHargaPembelian.FlatStyle = FlatStyle.Flat;
            AddHargaPembelian.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 0);
            AddHargaPembelian.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            AddHargaPembelian.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 64);
            AddHargaPembelian.Click += new EventHandler(AddPembelian_Click);

            DataGridView dgvPembelian = new DataGridView();
            dgvPembelian.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvPembelian.Location = new Point(32, 208);
            dgvPembelian.Size = new Size(AddTransactionTabControl.Size.Width - 64, 256);
            dgvPembelian.Tag = "dgvPembelian";

            AddPembelianPage.Controls.Add(LPembelian0);
            AddPembelianPage.Controls.Add(LPembelian1);
            AddPembelianPage.Controls.Add(LPembelian2);
            AddPembelianPage.Controls.Add(LPembelian3);
            AddPembelianPage.Controls.Add(LPembelian4);
            AddPembelianPage.Controls.Add(LPembelian5);
            AddPembelianPage.Controls.Add(LPembelian6);

            AddPembelianPage.Controls.Add(TPembelian0);
            AddPembelianPage.Controls.Add(TPembelian1);
            AddPembelianPage.Controls.Add(TPembelian2);
            AddPembelianPage.Controls.Add(TPembelian3);
            AddPembelianPage.Controls.Add(TPembelian4);
            AddPembelianPage.Controls.Add(TPembelian5);
            AddPembelianPage.Controls.Add(TPembelian6);

            AddPembelianPage.Controls.Add(BrowsePembelianCode);
            AddPembelianPage.Controls.Add(BrowsePembelianSupplier);
            AddPembelianPage.Controls.Add(BrowsePembelianProduct);
            AddPembelianPage.Controls.Add(AddHargaPembelian);

            AddPembelianPage.Controls.Add(dgvPembelian);
            #endregion

            #region AddPenjualan
            MetroLabel LPenjualan0 = new MetroLabel();
            LPenjualan0.Font = new Font("Segoe UI", 12F);
            LPenjualan0.Text = "Kode";
            LPenjualan0.Location = new Point(32, 16);
            LPenjualan0.UseCustomBackColor = LPenjualan0.UseCustomForeColor = true;

            MetroLabel LPenjualan1 = new MetroLabel();
            LPenjualan1.Font = new Font("Segoe UI", 12F);
            LPenjualan1.Text = "Customer";
            LPenjualan1.Location = new Point(32, 48);
            LPenjualan1.UseCustomBackColor = LPenjualan1.UseCustomForeColor = true;

            MetroLabel LPenjualan2 = new MetroLabel();
            LPenjualan2.Font = new Font("Segoe UI", 12F);
            LPenjualan2.Text = "Barang";
            LPenjualan2.Location = new Point(32, 80);
            LPenjualan2.UseCustomBackColor = LPenjualan2.UseCustomForeColor = true;

            MetroLabel LPenjualan3 = new MetroLabel();
            LPenjualan3.Font = new Font("Segoe UI", 12F);
            LPenjualan3.Text = "Harga Barang";
            LPenjualan3.Location = new Point(32, 112);
            LPenjualan3.UseCustomBackColor = LPenjualan3.UseCustomForeColor = true;

            MetroLabel LPenjualan4 = new MetroLabel();
            LPenjualan4.Font = new Font("Segoe UI", 12F);
            LPenjualan4.Text = "Kuantitas";
            LPenjualan4.Location = new Point(32, 144);
            LPenjualan4.UseCustomBackColor = LPenjualan4.UseCustomForeColor = true;

            MetroLabel LPenjualan5 = new MetroLabel();
            LPenjualan5.Font = new Font("Segoe UI", 12F);
            LPenjualan5.Text = "SubTotal Harga";
            LPenjualan5.Location = new Point(32, 176);
            LPenjualan5.UseCustomBackColor = LPenjualan5.UseCustomForeColor = true;

            MetroLabel LPenjualan6 = new MetroLabel();
            LPenjualan6.Font = new Font("Segoe UI", 12F);
            LPenjualan6.Text = "Total Harga";
            LPenjualan6.Location = new Point(888, 480);
            LPenjualan6.UseCustomBackColor = LPenjualan6.UseCustomForeColor = true;

            MetroTextBox TPenjualan0 = new MetroTextBox();
            TPenjualan0.Font = new Font("Segoe UI", 8F);
            TPenjualan0.Location = new Point(144, 16);
            TPenjualan0.Size = new Size(144, 24);
            TPenjualan0.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan0.UseCustomBackColor = TPenjualan0.UseCustomForeColor = true;
            TPenjualan0.Tag = "TPenjualan0";

            MetroTextBox TPenjualan1 = new MetroTextBox();
            TPenjualan1.Font = new Font("Segoe UI", 8F);
            TPenjualan1.Location = new Point(144, 48);
            TPenjualan1.Size = new Size(144, 24);
            TPenjualan1.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan1.BackColor = Color.FromArgb(64, 64, 64);
            TPenjualan1.UseCustomBackColor = TPenjualan1.UseCustomForeColor = true;
            TPenjualan1.ReadOnly = true; TPenjualan1.Enabled = false;
            TPenjualan1.Tag = "TPenjualan1";

            MetroTextBox TPenjualan2 = new MetroTextBox();
            TPenjualan2.Font = new Font("Segoe UI", 8F);
            TPenjualan2.Location = new Point(144, 80);
            TPenjualan2.Size = new Size(144, 24);
            TPenjualan2.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan2.BackColor = Color.FromArgb(64, 64, 64);
            TPenjualan2.UseCustomBackColor = TPenjualan2.UseCustomForeColor = true;
            TPenjualan2.ReadOnly = true; TPenjualan2.Enabled = false;
            TPenjualan2.Tag = "TPenjualan2";

            MetroTextBox TPenjualan3 = new MetroTextBox();
            TPenjualan3.Font = new Font("Segoe UI", 8F);
            TPenjualan3.Location = new Point(144, 112);
            TPenjualan3.Size = new Size(144, 24);
            TPenjualan3.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan3.UseCustomBackColor = TPenjualan3.UseCustomForeColor = true;
            TPenjualan3.Tag = "TPenjualan3";
            TPenjualan3.TextChanged += new EventHandler(HargaBarangPenjualan_TextChanged);

            MetroTextBox TPenjualan4 = new MetroTextBox();
            TPenjualan4.Font = new Font("Segoe UI", 8F);
            TPenjualan4.Location = new Point(144, 144);
            TPenjualan4.Size = new Size(144, 24);
            TPenjualan4.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan4.UseCustomBackColor = TPenjualan4.UseCustomForeColor = true;
            TPenjualan4.Tag = "TPenjualan4";
            TPenjualan4.TextChanged += new EventHandler(KuantitasPenjualan_TextChanged);

            MetroTextBox TPenjualan5 = new MetroTextBox();
            TPenjualan5.Font = new Font("Segoe UI", 8F);
            TPenjualan5.Location = new Point(144, 176);
            TPenjualan5.Size = new Size(144, 24);
            TPenjualan5.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan5.BackColor = Color.FromArgb(64, 64, 64);
            TPenjualan5.UseCustomBackColor = TPenjualan5.UseCustomForeColor = true;
            TPenjualan5.ReadOnly = true; TPenjualan5.Enabled = false;
            TPenjualan5.Tag = "TPenjualan5";

            MetroTextBox TPenjualan6 = new MetroTextBox();
            TPenjualan6.Font = new Font("Segoe UI", 8F);
            TPenjualan6.Location = new Point(994, 480);
            TPenjualan6.Size = new Size(288, 24);
            TPenjualan6.ForeColor = Color.FromArgb(255, 255, 0);
            TPenjualan6.BackColor = Color.FromArgb(64, 64, 64);
            TPenjualan6.UseCustomBackColor = TPenjualan6.UseCustomForeColor = true;
            TPenjualan6.ReadOnly = true; TPenjualan6.Enabled = false;
            TPenjualan6.Tag = "TPenjualan6";

            Button BrowsePenjualanCode = new Button();
            BrowsePenjualanCode.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePenjualanCode.Text = "Browse Code";
            BrowsePenjualanCode.Location = new Point(320, 20);
            BrowsePenjualanCode.Size = new Size(160, 32);
            BrowsePenjualanCode.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePenjualanCode.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePenjualanCode.FlatStyle = FlatStyle.Flat;
            BrowsePenjualanCode.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePenjualanCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePenjualanCode.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePenjualanCode.Click += new EventHandler(BrowsePenjualanCode_Click);

            Button BrowsePenjualanCustomer = new Button();
            BrowsePenjualanCustomer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePenjualanCustomer.Text = "Browse Customer";
            BrowsePenjualanCustomer.Location = new Point(320, 68);
            BrowsePenjualanCustomer.Size = new Size(160, 32);
            BrowsePenjualanCustomer.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePenjualanCustomer.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePenjualanCustomer.FlatStyle = FlatStyle.Flat;
            BrowsePenjualanCustomer.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePenjualanCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePenjualanCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePenjualanCustomer.Click += new EventHandler(BrowsePenjualanCustomer_Click);

            Button BrowsePenjualanProduct = new Button();
            BrowsePenjualanProduct.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BrowsePenjualanProduct.Text = "Browse Product";
            BrowsePenjualanProduct.Location = new Point(320, 116);
            BrowsePenjualanProduct.Size = new Size(160, 32);
            BrowsePenjualanProduct.BackColor = Color.FromArgb(16, 96, 112);
            BrowsePenjualanProduct.ForeColor = Color.FromArgb(16, 16, 16);
            BrowsePenjualanProduct.FlatStyle = FlatStyle.Flat;
            BrowsePenjualanProduct.FlatAppearance.BorderColor = Color.FromArgb(32, 192, 224);
            BrowsePenjualanProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 192, 224);
            BrowsePenjualanProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 192, 224);
            BrowsePenjualanProduct.Click += new EventHandler(BrowsePenjualanProduct_Click);

            Button AddHargaPenjualan = new Button();
            AddHargaPenjualan.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            AddHargaPenjualan.Text = "Add";
            AddHargaPenjualan.Location = new Point(320, 164);
            AddHargaPenjualan.Size = new Size(160, 32);
            AddHargaPenjualan.BackColor = Color.FromArgb(128, 128, 0);
            AddHargaPenjualan.ForeColor = Color.FromArgb(16, 16, 16);
            AddHargaPenjualan.FlatStyle = FlatStyle.Flat;
            AddHargaPenjualan.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 0);
            AddHargaPenjualan.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            AddHargaPenjualan.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 64);
            AddHargaPenjualan.Click += new EventHandler(AddPenjualan_Click);

            DataGridView dgvPenjualan = new DataGridView();
            dgvPenjualan.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvPenjualan.Location = new Point(32, 208);
            dgvPenjualan.Size = new Size(AddTransactionTabControl.Size.Width - 64, 256);
            dgvPenjualan.Tag = "dgvPenjualan";

            AddPenjualanPage.Controls.Add(LPenjualan0);
            AddPenjualanPage.Controls.Add(LPenjualan1);
            AddPenjualanPage.Controls.Add(LPenjualan2);
            AddPenjualanPage.Controls.Add(LPenjualan3);
            AddPenjualanPage.Controls.Add(LPenjualan4);
            AddPenjualanPage.Controls.Add(LPenjualan5);
            AddPenjualanPage.Controls.Add(LPenjualan6);

            AddPenjualanPage.Controls.Add(TPenjualan0);
            AddPenjualanPage.Controls.Add(TPenjualan1);
            AddPenjualanPage.Controls.Add(TPenjualan2);
            AddPenjualanPage.Controls.Add(TPenjualan3);
            AddPenjualanPage.Controls.Add(TPenjualan4);
            AddPenjualanPage.Controls.Add(TPenjualan5);
            AddPenjualanPage.Controls.Add(TPenjualan6);

            AddPenjualanPage.Controls.Add(BrowsePenjualanCode);
            AddPenjualanPage.Controls.Add(BrowsePenjualanCustomer);
            AddPenjualanPage.Controls.Add(BrowsePenjualanProduct);
            AddPenjualanPage.Controls.Add(AddHargaPenjualan);

            AddPenjualanPage.Controls.Add(dgvPenjualan);
            #endregion
        }

        private void HargaBarangPembelian_TextChanged(object sender, EventArgs e)
        {
            decimal HargaBarang;
            int Kuantitas;
            string textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPembelian3") { textHargaBarang = item.Text; }
                    if (item.Tag.ToString() == "TPembelian4") { textKuantitas = item.Text; }
                }
            }
            HargaBarang = (textHargaBarang.Trim() != "") ? decimal.Parse(textHargaBarang) : 0;
            Kuantitas = (textKuantitas.Trim() != "") ? int.Parse(textKuantitas) : 0;
            
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPembelian5") { item.Text = (HargaBarang * Kuantitas).ToString(); }
                }
            }
        }

        private void HargaBarangPenjualan_TextChanged(object sender, EventArgs e)
        {
            decimal HargaBarang;
            int Kuantitas;
            string textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPenjualan3") { textHargaBarang = item.Text; }
                    if (item.Tag.ToString() == "TPenjualan4") { textKuantitas = item.Text; }
                }
            }
            HargaBarang = (textHargaBarang.Trim() != "") ? decimal.Parse(textHargaBarang) : 0;
            Kuantitas = (textKuantitas.Trim() != "") ? int.Parse(textKuantitas) : 0;
            
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPenjualan5") { item.Text = (HargaBarang * Kuantitas).ToString(); }
                }
            }
        }

        private void KuantitasPembelian_TextChanged(object sender, EventArgs e)
        {
            decimal HargaBarang;
            int Kuantitas;
            string textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPembelian3") { textHargaBarang = item.Text; }
                    if (item.Tag.ToString() == "TPembelian4") { textKuantitas = item.Text; }
                }
            }
            HargaBarang = (textHargaBarang.Trim() != "") ? decimal.Parse(textHargaBarang) : 0;
            Kuantitas = (textKuantitas.Trim() != "") ? int.Parse(textKuantitas) : 0;
            
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPembelian5") { item.Text = (HargaBarang * Kuantitas).ToString(); }
                }
            }
        }

        private void KuantitasPenjualan_TextChanged(object sender, EventArgs e)
        {
            decimal HargaBarang;
            int Kuantitas;
            string textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPenjualan3") { textHargaBarang = item.Text; }
                    if (item.Tag.ToString() == "TPenjualan4") { textKuantitas = item.Text; }
                }
            }
            HargaBarang = (textHargaBarang.Trim() != "") ? decimal.Parse(textHargaBarang) : 0;
            Kuantitas = (textKuantitas.Trim() != "") ? int.Parse(textKuantitas) : 0;
            
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPenjualan5") { item.Text = (HargaBarang * Kuantitas).ToString(); }
                }
            }
        }

        private void BrowsePembelianCode_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("purchase");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0) {
                Class.Supplier supplier = Class.Supplier.SelectID(int.Parse(datas["supplier_id"]));
                id_supplier = supplier.getID();
                foreach (Control item in AddPembelianPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPembelian0") { item.Text = datas["kode"]; }
                        if (item.Tag.ToString() == "TPembelian1") { item.Text = supplier.getEmail(); }
                    }
                }
                DataTable dt = Class.DetailPembelian.SelectByPurchaseId(int.Parse(datas["purchase_id"]));
                foreach (Control item in AddPembelianPage.Controls) {
                    if (item is DataGridView) {
                        if (item.Tag.ToString() == "dgvPembelian") {
                            (item as DataGridView).DataSource = dt;
                            item.Refresh();
                        }
                    }
                }

                decimal sum = 0;
                foreach (DataRow dr in dt.Rows) {
                    sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
                }
                foreach (Control item in AddPembelianPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPembelian6") { item.Text = sum.ToString(); }
                    }
                }
            }
        }

        private void BrowsePenjualanCode_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("sale");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0) {
                Class.Customer customer = Class.Customer.SelectID(int.Parse(datas["customer_id"]));
                id_customer = customer.getID();
                foreach (Control item in AddPenjualanPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPenjualan0") { item.Text = datas["kode"]; }
                        if (item.Tag.ToString() == "TPenjualan1") { item.Text = customer.getEmail(); }
                    }
                }
                DataTable dt = Class.DetailPenjualan.SelectBySaleId(int.Parse(datas["sale_id"]));
                foreach (Control item in AddPenjualanPage.Controls) {
                    if (item is DataGridView) {
                        if (item.Tag.ToString() == "dgvPenjualan") {
                            (item as DataGridView).DataSource = dt;
                            item.Refresh();
                        }
                    }
                }

                decimal sum = 0;
                foreach (DataRow dr in dt.Rows) {
                    sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
                }
                foreach (Control item in AddPenjualanPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPenjualan6") { item.Text = sum.ToString(); }
                    }
                }
            }
        }

        private void BrowsePembelianSupplier_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("supplier");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0)
            {
                id_supplier = int.Parse(datas["supplier_id"]);
                foreach (Control item in AddPembelianPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPembelian1") { item.Text = datas["email"]; }
                    }
                }
            }
        }

        private void BrowsePenjualanCustomer_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("customer");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0) {
                id_customer = int.Parse(datas["customer_id"]);
                foreach (Control item in AddPenjualanPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPenjualan1") { item.Text = datas["email"]; }
                    }
                }
            }
        }

        private void BrowsePembelianProduct_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("barang");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0)
            {
                id_barang_pembelian = Convert.ToInt32(datas["barang_id"]);
                foreach (Control item in AddPembelianPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPembelian2") { item.Text = datas["kode"] + " - " + datas["nama"]; }
                        if (item.Tag.ToString() == "TPembelian3") { item.Text = datas["harga_jual"]; }
                    }
                }
            }
        }

        private void BrowsePenjualanProduct_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse("barang");
            this.Hide();
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();
            this.Show();

            if (datas.Count > 0) {
                id_barang_penjualan = Convert.ToInt32(datas["barang_id"]);
                foreach (Control item in AddPenjualanPage.Controls) {
                    if (item is MetroTextBox) {
                        if (item.Tag.ToString() == "TPenjualan2") { item.Text = datas["kode"] + " - " + datas["nama"]; }
                        if (item.Tag.ToString() == "TPenjualan3") { item.Text = datas["harga_jual"]; }
                    }
                }
            }
        }


        private void AddPembelian_Click(object sender, EventArgs e)
        {
            string textKode = "", textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "" && item.Tag.ToString() != "TPembelian6") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TPembelian0") { textKode = item.Text; }
                        else if (item.Tag.ToString() == "TPembelian3") { textHargaBarang = item.Text; }
                        else if (item.Tag.ToString() == "TPembelian4") { textKuantitas = item.Text; }
                    }
                }
            }

            Class.Pembelian pembelian = Class.Pembelian.SelectCode(textKode);
            Class.Pembelian pembelianBaru = new Class.Pembelian();
            if (pembelian == null) {
                pembelianBaru.SetSupplier(Class.Supplier.SelectID(id_supplier));
                pembelianBaru.Kode(textKode);
                try {
                    pembelianBaru.Insert();
                    pembelian = Class.Pembelian.SelectCode(pembelianBaru.getKode());
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }

            Class.DetailPembelian detailPembelian = Class.DetailPembelian.
                SelectByProductIdAndPurchaseId(id_barang_pembelian, pembelian.getID());

            if (detailPembelian == null)
            {
                Class.DetailPembelian detailPembelianBaru = new Class.DetailPembelian();
                detailPembelianBaru.SetBarang(Class.Barang.SelectID(id_barang_pembelian));

                Class.Barang barang = detailPembelianBaru.getBarang();

                int kuantitas = int.Parse(textKuantitas);

                detailPembelianBaru.Kuantitas(kuantitas);
                detailPembelianBaru.HargaBarang(decimal.Parse(textHargaBarang));
                detailPembelianBaru.SetPembelian(pembelian);

                try {
                    detailPembelianBaru.Insert();
                    barang.JumlahAwal(barang.getJumlahAwal() + kuantitas);
                    barang.HargaHPP(detailPembelianBaru.getHargaBarang());
                    barang.Update();
                    MessageBox.Show("Barang dengan kode " + detailPembelianBaru.getBarang().getKode() +
                                    " berhasil dimasukkan pada faktur dengan kode " + pembelian.getKode());
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
            else {
                Class.Barang barang = detailPembelian.getBarang();
                int kuantitas = int.Parse(textKuantitas);
                int kuantitasLama = detailPembelian.getKuantitas();
                detailPembelian.Kuantitas(kuantitas);
                detailPembelian.HargaBarang(decimal.Parse(textHargaBarang));

                if (kuantitas < 0) { MessageBox.Show("Kuantitas tidak valid."); }
                else {
                    try {
                        detailPembelian.Update();
                        barang.JumlahAwal(barang.getJumlahAwal() + kuantitas - kuantitasLama);
                        barang.HargaHPP(detailPembelian.getHargaBarang());
                        barang.Update();
                        MessageBox.Show("Barang dengan kode " + detailPembelian.getBarang().getKode() +
                                        " pada faktur dengan kode " + pembelian.getKode());
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message);
                    }
                }
            }

            DataTable dt = Class.DetailPembelian.SelectByPurchaseId(pembelian.getID());

            foreach (Control item in AddPembelianPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "dgvPembelian") {
                        (item as DataGridView).DataSource = dt;
                        item.Refresh();
                    }
                }
            }

            decimal sum = 0;
            foreach (DataRow dr in dt.Rows) {
                sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
            }
            foreach (Control item in AddPembelianPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPembelian6") { item.Text = sum.ToString(); }
                }
            }
        }

        private void AddPenjualan_Click(object sender, EventArgs e)
        {
            string textKode = "", textHargaBarang = "", textKuantitas = "";
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Text == "" && item.Tag.ToString() != "TPenjualan6") {
                        MessageBox.Show("Input must not be empty.");
                        return;
                    }
                    else {
                        if (item.Tag.ToString() == "TPenjualan0") { textKode = item.Text; }
                        else if (item.Tag.ToString() == "TPenjualan3") { textHargaBarang = item.Text; }
                        else if (item.Tag.ToString() == "TPenjualan4") { textKuantitas = item.Text; }
                    }
                }
            }

            Class.Penjualan penjualan = Class.Penjualan.SelectCode(textKode);
            Class.Penjualan penjualanBaru = new Class.Penjualan();
            if (penjualan == null) {
                penjualanBaru.SetCustomer(Class.Customer.SelectID(id_customer));
                penjualanBaru.Kode(textKode);
                try {
                    penjualanBaru.Insert();
                    penjualan = Class.Penjualan.SelectCode(penjualanBaru.getKode());
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }

            Class.DetailPenjualan detailPenjualan = Class.DetailPenjualan.
                SelectByProductIdAndPurchaseId(id_barang_penjualan, penjualan.getID());

            if (detailPenjualan == null)
            {
                Class.DetailPenjualan detailPenjualanBaru = new Class.DetailPenjualan();
                detailPenjualanBaru.SetBarang(Class.Barang.SelectID(id_barang_penjualan));

                Class.Barang barang = detailPenjualanBaru.getBarang();

                int kuantitas = int.Parse(textKuantitas);

                detailPenjualanBaru.Kuantitas(kuantitas);
                detailPenjualanBaru.HargaBarang(decimal.Parse(textHargaBarang));
                detailPenjualanBaru.SetPenjualan(penjualan);

                try {
                    detailPenjualanBaru.Insert();
                    barang.JumlahAwal(barang.getJumlahAwal() + kuantitas);
                    barang.HargaHPP(detailPenjualanBaru.getHargaBarang());
                    barang.Update();
                    MessageBox.Show("Barang dengan kode " + detailPenjualanBaru.getBarang().getKode() +
                                    " berhasil dimasukkan pada faktur dengan kode " + penjualan.getKode());
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
            else {
                Class.Barang barang = detailPenjualan.getBarang();
                int kuantitas = int.Parse(textKuantitas);
                int kuantitasLama = detailPenjualan.getKuantitas();
                detailPenjualan.Kuantitas(kuantitas);
                detailPenjualan.HargaBarang(decimal.Parse(textHargaBarang));

                if (kuantitas < 0) { MessageBox.Show("Kuantitas tidak valid."); }
                else {
                    try {
                        detailPenjualan.Update();
                        barang.JumlahAwal(barang.getJumlahAwal() + kuantitas - kuantitasLama);
                        barang.HargaHPP(detailPenjualan.getHargaBarang());
                        barang.Update();
                        MessageBox.Show("Barang dengan kode " + detailPenjualan.getBarang().getKode() +
                                        " pada faktur dengan kode " + penjualan.getKode());
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message);
                    }
                }
            }

            DataTable dt = Class.DetailPenjualan.SelectBySaleId(penjualan.getID());

            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is DataGridView) {
                    if (item.Tag.ToString() == "dgvPenjualan") {
                        (item as DataGridView).DataSource = dt;
                        item.Refresh();
                    }
                }
            }

            decimal sum = 0;
            foreach (DataRow dr in dt.Rows) {
                sum += Convert.ToDecimal(dr["harga_barang"]) * Convert.ToInt32(dr["kuantitas"]);
            }
            foreach (Control item in AddPenjualanPage.Controls) {
                if (item is MetroTextBox) {
                    if (item.Tag.ToString() == "TPenjualan6") { item.Text = sum.ToString(); }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
