using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    static  class sensorFactory
    {

       private static Random rnd = new Random();

        public static string[] sensorNames = new string[]
    {
        "movement", "thermal", "selilar"
    };

        private static Dictionary<string, int> arrRank = new Dictionary<string, int>
        {
            { "junior", 2 },
            { "senior", 3 },
            { "commander", 4 }
        };
        //----------------------------------------------------------------------------------------------------
        public static sensor[]  rndSensor(string rank)
        {

            sensor[] sensor = new sensor[arrRank[rank]];
            ;
            if (!arrRank.ContainsKey(rank))
            {
                throw new ArgumentException("Rank not found");
            }
            
            for (int i = 0; i < sensor.Length; i++)
            {
                sensor[i] = new sensor(sensorNames[rnd.Next(sensorNames.Length)]);
            }

            return sensor;


        }
        //----------------------------------------------------------------------------------------------------
        
        //----------------------------------------------------------------------------------------------------

    }
}
