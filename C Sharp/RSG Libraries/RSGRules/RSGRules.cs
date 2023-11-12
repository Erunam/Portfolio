using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RainbowStainedGlass
{
    public class RSGRules
    {
        string connection;

        public RSGRules(string conn)
        {
            this.connection = conn;
        }

        public decimal GetCalculation(string input, string productpart, string componentname)
        {
            decimal value = 0;
            switch (productpart)
            {
                case "Design Copper Foil":
                    switch (input)
                    {
                        case "Copper Foil":
                            ;
                        break;
                        case "Solder":
                        ;
                        break;
                    }
                    break;
                case "Design Leaded":
                    switch (input)
                    {
                        case "":

                        break;
                    }
                    break;
                default:
                    break;
            }
            return value;
        }
    }
}
