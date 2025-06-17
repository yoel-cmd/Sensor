using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    internal class room
    {
        private int numRoom { get; }
        private  sensor[] attachedSensor { get; set; }

        Dictionary<string, int> sensorAgent = new Dictionary<string, int>();

        Dictionary<string, int> snesorUser = new Dictionary<string, int>();
        //--------------------------------------------------------------------
        public room(int num)
        {
            this.numRoom = num;
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
        public string HasSensorOverlap()
        {
            int sensor = 0, countSensor = 0;

            foreach(var item in sensorAgent)
            {
                if(sensorAgent.ContainsKey())
            }







            return $"{sensor} / {countSensor}";

        }
        //--------------------------------------------------------------------

    }
}
