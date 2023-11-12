using System;
using System.Windows.Forms;

namespace RainbowStainedGlass
{
    public partial class DesignSettings : Form
    {
        public DesignSettings()
        {
            InitializeComponent();
        }

        RainbowConnectorMySQL rc = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);

        private void tab_designsettings_Enter(object sender, EventArgs e)
        {
            string[] tables = { "License", "ManufacturingSettings"};
            rc.SetDataSet(tables);
        }
        private void tab_DesignSettings_Leave(object sender, EventArgs e)
        {
            rc.Update();
        }
        private void tab_license_Enter(object sender, EventArgs e)
        {
            rc.FillDataGrid(ds_License, "License");
        }
        private void tab_maunfacturing_Enter(object sender, EventArgs e)
        {
            rc.FillDataGrid(ds_Manufacturing, "ManufacturingSettings");
        }
        private void DesignSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            rc.Update();
        }
    }
}
