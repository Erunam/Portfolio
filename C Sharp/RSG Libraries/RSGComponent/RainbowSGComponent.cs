using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RainbowStainedGlass
{
    public class RainbowSGComponent
    {
        private Dictionary<int, int> Parents = new Dictionary<int,int>();
        private RainbowConnectorMySQL rsgconn;

        public RainbowSGComponent(string conn)
        {
            this.rsgconn = new RainbowConnectorMySQL(conn);
        }
        
        public int[] ParentTree
        {
            get 
            {
                int[] cid = new int[this.Parents.Keys.Count];
                int[] lev = new int[this.Parents.Values.Count];
                this.Parents.Keys.CopyTo(cid, 0);
                this.Parents.Values.CopyTo(lev, 0);
                Array.Sort(lev, cid);
                return cid;
            }
        }
        public string[] ParentTreeNames
        {
            get
            {
                string[] cidname = new string[this.Parents.Keys.Count];
                for (int i = 0; i < cidname.Length; i++)
                {
                    cidname[i] = this.rsgconn.GetValueForQuery(
                        "ComponentAndPart",
                        "concat(ComponentName,'.',Attribute)",
                        "ComponentID = " + ParentTree[i])[0].ToString();
                }
                return cidname;
            }
        }
        public decimal GetComponentWP(string componentid)
        {
            return 12;
        }
        public decimal GetComponentCost(string componentid)
        {
            return 12;
        }
        public string GetNameById(int id)
        {
            if (this.Parents.ContainsKey(id))
            {
                return this.rsgconn.GetValueForQuery(
                        "ComponentAndPart",
                        "concat(ComponentName,'.',Attribute)",
                        "ComponentID = " + id)[0].ToString();
            }
            else
            {
                return "";
            }
        }
        public void ClearParentTree()
        {
            this.Parents.Clear();
        }
        public void SetParentTree(int cid, int level, bool root)
        {
            if (root)
            {
                InsertDictionary(cid, level);
            }

            level++;
            ArrayList parentid = new ArrayList();
            string condition = "PartID = " + cid.ToString();

            parentid = rsgconn.GetValueForQuery("ComponentDetails", "ComponentID", condition);

            if (parentid.Count > 0)
            {
                foreach (string id in parentid)
                {
                    InsertDictionary(Convert.ToInt16(id), level);
                    SetParentTree(Convert.ToInt16(id), level, false);
                }
            }
        }
        private void InsertDictionary(int id, int lev)
        {
            if (this.Parents.ContainsKey(id))
            {
                if (this.Parents[id] <= lev)
                {
                    this.Parents.Remove(id);
                    Parents.Add(id, lev);
                }
            }
            else
            {
                Parents.Add(id, lev);
            }
        }
    }
}
