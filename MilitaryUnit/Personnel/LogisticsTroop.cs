using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class LogisticsTroop : Personnel
    {
        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved logistics training");
        }
        public override void Title()
        {
            Console.WriteLine("Logistician");
        }
        public void LogCapabilities()
        {
            Console.WriteLine("This troop can plan, coordinate and execute logistics missions");
        }
    }
}
