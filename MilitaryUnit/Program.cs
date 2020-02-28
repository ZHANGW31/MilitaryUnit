using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Mission blueFalcon = new Mission();
            blueFalcon.MissionName = "blue falcon";
            Console.WriteLine(blueFalcon.MissionName);
        }
    }
}
