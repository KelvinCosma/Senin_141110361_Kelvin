using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Latihan_pos.Class
{
    class Supplier
    {
        private static string tableName = "supplier";
        public int id { private set; get; }
        public string nama { private set; get; }
        public string alamat { private set; get; }
        public string kodePos { private set; get; }
        public string nomorTelepon { private set; get; }
        public string email { private set; get; }
        public DateTime createdAt { private set; get; }
        public DateTime updatedAt { private set; get; }

        public int getID() { return this.id; }
        public string getEmail() { return this.email; }

        public Supplier ID(int id) { this.id = id; return this; }
        public Supplier Nama(string nama) { this.nama = nama; return this; }
        public Supplier Alamat(string alamat) { this.alamat = alamat; return this; }
        public Supplier KodePos(string kodePos) { this.kodePos = kodePos; return this; }
        public Supplier NomorTelepon(string nomorTelepon) { this.nomorTelepon = nomorTelepon; return this; }
        public Supplier Email(string email) { this.email = email; return this; }
        public Supplier CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public Supplier UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

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

        public static Supplier SelectID(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FROM ", tableName, " WHERE supplier_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            Supplier supplier = new Supplier();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                supplier.ID(Convert.ToInt32(DR["supplier_id"]));
                supplier.Nama(DR["nama"].ToString());
                supplier.Alamat(DR["alamat"].ToString());
                supplier.KodePos(DR["kode_pos"].ToString());
                supplier.NomorTelepon(DR["nomor_telepon"].ToString());
                supplier.Email(DR["email"].ToString());
                supplier.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                supplier.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return supplier;
            }

            return null;
        }

        public void Insert() {
            string insertString = String.Concat("INSERT INTO ", tableName,
                " (nama, alamat, kode_pos, nomor_telepon, email, created_at, updated_at)",
                " VALUES (@nama, @alamat, @kodePos, @nomorTelepon, @email, @createdAt, @updatedAt)");
            MySqlCommand cmd = new MySqlCommand(insertString, Database.conn);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@kodePos", kodePos);
            cmd.Parameters.AddWithValue("@nomorTelepon", nomorTelepon);
            cmd.Parameters.AddWithValue("@email", email);
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
                " SET nama = @nama, alamat = @alamat, kode_pos = @kodePos, ",
                "nomor_telepon = @nomorTelepon, email = @email, updated_at = @updatedAt WHERE supplier_id = @id");
            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@kodePos", kodePos);
            cmd.Parameters.AddWithValue("@nomorTelepon", nomorTelepon);
            cmd.Parameters.AddWithValue("@email", email);
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
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE supplier_id = @id");
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
