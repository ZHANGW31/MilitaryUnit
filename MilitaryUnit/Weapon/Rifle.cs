using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Rifle : Weapon
    {
        private string ammoType;

        public Rifle(string ammo)
        {
            ammoType = ammo;
        }
        public override void WeaponEmployment()
        {
            Console.WriteLine("It is used for: Distanced Engagements, Suppressing Fire");
        }
        public void RifleAmmoTypes()
        {
            Console.WriteLine("It uses: " + ammoType + " ammunition.");
        }
        public void RifleMountingOptions()
        {
            Console.WriteLine("Mounting options: Scope, Bipod, Rifle Sights, Laser Pointers, Flash Lights, Grenade Launcher");
        }

    }
}
