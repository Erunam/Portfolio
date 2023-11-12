using System;
using System.Windows.Forms;

namespace RainbowStainedGlass
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
            RainbowConnectorMySQL rc = new RainbowConnectorMySQL(connectionstring);
            if (rc.CheckConnection()) { checkBox1.Checked = true; }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBox_Password.Text = Properties.Settings.Default.MySqlPassword;
            textBox_Port.Text = Properties.Settings.Default.MySqlPort;
            textBox_ServerHost.Text = Properties.Settings.Default.MySqlServer;
            textBox_UserName.Text = Properties.Settings.Default.MySqlUser;
            textBox_Database.Text = Properties.Settings.Default.MySqlDatabase;
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
        }
    }
}
