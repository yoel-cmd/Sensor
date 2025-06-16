using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    internal class sensor
    {
        string name;

        public sensor(string name)
        {
            this.name = name;
        }
        public void activate()
        {
            Console.WriteLine($"my name is : {name}");
        }
    }
}
