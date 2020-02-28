using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Patrol : Mission
    {
        public override void MissionPurpose()
        {
            Console.WriteLine("The purpose of a patrol mission ranges from force projection, security, destroying the enemy");
        }
        public void PatrolPersonnel()
        {
            Console.WriteLine("Any basicly trained troop may serve as a patrol personnel");
        }
        public void PatrolEquipment()
        {
            Console.WriteLine("Patrol equipment varies based on distance, length and mission statement.");
        }
    }
}
