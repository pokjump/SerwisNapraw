using System.Collections.Generic;

namespace SerwisNapraw
{
    public class KontrolerGlownegoOkna
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerGlownegoOkna(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public List<Naprawa> PobierzAktywne()
        {
            return serwis.PobierzAktywne();
        }
        
        public void PokazSzczegoly(Naprawa n)
        {
            serwis.WyswietlSzczegolyNaprawy(n);
        }

        public bool CzySaAktywneNaprawy(int liczbaElementow)
        {
            return liczbaElementow > 0;
        }
    }
}