using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.agent
{
    internal class Organization_Leader:Agent
    {
        Random Random = new Random();

        int count = 10;
        public Organization_Leader(string name) : base(name, "Organization Leader", 8)
        {
        }
        public void removing3()
        {
            remove(1);
        }

        //public void removing10()
        //{
        //    this.remove(1);
        //}



        //כל 10 מאפס את החולשות לרשימה חדשה
        //מסיר את כל המוצמדים 


    }
}
