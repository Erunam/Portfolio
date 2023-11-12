using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//Delete  file

namespace RainbowStainedGlass
{
    public partial class Specifications : Form
    {
        public Specifications()
        {
            InitializeComponent();
        }

                private MySqlConnection conn =
                    new MySqlConnection(Properties.Settings.Default.MySqlConnection);
                private DataTable data = new DataTable();
                private MySqlDataAdapter da;
                private MySqlCommandBuilder cb;



        private ArrayList datacolumns = new ArrayList();

        #region Initialize controls

        private void FillDataTable(DataGridView gridview, string table)
        {
            data = new DataTable();
            //data.Clear();
            da = new MySqlDataAdapter("SELECT * FROM " + table, conn);
            cb = new MySqlCommandBuilder(da);

            da.Fill(data);
            gridview.DataSource = data;
        }
        private void GetColumnsProperties(DataGridView gridview)
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
        private void SetColumnsProperties(DataGridView gridview)
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
        private void SetComboData(ComboBox combo, string query)
        {
            DataTable combodata = new DataTable();
            MySqlDataAdapter cap = new MySqlDataAdapter(query, conn);
            cap.Fill(combodata);

            combo.Items.Clear();

            foreach (DataRow row in combodata.Rows)
            {
                combo.Items.Add(row.ItemArray[0]);
            }
        }

        # endregion

        #region Enter/Leave Tabs
        private void tabPage_Enter(object sender, EventArgs e)
        {
            string text = sender.ToString();
            switch (sender.ToString())
            {
                case "TabPage: {Products}":
                    FillDataTable(sp_Product, "ProductCategory");
                    break;
                case "TabPage: {Collections}":
                    FillDataTable(sp_Collections, "Collections");
                    break;
                case "TabPage: {Themes}":
                    FillDataTable(sp_Themes, "Themes");
                    break;
                case "TabPage: {Component Categories}":
                    FillDataTable(sp_ComponentsCategories, "ComponentCategory");
                    break;
                case "TabPage: {Part Classes}":
                    FillDataTable(sp_Parts, "MaterialClass");
                    break;
                case "TabPage: {Product Categories}":
                    SetComboData(sp_pc_Product, "select product from productcategory");
                    break;
                case "TabPage: {Product Subcategory}":
                    SetComboData(sp_ps_product, "select product from productcategory");
                    sp_ps_category.Items.Clear();
                    sp_ps_category.Text = null;
                    break;
                case "TabPage: {License}":
                    FillDataTable(sp_License, "License");
                    break;
                default:
                    break;
            }
        }
        private void sp_SpecyficationsTab_Enter(object sender, EventArgs e)
        {
            GetColumnsProperties(sp_Product);
            FillDataTable(sp_Product, "ProductCategory");
            SetColumnsProperties(sp_Product);

            GetColumnsProperties(sp_Collections);
            FillDataTable(sp_Collections, "Collections");
            SetColumnsProperties(sp_Collections);

            GetColumnsProperties(sp_Themes);
            FillDataTable(sp_Themes, "Themes");
            SetColumnsProperties(sp_Themes);

            GetColumnsProperties(sp_ComponentsCategories);
            FillDataTable(sp_ComponentsCategories, "ComponentCategory");
            SetColumnsProperties(sp_ComponentsCategories);

            GetColumnsProperties(sp_Parts);
            FillDataTable(sp_Parts, "MaterialClass");
            SetColumnsProperties(sp_Parts);

            GetColumnsProperties(sp_License);
            FillDataTable(sp_License, "License");
            SetColumnsProperties(sp_License);
        }
        private void tabPage_Leave(object sender, EventArgs e)
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
        #endregion

        private void FillProductCategories()
        {
            string selected = sp_pc_Product.Text;

            GetColumnsProperties(sp_Categories);
            FillDataTable(sp_Categories,
                "ProductCategories Where product = '" + selected + "'");

            sp_Categories.Columns["CategoryID"].Visible = false;
            sp_Categories.Columns["Product"].Visible = false;

            data.Columns["CategoryID"].AutoIncrement = true;
            data.Columns["Product"].DefaultValue = sp_pc_Product.Text;

            SetColumnsProperties(sp_Categories);
        }
        private void FillProductSubcategories()
        {
            string selectedp = sp_ps_product.Text;
            string selectedid = sp_ps_category.Tag.ToString();
            
            GetColumnsProperties(sp_Subcategories);

            FillDataTable(sp_Subcategories,
                "ProductSubcategories Where Product = '" + selectedp +
                                "' and CategoryID = '" + selectedid + "'");

            sp_Subcategories.Columns["SubcategoryID"].Visible = false;
            sp_Subcategories.Columns["CategoryID"].Visible = false;
            sp_Subcategories.Columns["Product"].Visible = false;

            data.Columns["SubcategoryID"].AutoIncrement = true;
            data.Columns["Product"].DefaultValue = sp_ps_product.Text;

            int te = Convert.ToInt32(sp_ps_category.Tag);
            data.Columns["CategoryID"].DefaultValue =
                Convert.ToInt32(sp_ps_category.Tag);

            SetColumnsProperties(sp_Subcategories);
        }

        private void sp_pc_Product_SelectedValueChanged(object sender, EventArgs e)
        {
            EventArgs en = new EventArgs();
            tabPage_Leave("SelectedValueChanged", en);
            FillProductCategories();
        }
        private void sp_ps_product_SelectedValueChanged(object sender, EventArgs e)
        {
            EventArgs en = new EventArgs();
            tabPage_Leave("SelectedValueChanged", en);
            
            string selected = sp_ps_product.Text;
            SetComboData(sp_ps_category, "select category from productcategories where product = '" + selected + "'");
            
            sp_ps_category.Text = null;
            sp_Subcategories.DataSource = null;
        }
        private void sp_ps_category_SelectedValueChanged(object sender, EventArgs e)
        {
            EventArgs en = new EventArgs();
            tabPage_Leave("SelectedValueChanged", en);

            string query = "select CategoryID from ProductCategories where Product = '";
            query += sp_ps_product.Text;
            query += "' and Category = '";
            query += sp_ps_category.Text;
            query += " '";
            
            DataTable id = new DataTable();
            MySqlDataAdapter ida = new MySqlDataAdapter(query, conn);
            ida.Fill(id);
            sp_ps_category.Tag = id.Rows[0].ItemArray[0].ToString();
            
            FillProductSubcategories();
        }
    }
}
