using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Sidearm : Weapon
    {
        public override void WeaponEmployment()
        {
            Console.WriteLine("Backup Weapon, In Close Spaces");
        }

        public void SideArmAmmoTypes()
        {
            Console.WriteLine("9mm , .45 ACP, .45 Auto ");
        }

        public void SideArmMounts()
        {
            Console.WriteLine("Sidearm Iron Sights, Laser, Flashlight ");
        }
    }
}
