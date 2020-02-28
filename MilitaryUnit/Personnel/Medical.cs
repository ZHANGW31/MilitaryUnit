using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Medical : Personnel
    {
        public override void SpecialtyTraining()
        {
            Console.WriteLine("This troop has recieved Medical training");
        }
    }
}
