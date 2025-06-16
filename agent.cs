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
        public string name{ get; set; }
        public string rank{ get; set; }
        public sensor[] WeaknesseSsensors { get; set;}
        public sensor[] attachedSensor { get; set;}


 //----------------------------------------------------------------------------------------------------       
      

        public agent(string name,string rank)
        {
            this.rank = rank;
            this.name = name;
            this.WeaknesseSsensors = sensorFactory.rndSensor(rank);
        }
//----------------------------------------------------------------------------------------------------
      
        public void printInfo()
        {
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"name : {name}");
            for (int i = 0; i < WeaknesseSsensors.Length; i++)
            {
                Console.WriteLine($"name sensor : {name}");      
            }  
        }


        public void activateSensor()
        {
            foreach (var item in WeaknesseSsensors)
            {
                item.activate();
            }
        }

    }
}
