using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void SpecialtyTraining()
        {
            Console.WriteLine("This troop is infantry"); //Default implementation for this virtual method.
        }
        public void BasicTraining()
        {
            Console.WriteLine("This troop has recieved basic training");
        }
        public void StandardIssuedGear()
        {
            Console.WriteLine("This troop has standard combat and survival equipment.");
        }
        public virtual void Title()
        {

        }
        public virtual void Rank()
        {

        }
    }
}
