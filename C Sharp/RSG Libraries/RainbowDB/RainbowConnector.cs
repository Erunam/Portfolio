using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RainbowStainedGlass
{
    public struct ComboDataSet
    {
        private string member, value;
        public ComboDataSet(string member, string value)
        {
            this.member = member;
            this.value = value;
        }
        public string DisplayMember { get {return this.member;}}
        public string ValueMember {get {return this.value;}}
    }

    public class RainbowConnectorMySQL
    {
        private MySqlConnection conn = new MySqlConnection();
        public DataSet Data = new DataSet();
        private MySqlCommand sc = new MySqlCommand();   // selectCommand
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private MySqlCommandBuilder cb = new MySqlCommandBuilder();

        private Dictionary<string, string> tsc = new Dictionary<string, string>();

        private string query;
        private ArrayList datacolumns = new ArrayList();
        
        public RainbowConnectorMySQL(string connection)
        {
            this.conn.ConnectionString = connection;
            this.sc.Connection = conn;
            this.da.SelectCommand = this.sc;
            this.da.SelectCommand.CommandType = CommandType.Text;
            this.cb.DataAdapter = this.da;
        }

        #region .   metody obsługi obiektu bazy

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
        public void CloseConnection()
        {
            conn.Close();
        }
        public void ResetDataSet()
        {
            this.Data = new DataSet();
            this.tsc.Clear();
        }
        public void SetDataSet(string table)
        {
            //this.Data = new DataSet();
            this.sc.CommandText = "SELECT * FROM " + table;
            da.Fill(Data, table);
            this.tsc.Add(table, sc.CommandText);
        }
        public void SetDataSet(string[] tables)
        {
            foreach (string table in tables)
            {
                SetDataSet(table);
            }
        }
        public void SetDataSet(string table, string condition)
        {
            this.Data = new DataSet();
            this.da = new MySqlDataAdapter("SELECT * FROM " + table + " WHERE " + condition, conn);
            this.cb = new MySqlCommandBuilder(da);
            this.da.TableMappings.Add("Table", table);
            da.Fill(Data);
        }
        public void DeleteDataSet(string table, string cond)
        {
            string query = "delete from " + table + " where " + cond;
            MySqlCommand myCommand = new MySqlCommand(query);
            myCommand.Connection = conn;
            
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            // ustawia pusty DataSet. łatwiejszy update/zapis
            SetDataSet(table, cond);
        }
        public void SetRelation(string relationname,
            string mastertable, string mastercolumn,
            string slavetable, string slavecolumn)
        {
            DataColumn MasterCol = this.Data.Tables[mastertable].Columns[mastercolumn];
            DataColumn SlaveCol = this.Data.Tables[slavetable].Columns[slavecolumn];
            DataRelation Relation = new DataRelation(relationname, MasterCol, SlaveCol);

            this.Data.Relations.Add(Relation);
        }
        public bool Update()
        {
            //from akadia
            DataSet changes = Data.GetChanges();
            bool okayFlag = false;

            if (changes != null)
            {
                // Test to make sure all the changed rows are without errors
                okayFlag = true;
                string message = "";
                if (changes.HasErrors)
                {
                    okayFlag = false;

                    // Examine each table in the changed DataSet
                    foreach (DataTable theTable in changes.Tables)
                    {
                        // If any table has errors, find out which rows
                        if (theTable.HasErrors)
                        {
                            // Get the rows with errors
                            DataRow[] errorRows = theTable.GetErrors();

                            // iterate through the errors and correct
                            foreach (DataRow theRow in errorRows)
                            {
                                message = message + theRow[0];
                            }
                        }
                    }
                    MessageBox.Show(message);
                }

                if (okayFlag)
                {
                    // Update the database
                    // check connection here
                    if (conn.State.ToString() == "Closed")
                    {
                        conn.Open();
                    }
                    da.Update(changes);
                    this.Data.AcceptChanges();
                }
                else
                {
                    // If we had errors, reject the changes
                    this.Data.RejectChanges();
                }
            }
            return okayFlag;
        }
        public void SetPrimaryKeys(string table, string[] columnname)
        {
            this.Data.Tables[table].PrimaryKey = null;

            int l = columnname.GetLength(0);
            int i = 0;
            DataColumn[] keys = new DataColumn[l];
            foreach (string column in columnname)
            {
                keys[i] = this.Data.Tables[table].Columns[column];
                i++;
            }
            this.Data.Tables[table].PrimaryKey = keys;
        }
        public int GetFirstID(string table, string column)
        {
            int i = 0;
            ArrayList sortedID = new ArrayList();

            foreach (DataRow row in this.Data.Tables[table].Rows)
            {
                sortedID.Add(int.Parse(row[column].ToString()));
            }
            do
            {
                i++;
            }
            while (sortedID.Contains(i));

            return i;
        }
        #endregion

        #region .   obsługa zapytań

        public ArrayList GetValueForQuery(string table, int column)
        //  execute query Select * from 'table'
        {
            query = "Select * from " + table;
            return ExecuteReader(query, column);
        }
        public ArrayList GetValueForQuery(string table, string column)
        //  execute query Select 'column' from 'table'
        {
            query = "Select " + column + " from " + table;
            return ExecuteReader(query, 0);
        }
        public ArrayList GetValueForQuery(string table, string column, string condition)
        //  execute query Select 'column' from 'table' where 'condition'
        {
            query = "Select " + column + " from " + table + " where " + condition;
            return ExecuteReader(query, 0);
        }
        private ArrayList ExecuteReader(string query, int column)
        //  execute 'query' and return single 'column' result as ArrayList
        {
            ArrayList result = new ArrayList();

            result.Clear();
            MySqlCommand myCommand = new MySqlCommand(query, conn);

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

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

        #endregion

        #region .   obsługa kontrolek

        public void FillComboBox(ComboBox combo, ArrayList datasource)
        {
            combo.DataSource = datasource;
            combo.DisplayMember = "DisplayMember";
            combo.ValueMember = "ValueMember";
        }       
        public ArrayList SetComboData(string table, string displaycolumn)
        {
            /* 
             * opcja 2: używamy ComboDataSet i teraz trzeba zwracać tablicę ComboDataSetów
             *      aby ustawić źródło trzeba przekazać do metody kontrolkę i tablicę,
             *      ewentualnie podłączyć kontrolkę w WindowsFormie.
             * Kontrolka z filtrem musi mieć przefiltrowaną tablice ComboDataSetów przed 
             * podłączeniem
             */
            ArrayList combolist = new ArrayList();
            foreach (string entry in GetValueForQuery(table, displaycolumn))
            {
                combolist.Add(new ComboDataSet(entry, entry));
            }
            return combolist;
        }
        public ArrayList SetComboData(string table, string display, string value)
        {
            ArrayList combolist = new ArrayList();
            ArrayList val = new ArrayList();
            foreach (string entry in GetValueForQuery(table, display))
            {
                val = GetValueForQuery(table, value,
                    display + " = '" + entry + "'");
                combolist.Add(new ComboDataSet(entry, val[0].ToString()));
            }
            return combolist;
        }
        public void FillDataGrid(DataGridView gridview, string table)
        {
            gridview.DataSource = this.Data;
            gridview.DataMember = table;
        }

        #endregion

        /*
        public void GetDataGridProperties(DataGridView gridview)
        {
            // do usunięcia
            this.datacolumns.Clear();

            foreach (DataGridViewColumn column in gridview.Columns)
            {
                string[] values = { column.Name, column.HeaderText, column.FillWeight.ToString() };
                this.datacolumns.Add(values);
            }
            foreach (string[] row in datacolumns)
            {
                gridview.Columns.Remove(row[0]);
            }
        }*/
        /*
        public void SetDataGridProperties(DataGridView gridview)
        {
            // do usunięcia
            if (this.datacolumns != null)
            {
                foreach (string[] val in this.datacolumns)
                {
                    gridview.Columns[val[0]].HeaderText = val[1];
                    gridview.Columns[val[0]].FillWeight = Convert.ToSingle(val[2]);
                }
            }
        }*/
        /*
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
        public void SetDataSet(string tablequery, string columns)
        {
            this.Data.Clear();
            this.Data = new DataSet();
            this.da = new MySqlDataAdapter("SELECT " + columns + " FROM " + tablequery, conn);
            this.cb = new MySqlCommandBuilder(da);
            da.Fill(Data);
        }*/
        /*
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
        }*/
        /*
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
        } */ 
    }
}
