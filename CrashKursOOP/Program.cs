using System;

namespace CrashKursOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kann nicht instanziiert werden, da abstact.
            //Gebaeude meinGebaeude = new Gebaeude();
            //meinGebaeude.Adresse = "";
            
            Haus meinHaus = new Haus();
            meinHaus.Adresse = "safdasdfadf";
            meinHaus.Stockwerke = 3;

            Bewohner bw1 = new Bewohner();
            bw1.Name = "Tom";

            meinHaus.Einziehen(bw1);

            Ferienhaus fh = new Ferienhaus();
            fh.BelegtStart = new DateTime(3, 7, 2021);
            fh.BelegtEnde = new DateTime(28, 7, 2021);
            




            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
