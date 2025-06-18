using System;
using System.Collections.Generic;
using System.Linq;


namespace Sensor
{
    internal class room
    {
        agent agent1;
       
        private int numRoom { get; }
        private  sensor[] attachedSensor =new sensor[agent.]{ get; set; }


        //Dictionary<string, int> snesorUser = new Dictionary<string, int>();
        //--------------------------------------------------------------------
        public room(int num)
        {
            this.numRoom = num;
        }

        //--------------------------------------------------------------------
        public void attache(string sensorName)
        {

            if (!sensorFactory.sensorNames.Contains(sensorName))
            {
                Console.WriteLine("The sensor does not exist, please insert a new one.");
                return;
            }
            for (int i = 0; i < attachedSensor.Length; i++)
            {
                if (attachedSensor[i] == null)
                {
                    attachedSensor[i] = new sensor(sensorName);
                    Console.WriteLine("adding sensor");
                    return;
                }
                Console.WriteLine("The lineup is full.");

            }
        }
        //--------------------------------------------------------------------
        public Dictionary<string,int> dictionarySensor(sensor[] sensors)
        {
            Dictionary<string, int> returnDict = new Dictionary<string, int>();
            foreach (var item in sensors)
            {
                if (!returnDict.ContainsKey(item.name))
                {
                    returnDict.Add(item.name,1);
                }
                else
                {
                    returnDict[item.name] += 1;
                }               
            }
                return returnDict;
        }
        //--------------------------------------------------------------------
        
        public void HasSensorOverlap(sensor[] sensor,agent agent)
        {
            int sensorsArraySize = sensor.Length;    
            int totalSensorCount = 0;

            int sum = 0;
            while (totalSensorCount > 0)
            {
                Dictionary<string, int> DensorAgent = dictionarySensor(agent.WeaknesseSsensors);
                Console.WriteLine("Insert sensor");
                string sensorName = Console.ReadLine();
                attache(sensorName);

                for (int i = 0; i < attachedSensor.Length; i++)
                {
                    string name = attachedSensor[i].name;
                    if (DensorAgent.ContainsKey(name))

                    {
                        if (DensorAgent[name] > 0)
                        {
                            DensorAgent[name] -=1;
                            Console.WriteLine($"{sensorName} fell{DensorAgent[sensorName]}");
                        }
                        else
                        {
                            Console.WriteLine($"{sensorName} It exists but can no longer be downloaded.");
                            attachedSensor[i] = null;
                        }
                    }
                    Console.WriteLine("");
                    attachedSensor[i] = null;
                }

                foreach (int value in DensorAgent.Values)
                {
                    totalSensorCount += value;
                }
                sum = sensorsArraySize - totalSensorCount;
                Console.WriteLine($"You found {sum} / {sensorsArraySize}");

            }
            //return $"{sensor} / {countSensor}";

        }
        //--------------------------------------------------------------------

    }
}
