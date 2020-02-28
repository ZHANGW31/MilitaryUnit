using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class AttackHelicopter : Vehicle
    {
        public override void HasArmor()
        {
            Console.WriteLine("The attack helicopter has armor");
        }
        public override void HasGuns()
        {
            Console.WriteLine("The attack helicopter has heat seaking missile pods, and chin mounted 50 caliber machine gun.");
        }
        public void Attack()
        {
            Console.WriteLine("The attack helicopter is good for fires support and air to ground combat");
        }
    }
}
