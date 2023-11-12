using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
// Delete file

namespace RainbowStainedGlass
{
    public partial class Configurations : Form
    {

        public Configurations()
        {
            InitializeComponent();
        }
        private SortedList TranslactionTable = new SortedList();
        private MySqlConnection conn =
            new MySqlConnection(Properties.Settings.Default.MySqlConnection);
        private DataTable data = new DataTable();
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;

        #region Initialise Controls

        private void SetTable(DataGridView table)
        {
            string componentid = "";
            foreach (DataRow row in data.Rows)
            {
                if (row["ComponentID"].ToString() != "")
                {
                    int index = TranslactionTable.IndexOfValue(row[4]);
                    componentid = TranslactionTable.GetKey(index).ToString();
                }
                else
                {
                    componentid = "";
                }
                table.Rows.Add(row["ComponentCategory"].ToString(), componentid);
            }
        }
        private void SetComponentTable(DataGridView table)
        {
            string componentid = "";
            foreach (DataRow row in data.Rows)
            {
                if (row["ComponentID"].ToString() != "")
                {
                    int index = TranslactionTable.IndexOfValue(row["ComponentID"]);
                    componentid = TranslactionTable.GetKey(index).ToString();
                }
                else
                {
                    componentid = "";
                }
                table.Rows.Add(row["PartClass"].ToString(), componentid);
            }
        }
        private void GetTable(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.IsNewRow != true)
                {
                    DataRow insrow = data.NewRow();
                    string ccategory = Convert.ToString(row.Cells[0].Value);
                    string component = Convert.ToString(row.Cells[1].Value);

                    if (component != "")
                    {
                        string index = TranslactionTable[component].ToString();
                        insrow["ComponentID"] = Convert.ToInt32(index);
                    }
                    insrow["ComponentCategory"] = ccategory;

                    data.Rows.Add(insrow);
                }
            }
        }
        private void GetComponentTable(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.IsNewRow != true)
                {
                    DataRow insrow = data.NewRow();
                    string pclass = Convert.ToString(row.Cells[0].Value);
                    string component = Convert.ToString(row.Cells[1].Value);

                    if (component != "")
                    {
                        string index = TranslactionTable[component].ToString();
                        insrow["ComponentID"] = Convert.ToInt32(index);
                    }
                    insrow["PartClass"] = pclass;

                    data.Rows.Add(insrow);
                }
            }
        }
        private void ReloadDataTable(string table)
        {
            string query = "delete from " + table;
            MySqlCommand myCommand = new MySqlCommand(query);
            myCommand.Connection = conn;
            conn.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            FillDataTable(table);
        }
        private void FillDataTable(string table)
        {
            data = new DataTable();
            //data.Clear();
            da = new MySqlDataAdapter("SELECT * FROM " + table, conn);
            cb = new MySqlCommandBuilder(da);

            da.Fill(data);
        }
        private void UpdateDataTable()
        {
            try
            {
                DataTable changes = data.GetChanges();
                da.Update(changes);
                data.AcceptChanges();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetComboData(ComboBox combo, string query)
        {
            DataTable combodata = new DataTable();
            MySqlDataAdapter cap = new MySqlDataAdapter(query, conn);
            cap.Fill(combodata);

            combo.Items.Clear();

            foreach (DataRow row in combodata.Rows)
            {
                combo.Items.Add(row.ItemArray[0].ToString());
            }
        }
        private void SetComboData(DataGridViewComboBoxColumn combo, string query)
        {
            DataTable combodata = new DataTable();
            MySqlDataAdapter cap = new MySqlDataAdapter(query, conn);
            cap.Fill(combodata);

            combo.Items.Clear();

            foreach (DataRow row in combodata.Rows)
            {
                string val = row.ItemArray[0].ToString();
                combo.Items.Add(row.ItemArray[0].ToString());
            }
        }
        private int GetIndexForControl(string query)
        {
            DataTable id = new DataTable();
            MySqlDataAdapter ida = new MySqlDataAdapter(query, conn);
            ida.Fill(id);
            return Convert.ToInt32(id.Rows[0].ItemArray[0]);
        }
        private void SetTranslationTable(string query)
        {
            TranslactionTable.Clear();

            DataTable transdata = new DataTable();
            MySqlDataAdapter cap = new MySqlDataAdapter(query, conn);
            cap.Fill(transdata);

            foreach (DataRow row in transdata.Rows)
            {
                TranslactionTable.Add(row[0] , row[1]);
            }
        }
        #endregion
        #region Product Configuration
        private void tabPage_Product_Enter(object sender, EventArgs e)
        {
            SetComboData(cbt_ProductComponent, "select ComponentCategory from ComponentCategory");
            SetComboData(cbt_ProductPartID, "select concat(ComponentName, '.' , Attribute) as component from ComponentAndPart");
            
            SetTranslationTable("select concat(ComponentName, '.' , Attribute) as component, ComponentID from ComponentAndPart");
            
            cb_Product.Items.Clear();
            cb_Product.Text = null;
            cb_Category.Items.Clear();
            cb_Category.Text = null;
            cb_Subcategory.Items.Clear();
            cb_Subcategory.Text = null;
            cbt_Product.Rows.Clear();
            data = null;

            SetComboData(cb_Product, "select product from productcategory");
        }
        private void cb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Category.Items.Clear();
            cb_Category.Tag = null;
            cb_Category.Text = null;
            cb_Subcategory.Items.Clear();
            cb_Subcategory.Text = null;
            cb_Subcategory.Tag = null;
            cbt_Product.Rows.Clear();
            data = null;

            SetComboData(cb_Category, "select category from productcategories where product = '"
                + cb_Product.Text + "'");
        }
        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Product.Text != "")
            {

                cb_Subcategory.Items.Clear();
                cb_Subcategory.Text = null;
                cb_Subcategory.Tag = null;
                cbt_Product.Rows.Clear();
                data = null;

                cb_Category.Tag = GetIndexForControl(
                    "select CategoryID from ProductCategories where product = '"
                    + cb_Product.Text + " ' and Category = '"
                    + cb_Category.Text + " '");

                SetComboData(cb_Subcategory, "select Subcategory from ProductSubcategories where Product = '"
                    + cb_Product.Text + " ' and CategoryID = '"
                    + cb_Category.Tag.ToString() + " '");
            }
        }
        private void cb_Subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Product.Text != "")
            {
                cbt_Product.Rows.Clear();
                data = null;

                cb_Subcategory.Tag = GetIndexForControl(
                    "select SubCategoryID from ProductSubCategories where product = '"
                    + cb_Product.Text + " ' and CategoryID = '"
                    + cb_Category.Tag.ToString() + " ' and Subcategory = '"
                    + cb_Subcategory.Text + " '");

                FillDataTable("ProductConfiguration where Product = '"
                    + cb_Product.Text + " ' and ProductCategory = '"
                    + cb_Category.Tag.ToString() + " ' and ProductSubcategory = '"
                    + cb_Subcategory.Tag.ToString() + " '");

                data.Columns["Product"].DefaultValue = cb_Product.Text;
                data.Columns["ProductCategory"].DefaultValue = (int)cb_Category.Tag;
                data.Columns["ProductSubcategory"].DefaultValue = (int)cb_Subcategory.Tag;

                SetTable(cbt_Product);
            }
        }
        private void cb_ProductSave_Click(object sender, EventArgs e)
        {
            if (cb_Product.Text != "" & cb_Category.Tag != null & cb_Subcategory.Tag !=null)
            {
                string query = "ProductConfiguration where product = '" +
                    cb_Product.Text + "' and ProductCategory = '" +
                    cb_Category.Tag.ToString() + "' and ProductSubcategory = '" +
                    cb_Subcategory.Tag.ToString() + "'";
    
                ReloadDataTable(query);
    
                data.Columns["Product"].DefaultValue = cb_Product.Text;
                data.Columns["ProductCategory"].DefaultValue = (int)cb_Category.Tag;
                data.Columns["ProductSubcategory"].DefaultValue = (int)cb_Subcategory.Tag;
                
                GetTable(cbt_Product);
                UpdateDataTable();
            }
        }
        private void tabPage_Product_Leave(object sender, EventArgs e)
        {
            cbt_Product.Rows.Clear();
            data = null;
        }

        #endregion

        #region Component Configuration
        private void tabPage_Component_Enter(object sender, EventArgs e)
        {
            SetComboData(cbt_ComponentPart, "select PartClass from MaterialClass");
            SetComboData(cbt_ComponentMaterial, "select concat(ComponentName, '.' , Attribute) as component from ComponentAndPart");

            SetTranslationTable("select concat(ComponentName, '.' , Attribute) as component, ComponentID from ComponentAndPart");

            cb_Component.Items.Clear();
            cb_Component.Text = null;

            data = null;

            SetComboData(cb_Component, "select ComponentCategory from ComponentCategory");
        }
        private void cb_Component_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbt_Component.Rows.Clear();
            data = null;

            FillDataTable("ComponentConfiguration where ComponentCategory = '"
                + cb_Component.Text + "'");

            data.Columns["ComponentCategory"].DefaultValue = cb_Component.Text;

            SetComponentTable(cbt_Component);
        }
        private void cb_ComponentSave_Click(object sender, EventArgs e)
        {
            if (cb_Component.Text != "")
            {
                string query = "ComponentConfiguration where ComponentCategory = '"
                    + cb_Component.Text + "'";

                ReloadDataTable(query);

                data.Columns["ComponentCategory"].DefaultValue = cb_Component.Text;

                GetComponentTable(cbt_Component);
                UpdateDataTable();
            }
        }
        private void tabPage_Component_Leave(object sender, EventArgs e)
        {
            cbt_Product.Rows.Clear();
            data = null;
        }
        #endregion
    }
}
