using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace RainbowStainedGlass
{
    public class RSGFileImport
    {
        private string log = "";

        public RSGFileImport()
        {
        }
        public DataRow ImportDesign(string file, DataRow dr)
        {
            string[] FileText = File.ReadAllLines(file);
            this.log = file + "/n";

            try
            {
                foreach (string line in FileText)
                {
                    if (line.Contains("Square centimeters of glass:"))
                    {
                        string area = line.Substring(line.IndexOf(":")+1).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["TotalArea"] = Double.Parse(area, NumberStyles.Float);
                    }
                    else if (line.Contains("Centimeters of came:"))
                    {
                        string area = line.Substring(line.IndexOf(":")+1).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["SolderLine"] = Double.Parse(area, NumberStyles.Float);
                    }
                    else if (line.Contains("Centimeters of copper foil:"))
                    {
                        string area = line.Substring(line.IndexOf(":")+1).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["TotalPerimeter"] = Double.Parse(area, NumberStyles.Float);
                    }
                    else if (line.Contains("Number of pieces:"))
                    {
                        string area = line.Substring(line.IndexOf(":")+1).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["TotalElements"] = Double.Parse(area, NumberStyles.Float);
                    }
                    else if (line.Contains("Width:"))
                    {
                        string area = line.Substring(line.IndexOf("Width:") + 6).Trim();
                        area = area.Substring(0, area.IndexOf("cm")).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["DesignWidth"] = Double.Parse(area);

                        area = line.Substring(line.IndexOf("Height:") + 7).Trim();
                        area = area.Substring(0, area.IndexOf("cm")).Trim();
                        area = area.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                        dr["DesignHeight"] = Double.Parse(area);
                    }
                }
                this.log += "\n - Lines parsed";

                // Grinded Perimeter
                decimal tp = decimal.Parse(dr["TotalPerimeter"].ToString());
                decimal sl = decimal.Parse(dr["SolderLine"].ToString());
                decimal gr = 2*(tp-sl);
                dr["GrindedPerimeter"] = decimal.Round(gr, 3);

                this.log += "\n - grinded parsed";

                // Author
                string author = FileText[0].Substring(FileText[0].IndexOf('�') + 1).Trim();
                //author = author.Substring(0, author.LastIndexOf(' ')).Trim();
                dr["Author"] = author;

                this.log += "\n - author parsed";

                // Design Name
                int index = file.LastIndexOf(@"\");
                string filename = file.Substring(index + 1);
                string[] design = filename.Split('.');

                dr["DesignName"] = design[0];
                dr["DesignSize"] = design[1];

                dr["ScrapFactor"] = 0.8;

                this.log += "\n - design name parsed";

                return dr;
            }
            catch
            {
                MessageBox.Show(this.log);
                return null;
            }
        }


    }
}
