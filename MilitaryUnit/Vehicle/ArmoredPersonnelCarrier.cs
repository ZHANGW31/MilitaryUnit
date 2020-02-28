using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class ArmoredPersonnelCarrier : Vehicle
    {
        public void Wheels()
        {
            Console.WriteLine("All Terrain Wheels, Tracks");
        }

        public override void HasArmor()
        {
            Console.WriteLine("Has Armor");
        }
        public override void HasGuns()
        {
            Console.WriteLine("50 Cal machine gun, 40mm grenade launcher, 7.62 Machine Gun");
        }
        
    }
}
