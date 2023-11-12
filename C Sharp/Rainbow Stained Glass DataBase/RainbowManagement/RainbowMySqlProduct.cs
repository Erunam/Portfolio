using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace RainbowManagement
{
    class RainbowMySqlProduct
    {
        private string myConnectionString;
        private string Message = null;
        private MySqlConnection connection;
        public DataTable data = new DataTable();
        private MySqlDataAdapter da = new MySqlDataAdapter();
        // tylko do testów => MySqlCommandBuilder help
        private MySqlCommandBuilder cb;

        public RainbowMySqlProduct()
        {

        }
        public RainbowMySqlProduct(string ConnectionString)
        {
            this.connection = new MySqlConnection(ConnectionString);
        }
        public RainbowMySqlProduct(string Server, string Port, string Database, string User, string Password)
        {
            this.myConnectionString = String.Format(
                "Server={0}; Port={1}; Database={2}; User Id={3}; Password={4}; ",
                Server, Port, Database, User, Password );

            this.connection = new MySqlConnection(myConnectionString);
        }
        public string MessageText
        {
            get { return this.Message; }
        }
        public bool TestConnection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                this.Message = ex.Message;
                return false;
            }
        }
        public bool UpdateDatabase(DataTable changes)
        {
            da.Update(changes);
            return true;
        }
        public void UpdateDatabase()
        {
            // wg help dla MySqlDataAdapter
            DataTable changes = data.GetChanges();
            if (changes != null)
            {
                da.Update(changes);
                data.AcceptChanges();
            }
        }
        public void ParseQuery(string query)
        {
            da.SelectCommand = new MySqlCommand(query, connection);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
        }
        public DataTable GetData(string query)
        {
            data = null;
            da = null;
//            cb = null;
            da.SelectCommand = new MySqlCommand(query, connection);
            da.Fill(data);
            return data;
        }
    }
}
