using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_pos.Class
{
    class Customer
    {
        private static string tableName = "customer";
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

        public Customer ID(int id) { this.id = id; return this; }
        public Customer Nama(string nama) { this.nama = nama; return this; }
        public Customer Alamat(string alamat) { this.alamat = alamat; return this; }
        public Customer KodePos(string kodePos) { this.kodePos = kodePos; return this; }
        public Customer NomorTelepon(string nomorTelepon) { this.nomorTelepon = nomorTelepon; return this; }
        public Customer Email(string email) { this.email = email; return this; }
        public Customer CreatedAt(DateTime createdAt) { this.createdAt = createdAt; return this; }
        public Customer UpdatedAt(DateTime updatedAt) { this.updatedAt = updatedAt; return this; }

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

        public static Customer SelectID(int id) {
            Database.openConnection();
            string selectString = String.Concat("SELECT * FORM ", tableName, " WHERE customer_id = @id");
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(selectString, Database.conn);
            DA.SelectCommand.Parameters.AddWithValue("@id", id);

            MySqlCommandBuilder CB = new MySqlCommandBuilder(DA);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Database.closeConnection();

            Customer customer = new Customer();
            if (DS.Tables[0].Rows.Count > 0) {
                DataRow DR = DS.Tables[0].Rows[0];
                customer.ID(Convert.ToInt32(DR["customer_id"]));
                customer.Nama(DR["nama"].ToString());
                customer.Alamat(DR["alamat"].ToString());
                customer.KodePos(DR["kode_pos"].ToString());
                customer.NomorTelepon(DR["nomor_telepon"].ToString());
                customer.Email(DR["email"].ToString());
                customer.CreatedAt(Convert.ToDateTime(DR["created_at"]));
                customer.UpdatedAt(Convert.ToDateTime(DR["updated_at"]));
                return customer;
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
                "nomor_Telepon = @nomorTelepon, email = @email, updated_at = @updatedAt WHERE customer_id = @id");

            MySqlCommand cmd = new MySqlCommand(updateString, Database.conn);
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

        public void Delete() {
            string deleteString = String.Concat("DELETE FROM ", tableName, " WHERE customer_id = @id");

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
