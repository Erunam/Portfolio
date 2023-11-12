using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RainbowStainedGlass
{
    public class RainbowConnectorMySQL
    {
        private MySqlConnection conn;
        public DataTable Data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;
        
        private string query;
        private ArrayList datacolumns = new ArrayList();
        
        public RainbowConnectorMySQL(string connection)
        {
            this.conn = new MySqlConnection(connection);
        }
        public bool CheckConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void SetDataSet(string tablequery)
        {
            this.Data = new DataTable();
            this.da = new MySqlDataAdapter("SELECT * FROM " + tablequery, conn);
            this.cb = new MySqlCommandBuilder(da);
            try
            {
                da.Fill(Data);
            }
            catch (System.Exception ex)
            {
                    MessageBox.Show("RainbowConnection.SetDataSet \n" + ex.Message);
            }
        }
        public void SetDataSet(string tablequery, string columns)
        {
            this.Data.Clear();
            this.Data = new DataTable();
            this.da = new MySqlDataAdapter("SELECT " + columns + " FROM " + tablequery, conn);
            this.cb = new MySqlCommandBuilder(da);
            da.Fill(Data);
        }
        public void SetPrimaryKey(string columnname)
        {
            DataColumn[] keys = new DataColumn[1];
            keys[0] = this.Data.Columns[columnname];
            this.Data.PrimaryKey = keys;
        }
        public int GetFirstEmptyID(string table, string column)
        {
            int i = 1;
            foreach (string val in GetValueForQuery(table, column))
            {
                if (val == i.ToString())
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }
            return 0;
        }
        public int GetFirstEmptyID(string column)
        {
            int i = 1;
            foreach (DataRow row in this.Data.Rows)
            {
                if (row[column].ToString() == i.ToString())
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }
            return i++;
        }
        public bool Update()
        {
            try
            {
                DataTable changes = Data.GetChanges();
                da.Update(changes);
                Data.AcceptChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                if (!ex.Message.Contains("Value cannot be null"))
                {
                    MessageBox.Show("No changes applied: \n\n" + ex.Message);
                    return false;
                }
                return false;
            }
        }
        public void Close()
        {
            conn.Close();
        }
        public void FillDataTable(DataGridView gridview, string table)
        {
            SetDataSet(table);
            gridview.DataSource = Data;
        }
        public void DeleteDataSet(string tablequery)
        {
            string query = "delete from " + tablequery;
            MySqlCommand myCommand = new MySqlCommand(query);
            myCommand.Connection = conn;
            conn.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            // ustawia pusty DataSet. łatwiejszy update/zapis
            SetDataSet(tablequery);
        }
        public ArrayList GetValueForQuery(string table, int column)
        {
            query = "Select * from " + table;
            return ExecuteReader(query, column);
        }
        public ArrayList GetValueForQuery(string table, string column)
        {
            query = "Select " + column + " from " + table;
            return ExecuteReader(query, 0);
        }
        public ArrayList GetValueForQuery(string table, string column, string condition)
        // execute query Select 'column' from 'table' wher 'condition'
        {
            query = "Select " + column + " from " + table + " where " + condition;
            return ExecuteReader(query, 0);
        }
        private ArrayList ExecuteReader(string query, int column)
        {
            ArrayList result = new ArrayList();

            result.Clear();
            MySqlCommand myCommand = new MySqlCommand(query, conn);
            
            conn.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                result.Add(myReader.GetString(column));
            }
            
            myReader.Close();
            conn.Close();
            return result;
        }
        public void GetDataGridProperties(DataGridView gridview)
        {
            datacolumns.Clear();

            foreach (DataGridViewColumn column in gridview.Columns)
            {
                string[] values = { column.Name, column.HeaderText, column.FillWeight.ToString() };
                datacolumns.Add(values);
            }
            foreach (string[] row in datacolumns)
            {
                gridview.Columns.Remove(row[0]);
            }
        }
        public void SetDataGridProperties(DataGridView gridview)
        {
            if (datacolumns != null)
            {
                foreach (string[] val in datacolumns)
                {
                    gridview.Columns[val[0]].HeaderText = val[1];
                    gridview.Columns[val[0]].FillWeight = Convert.ToSingle(val[2]);
                }
            }
        }
        public int GetRowIndexForId(DataGridView gridview, string idcolumn, int id)
        {
            foreach (DataGridViewRow r in gridview.Rows)
            {
                
                if (r.Cells[idcolumn].Value.ToString() == id.ToString())
                {
                    return r.Index;
                }
            }
            return 0;
        }
    }
}
