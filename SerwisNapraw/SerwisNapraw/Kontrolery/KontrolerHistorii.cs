using System.Collections.Generic;

namespace SerwisNapraw
{
    public class KontrolerHistorii
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerHistorii(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public List<Naprawa> Szukaj(bool zakonczone, bool aktywne, string tekst)
        {
            return serwis.PrzeszukajHistorie(zakonczone, aktywne, tekst);
        }
    }
}