using System.Data;

namespace RainbowStainedGlass
{
    public class RainbowSGDesign
    {
        private RainbowParameters par;
        private RainbowConnectorMySQL design;

        private string name;
        private int id;

        private decimal te;
        private decimal tp;
        private decimal sl;
        private decimal ta;
        private decimal gp;

        private decimal scrap;

        public RainbowSGDesign()
        {
        }
        public RainbowSGDesign(string name, string connection)
        {
            this.design = new RainbowConnectorMySQL(connection);
            GetDesignByName(name);
        }
        public RainbowSGDesign(decimal[] fields, RainbowParameters rsgpar)
        {
            SetDesign(fields);
            SetParameters(rsgpar);
        }
        public RainbowSGDesign(decimal[] fields, string connection)
        {
            this.par = new RainbowParameters(connection);
            SetDesign(fields);
        }
        public void SetDesign(decimal[] fields /*te, tp, sl, ta, gp*/)
        {
            ///*te, tp, sl, ta, gp*/
            this.te = fields[0];
            this.tp = fields[1];
            this.sl = fields[2];
            this.ta = fields[3];
            this.gp = fields[4];
        }
        public void SetParameters(RainbowParameters rsgpar)
        {
            this.par = rsgpar;
        }
        private void GetDesignByName(string name)
        {
            string table = "StainedGlassDesign";
            this.design.SetDataSet(table,
                "Concat(DesignName, '.', DesignSize) = '" + name + "'");
            if (this.design.Data.Tables[table].Rows.Count == 1)
            {
                DataRow r = this.design.Data.Tables[table].Rows[0];
                this.Elements = decimal.Parse(r["TotalElements"].ToString());
                this.Perimeter = decimal.Parse(r["TotalPerimeter"].ToString());
                this.Solder = decimal.Parse(r["SolderLine"].ToString());
                this.Area = decimal.Parse(r["TotalArea"].ToString());
                this.Grinded = decimal.Parse(r["GrindedPerimeter"].ToString());
                this.Scraps = decimal.Parse(r["ScrapFactor"].ToString());
                //TODO this.Labels = decimal.Parse(r["
                this.Name = name;
                this.ID = int.Parse(r["DesignID"].ToString());
            }
        }

        #region .   Equation variables
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value;}
        }
        public int ID
        {
            get { return this.id; }
            set { this.ID = value; }
        }
        public decimal Elements
        {
            get { return te; }
            set { this.te = value; }
        }
        public decimal Perimeter
        {
            get { return tp; }
            set { this.tp = value; }
        }
        public decimal Solder
        {
            get { return sl; }
            set { this.sl = value; }
        }
        public decimal Area
        {
            get { return ta; }
            set { this.ta = value; }
        }
        public decimal Grinded
        {
            get { return gp; }
            set { this.gp = value; }
        }
        public decimal Scraps
        {
            get { return scrap; }
            set { this.scrap = value; }
        }

        #endregion

        #region .   Calculations

        public decimal WP
        {
            get
            {

                decimal WP =
                        this.par.P["Elements"] * this.te +
                        this.par.P["Perimeter"] * this.tp +
                        this.par.P["SolderLine"] * this.sl +
                        this.par.P["Area"] * this.ta +
                        this.par.P["GrindedPerimeter"] * this.gp
                        ;
                WP = WP / 3600;
                return decimal.Round(WP, 3);
            }
        }

        public decimal DesignSolder
        {
            get
            {
                decimal DS = this.par.P["SolderUsage"] * this.sl;
                return decimal.Round(DS, 3);
            }
        }
        public decimal DesignCopperFoil
        {
            get
            {
                decimal CF = this.Perimeter + 2*this.Elements;
                return decimal.Round(CF, 3);
            }
        }
        public decimal DesignGlass
        {
            get
            {
                decimal G = this.Area * (1 + this.Scraps);
                return decimal.Round(G, 3);
            }
        }

        #endregion
    }
}