using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.agent
{   
    internal class Senior_Commander:Agent
    {
        public int count { get; set; } = 3;
        public Senior_Commander(string name) : base(name, "Senior Commander", 6)
        {
        }

       public void removing3()
        {
            remove(2);
        }


    }
}
