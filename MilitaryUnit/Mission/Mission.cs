using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Mission //Base class
    {
        private string missionName; //field
        public string MissionName //property
        {
            get { return missionName; }
            set { missionName = value; }
        }

        public void TroopRequirements()
        {
            Console.WriteLine("This mission requires troops");
        }
        public void VehicleRequirements()
        {
            Console.WriteLine("This mission requires vehicles");
        }
        public virtual void MissionPurpose()
        {
            Console.WriteLine("Default mission purpose");
        }
    }
}
