using System.Collections.Generic;

namespace SerwisNapraw
{
    public class KontrolerSerwisantow
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerSerwisantow(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public List<Serwisant> DajSerwisantow() => serwis.DajSerwisantow();
        public List<Naprawa> DajZadania(Serwisant s) => serwis.PobierzAktywneDlaSerwisanta(s);
        public void PokazSzczegoly(Naprawa n) => serwis.WyswietlSzczegolyNaprawy(n);
    }
}