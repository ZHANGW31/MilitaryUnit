using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Melee : Weapon
    {
        public override void WeaponEmployment()
        {
            Console.WriteLine("Used for hand to hand combat");
        }
        public void Attack()
        {
            Console.WriteLine("Swing, Stab, Slash");
        }
        public void block()
        {
            Console.WriteLine("Vertical Block, Horizontal Block, Parry");
        }
    }
}
