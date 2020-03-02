using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class CommunicationsTroop : Personnel
    {

        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved communications training");
        }
        public override void Title()
        {
            Console.WriteLine("Radio Operator");
        }
        public override void SpecialEquipment()
        {
            Console.WriteLine("This troop is equipped with specialized communications equipment");
        }
        public void CommunicationCapabilities()
        {
            Console.WriteLine("Provides secure communications, and can call for fire.");
        }
    }
}
