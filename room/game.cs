using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.room
{
    internal class Game
    {

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
        //--------------------------------------------------------------------
        //--------------------------------------------------------------------
        //--------------------------------------------------------------------

        //--------------------------------------------------------------------

        //--------------------------------------------------------------------

        //--------------------------------------------------------------------

    }
}
