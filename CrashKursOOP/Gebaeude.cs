using System;
using System.Collections.Generic;
using System.Text;

namespace CrashKursOOP
{
    abstract class Gebaeude
    {
        private string _adresse;
        public string Adresse
        {
            set
            {
                if (value != "")
                {
                    _adresse = value;
                }
            }
            get
            {
                return _adresse;
            }
        }
    }

    class Haus : Gebaeude
    {
        private int _stockwerke;
        private List<Bewohner> _hausBewohner;
        public int Stockwerke
        { 
            get { return _stockwerke; }
            set 
            {
                if (value > 0)
                {
                    _stockwerke = value;
                }
            }
        }

        public Haus()
        {
            _hausBewohner = new List<Bewohner>();
        }

        public void Einziehen(Bewohner b)
        {
            _hausBewohner.Add(b);
        }

        public void Ausziehen(Bewohner b)
        {
            _hausBewohner.Remove(b);
        }
    }

    class Garage : Gebaeude
    {
        public bool TorIstOffen { get; set; }
        public bool AutoStehtDrin { get; set; }
    }

    class Ferienhaus : Haus
    {
        public DateTime BelegtStart { get; set; }
        public DateTime BelegtEnde { get; set; }
    }
}
