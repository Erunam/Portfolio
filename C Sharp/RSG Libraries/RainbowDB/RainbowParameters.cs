using System;
using System.Collections.Generic;
using System.Data;

namespace RainbowStainedGlass
{
    public class RainbowParameters
    {
        public Dictionary<string, decimal> P;

        public RainbowParameters(string conn)
        {
            this.P = new Dictionary<string, decimal>();
            this.SetParameters(conn);
        }
        public void SetParameters(string conn)
        {
            RainbowConnectorMySQL rsgconn = new RainbowConnectorMySQL(conn);
            string[] sds = { "ManufacturingSettings" };
            
            rsgconn.SetDataSet(sds);

            foreach (DataRow row in rsgconn.Data.Tables[0].Rows)
            {
                string key = row["Parameter"].ToString();
                decimal val = Convert.ToDecimal(row["Value"]);
                this.P.Add(key, val);
            }
        }
    }
}
