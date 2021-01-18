using System;
using System.Collections.Generic;
using System.Text;

namespace CrashKursOOP
{
    abstract class Gebaeude
    {
        protected double _qmZahl;
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

        private void Ausbauen()
        {
            _qmZahl = _qmZahl + 5.4;
        }
    }

    class Haus : Gebaeude
    {
        private Haustuere _meineHaustuere;
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
            
            //Komposition => Eigenschaften werden im Konstruktor angelegt.
            _meineHaustuere = new Haustuere(this);
        }

        public void Einziehen(Bewohner b)
        {
            _hausBewohner.Add(b);
            _qmZahl -= 20.0;
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
        //einfache Assoziation auf WLAN.
        private WLAN _wlan;
        public DateTime BelegtStart { get; set; }
        public DateTime BelegtEnde { get; set; }

        public Ferienhaus()
        {
            _wlan = new WLAN(this);
        }
    }
}
