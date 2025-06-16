using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    internal class agent
    {
        Random rnd = new Random();
        public string rank{ get; set; }
        public sensor[] WeaknesseSsensors { get; set;}
        public sensor[] attachedSensor { get; set;}

 //----------------------------------------------------------------------------------------------------       
      

        public agent(string rank)
        {
            this.rank = rank;
            //this.WeaknesseSsensors = sensors;
        
        }
//----------------------------------------------------------------------------------------------------
      


    }
}
