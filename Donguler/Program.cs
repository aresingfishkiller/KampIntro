using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "1";
            string kurs2 = "2";
            string kurs3 = "3";



            string[] kurslar = new string[] {"1", "2", "3" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
