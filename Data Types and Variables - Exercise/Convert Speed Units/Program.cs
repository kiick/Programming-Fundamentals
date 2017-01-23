using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            double allSec = seconds + minutes * 60 + hours * 3600;
            double secToHour = allSec / 3600.0;

            double metersPerSecond = distanceInMeters / allSec;
            double kilomPerHour = (distanceInMeters / 1000.0) / secToHour;
            double milesPerHour = (distanceInMeters / 1609.0) / secToHour;
            Console.WriteLine($"{metersPerSecond:f6}\n{kilomPerHour:f6}\n{milesPerHour:f6}");
        }
    }
}
