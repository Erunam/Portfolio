using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RainbowManagement
{
    public partial class Design : Form
    {
        public Design()
        {
            InitializeComponent();
        }
        private RainbowConnectorMySQL rc = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);
        private RainbowSGDesign des = new RainbowSGDesign();
        private static RainbowParameters calcpar = new RainbowParameters(Properties.Settings.Default.MySqlConnection);
        private RainbowDesignCalc dcalc = new RainbowDesignCalc(calcpar);

        private void ClearControls()
        {
            ds_Name.Text = "";
            ds_Size.Text = "";
            ds_Width.Text = "";
            ds_Height.Text = "";
            ds_Elements.Text = "";
            ds_Perimeter.Text = "";
            ds_Solder.Text = "";
            ds_Area.Text = "";
            ds_Grinded.Text = "";
            ds_Scrap.Text = "";
            ds_Author.Text = "";
            ds_License.Text = "";
            ds_EnteredBy.Text = "";
            ds_DateEnter.Text = "";
            ds_Comments.Text = "";
            ds_Image.ImageLocation = "";


        }

        private void Designs_Activated(object sender, EventArgs e)
        {
            ClearControls();
            rc.GetDataGridProperties(ds_Designs);
            rc.FillDataTable(ds_Designs, "StainedGlassDesign");
            rc.SetDataGridProperties(ds_Designs);

            object[] lic = (Object[])
                rc.GetValueForQuery("License", "License").ToArray(typeof(object));
            ds_License.Items.AddRange(lic);
            ds_License.SelectedText = "Deviated";
        }

    }
}
