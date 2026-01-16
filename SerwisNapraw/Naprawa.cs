using System;

namespace SerwisNapraw
{
	public class Naprawa
	{
		public Sprzet Urzadzenie { get; set; }
		public Serwisant Wykonawca { get; set; }
		public Klient Wlasciciel { get; set; }

		public decimal KosztRobocizny { get; set; }
		public decimal KosztCzesci { get; set; }
		public string UzyteCzesciOpis { get; set; } = "Brak";

		public string OpisUsterki { get; set; }
		public bool CzyZakonczona { get; set; } = false;

		public DateTime Data { get; set; }
		public DateTime? DataZakonczenia { get; set; } = null;

		public decimal DajCeneRazem()
		{
			return KosztRobocizny + KosztCzesci;
		}

		public override string ToString()
		{
			string stan = CzyZakonczona ? "ZAKOŃCZONA" : "W TOKU";
			string klient = Wlasciciel != null ? Wlasciciel.ImieNazwisko : "---";

			return $"{Data.ToShortDateString()} | {Urzadzenie.Model} | {klient} | {stan}";
		}

		public string PobierzSzczegoly()
		{
			string dataZakonczeniaTekst = DataZakonczenia.HasValue ? DataZakonczenia.Value.ToString() : "---";

			string szczegoly = "";
			szczegoly += "KLIENT: " + (Wlasciciel != null ? Wlasciciel.ImieNazwisko : "Brak") + "\n";
			szczegoly += "TELEFON: " + (Wlasciciel != null ? Wlasciciel.Telefon : "Brak") + "\n";

			if (Wlasciciel != null && Wlasciciel.CzyFirma)
				szczegoly += "NIP: " + Wlasciciel.Nip + "\n";

			szczegoly += "SPRZĘT: " + Urzadzenie.Model + " (SN: " + Urzadzenie.NumerSeryjny + ")\n";
			szczegoly += "USTERKA: " + OpisUsterki + "\n";
			szczegoly += "SERWISANT: " + (Wykonawca != null ? Wykonawca.Imie : "Brak") + "\n";
			szczegoly += "----------------------------------\n";
			szczegoly += "DATA PRZYJĘCIA: " + Data.ToString() + "\n";
			szczegoly += "DATA ZAKOŃCZENIA: " + dataZakonczeniaTekst + "\n";

			if (CzyZakonczona)
			{
				szczegoly += "----------------------------------\n";
				szczegoly += "ROZLICZENIE:\n";
				szczegoly += "   Robocizna: " + KosztRobocizny + " PLN\n";
				szczegoly += "   Części:    " + KosztCzesci + " PLN\n";
				szczegoly += "   UZYTE CZĘŚCI: " + UzyteCzesciOpis + "\n";
				szczegoly += "   RAZEM:     " + DajCeneRazem() + " PLN";
			}
			else
			{
				szczegoly += "STATUS: W trakcie naprawy";
			}
			return szczegoly;
		}
	}
}