using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.agent
{
    internal class Squad_Leader : Agent
    {

        int count = 3;
        public Squad_Leader(string name) : base(name, "Squad Leader", 4)
        {
        }

        public void removing3()
        {
            remove(1);
        }

    }
}
