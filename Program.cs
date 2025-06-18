using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sensor.agent;
using Sensor.room;

namespace Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Foot_Soldier foot_Soldier = new Foot_Soldier("yoel");
            Room room = new Room(9, foot_Soldier);
            Game game = new Game(room);
            game.Run();

        }
    }
}
