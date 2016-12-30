using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_pos.Class
{
    class Pembelian
    {
        private static string tableName = "purchase";
        private int id;
        private string kode;
        private Supplier supplier;
        private DateTime createdAt;
        private DateTime updatedAt;

        public int getID() { return this.id; }
        public string getKode() { return this.kode; }
        public Supplier getSupplier() { return this.supplier; }

        public Pembelian ID(int id) { this.id = id; return this; }
        public Pembelian Kode(string kode) { this.kode = kode; return this; }
        public Pembelian SetSupplier(Supplier supplier) { this.supplier = supplier; return this; }
        public Pembelian CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public Pembelian UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

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

        public static Pembelian SelectID(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE purchase_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            Pembelian pembelian = new Pembelian();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                pembelian.ID(Convert.ToInt32(DR["purchase_id"]));
                pembelian.Kode(DR["kode"].ToString());
                pembelian.SetSupplier(Supplier.SelectID(Convert.ToInt16(DR["supplier_id"])));
                pembelian.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                pembelian.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));

                return pembelian;
            }
            return null;
        }

        public static Pembelian SelectCode(string kode) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE kode = @kode");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@kode", kode);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            Pembelian pembelian = new Pembelian();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                pembelian.ID(Convert.ToInt32(DR["purchase_id"]));
                pembelian.Kode(DR["kode"].ToString());
                pembelian.SetSupplier(Supplier.SelectID(Convert.ToInt16(DR["supplier_id"])));
                pembelian.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                pembelian.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));

                return pembelian;
            }
            return null;
        }

        public void Insert() {
            string insertString = String.Concat("INSERT INTO ", tableName, 
                "(supplier_id, kode , created_at, updated_at)  VALUES (@supplierId, @kode, @created_at, @updated_at)");
            MySqlCommand cmd = new MySqlCommand(insertString, Database.conn);
            cmd.Parameters.AddWithValue("@supplierId", this.supplier.getID());
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
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
            string updateString = String.Concat("UPDATE ", tableName,
                " SET supplier_id = @supplierId, kode = @kode, updated_at = @updated_at WHERE purchase_id = @id");
            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn); 
            cmd.Parameters.AddWithValue("@supplierId", this.supplier.getID());
            cmd.Parameters.AddWithValue("@kode", this.kode);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
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
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE purchase_id = @id");
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
