using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace RainbowStainedGlass
{
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private RainbowConnectorMySQL componentdata;
        private RainbowConnectorMySQL slave = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);
        private RainbowSGComponent component = new RainbowSGComponent(Properties.Settings.Default.MySqlConnection);
        private CurrencyManager cm;
        int currentkey;
        private DataRow currentrow;

        #region .   metody Formy

        private void ClearControls()    // czyszczenie kontrolek
        {
            c_ID.Text = "";
            c_Name.Text = "";
            c_Attribute.Text = "";
            c_Group.Text = "";
            c_ProductPart.Text = "";
            c_Awp.Text = "";
            c_Cwp.Text = "";
            c_MC.Text = "";
            c_Description.Text = "";
        }
        private void BindControls()
        {
            c_ID.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.ComponentID");
            c_Name.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.ComponentName");
            c_Attribute.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.Attribute");
            c_Group.DataBindings.Add("SelectedValue", componentdata.Data, "ComponentAndPart.Group");
            c_ProductPart.DataBindings.Add("SelectedValue", componentdata.Data, "ComponentAndPart.ProductPart");
            c_Awp.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.AWP");
            c_Cwp.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.CWP");
            c_MC.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.MC");
            c_Description.DataBindings.Add("Text", componentdata.Data, "ComponentAndPart.Description");
        }
        private void ClearBindings()
        {
            c_ID.DataBindings.Clear();
            c_Name.DataBindings.Clear();
            c_Attribute.DataBindings.Clear();
            c_Group.DataBindings.Clear();
            c_ProductPart.DataBindings.Clear();
            c_Awp.DataBindings.Clear();
            c_Cwp.DataBindings.Clear();
            c_MC.DataBindings.Clear();
            c_Description.DataBindings.Clear();
        }

        #endregion
        
        #region .   Obsługa zdarzeń 

        private void Components_Activated(object sender, EventArgs e)
        {
            this.componentdata = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);

            ClearBindings();

            string[] tables = { "ComponentAndPart" };

            componentdata.SetDataSet(tables);
            componentdata.FillDataGrid(c_Components, "ComponentAndPart");

            //c_Components.DataSource = componentdata.Data;
            //c_Components.DataMember = "ComponentAndPart";

            //inicjacja combosa product part
            ArrayList productpart = componentdata.SetComboData("ProductParts", "ProductPart");
            componentdata.FillComboBox(c_ProductPart, productpart);

            // inicjacja combosa Group
            ComboDataSet[] group = {
                               new ComboDataSet("Component", "Component"), 
                               new ComboDataSet ("Part", "Part")
                           };
            c_Group.DataSource = group;
            c_Group.DisplayMember = "DisplayMember";
            c_Group.ValueMember = "ValueMember";
            
            // inicjacja combosa Component Part
            ArrayList componentpart = slave.SetComboData("ComponentParts", "ComponentPart");
            cd_ComponentPart.DataSource = componentpart;
            cd_ComponentPart.DisplayMember = "DisplayMember";
            cd_ComponentPart.ValueMember = "ValueMember";

            BindControls();

            this.cm = (CurrencyManager)this.BindingContext[componentdata.Data, "ComponentAndPart"];
            // TODO component ma 3 klucze
            string[] keys = { "ComponentName", "Attribute", "ProductName"};
            componentdata.SetPrimaryKeys("ComponentAndPart", keys);
        }
        private void c_Component_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (componentdata.Data.Tables["ComponentAndPart"].PrimaryKey.Length > 0)
            {
                this.currentkey = int.Parse(c_Components["ComponentID", e.RowIndex].Value.ToString());
                
                if (this.currentkey > 0)
                {
                    this.component.ClearParentTree();
                    this.component.SetParentTree(this.currentkey, 0, true);

                    if (c_Components["Group", e.RowIndex].Value.ToString() == "Component")
                    {
                        c_MC.Enabled = false;
                        c_CDetails.Enabled = true;
                        SetSlaveGrid(this.currentkey.ToString());
                    }
                    else
                    {
                        c_MC.Enabled = true;
                        c_CDetails.Rows.Clear();
                        c_CDetails.Enabled = false;
                    }
                }
            }
        }
        private void c_Components_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Main Table row error");
        }
        private void c_CDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Slave Table row error");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EventArgs ea = new EventArgs();
            Components_Activated(this, ea);
        }
        private void ds_prev_Click(object sender, EventArgs e)
        {
            if (this.cm.Position > 0)
            {
                this.cm.Position--;
            }
            c_Name.Focus();
        }
        private void ds_next_Click(object sender, EventArgs e)
        {
            if (this.cm.Position < this.cm.Count - 1)
            {
                this.cm.Position++;
            }
            c_Name.Focus();
        }
        private void c_MC_Leave(object sender, EventArgs e)
        {
            this.cm.EndCurrentEdit();

            this.component.ClearParentTree();
            this.component.SetParentTree(this.currentkey, 0, false);
            
            UpgradeComponents(this.currentkey.ToString());
        }
        private void Components_Leave(object sender, EventArgs e)
        {
            ComponentSave();
        }
        private void c_SaveDetails_Click(object sender, EventArgs e)
        {
            c_CDetails.EndEdit();

            if (ValidateDetailsTable())
            {
                SaveDetailsTable("ComponentDetails", this.currentkey.ToString());
                UpgradeComponents(this.currentkey.ToString());
            }
        }

        #endregion

        #region .   Obliczenia komponentów

        private void UpgradeComponents(string id)
        {
            string[] key = { "ComponentID" };
            componentdata.SetPrimaryKeys("ComponentAndPart", key);

            decimal[] costs = { 0, 0 };
            foreach (int cid in component.ParentTree)
            {
                costs = GetCosts(cid.ToString());

                DataRow foundRow = componentdata.Data.Tables["ComponentAndPart"].Rows.Find(cid);

                foundRow["MC"] = costs[0];
                foundRow["CWP"] = costs[1];
            }

            string[] keys = { "ComponentName", "Attribute", "ProductName" };
            componentdata.SetPrimaryKeys("ComponentAndPart", keys);
        }
        private decimal[] GetCosts(string id)
        {
            ArrayList cmpid = componentdata.GetValueForQuery("ComponentDetails", "PartID",
                "ComponentID = " + id);
            ArrayList cmpqty = componentdata.GetValueForQuery("ComponentDetails", "Quantity",
                "ComponentID = " + id);

            decimal mc = 0;
            decimal wp = 0;
            int i = 0;

            foreach (string cid in cmpid)
            {
                DataRow foundRow = componentdata.Data.Tables["ComponentAndPart"].Rows.Find(cid);

                mc += decimal.Parse(foundRow["MC"].ToString()) * decimal.Parse(cmpqty[i].ToString());
                wp += (
                    decimal.Parse(foundRow["CWP"].ToString()) +
                    decimal.Parse(foundRow["AWP"].ToString()) 
                    ) * decimal.Parse(cmpqty[i].ToString());

                i++;
            }

            decimal[] costs = {mc, wp};
            return costs;
        }
        
        #endregion

        #region .   Obsługa tabeli "Component Details"

        private bool ValidateDetailsTable()
        {
            bool validate = true;
            int num;
            foreach (DataGridViewRow row in c_CDetails.Rows)
            {
                if (row.IsNewRow != true)
                {
                    string a = Convert.ToString(row.Cells[0].Value);
                    string b = Convert.ToString(row.Cells[1].Value);
                    string c = Convert.ToString(row.Cells[2].Value);
                    bool n = int.TryParse(c, out num);
                    if (a == "" | b == "" | c == "")
                    {
                        return false;
                    }
                    else if (n != true)
                    {
                        return false;
                    }
                }
            }
            return validate;
        }
        private void SetSlaveGrid(string masterid)
        {
            c_CDetails.Rows.Clear();

            SetDetailsCombo(masterid);
            SetDetailsTable("ComponentDetails", masterid);
        }
        private void SetDetailsCombo(string masterid)
        {
            // inicjacja combosa PartID
            ArrayList partid = slave.SetComboData(
                "ComponentAndPart",
                "CONCAT(ComponentName, '.', Attribute)",
                "ComponentID");
            partid.Add(new ComboDataSet("", ""));

            if (int.Parse(masterid) >= 0)
            {
                foreach (int val in this.component.ParentTree)
                {
                    ComboDataSet cbs = new ComboDataSet(this.component.GetNameById(val), val.ToString());
                    partid.Remove(cbs);
                }
            }

            cd_PartID.DataSource = partid;
            cd_PartID.DisplayMember = "DisplayMember";
            cd_PartID.ValueMember = "ValueMember";
        }
        private void SetDetailsTable(string table, string key)
        {
            slave.SetDataSet(table, "ComponentID = '" + key + "'");

            foreach (DataRow row in slave.Data.Tables[table].Rows)
            {
                c_CDetails.Rows.Add(
                    row["ComponentPart"].ToString(),
                    row["PartID"].ToString(),
                    row["Quantity"].ToString());
            }
        }
        private void SaveDetailsTable(string table, string key)
        {
            string query = "ComponentID = '" + key + "'";
            
            slave.DeleteDataSet(table, query);

            slave.Data.Tables[table].Columns["ComponentID"].DefaultValue = key;

            foreach (DataGridViewRow row in c_CDetails.Rows)
            {
                if (row.IsNewRow != true)
                {
                    DataRow r = slave.Data.Tables[table].NewRow();

                    r["ComponentPart"] = row.Cells["cd_ComponentPart"].Value;
                    r["PartID"] = row.Cells["cd_PartID"].Value;
                    r["Quantity"] = row.Cells["cd_Quantity"].Value;

                    slave.Data.Tables[table].Rows.Add(r);
                }
            }

            slave.Update();
        }

        #endregion

        #region Metody dla Parent MDI
        
        public void ComponentSave()
        {
            this.cm.EndCurrentEdit();
            
            bool update = componentdata.Update();
            if (update)
            {
                MessageBox.Show("Data has been saved");
            }
        }
        public void ComponentDelete()
        {

        }
        public void ComponentCopy()
        {
            c_Components.EndEdit();
            c_CDetails.EndEdit();

            DataRowView row = (DataRowView)cm.Current;
            this.currentrow = row.Row;
        }
        public void ComponentPaste()
        {
            if (this.currentrow != null)
            {
                string table = this.currentrow.Table.TableName;
                string[] keys = {"", ""};
                DataRow foundRow = componentdata.Data.Tables[table].Rows.Find(keys);

                if (foundRow == null)
                {   
                    
                    
                    DataRow nr = componentdata.Data.Tables[table].NewRow();
                    nr.ItemArray = this.currentrow.ItemArray;
                    int id = componentdata.GetFirstID(table, "ComponentID");

                    nr["ComponentID"] = id;
                    nr["ComponentName"] = "";
                    nr["Attribute"] = "";

                    //paste details
                    RainbowConnectorMySQL paste = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);
                    paste.SetDataSet("ComponentDetails", "ComponentID = '" + this.currentkey.ToString() + "'");

                    foreach (DataRow row in slave.Data.Tables["ComponentDetails"].Rows)
                    {
                        DataRow dr = paste.Data.Tables["ComponentDetails"].NewRow();
                        dr.ItemArray = row.ItemArray;
                        dr["ComponentID"] = id;
                        paste.Data.Tables["ComponentDetails"].Rows.Add(dr);
                    }
                    //end details

                    componentdata.Data.Tables[table].Rows.Add(nr);
                    
                    componentdata.Update();
                    paste.Update();

                    cm.Position = componentdata.Data.Tables[table].Rows.IndexOf(nr);
                }
                else
                {
                    cm.Position = componentdata.Data.Tables[table].Rows.IndexOf(this.currentrow);
                }
            }
        }
        public void ComponentNew()
        {
            string table = "ComponentAndPart";
            string[] keys = { "", "" };

            DataRow foundRow = componentdata.Data.Tables[table].Rows.Find(keys);

            if (foundRow == null)
            {
                DataRow nr = componentdata.Data.Tables[table].NewRow();

                DataRowView r = (DataRowView)this.cm.Current;

                nr["ComponentID"] = componentdata.GetFirstID(table, "ComponentID");
                nr["ProductPart"] = r["ProductPart"];
                nr["ComponentName"] = "";
                nr["Attribute"] = "";
                nr["Group"] = "Component";
                nr["AWP"] = 0;
                nr["CWP"] = 0;
                nr["MC"] = 0;
                nr["Description"] = "";

                componentdata.Data.Tables[table].Rows.Add(nr);

                componentdata.Update();

                cm.Position = componentdata.Data.Tables[table].Rows.IndexOf(nr);
            }
        }

        #endregion

        private void c_CDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // e daje column index, row index;
            if (e.ColumnIndex == 0)
            {
                RSGRules rules = new RSGRules(Properties.Settings.Default.MySqlConnection);

                decimal output = rules.GetCalculation(
                    c_CDetails[e.ColumnIndex, e.RowIndex].Value.ToString(),
                    c_Components.CurrentRow.Cells["ProductPart"].Value.ToString(), 
                    c_Components.CurrentRow.Cells["ComponentName"].Value.ToString() + 
                    "." + 
                    c_Components.CurrentRow.Cells["Attribute"].Value.ToString());
            }
        }

    }
}
