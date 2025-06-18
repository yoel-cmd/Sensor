using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    static  class SensorFactory
    {

       private static Random rnd = new Random();

        public static string[] sensorNames = new string[]
    {
         "Thermal", "Audio", "Pulse", "Motion", "Magnetic", "Cellular", "Light", "Single"
    };
        //----------------------------------------------------------------------------------------------------
        public static Sensor[]  rndSensor(int num)
        {

            Sensor[] sensor = new Sensor[num];
            for (int i = 0; i < sensor.Length; i++)
            {
                sensor[i] = new Sensor(sensorNames[rnd.Next(sensorNames.Length)]);
            }

            return sensor;
        }
        //----------------------------------------------------------------------------------------------------
        
        

    }
}
