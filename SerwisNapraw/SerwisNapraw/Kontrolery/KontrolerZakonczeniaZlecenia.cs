using System.Collections.Generic;

namespace SerwisNapraw
{
    public class KontrolerZakonczeniaZlecenia
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerZakonczeniaZlecenia(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public List<Naprawa> DajAktywne() => serwis.PobierzAktywne();
        public Dictionary<string, bool> PrzygotujWeryfikacje(Naprawa n) => serwis.PrzygotujCzynnosciDoWeryfikacji(n);
        
        public void Rozlicz(Naprawa n, decimal robocizna, decimal czesci, string opisCzesci, System.Collections.IEnumerable wybraneCzynnosci) 
        {
            string czynnosci = "";
            foreach (var item in wybraneCzynnosci)
            {
                czynnosci += item.ToString() + ", ";
            }
            serwis.RozliczNaprawe(n, robocizna, czesci, opisCzesci, czynnosci);
        }

        public bool CzyMoznaDodacCzynnosc(string tekst)
        {
            return !string.IsNullOrWhiteSpace(tekst);
        }
    }
}