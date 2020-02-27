using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Weapon
    {
        private string frameSize; //Private field , weapon frame size, for example: small , medium, large
        

        public string FrameSize //Gets and sets the frame field.
        {
            get { return frameSize; }
            set { frameSize = value; }
        }
    }
}
