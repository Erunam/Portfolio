using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ToolongControl
{
    public partial class Tooling : Form
    {
        private SortedList<string, string> PIFiles = new SortedList<string,string>();
        private List<string[]> Extracted = new List<string[]>();
        private List<string> ErrorTable = new List<string>();

        public Tooling()
        {
            InitializeComponent();

            this.startExpr.SelectedIndex = 0;
            this.stopExpr.SelectedIndex = 0;
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            string name = "";
            int startindex = 0;
            int endindex = 0;
            string[] FileList;

            this.PIList.Items.Clear();
            this.PIFiles.Clear();
            this.OutputWindow.Items.Clear();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileList = openFileDialog1.FileNames;

                foreach (string entry in FileList)
                {
                    startindex = entry.LastIndexOf(@"\");
                    endindex = entry.LastIndexOf(@".txt");
                    name = entry.Substring(startindex + 1, endindex-1 - startindex);

                    this.PIFiles.Add(name, entry);
                    this.PIList.Items.Add(name,true);
                    //debug info
                    this.OutputWindow.Items.Add(entry);
                    //debug info end
                }
            }
        }

        private List<int[]> GetIndexes(string PINumber)
        {
            string[] content = File.ReadAllLines(this.PIFiles[PINumber]);
            List<int[]> brackets = new List<int[]>();
            
            for (int index = 0; index <= content.Length -1 ; index++)
            {
                //content.
                Regex reg = new Regex(this.startExpr.Text);
                Match mc = reg.Match(content[index]);
                if (mc.Success)
                {
                    for (int i = index; i <= index + 30; i++)
                    {
                        string entry = content[i];
                        Regex regend = new Regex(this.stopExpr.Text, (RegexOptions) 0);
                        Match mcend = regend.Match(content[i]);
                        if (mcend.Success)
                        {
                            int[] indexes = new int[2] { index, i };
                            brackets.Add(indexes);
                        }
                    }
                }
            }
            return brackets;
        }
        private List<string> GetExtract(string PINumber, List<int[]> Brackets)
        {
            List<string> Extract = new List<string>();

            string[] content = File.ReadAllLines(this.PIFiles[PINumber]);
            
            foreach (int[] range in Brackets)
            {
                for (int i = range[0]+1;i <= range[1]-1;i++)
                {
                    Extract.Add(content[i]);
                }
            }
            return Extract;
        }
        private void startExpr_Leave(object sender, EventArgs e)
        {
            if (!this.startExpr.Items.Contains(this.startExpr.Text)) this.startExpr.Items.Add(this.startExpr.Text);
        }

        private void stopExpr_Leave(object sender, EventArgs e)
        {
            if (!this.stopExpr.Items.Contains(this.stopExpr.Text)) this.stopExpr.Items.Add(this.stopExpr.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OutputWindow.Items.Clear();
        }

        private void TestExpression_Click(object sender, EventArgs e)
        {
            try
            {
                string test = this.PIList.SelectedItem.ToString();
                List<int[]> find = new List<int[]>();

                find = this.GetIndexes(test);
                OutputWindow.Items.Clear();
                foreach (int[] entry in find)
                {
                    OutputWindow.Items.Add(entry[0]);
                    OutputWindow.Items.Add(entry[1]);
                }
            }
            catch { }
        }

        private void ShowRegion_Click(object sender, EventArgs e)
        {
            try
            {
                string test = this.PIList.SelectedItem.ToString();
                List<int[]> find = new List<int[]>();
                List<string> extract = new List<string>();

                find = this.GetIndexes(test);
                extract = this.GetExtract(test, find);

                OutputWindow.Items.Clear();
                foreach (string entry in extract)
                {
                    OutputWindow.Items.Add(entry);
                }
            }
            catch { }
        }

        private void ShowAllDone_Click(object sender, EventArgs e)
        {
            foreach (string[] entry in this.Extracted)
            {
                OutputWindow.Items.Add(entry[0] + "::" + entry[1]);
            }
        }

        private void Parsing_Click(object sender, EventArgs e)
        {
            List<string> extract = new List<string>();
            List<string> donePI = new List<string>();

            foreach (string PINumber in this.PIList.CheckedItems)
            {
                
                extract = this.GetExtract(PINumber, this.GetIndexes(PINumber));

                if (extract.Count > 0)
                {

                    foreach (string item in extract)
                    {
                        this.Extracted.Add(new string[2] { PINumber, item });
                    }
                    donePI.Add(PINumber);
                }
            }
            foreach (string pinumber in donePI)
            {
                this.PIList.SetItemChecked(this.PIList.Items.IndexOf(pinumber), false);
            }
        }

        private void ClearParsed_Click(object sender, EventArgs e)
        {
            this.Extracted.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Extracted.ForEach(cleaning);
        }

        private void Separate_Click(object sender, EventArgs e)
        {
            this.Extracted.ForEach(separating);
        }
        public void cleaning (string[] entry)
        {
            string delim = this.Rubishes.Text;
            entry[1] = entry[1].Trim(delim.ToCharArray());
        }
        public void separating(string[] entry)
        {
            Regex reg = new Regex(this.Rubishes.Text);
            Match m = reg.Match(entry[1]);

            //int index = this.Extracted.IndexOf(entry);
            string temp = "";

            while (m.Success)
            {
                temp = "::" + temp + m.Value;
                int ind = m.Index;
                int lg = m.Length;

                entry[1] = entry[1].Remove(m.Index, m.Length);

                m = m.NextMatch();
            }
            entry[1] = entry[1] + temp;
        }

        private void Rubishes_Leave(object sender, EventArgs e)
        {
            if (!this.Rubishes.Items.Contains(this.Rubishes.Text)) this.Rubishes.Items.Add(this.Rubishes.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.Extracted.Count >= 1)
            {
                string[] content = new string[this.Extracted.Count];
                int i = 0;

                DialogResult Result = this.saveFileDialog1.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    foreach (string[] entry in this.Extracted)
                    {
                        content[i] = entry[0] + "::" + entry[1] + "::";
                        i += 1;
                    }

                    File.WriteAllLines(this.saveFileDialog1.FileName, content);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process viewfile = new Process();
            string pinumber = this.PIList.SelectedItem.ToString();

            viewfile.StartInfo.FileName = this.PIFiles[pinumber];
            viewfile.Start();
        }
    }
}