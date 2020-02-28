using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Tank : Vehicle
    {
        public override void HasArmor()
        {
            Console.WriteLine("3 inch thick composite armor");
        }
        public override void HasGuns()
        {
            Console.WriteLine("105mm, 120mm, 50 caliber machine gun");
        }
    }
}
