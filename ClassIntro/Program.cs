using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Raid Raid1 = new Raid();
            Raid1.KarakterAdi = "Aresing";
            Raid1.Rol = "DPS";
            Raid1.OynadıgıClass = "Priest";
            Raid1.ItemLevel = 242;


            Raid Raid2 = new Raid();
            Raid2.KarakterAdi = "Jûr";
            Raid2.Rol = "Healer";
            Raid2.OynadıgıClass = "Priest";
            Raid2.ItemLevel = 240;


            Raid Raid3 = new Raid();
            Raid3.KarakterAdi = "Ulsia";
            Raid3.Rol = "Tank";
            Raid3.OynadıgıClass = "Demon Hunter";
            Raid3.ItemLevel = 236;

            Raid[] RaidKadrosu = new Raid[] {Raid1, Raid2, Raid3 };

            foreach (Raid raid in RaidKadrosu)
            {
                Console.WriteLine(raid.KarakterAdi + " " + raid.OynadıgıClass + " " + raid.Rol + " " + raid.ItemLevel);    
            }

        }
    }

    class Raid
    {
        public string KarakterAdi { get; set; }
        public string Rol { get; set; }
        public string OynadıgıClass { get; set; }
        public int ItemLevel { get; set; }
    }
}
