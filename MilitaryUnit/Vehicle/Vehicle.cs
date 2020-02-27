using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Vehicle
    {
        public void PersonnelCapacity(int capacity)
        {
            Console.WriteLine($"This vehicle has a personnel capacity of: {capacity}");
        }
        public void Fuel(string fuelType)
        {
            Console.WriteLine($"This vehicle takes: {fuelType}");
        }
        public void TerrainCapability(string terrainType)
        {
            Console.WriteLine($"This vehicle is a {terrainType} vehicle.");
        }
        public virtual void HasGuns()
        {
            Console.WriteLine("No Guns"); //No guns is the default implementation here.
        }

    }
}
