﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        private string weaponName;

        public string WeaponName
        {
            get { return weaponName; }
            set { weaponName = value; }
        }

        public void EffectiveRange(string effectiveRange)
        {
            Console.WriteLine($"The effective range of this weapon is: {effectiveRange}");
        }
        public void CarryStyle(string carryStyle)
        {
            Console.WriteLine($"The carry style of this weapon is: {carryStyle}");
        }
        public virtual void WeaponEmployment()
        {
            Console.WriteLine("The default weapon employment technique");
        }

    }
}
