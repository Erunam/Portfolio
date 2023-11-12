using System;
using System.Collections;
using System.Windows.Forms;

namespace RainbowStainedGlass
{
    public partial class ProductCentreMDI : Form
    {
        private SortedList OpenedWindows = new SortedList();

        public ProductCentreMDI()
        {
            InitializeComponent();
        }
        private Designs designs;
        private Components component;
        private Products products;

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private bool ChildNameExist(string name)
        {
            bool exists = false;

            if (this.MdiChildren.Length > 0)
            {
                for (int x = 0; x < this.MdiChildren.Length; x++)
                {
                    Form tempChild = (Form)this.MdiChildren[x];
                    if (exists == false & tempChild.Text == name)
                    {
                        exists = true;
                    }
                }
            }
            return exists;
        }

        private void designSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesignSettings DesignSettings = new DesignSettings();
            DesignSettings.Show();
        }

        private void organiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComponentSettings ComponentSettings = new ComponentSettings();
            ComponentSettings.Show();
        }

        private void productsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!ChildNameExist("Products"))
            {
                this.products = new Products();
                products.MdiParent = this;
                products.Show();
                //products.WindowState = FormWindowState.Maximized;
            }
        }

        private void componentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!ChildNameExist("Components"))
            {
                this.component = new Components();
                component.MdiParent = this;
                component.Show();
                //mycomponents.WindowState = FormWindowState.Maximized;
            }
        }

        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChildNameExist("Designs"))
            {
                this.designs = new Designs();
                designs.MdiParent = this;
                designs.Show();
                //designs.WindowState = FormWindowState.Maximized;
            }
        }

        private void programSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm ProgramSettings = new SettingsForm();
            ProgramSettings.Show();
        }

        private void testrunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            //RainbowSGDesign des = new RainbowSGDesign(Properties.Settings.Default.MySqlConnection, "Got);
            RainbowParameters par = new RainbowParameters(Properties.Settings.Default.MySqlConnection);
            decimal[] desp = { 53, 1333.840, 781.400, 3465.990, 1104.880 };
            RainbowSGDesign des = new RainbowSGDesign(desp);
            RainbowDesignCalc dcalc = new RainbowDesignCalc(par);

            decimal wp = dcalc.GetDesignWP(des);
             */
            /*
            RainbowSGComponent cmp = new RainbowSGComponent(Properties.Settings.Default.MySqlConnection);
            cmp.SetParentTree(3,0);
            int[] ar = new int[cmp.Parents.Keys.Count];
            int[] vr = new int[cmp.Parents.Keys.Count];

            cmp.Parents.Keys.CopyTo(ar, 0);
            cmp.Parents.Values.CopyTo(vr, 0);
            Array.Sort(vr, ar);
             
            RainbowSGComponent cmp = new RainbowSGComponent(Properties.Settings.Default.MySqlConnection);
            cmp.SetParentTree(3, 0);
            int[] tmp = cmp.ParentTree;
            string[] tmpo = cmp.ParentTreeNames;
             * */
        }
        #region Edit Toolbars
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                string activewindow = this.ActiveMdiChild.Name;

                switch (activewindow)
                {
                    case "Components":
                        this.component.ComponentSave();
                        break;
                    case "Designs":
                        this.designs.DesignSave();
                        break;
                }
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string activewindow = this.ActiveMdiChild.Name;

            switch (activewindow)
            {
                case "Designs":
                    this.designs.DesignDelete();
                    break;
                case "Components":
                    this.component.ComponentDelete();
                    break;
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string activewindow = this.ActiveMdiChild.Name;

            switch (activewindow)
            {
                case "Designs":
                    this.designs.DesignCopy();
                    break;
                case "Components":
                    this.component.ComponentCopy();
                    break;
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string activewindow = this.ActiveMdiChild.Name;

            switch (activewindow)
            {
                case "Designs":
                    this.designs.DesignPaste();
                    break;
                case "Components":
                    this.component.ComponentPaste();
                    break;
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string activewindow = this.ActiveMdiChild.Name;

            switch (activewindow)
            {
                case "Designs":
                    this.designs.DesignNew();
                    break;
                case "Components":
                    this.component.ComponentNew();
                    break;
            }
        }
        #endregion
    }
}
