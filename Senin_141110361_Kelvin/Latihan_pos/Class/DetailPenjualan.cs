using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_pos.Class
{
    class DetailPenjualan
    {
        private static string tableName = "sale_detail";
        private int id;
        private Penjualan penjualan;
        private Barang barang;
        private decimal hargaBarang;
        private int kuantitas;
        private DateTime createdAt;
        private DateTime updatedAt;

        public int getID() { return this.id; }
        public Penjualan getPenjualan() { return this.penjualan; }
        public Barang getBarang() { return this.barang; }
        public decimal getHargaBarang() { return this.hargaBarang; }
        public int getKuantitas() { return this.kuantitas; }

        public DetailPenjualan ID(int id) { this.id = id; return this; }
        public DetailPenjualan SetPenjualan(Penjualan penjualan) { this.penjualan = penjualan; return this; }
        public DetailPenjualan SetBarang(Barang barang) { this.barang = barang; return this; }
        public DetailPenjualan HargaBarang(decimal hargaBarang) { this.hargaBarang = hargaBarang; return this; }
        public DetailPenjualan Kuantitas(int kuantitas) { this.kuantitas = kuantitas; return this; }
        public DetailPenjualan CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public DetailPenjualan UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

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

        public static DataTable SelectBySaleId(int saleId) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE sale_id = @saleId");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@saleId", saleId);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DataTable DT = DS.Tables[0].Clone();
            foreach (DataColumn DC in DT.Columns) { DC.DataType = typeof(string); }
            foreach (DataRow row in DS.Tables[0].Rows) { DT.ImportRow(row); }
            return DT;
        }

        public static DetailPenjualan SelectById(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE sale_detail_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DetailPenjualan detailPenjualan = new DetailPenjualan();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                detailPenjualan.ID(Convert.ToInt32(DR["sale_detail_id"]));
                detailPenjualan.SetPenjualan(Penjualan.SelectID(Convert.ToInt32(DR["sale_id"])));
                detailPenjualan.SetBarang(Barang.SelectID(Convert.ToInt32(DR["barang_id"])));
                detailPenjualan.Kuantitas(Convert.ToInt32(DR["kuantitas"]));
                detailPenjualan.HargaBarang(Convert.ToDecimal(DR["harga_barang"]));
                detailPenjualan.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                detailPenjualan.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return detailPenjualan;
            }
            return null;
        }

        public static DetailPenjualan SelectByProductIdAndPurchaseId(int barangId, int saleId) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE barang_id = @barangId AND sale_id = @saleId");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@barangId", barangId);
            DA.SelectCommand.Parameters.AddWithValue("@saleId", saleId);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DetailPenjualan detailPenjualan = new DetailPenjualan();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                detailPenjualan.ID(Convert.ToInt32(DR["sale_detail_id"]));
                detailPenjualan.SetPenjualan(Penjualan.SelectID(Convert.ToInt32(DR["sale_id"])));
                detailPenjualan.SetBarang(Barang.SelectID(Convert.ToInt32(DR["barang_id"])));
                detailPenjualan.Kuantitas(Convert.ToInt32(DR["kuantitas"]));
                detailPenjualan.HargaBarang(Convert.ToDecimal(DR["harga_barang"]));
                detailPenjualan.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                detailPenjualan.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return detailPenjualan;
            }
            return null;
        }

        public void Insert() {
            string insertString = String.Concat("INSERT INTO ", tableName, 
                "(sale_id, barang_id, harga_barang, kuantitas, created_at, updated_at) ", 
                "VALUES (@saleId, @barangId, @hargaBarang, @kuantitas, @createdAt, @updatedAt)");
            MySqlCommand cmd = new MySqlCommand(insertString, Database.conn);
            cmd.Parameters.AddWithValue("@saleId", this.penjualan.getID());
            cmd.Parameters.AddWithValue("@barangId", this.barang.getID());
            cmd.Parameters.AddWithValue("@hargaBarang", this.hargaBarang);
            cmd.Parameters.AddWithValue("@kuantitas", this.kuantitas);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try {
                Database.openConnection();
                cmd.ExecuteNonQuery();
                Database.closeConnection();
            }
            catch (Exception ex) {
                Database.closeConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Update() {
            string updateString = String.Concat("UPDATE " + tableName + 
                " SET sale_id = @saleId, barang_id = @barangId, harga_barang = @hargaBarang, " +
                "kuantitas = @kuantitas, updated_at = @updatedAt WHERE sale_detail_id = @id");
            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn);
            cmd.Parameters.AddWithValue("@saleId", this.penjualan.getID());
            cmd.Parameters.AddWithValue("@barangId", this.barang.getID());
            cmd.Parameters.AddWithValue("@hargaBarang", this.hargaBarang);
            cmd.Parameters.AddWithValue("@kuantitas", this.kuantitas);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
            try {
                Database.openConnection();
                cmd.ExecuteNonQuery();
                Database.closeConnection();
            }
            catch (Exception ex) {
                Database.closeConnection();
                throw new Exception(ex.Message);
            }
        }

        public void Delete() {
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE sale_detail_id = @id");
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
