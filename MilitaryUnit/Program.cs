using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MilitaryUnit");

            Rifle m16 = new Rifle("5.56");
            m16.WeaponName = "M16";

            Console.WriteLine("\nThe " + m16.WeaponName + " is a rifle");
            m16.WeaponEmployment();
            m16.EffectiveRange("550 meters");
            m16.CarryStyle("Sling");
            m16.RifleAmmoTypes();
            m16.RifleMountingOptions();


        }
    }
}
