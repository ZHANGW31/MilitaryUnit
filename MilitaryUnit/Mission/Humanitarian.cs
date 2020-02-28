using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Humanitarian : Mission
    {
        public override void MissionPurpose()
        {
            Console.WriteLine("The purpose of a humanitarian mission is to aid civilian organizations with shelter, food, medical supplies etc ");
        }
        public void HumanitarianPersonnel()
        {
            Console.WriteLine("Any basicly trained troop may be assigned, medical and logistics personnel recommened.");
        }
        public void HumanitarianEquipment()
        {
            Console.WriteLine("Depending on the mission size, the equipment includes communications equipment, vehicles, cargo, fuel, and supplies");
        }

    }
}
