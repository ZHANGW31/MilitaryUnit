using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Reconnaissance : Mission
    {
        public override void MissionPurpose()
        {
            Console.WriteLine("The purpose of a Reconnaissance Mission is to gather intelligence on the enemy and scout the enemy territory");
        }
        public void ReconPersonnel()
        {
            Console.WriteLine("Recon missions requires specially trained personnel");
        }
        public void ReconEquipment()
        {
            Console.WriteLine("Special Recon Loadout and supplies.");
        }
    }
}
