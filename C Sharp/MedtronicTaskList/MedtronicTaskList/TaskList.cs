using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MedtronicTaskList
{
    public partial class TaskList : Form
    {
        private string[] FileList;
        private SortedList<string, string> IDList = new SortedList<string, string>();
        private string[] FileContent;
        
        public TaskList()
        {
            InitializeComponent();
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            string name = "";
            int index = 0;

            DialogResult result = OpenFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.FileList = OpenFileDlg.FileNames;

                foreach (string entry in this.FileList)
                {

                    index = entry.LastIndexOf(@"\");
                    name = entry.Substring(index+1);

                    this.FileListBox.Items.Add(name);
                }
                this.ProgressBar.Visible = true;
                this.ProgressBar.Minimum = 1;
                this.ProgressBar.Maximum = this.FileList.Length;
                this.ProgressBar.Value = 1;
                this.ProgressBar.Step = 1;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string key;
            string value;
            try
            {

                foreach (string entry in this.FileList)
                {
                    this.FileContent = File.ReadAllLines(entry);

                    foreach (string line in this.FileContent)
                    {
                        if (line.Contains("Mat. Comp."))
                        {
                            key = line.Substring(13, 18).Trim();
                            value = line.Substring(31).Trim();
                            if (!this.IDList.ContainsKey(key))
                            {
                                this.IDList.Add(key, value);
                            }
                        }
                    }

                    this.ProgressBar.PerformStep();
                }
            }
            catch { }
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            string key;
            string value;

            key = this.idText.Text.Trim();
            value = this.descText.Text.Trim();

            if (!this.IDList.ContainsKey(key))
            {
                this.IDList.Add(key, value);
            }
            else
            {
                MessageBox.Show("Entry: " + key + "  already exists in file");
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (this.IDList.Count >= 1)
            {
                string[] content = new string[this.IDList.Count];
                int i = 0;

                DialogResult Result = this.SaveFileDlg.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    foreach (KeyValuePair<string,string> entry in this.IDList)
                    {
                        content[i] = entry.Key + ":" + entry.Value;
                        i += 1;
                    }
                    
                    File.WriteAllLines(this.SaveFileDlg.FileName, content);
                }
            }
            else
            {
                MessageBox.Show("File is empty");
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox1();
            about.ShowDialog();
        }
    }
}