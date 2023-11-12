using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RainbowManagement
{
    public partial class RainbowParentMDI : Form
    {
        private SortedList OpenedWindows = new SortedList();

        public RainbowParentMDI()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut");
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm mysettings = new SettingsForm();
            mysettings.Show();
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

        private void productBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChildNameExist("Designs"))
            {
                Designs designs = new Designs();
                designs.MdiParent = this;
                designs.Show();
                //designs.WindowState = FormWindowState.Maximized;
            }
        }

        private void organiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specifications specyfications = new Specifications();
            specyfications.Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configurations configurations = new Configurations();
            configurations.Show();
        }

        private void componentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChildNameExist("Components"))
            {
                Components mycomponents = new Components();
                mycomponents.MdiParent = this;
                mycomponents.Show();
                //mycomponents.WindowState = FormWindowState.Maximized;
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChildNameExist("Products"))
            {
                Products products = new Products();
                products.MdiParent = this;
                products.Show();
                //products.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
