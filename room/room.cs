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


        public void Game()
        {  
            Console.WriteLine($"Welcome to number room: {numRoom} ");
            int sensorsArraySize = agent.weaknesseSensors.Length;    
            int totalSensorCount =1;
            int raund = 1;
            Console.WriteLine($"You can attach sensors to {sensorsArraySize} locations.");

            while (totalSensorCount > 0)
            {
                Console.WriteLine($"raund : {raund}");

                //חייב לעדכן פה מספר של תורות כי יש סוכנים שאחרי 3 תורות מורידים מהמוצמדים 
                Console.WriteLine("Insert int to location ");
                int Location;
                try
                {
                    Location = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }


                if (Location >= sensorsArraySize || Location < 0)
                {
                    Console.WriteLine($"Invalid location. Please enter a number between 1 and {sensorsArraySize}.");
                    continue;
                }
                 Console.WriteLine("Insert Sensor");
                string sensorName = Console.ReadLine();

                if(!attache(Location, sensorName))
                {
                    continue;
                }
                DictWeaknesseSensors = dictionarySensor(agent.weaknesseSensors);
                for (int i = 0; i < agent.attachedSensor.Length; i++)
                {
                    if (agent.attachedSensor[i] != null) 
                    {
                        string name = agent.attachedSensor[i].name;
                        if (DictWeaknesseSensors.ContainsKey(name))

                        {
                            if (DictWeaknesseSensors[name] > 0)
                            {
                                DictWeaknesseSensors[name] -= 1;
                                Console.WriteLine($"{name} fell{DictWeaknesseSensors[name]} remaining");
                            }
                            else
                            {
                                Console.WriteLine($"{name} It exists but can no longer be downloaded.");
                                //agent. attachedSensor[i] = null;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no such sensor on the list of weaknesses.");
                            //agent.attachedSensor[i] = null;
                        }
                    }
                }

                totalSensorCount = DictWeaknesseSensors.Values.Sum();

                int sum = sensorsArraySize - totalSensorCount;
                raund += 1;
                Console.WriteLine($"You found {sum} / {sensorsArraySize}");

            }
           

        }
        //--------------------------------------------------------------------
        //return $"{Sensor} / {countSensor}";
        //public void attache(string sensorName)
        //{

        //    if (!SensorFactory.sensorNames.Contains(sensorName))
        //    {
        //        Console.WriteLine("The Sensor does not exist, please insert a new one.");
        //        return;
        //    }
        //    for (int i = 0; i < agent. attachedSensor.Length; i++)
        //    {
        //        if (agent.attachedSensor[i] == null)
        //        {
        //            agent.attachedSensor[i] = new Sensor(sensorName);


        //            Console.WriteLine("adding Sensor");
        //            return;
        //        }
        //        Console.WriteLine("The lineup is full.");

        //    }
        //}
        //--------------------------------------------------------------------
    }
}
