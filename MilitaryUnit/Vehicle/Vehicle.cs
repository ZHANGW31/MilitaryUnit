using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Vehicle
    {
        private string vehicleName;

        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }
        public void PersonnelCapacity(int capacity)
        {
            Console.WriteLine($"This vehicle has a personnel capacity of: {capacity}");
        }
        public void TerrainCapability(string terrainType)
        {
            Console.WriteLine($"This vehicle is a {terrainType} vehicle.");
        }
        public virtual void HasGuns()
        {
            Console.WriteLine("No Guns"); //No guns is the default implementation here.
        }
        public virtual void HasArmor()
        {
            Console.WriteLine("No Armor"); //No armor is the default implementation here.
        }

    }
}
