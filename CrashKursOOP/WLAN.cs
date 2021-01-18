using System;
using System.Collections.Generic;
using System.Text;

namespace CrashKursOOP
{
    class WLAN
    {
        //einfache Assoziation auf Ferienhaus
        private Ferienhaus _ferienhaus;
        public string WPA2Password { get; set; }

        public WLAN(Ferienhaus fh)
        {
            _ferienhaus = fh;
        }
    }
}
