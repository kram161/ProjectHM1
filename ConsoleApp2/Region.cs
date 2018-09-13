using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHM1
{
    public class Region
    {
        public string name { get; set; }
        public double Area { get; protected set;}
        List<City> Cities = new List<City>();

        public Region(string name,List<City> Cities)
        {
            this.name = name;
            if (Cities != null)
                this.Cities = Cities;
            ColculateRegionArea();
        }

        private void ColculateRegionArea()
        {
            foreach (City x in Cities)
                Area += x.Area;
        }
    }
}
