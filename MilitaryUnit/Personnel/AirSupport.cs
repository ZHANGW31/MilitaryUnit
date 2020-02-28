using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class AirSupport : Personnel
    {
        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved pilot training");
        }
        public override void Title()
        {
            Console.WriteLine("Pilot");
        }
        public override void SpecialEquipment()
        {
            Console.WriteLine("This troop is equipped with pilot flight equipment and survival kit");
        }
        public void MedCapabilities()
        {
            Console.WriteLine("Provides air support");
        }
    }
}
