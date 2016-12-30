using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_pos.Class
{
    class DetailPembelian
    {
        private static string tableName = "purchase_detail";
        private int id;
        private Pembelian pembelian;
        private Barang barang;
        private decimal hargaBarang;
        private int kuantitas;
        private DateTime createdAt;
        private DateTime updatedAt;

        public int getID() { return this.id; }
        public Pembelian getPembelian() { return this.pembelian; }
        public Barang getBarang() { return this.barang; }
        public decimal getHargaBarang() { return this.hargaBarang; }
        public int getKuantitas() { return this.kuantitas; }

        public DetailPembelian ID(int id) { this.id = id; return this; }
        public DetailPembelian SetPembelian(Pembelian pembelian) { this.pembelian = pembelian; return this; }
        public DetailPembelian SetBarang(Barang barang) { this.barang = barang; return this; }
        public DetailPembelian HargaBarang(decimal hargaBarang) { this.hargaBarang = hargaBarang; return this; }
        public DetailPembelian Kuantitas(int kuantitas) { this.kuantitas = kuantitas; return this; }
        public DetailPembelian CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public DetailPembelian UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

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

        public static DataTable SelectByPurchaseId(int purchaseId) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE purchase_id = @purchaseId");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@purchaseId", purchaseId);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DataTable DT = DS.Tables[0].Clone();
            foreach (DataColumn DC in DT.Columns) { DC.DataType = typeof(string); }
            foreach (DataRow row in DS.Tables[0].Rows) { DT.ImportRow(row); }
            return DT;
        }

        public static DetailPembelian SelectById(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE purchase_detail_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DetailPembelian detailPembelian = new DetailPembelian();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                detailPembelian.ID(Convert.ToInt32(DR["purchase_detail_id"]));
                detailPembelian.SetPembelian(Pembelian.SelectID(Convert.ToInt32(DR["purchase_id"])));
                detailPembelian.SetBarang(Barang.SelectID(Convert.ToInt32(DR["barang_id"])));
                detailPembelian.Kuantitas(Convert.ToInt32(DR["kuantitas"]));
                detailPembelian.HargaBarang(Convert.ToDecimal(DR["harga_barang"]));
                detailPembelian.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                detailPembelian.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return detailPembelian;
            }
            return null;
        }

        public static DetailPembelian SelectByProductIdAndPurchaseId(int barangId, int purchaseId) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE barang_id = @barangId AND purchase_id = @purchaseId");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@barangId", barangId);
            DA.SelectCommand.Parameters.AddWithValue("@purchaseId", purchaseId);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            DetailPembelian detailPembelian = new DetailPembelian();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                detailPembelian.ID(Convert.ToInt32(DR["purchase_detail_id"]));
                detailPembelian.SetPembelian(Pembelian.SelectID(Convert.ToInt32(DR["purchase_id"])));
                detailPembelian.SetBarang(Barang.SelectID(Convert.ToInt32(DR["barang_id"])));
                detailPembelian.Kuantitas(Convert.ToInt32(DR["kuantitas"]));
                detailPembelian.HargaBarang(Convert.ToDecimal(DR["harga_barang"]));
                detailPembelian.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                detailPembelian.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return detailPembelian;
            }
            return null;
        }

        public void Insert() {
            string insertString = String.Concat("INSERT INTO ", tableName, 
                "(purchase_id, barang_id, harga_barang, kuantitas, created_at, updated_at) ", 
                "VALUES (@purchaseId, @barangId, @hargaBarang, @kuantitas, @createdAt, @updatedAt)");
            MySqlCommand cmd = new MySqlCommand(insertString, Database.conn);
            cmd.Parameters.AddWithValue("@purchaseId", this.pembelian.getID());
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
                " SET purchase_id = @purchaseId, barang_id = @barangId, harga_barang = @hargaBarang, " +
                "kuantitas = @kuantitas, updated_at = @updatedAt WHERE purchase_detail_id = @id");
            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn);
            cmd.Parameters.AddWithValue("@purchaseId", this.pembelian.getID());
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
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE purchase_detail_id = @id");
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
