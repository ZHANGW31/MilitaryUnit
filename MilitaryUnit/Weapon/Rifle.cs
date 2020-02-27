using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Rifle : Weapon
    {
        public override void WeaponEmployment()
        {
            Console.WriteLine("Distanced Engagements, Suppressing Fire");
        }
        public void RifleAmmoTypes()
        {
            Console.WriteLine("Standard NATO Rifle Ammunition Cartridges are: 5.56 x 45mm, 7.62 x 51mm");
        }
        public void RifleMountingOptions()
        {
            Console.WriteLine("Scope, Bipod, Rifle Sights, Laser Pointers, Flash Lights, Grenade Launcher");
        }

    }
}
