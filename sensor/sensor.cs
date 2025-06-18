using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    internal class Sensor
    {
       public string name { get; }

        public bool isActiv = false;
        
        public Sensor(string name)
        {
            this.name = name;
        }
        public void activate()
        {

            Console.WriteLine(name);

            //isActiv = true;

        }
    }
}
