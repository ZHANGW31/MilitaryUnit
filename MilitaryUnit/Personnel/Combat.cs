using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Combat : Personnel
    {
        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved extensive combat training");
        }
        public override void Title()
        {
            Console.WriteLine("Infantry");
        }
        public override void SpecialEquipment()
        {
            Console.WriteLine("This troop is equipped with additional weapons capabilities.");
        }
        public void CombatCapabilities()
        {
            Console.WriteLine("Suppressive fire, Fire and Manuevar, Destroy the enemy");
        }
    }
}
