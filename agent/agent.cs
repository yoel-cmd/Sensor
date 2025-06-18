using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.agent
{
    internal abstract class Agent
    {
        Random Random = new Random();

        public string name{ get; set; }
        public  string rank { get; set; }
        public  int MaxSensors { get; protected set; }
        public Sensor[] weaknesseSensors { get; set;}
        public Sensor[] attachedSensor { get; set; }
        //----------------------------------------------------------------------------------------------------       
        public Agent(string name,string rank, int MaxSensors)
        {
            this.rank = rank;
            this.name = name;
            this.MaxSensors = MaxSensors;
            weaknesseSensors = SensorFactory.rndSensor(MaxSensors);
            attachedSensor = new Sensor[MaxSensors];
        }
        //----------------------------------------------------------------------------------------------------
        protected void remove(int num)
        {

            for (int i = 0; i < num; i++)
            {
                attachedSensor[Random.Next(attachedSensor.Length)] = null;
            }
           
        }
        //----------------------------------------------------------------------------------------------------
        public void printInfo()
        {
                   
            for (int i = 0; i < weaknesseSensors.Length; i++)
            {
                Console.WriteLine($"name Sensor : {name}");      
            }  
        }
        //----------------------------------------------------------------------------------------------------
        public void activateSensor()
        {
            foreach (var item in weaknesseSensors)
            {
                item.activate();
            }
        }

    }
}
