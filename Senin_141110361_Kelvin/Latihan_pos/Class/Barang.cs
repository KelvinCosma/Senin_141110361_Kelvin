using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_pos.Class
{
    class Barang
    {
        private static string tableName = "barang";
        public int id { private set; get; }
        public string kode { private set; get; }
        public string nama { private set; get; }
        public int jumlahAwal { private set; get; }
        public decimal hargaHPP { private set; get; }
        public decimal hargaJual { private set; get; }
        public DateTime createdAt { private set; get; }
        public DateTime updatedAt { private set; get; }

        public int getID() { return this.id; }
        public string getKode() { return this.kode; }
        public int getJumlahAwal() { return this.jumlahAwal; }

        public Barang ID(int id) { this.id = id; return this; }
        public Barang Kode(string kode) { this.kode = kode; return this; }
        public Barang Nama(string nama) { this.nama = nama; return this; }
        public Barang JumlahAwal(int jumlahAwal) { this.jumlahAwal = jumlahAwal; return this; }
        public Barang HargaHPP(decimal hargaHPP) { this.hargaHPP = hargaHPP; return this; }
        public Barang HargaJual(decimal hargaJual) { this.hargaJual = hargaJual; return this; }
        public Barang CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public Barang UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

        public static DataTable SelectAll() {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName);
            MySqlDataAdapter DA = new MySqlDataAdapter(selectString, Database.conn);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DataTable DT = DS.Tables[0].Clone();
            foreach (DataColumn DC in DT.Columns) { DC.DataType = typeof(string); }
            foreach (DataRow row in DS.Tables[0].Rows) { DT.ImportRow(row); }
            return DT;
        }

        public static Barang SelectID(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE barang_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            Barang barang = new Barang();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                barang.ID(Convert.ToInt32(DR["barang_id"]));
                barang.Kode(DR["kode"].ToString());
                barang.Nama(DR["nama"].ToString());
                barang.JumlahAwal(Convert.ToInt32(DR["jumlah_awal"]));
                barang.HargaHPP(Convert.ToDecimal(DR["harga_HPP"]));
                barang.HargaJual(Convert.ToDecimal(DR["harga_jual"]));
                barang.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                barang.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return barang;
            }

            return null;
        }

        public void Insert() {
            string insertString = String.Concat("INSERT INTO ", tableName,
                " (kode, nama, jumlah_awal, harga_HPP, harga_jual, created_at, updated_at)", 
                " VALUES (@kode, @nama, @jumlahAwal, @hargaHPP, @hargaJual, @createdAt, @updatedAt)");
            MySqlCommand cmd = new MySqlCommand(insertString, Database.conn);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlahAwal);
            cmd.Parameters.AddWithValue("@hargaHPP", hargaHPP);
            cmd.Parameters.AddWithValue("@hargaJual", hargaJual);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try {
                Database.openConnection();
                cmd.ExecuteNonQuery();
                Database.closeConnection();
            }
            catch (Exception err) {
                Database.closeConnection();
                throw new Exception(err.Message);
            }
        }

        public void Update() {
            string updateString = String.Concat("UPDATE ", tableName, 
                " SET kode = @kode, nama = @nama, jumlah_awal = @jumlahAwal, harga_HPP = @hargaHPP, ", 
                "harga_jual = @hargaJual, updated_at = @updatedAt WHERE barang_id = @id");
            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jumlahAwal", jumlahAwal);
            cmd.Parameters.AddWithValue("@hargaHPP", hargaHPP);
            cmd.Parameters.AddWithValue("@hargaJual", hargaJual);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try {
                Database.openConnection();
                cmd.ExecuteNonQuery();
                Database.closeConnection();
            }
            catch (Exception err) {
                Database.closeConnection();
                throw new Exception(err.Message);
            }
        }

        public void Delete() {
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE barang_id = @id");
            MySqlCommand cmd = new MySqlCommand(deleteString, Database.conn);
            cmd.Parameters.AddWithValue("@id", id);
            try {
                Database.openConnection();
                cmd.ExecuteNonQuery();
                Database.closeConnection();
            }
            catch (Exception err) {
                Database.closeConnection();
                throw new Exception(err.Message);
            }
        }
    }
}
