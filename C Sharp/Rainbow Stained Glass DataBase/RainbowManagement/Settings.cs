using System;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            string connectionstring = String.Format(
                "Server={0}; Port={1}; Database={2}; User Id={3}; Password={4}; ",
                    textBox_ServerHost.Text, 
                    textBox_Port.Text, 
                    textBox_Database.Text,
                    textBox_UserName.Text,
                    textBox_Password.Text);
            MySqlConnection connection = new MySqlConnection(connectionstring);
            try
            {
                connection.Open();
                connection.Close();
                MessageBox.Show("Connection OK");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBox_Password.Text = Properties.Settings.Default.MySqlPassword;
            textBox_Port.Text = Properties.Settings.Default.MySqlPort;
            textBox_ServerHost.Text = Properties.Settings.Default.MySqlServer;
            textBox_UserName.Text = Properties.Settings.Default.MySqlUser;
            textBox_Database.Text = Properties.Settings.Default.MySqlDatabase;

            //ConnectionString.Text = Properties.Settings.Default.MySqlConnection;

            textBox_Elements.Text = Properties.Settings.Default.D_Elements.ToString();
            textBox_Solder.Text = Properties.Settings.Default.D_Solder.ToString();
            textBox_Perimeter.Text = Properties.Settings.Default.D_Perimeter.ToString();
            textBox_Grinded.Text = Properties.Settings.Default.D_Grinded.ToString();
            textBox_Area.Text = Properties.Settings.Default.D_Area.ToString();
            textBox_SolderPerCm.Text = Properties.Settings.Default.D_SolderPerCm.ToString();

            textBox_Profit.Text = Properties.Settings.Default.D_Profit.ToString();
            textBox_Warehouse.Text = Properties.Settings.Default.D_Warehouse.ToString();
            textBox_Vat.Text = Properties.Settings.Default.D_Vat.ToString();
        }

        private void button_SaveConnection_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MySqlServer = textBox_ServerHost.Text;
            Properties.Settings.Default.MySqlPort = textBox_Port.Text;
            Properties.Settings.Default.MySqlUser = textBox_UserName.Text;
            Properties.Settings.Default.MySqlPassword = textBox_Password.Text;
            Properties.Settings.Default.MySqlDatabase = textBox_Database.Text;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.MySqlConnection = String.Format(
                "Server={0}; Port={1}; Database={2}; User Id={3}; Password={4}; ",
                    textBox_ServerHost.Text, 
                    textBox_Port.Text, 
                    textBox_Database.Text,
                    textBox_UserName.Text,
                    textBox_Password.Text);
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.button_SaveConnection.PerformClick();
            this.set_WPSave.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.D_Elements = Convert.ToDouble(textBox_Elements.Text);
            Properties.Settings.Default.D_Solder = Convert.ToDouble(textBox_Solder.Text);
            Properties.Settings.Default.D_Perimeter = Convert.ToDouble(textBox_Perimeter.Text);
            Properties.Settings.Default.D_Grinded = Convert.ToDouble(textBox_Grinded.Text);
            Properties.Settings.Default.D_Area = Convert.ToDouble(textBox_Area.Text);
            Properties.Settings.Default.D_SolderPerCm = Convert.ToDouble(textBox_SolderPerCm.Text);

            Properties.Settings.Default.D_Profit = Convert.ToDouble(textBox_Profit.Text);
            Properties.Settings.Default.D_Warehouse = Convert.ToDouble(textBox_Warehouse.Text);
            Properties.Settings.Default.D_Vat = Convert.ToDouble(textBox_Vat.Text);


            Properties.Settings.Default.Save();
        }
    }
}
