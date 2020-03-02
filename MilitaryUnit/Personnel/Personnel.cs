using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        private string name;
        private string rank;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public void DisplayRankAndName()
        {
            Console.WriteLine(rank + " " + name);
        }
        public virtual void Title()
        {
            Console.WriteLine("Basic Troop");
        }
        public virtual void SpecialtyTraining()
        {
            Console.WriteLine("This troop has no specialty training."); //Default implementation for this virtual method.
        }
        public void BasicTraining()
        {
            Console.WriteLine("This troop has recieved basic training");
        }
        public void StandardIssuedGear()
        {
            Console.WriteLine("This troop has standard combat and survival equipment.");
        }
        public virtual void SpecialEquipment()
        {
            Console.WriteLine("This troop has no special equipment"); //Default implementation for this virtual method.
        }
    }
}
