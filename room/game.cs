using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor.room
{
    internal class Game
    {
        private Room room;
        private int raund;

        public Game(Room room)
        {
            this.room = room;
            this.raund = 1;
        }

        public void Run()
        {
            // פלט מעוצב לתחילת המשחק
            Console.WriteLine("==============================");
            Console.WriteLine($"      Welcome to Room {room.numRoom}      ");
            Console.WriteLine("==============================");
            int sensorsArraySize = room.agent.weaknesseSensors.Length;
            Console.WriteLine($"You can attach sensors to {sensorsArraySize} locations.");
            Console.WriteLine($"Available sensors: {string.Join(", ", SensorFactory.sensorNames)}");
            Console.WriteLine("==============================");
            Console.WriteLine();



            while (true)
            {
                
                Console.WriteLine($"----- Round {raund} -----");
                Console.WriteLine("Insert location (number):");
                int Location;
                try
                {
                    Location = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine();
                    continue;
                }

                if (Location >= sensorsArraySize || Location < 0)
                {
                    Console.WriteLine($"Invalid location. Please enter a number between 1 and {sensorsArraySize}.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Insert Sensor name:");
                string sensorName = Console.ReadLine();

                if (!room.attache(Location, sensorName))
                {
                    Console.WriteLine("The Sensor does not exist, please insert a new one.");
                    Console.WriteLine();
                    continue;
                }

                string result = room.CompareSensors();
                Console.WriteLine($"Progress: {result}");

                if (result.StartsWith(sensorsArraySize.ToString()))
                {
                    Console.WriteLine("All weaknesses have been neutralized!");
                    break;
                }

                raund++;
                Console.WriteLine();
            }
        }
    }
}

