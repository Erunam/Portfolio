using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


/*
 * Buglista
 * bug1: wybrany niew³aœciwy katalog - nie zawiera ¿adnych zipów - EXEPTION
 * bug2: b³êdny plik w katalogu - EXEPTION
 *
 * do zrobienia:
 * pusta lista - komunikat
 * otwarcie pliku prze d/click
 *
 */

namespace JobFinder
{
    public partial class JobFinder : Form
    {
        private string LastFolder;
        private string TemporaryFolder;

        public event EventHandler PressEnter;
        
        public JobFinder()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
            
            this.PressEnter += new EventHandler(this.JobButton_Click);

            this.SetFocus();
            this.SetComboBox(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Greaney Glass");
            this.SetComboBox(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Tough Orders");

            this.LastFolder = this.PathCombo.Text;
            this.CreateTemporaryFolder();
        }
        
        private void SetFocus()
        {
            // podœwietla ca³y tekst wewn¹trz JobText
            this.JobText.Select();
            this.JobText.SelectionStart = 0;
            this.JobText.SelectionLength = this.JobText.Text.Length;
        }
    
        private void JobText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                PressEnter(this, e);
            }
        }

        private void JobButton_Click(object sender, EventArgs e)
        {
            Finder finder = new Finder(this.PathCombo.Text);
            finder.Find(this.JobText.Text);

//           DataGridViewRowCollection DataGridRows = this.JobView.Rows;
            this.JobView.Rows.Clear();

            foreach (string[] row in finder.Rows)
            {
                this.JobView.Rows.Add(row);
            }

            this.LastFolder = this.PathCombo.Text;
//            this.CreateTemporaryFolder();
            SetFocus();
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = PathDialog.ShowDialog();
            string FolderName;

            if (Result == DialogResult.OK)
            {
                FolderName = PathDialog.SelectedPath;
            }
            else
            {
                this.SetFocus();
                return;
            }
            
            this.SetComboBox(FolderName);
            this.SetFocus();            
        }
        private void SetComboBox(string value)
        {
            this.PathCombo.Text = value;
            this.PathCombo.Items.Add(this.PathCombo.Text);
            return;
        }

        private void JobView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Finder finder = new Finder(LastFolder);
            string[] jobinfo = new string[3]
                {
                    this.JobView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    this.JobView.Rows[e.RowIndex].Cells[1].Value.ToString(), 
                    this.JobView.Rows[e.RowIndex].Cells[2].Value.ToString()
                };
            string file = finder.GetJob(jobinfo, this.TemporaryFolder);
            file = this.TemporaryFolder + @"\" + file;
            Process viewfile = new Process();
            viewfile.StartInfo.FileName = file;
            viewfile.Start();
        }

        private void CreateTemporaryFolder()
        {
            this.TemporaryFolder = Path.GetTempPath() + @"JobFinder";
            if (Directory.Exists(this.TemporaryFolder))
            {
                this.DeleteTemporaryFolder();
            }
            Directory.CreateDirectory(this.TemporaryFolder);
        }

        private void DeleteTemporaryFolder()
        {
            try
            {
                Directory.Delete(this.TemporaryFolder, true);
            }
            catch (Exception e)
            {
            }
        }
    }
}
