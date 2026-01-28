using System.Collections.Generic;

namespace SerwisNapraw
{
    public class KontrolerKonfiguracji
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerKonfiguracji(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public string[] DajTypy() => serwis.DajTypySprzetu();
        public List<string> DajCzynnosci(string typ) => serwis.DajUsterkiDlaTypu(typ);
        public List<Serwisant> DajSerwisantow() => serwis.DajSerwisantow();

        public void DodajTyp(string nazwa) => serwis.DodajNowyTypSprzetu(nazwa);
        public void UsunTyp(string nazwa) => serwis.UsunTypSprzetu(nazwa);
        public void DodajCzynnosc(string typ, string nazwa) => serwis.DodajCzynnosc(typ, nazwa);
        public void UsunCzynnosc(string typ, string nazwa) => serwis.UsunCzynnosc(typ, nazwa);
        
        public void DodajSerwisanta(string imie, System.Collections.IEnumerable wybraneKwalifikacje)
        {
            List<string> kwalifikacje = new List<string>();
            foreach (var item in wybraneKwalifikacje)
            {
                kwalifikacje.Add(item.ToString());
            }
            serwis.DodajSerwisanta(imie, kwalifikacje);
        }

        public void UsunSerwisanta(string imie) => serwis.UsunSerwisanta(imie);
    }
}