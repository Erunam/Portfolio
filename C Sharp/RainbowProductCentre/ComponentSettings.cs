using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace RainbowStainedGlass
{
    public partial class ComponentSettings : Form
    {
        public ComponentSettings()
        {
            InitializeComponent();
        }

        RainbowConnectorMySQL rc = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);
        RainbowConnectorMySQL slave = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);

        #region .   Obsługa zdarzeń

        private void tab_ComponentsPart_Leave(object sender, EventArgs e)
        {
            rc.Update();
        }
        private void tab_ComponentsPart_Enter(object sender, EventArgs e)
        {
            rc.SetDataSet("ComponentParts");
            rc.FillDataGrid(cs_ComponentParts, "ComponentParts");
        }
        private void tab_ComponentConfig_Enter(object sender, EventArgs e)
        {
            string[] tables = { "ProductParts", "ComponentParts", "ComponentAndPart"};

            rc.SetDataSet(tables);
            
            cs_ComponentPart.DataSource = rc.Data;
            cs_ComponentPart.DisplayMember = "ComponentParts.ComponentPart";
            cs_ComponentPart.ValueMember = "ComponentParts.ComponentPart";
            
            ArrayList combofill = rc.SetComboData(
                "ComponentAndPart",
                "CONCAT(ComponentName, '.', Attribute)",
                "ComponentID");
            combofill.Add(new ComboDataSet("", ""));

            cs_ComponentName.DataSource = combofill;
            cs_ComponentName.DisplayMember = "DisplayMember";
            cs_ComponentName.ValueMember = "ValueMember";

            cs_ProductPartList.DataSource = rc.Data;
            cs_ProductPartList.DisplayMember = "ProductParts.ProductPart";
            cs_ProductPartList.ValueMember = "ProductParts.ProductPart";
        }
        private void cs_ProductPartList_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = cs_ProductPartList.SelectedValue.ToString();
            if (s != "System.Data.DataViewManagerListItemTypeDescriptor"
                & s != "System.Data.DataRowView"
                & s != null)
            {
                SetSlaveGrid(s);
            }
        }

        #endregion

        #region .   Slave DataGrid
        // To trzeba przenieść do osobnej klasy
        private void cs_ConfigGrid_Leave(object sender, EventArgs e)
        {
            this.BindingContext[slave.Data, "ComponentConfiguration"].EndCurrentEdit();

            if (ValidateDetailsTable())
            {
                SaveDetailsTable("ComponentConfiguration", cs_ProductPartList.SelectedValue.ToString());
            }
            else
            {
                cs_ConfigGrid.Focus();
                cs_ConfigGrid.CurrentCell = cs_ConfigGrid[0, 0];
            }
        }
        private void SetSlaveGrid(string masterid)
        {
            cs_ConfigGrid.Rows.Clear();
            SetDetailsTable("ComponentConfiguration", masterid);
        }
        private void SetDetailsTable(string table, string key)
        {
            slave.SetDataSet(table, "ProductPart = '" + key + "'");
            
            foreach (DataRow row in slave.Data.Tables[table].Rows)
            {
                cs_ConfigGrid.Rows.Add(
                    row["ComponentPart"].ToString(),
                    row["ComponentID"].ToString());
            }
        }
        private void SaveDetailsTable(string table, string key)
        {
            GetDetailsTable(table, key);
            if (slave.Update())
            {
                //MessageBox.Show("Details saved");
            }
        }
        private void GetDetailsTable(string table, string key)
        {
            string query = "ProductPart = '" + key + "'";
            slave.DeleteDataSet(table, query);

            slave.Data.Tables[table].Columns["ProductPart"].DefaultValue = key;
            foreach (DataGridViewRow row in cs_ConfigGrid.Rows)
            {
                if (row.IsNewRow != true)
                {
                    DataRow r = slave.Data.Tables[table].NewRow();

                    r["ComponentPart"] = row.Cells["cs_ComponentPart"].Value;
                    r["ComponentID"] = row.Cells["cs_ComponentName"].Value;
                    
                    slave.Data.Tables[table].Rows.Add(r);
                }
            }
        }
        private bool ValidateDetailsTable()
        {
            bool validate = true;
            int num;
            foreach (DataGridViewRow row in cs_ConfigGrid.Rows)
            {
                if (row.IsNewRow != true)
                {
                    string a = Convert.ToString(row.Cells["cs_ComponentPart"].Value);
                    string b = Convert.ToString(row.Cells["cs_ComponentName"].Value);

                    bool n = int.TryParse(b, out num);

                    if (a == "")
                    {
                        return false;
                    }
                    else if (n != true)
                    {
                        row.Cells["cs_ComponentName"].Value = DBNull.Value;
                    }
                }
            }
            return validate;
        }
        #endregion

        private void cs_ConfigGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString() + "-" + e.Context.ToString());
        }
    }
}
