using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHM1
{
   public class District
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public District(string Name, double Area)
        {
            this.Name = Name;
            this.Area = Area;
        }
    }
}
