using System;
using System.Collections.Generic;
using System.Linq;
using Sensor.agent;


namespace Sensor.room
{
    internal class Room
    {

        public int numRoom { get; set; }
        public  Agent agent { get; set; }


        Dictionary<string, int> DictWeaknesseSensors = new Dictionary<string, int>();

        public Room(int num,Agent agent )
        {
            this.numRoom = num;
            this.agent = agent;
            
        }

        //--------------------------------------------------------------------
        public Dictionary<string, int> dictionarySensor(Sensor[] sensors)
        {
            Dictionary<string, int> returnDict = new Dictionary<string, int>();
            foreach (var item in sensors)
            {
                if (!returnDict.ContainsKey(item.name))
                {
                    returnDict.Add(item.name, 1);
                }
                else
                {
                    returnDict[item.name] += 1;
                }
            }
            return returnDict;
        }
        //--------------------------------------------------------------------          
        public bool attache(int Location, string sensorName)
        {

            if (!SensorFactory.sensorNames.Contains(sensorName))
            {
                Console.WriteLine("The Sensor does not exist, please insert a new one.");
                return false;
            }
            agent.attachedSensor[Location] = new Sensor(sensorName);

            Console.WriteLine();
            return true;
        }
        //--------------------------------------------------------------------

        public string CompareSensors()
        {
            int sensorsArraySize = agent.weaknesseSensors.Length;
            DictWeaknesseSensors = dictionarySensor(agent.weaknesseSensors);
            //int matchedSensors = 0;

            for (int i = 0; i < agent.attachedSensor.Length; i++)
            {
                if (agent.attachedSensor[i] != null)
                {
                    string name = agent.attachedSensor[i].name;
                    if (DictWeaknesseSensors.ContainsKey(name) && DictWeaknesseSensors[name] > 0)
                    {
                        DictWeaknesseSensors[name] -= 1;
                        //matchedSensors++;
                    }
                }
            }

            int totalSensorCount = DictWeaknesseSensors.Values.Sum();
            int found = sensorsArraySize - totalSensorCount;
            return $"{found}/{sensorsArraySize}";
        }

        
    }
}
