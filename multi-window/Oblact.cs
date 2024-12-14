using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_window
{
    public class Oblact
    {

        public string OblactString, City;
        public int YearMoney;
        public double CountPeople;

        public override string ToString()
        {
            return OblactString;
        }

        public string getView()
        {
            return $"{OblactString} {City} {YearMoney} {CountPeople}";
        }
    }
}
