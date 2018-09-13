using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHM1
{
    public class Country
    {
        public string name { get; set; }
        public Country Capital { get; set; }
        public double Area {get; protected set;}
        public List<Region> Regions = new List<Region>();

        public Country(string name,Country Capital, List<Region> Regions)
        {
            this.name = name;
            this.Capital = Capital;
            if (Regions != null)
                this.Regions = Regions;
            ColculateCountryArea();
        }

        private void ColculateCountryArea()
        {
            foreach (Region x in Regions)
                Area += x.Area;
        }
    }
}
