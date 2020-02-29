using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Sidearm : Weapon
    {
        private string ammoType;
        public Sidearm(string ammo)
        {
            ammoType = ammo;
        }

        public override void WeaponEmployment()
        {
            Console.WriteLine("It is used for: Backup Weapon, In Close Spaces");
        }

        public void SideArmAmmoTypes()
        {
            Console.WriteLine("It uses: " + ammoType + " ammunition.");
        }

        public void SideArmMounts()
        {
            Console.WriteLine("Sidearm Iron Sights, Laser, Flashlight ");
        }
    }
}
