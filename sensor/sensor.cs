using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    internal class sensor
    {
       public string name { get; }

        public bool isActiv = false;
        
        public sensor(string name)
        {
            this.name = name;
        }
        public void activate()
        {

            isActiv = true;

        }
    }
}
