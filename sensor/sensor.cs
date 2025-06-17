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
        
        public sensor(string name)
        {
            this.name = name;
        }
        public void activate(sensor[] sensors)
        {
            for (int i = 0; i < sensors.Length; i++)
            {
                if (sensors[i] == null)
                {
                    sensors[i] = this;
                    Console.WriteLine("adding sensor");
                    return;
                }               
                    Console.WriteLine("The lineup is full.");
                
            }
            

        }
    }
}
