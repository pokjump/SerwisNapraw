using System.Collections.Generic;
using System.Linq;

namespace SerwisNapraw
{
    public class KontrolerDodawaniaZlecenia
    {
        private ZarzadzanieSerwisem serwis;

        public KontrolerDodawaniaZlecenia(ZarzadzanieSerwisem z)
        {
            serwis = z;
        }

        public string[] DajTypy() => serwis.DajTypySprzetu();

        public List<string> DajUsterki(string typ) => serwis.DajUsterkiDlaTypu(typ);

        public void Zapisz(string typ, string model, string sn, string imie, string nazwisko, string tel, bool firma, System.Collections.IEnumerable wybraneCzynnosci, string opis)
        {
            string usterki = "";
            foreach (var item in wybraneCzynnosci)
            {
                usterki += item.ToString() + ", ";
            }

            serwis.DodajZlecenie(typ, model, sn, imie, nazwisko, tel, firma, usterki, opis);
        }

        public (string LabelImie, string LabelNazwisko) PobierzEtykietyKlienta(bool czyFirma)
        {
            if (czyFirma) return ("Nazwa Firmy", "NIP");
            else return ("Imię", "Nazwisko");
        }

        public bool CzyMoznaDodacCzynnosc(string tekst)
        {
            return !string.IsNullOrWhiteSpace(tekst);
        }
    }
}