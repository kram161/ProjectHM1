using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHM1
{
    public class City
    {
        public string Name { get; set; }
        public double Area { get; protected set; }
        public List<District> Districts = new List<District>();

        public City(string Name,List<District> Districts)
        {
            this.Name = Name;
            if (Districts != null)
                this.Districts = Districts;
            ColculateCityArea();
        }

        private void ColculateCityArea()
        {
            foreach (District x in Districts)
                Area += x.Area;
        }
    }
}
