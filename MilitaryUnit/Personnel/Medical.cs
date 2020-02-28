using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Medical : Personnel
    {
        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved Medical training");
        }
        public override void Title()
        {
            Console.WriteLine("Combat Medic");
        }
        public override void SpecialEquipment()
        {
            Console.WriteLine("This troop is equipped with additional medical equipment");
        }
        public void MedCapabilities()
        {
            Console.WriteLine("Provides medical assistance to wounded");
        }
    }
}
