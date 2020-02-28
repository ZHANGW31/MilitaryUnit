using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class LogisticsMission : Mission
    {
        public override void MissionPurpose()
        {
            Console.WriteLine("The purpose of a logistics mission ranges from resupply, cargo delivery, vehicle recovery etc");
        }
        public void LogisticsPersonnel()
        {
            Console.WriteLine("Personnel on a logistics mission may vary, it can be anyone trained to drive the military vehicles.");
        }
        public void LogisticsEquipment()
        {
            Console.WriteLine("Depending on the mission size, the equipment includes communications equipment, vehicles, cargo, fuel, and supplies");
        }
    }
}
