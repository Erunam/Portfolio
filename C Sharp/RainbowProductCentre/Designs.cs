using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace RainbowStainedGlass
{
    public partial class Designs : Form
    {
        public Designs()
        {
            InitializeComponent();
        }

        private RainbowConnectorMySQL rc;
        private CurrencyManager cm; // potrzebny do synchronizacji kontrolek
        private RSGFileImport desimport;
        private RainbowParameters rsgpar = new RainbowParameters(Properties.Settings.Default.MySqlConnection);
        private DataRow currentrow;

        #region .   metody Formy

        private void ClearControls()    // czyszczenie kontrolek
        {
            ds_DesignID.Text = "";
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
        private void BindControls()
        {
            ds_DesignID.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DesignID");
            ds_Name.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DesignName");
            ds_Size.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DesignSize");
            ds_Width.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DesignWidth");
            ds_Height.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DesignHeight");
            ds_Elements.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.TotalElements");
            ds_Perimeter.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.TotalPerimeter");
            ds_Solder.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.SolderLine");
            ds_Area.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.TotalArea");
            ds_Grinded.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.GrindedPerimeter");
            ds_Scrap.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.ScrapFactor");
            ds_WP.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.AWP");
            ds_Author.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.Author");
            ds_License.DataBindings.Add("SelectedValue", rc.Data, "StainedGlassDesign.License");
            ds_EnteredBy.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.EnteredBy");
            ds_DateEnter.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.DateEnter");
            ds_Comments.DataBindings.Add("Text", rc.Data, "StainedGlassDesign.Comments");
        }
        private void ClearBindings()
        {
            ds_DesignID.DataBindings.Clear();
            ds_Name.DataBindings.Clear();
            ds_Size.DataBindings.Clear();
            ds_Width.DataBindings.Clear();
            ds_Height.DataBindings.Clear();
            ds_Elements.DataBindings.Clear();
            ds_Perimeter.DataBindings.Clear();
            ds_Solder.DataBindings.Clear();
            ds_Area.DataBindings.Clear();
            ds_Grinded.DataBindings.Clear();
            ds_Scrap.DataBindings.Clear();
            ds_WP.DataBindings.Clear();
            ds_Author.DataBindings.Clear();
            ds_License.DataBindings.Clear();
            ds_EnteredBy.DataBindings.Clear();
            ds_DateEnter.DataBindings.Clear();
            ds_Comments.DataBindings.Clear();
        }
        private void SetProgressBar(int max)
        {
            this.ds_Progress.Visible = true;
            this.ds_Progress.Minimum = 1;
            this.ds_Progress.Maximum = max;
            this.ds_Progress.Value = 1;
            this.ds_Progress.Step = 1;
        }

        #endregion

        #region .   metody programu

        private void UpdateWP()         // oblicza WP
        {
            //ustawienie parametrów wzoru
            decimal[] despar = {
                                   decimal.Parse(ds_Elements.Text), 
                                   decimal.Parse(ds_Perimeter.Text),
                                   decimal.Parse(ds_Solder.Text),
                                   decimal.Parse(ds_Area.Text),
                                   decimal.Parse(ds_Grinded.Text),
                                  };

            RainbowSGDesign design = new RainbowSGDesign(despar, rsgpar);

            ds_WP.Text = design.WP.ToString();
        }
        
        #endregion

        #region .   Obsługa zdarzeń
        
        private void Designs_Activated(object sender, EventArgs e)  
        {
            this.rc = new RainbowConnectorMySQL(Properties.Settings.Default.MySqlConnection);

            ClearBindings();

            rc.SetDataSet("StainedGlassDesign");
            rc.FillDataGrid(ds_Designs, "StainedGlassDesign");
            
            //inicjacja combosa
            ArrayList cd = rc.SetComboData("License", "License");
            rc.FillComboBox(ds_License, cd);

            BindControls();
            
            this.cm = (CurrencyManager)this.BindingContext[rc.Data, "StainedGlassDesign"];
            
            string[] keys = { "DesignName","DesignSize" };
            rc.SetPrimaryKeys("StainedGlassDesign", keys);
        }
        private void Controls_Leave(object sender, EventArgs e) // akcja po opuszczeniu kontrolek
        {
            UpdateWP();
        }
        private void Designs_Leave(object sender, EventArgs e)
        {
            DesignSave();
        }
        private void ds_License_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ds_License.Items.Contains(ds_License.Text))
            {
                ds_License.Text = "";
                ds_License.SelectedItem = ds_License.Items[ds_License.Items.Count - 1];
            }
        }
        private void ds_next_Click(object sender, EventArgs e)
        {
            if (this.cm.Position < this.cm.Count - 1)
            {
                this.cm.Position++;
            }
            ds_Name.Focus();
        }
        private void ds_prev_Click(object sender, EventArgs e)
        {
            if (this.cm.Position > 0)
            {
                this.cm.Position--;
            }
            ds_Name.Focus();
        }
        private void ds_Load_Click(object sender, EventArgs e)
        {
            this.desimport = new RSGFileImport();
            openFileDialog.InitialDirectory = Properties.Settings.Default.LastDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filelist = openFileDialog.FileNames;

                Properties.Settings.Default.LastDirectory = 
                    filelist[0].Substring(0,filelist[0].LastIndexOf(@"\"));

                SetProgressBar(filelist.Length);

                foreach (string file in filelist)
                {
                    DataRow nr = rc.Data.Tables["StainedGlassDesign"].NewRow();

                    nr = this.desimport.ImportDesign(file, nr);
                    if (nr != null)
                    {
                        //oblicza WP
                        decimal[] despar = {
                                               decimal.Parse(nr["TotalElements"].ToString()),
                                               decimal.Parse(nr["TotalPerimeter"].ToString()),
                                               decimal.Parse(nr["SolderLine"].ToString()),
                                               decimal.Parse(nr["TotalArea"].ToString()),
                                               decimal.Parse(nr["GrindedPerimeter"].ToString())};

                        RainbowSGDesign design = new RainbowSGDesign(despar, rsgpar);
                        nr["AWP"] = design.WP.ToString();

                        string[] s = {  nr["DesignName"].ToString(),
                                    nr["DesignSize"].ToString()
                                 };
                        DataRow foundRow = rc.Data.Tables["StainedGlassDesign"].Rows.Find(s);

                        if (foundRow != null)
                        {
                            nr["DesignID"] = foundRow["DesignID"];
                            nr["License"] = foundRow["License"];
                            foundRow.ItemArray = nr.ItemArray;
                        }
                        else
                        {
                            nr["DesignID"] = rc.GetFirstID(nr.Table.TableName, "DesignID");
                            rc.Data.Tables[nr.Table.TableName].Rows.Add(nr);
                        }
                        ds_Progress.PerformStep();
                    }
                    else
                    {
                        MessageBox.Show("Error in file: \n" + file);
                    }
                }
            }
        }
        private void ds_Refresh_Click(object sender, EventArgs e)
        {
            EventArgs ea = new EventArgs();
            Designs_Activated(this, ea);
        }
        
        #endregion
        
        #region .   Metody dla Parent MDI
        
        public void DesignSave()
        {
            int pos = cm.Position;

            this.cm.EndCurrentEdit();

            bool update = rc.Update();
            if (update)
            {
                MessageBox.Show("Data has been saved");
            }

            this.cm.Position = pos;
        }
        public void DesignCopy()
        {
            DataRowView row = (DataRowView)cm.Current;
            this.currentrow = row.Row;
        }
        public void DesignPaste()
        {
            if (this.currentrow != null)
            {
                string table = this.currentrow.Table.TableName;
                string[] keys = {"", ""};
                DataRow foundRow = rc.Data.Tables[table].Rows.Find(keys);

                if (foundRow == null)
                {
                    DataRow nr = rc.Data.Tables[table].NewRow();
                    nr.ItemArray = this.currentrow.ItemArray;
                    int id = rc.GetFirstID(table, "DesignID");

                    nr["DesignID"] = id;
                    nr["DesignName"] = "";
                    nr["DesignSize"] = "";

                    rc.Data.Tables[table].Rows.Add(nr);

                    cm.Position = rc.Data.Tables[table].Rows.IndexOf(nr);
                }
                else
                {
                    cm.Position = rc.Data.Tables[table].Rows.IndexOf(this.currentrow);
                }
            }   
        }
        public void DesignNew()
        {
            string table = "StainedGlassDesign";
            string[] keys = {"", ""};
            
            DataRow foundRow = rc.Data.Tables["StainedGlassDesign"].Rows.Find(keys);

            if (foundRow == null)
            {
                DataRow nr = rc.Data.Tables[table].NewRow();

                nr["DesignID"] = rc.GetFirstID(table, "DesignID");
                nr["DesignName"] = "";
                nr["DesignSize"] = "";
                nr["TotalElements"] = 0;
                nr["TotalPerimeter"] = 0;
                nr["SolderLine"] = 0;
                nr["TotalArea"] = 0;
                nr["GrindedPerimeter"] = 0;
                nr["ScrapFactor"] = 0;
                nr["AWP"] = 0;
                ComboDataSet lic = (ComboDataSet)ds_License.Items[ds_License.Items.Count - 1];
                nr["License"] = lic.ValueMember;

                rc.Data.Tables[table].Rows.Add(nr);

                cm.Position = rc.Data.Tables[table].Rows.IndexOf(nr);
            }
        }
        public void DesignDelete()
        {
        }

        #endregion
    }
}