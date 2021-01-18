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
            meinHaus.Adresse = "Schöne Straße 5, 58483 Schönhausen";
            meinHaus.Stockwerke = 3;

            Bewohner bw1 = new Bewohner();
            bw1.Name = "Tom";

            Haus huette1 = new Haus();
            //huette1._qmZahl = -45.3; //Geht nicht, weil das Feld protected ist.



            //meinHaus.Einziehen(bw1);

            //Ferienhaus fh = new Ferienhaus();
            //fh.BelegtStart = new DateTime(3, 7, 2021);
            //fh.BelegtEnde = new DateTime(28, 7, 2021);

            Ferienhaus meinFeHa = new Ferienhaus();


           // WLAN meinWLan = new WLAN(meinFeHa);





            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
