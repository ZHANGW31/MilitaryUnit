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

            Sidearm m1911 = new Sidearm("45 ACP");
            m1911.WeaponName = "Colt M1911";

            Console.WriteLine("\nThe " + m1911.WeaponName + " is a sidearm");
            m1911.WeaponEmployment();
            m1911.EffectiveRange("100 meters");
            m1911.CarryStyle("holster");
            m1911.SideArmAmmoTypes();
            m1911.SideArmMounts();

           
            ArmoredPersonnelCarrier amtrak = new ArmoredPersonnelCarrier();
            amtrak.VehicleName = "amtrack";

            Console.WriteLine("\nThe " + amtrak.VehicleName + "is an armored personnel carrier");
            amtrak.HasArmor();
            amtrak.HasGuns();
            amtrak.PersonnelCapacity(10);
            amtrak.TerrainCapability("This is an all terrain vehicle");

            Console.WriteLine();
            CommunicationsTroop comJoe = new CommunicationsTroop();
            comJoe.Name = "Joe";
            comJoe.Rank = "Corporal";
            comJoe.DisplayRankAndName();
            comJoe.Title();
            comJoe.SpecialEquipment();
            comJoe.SpecialtyTraining();
        }
    }
}
