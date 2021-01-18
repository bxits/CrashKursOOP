using System;
using System.Collections.Generic;
using System.Text;

namespace CrashKursOOP
{
    class Haustuere
    {
        private Haus _meinHaus;
        bool IsAbgeschlossen { get; set; }

        public Haustuere(Haus h)
        {
            _meinHaus = h;
        }
    }
}
