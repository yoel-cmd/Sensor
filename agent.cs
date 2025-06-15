using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor
{
    abstract class agent
    {

        //public string type { get;set; }
        public string rank{ get; set; }
        public Dictionary<string, int> arrRank = new Dictionary<string, int>
        {
            { "junior", 1 },
            { "senior", 2 },
            { "commander", 3 }
        };
        public sensor[] sensors ;

        public agent(string rank)
        {
            this.rank = rank;
            if (!arrRank.ContainsKey(rank))
            {
                throw new ArgumentException("Rank not found");
            }
            else
            {
                sensors = new sensor[arrRank[rank]];
            }
        }
    }
}
