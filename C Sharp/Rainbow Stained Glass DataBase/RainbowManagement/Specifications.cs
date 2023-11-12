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

namespace RainbowManagement
{
    public partial class Specifications : Form
    {
        public Specifications()
        {
            InitializeComponent();
        }
        
        private MySqlConnection conn = 
            new MySqlConnection(Properties.Settings.Default.MySqlConnection);
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlCommandBuilder cb;
        
        private void tabPage_Product_Enter(object sender, EventArgs e)
        {
            data = new DataTable();
            da = new MySqlDataAdapter("SELECT * FROM ProductCategory", conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);
            sp_Product.DataSource = data;
        }

        private void sp_Product_DoubleClick(object sender, EventArgs e)
        {
            DataTable changes = data.GetChanges();
            da.Update(changes);
            data.AcceptChanges();
        }

/*
        Update Database from Table
        {
            DataTable changes = data.GetChanges();
            da.Update(changes);
            data.AcceptChanges();
        }
 */
    }
}
