using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class TransportHelicopter : Vehicle
    {
        public override void HasArmor()
        {
            Console.WriteLine("Has Armor");
        }
        public override void HasGuns()
        {
            Console.WriteLine("7.62 Gattling Gun");
        }
        public void AirTransportation()
        {
            Console.WriteLine("Can transport many troops via airlift");
        }
    }
}
