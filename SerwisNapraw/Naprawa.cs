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

		public decimal DajCeneRazem()
		{
			return KosztRobocizny + KosztCzesci;
		}

		public string OpisUsterki { get; set; }
		public bool CzyZakonczona { get; set; } = false;

		public DateTime Data { get; set; }
		public DateTime? DataZakonczenia { get; set; } = null;

		public string Info()
		{
			string stan = "W TOKU";
			if (CzyZakonczona) stan = "ZAKOŃCZONA";

			string k = "Brak";
			if (Wlasciciel != null) k = Wlasciciel.ImieNazwisko;

			return Data.ToShortDateString() + " | " + Urzadzenie.Model + " | " + k + " | " + stan;
		}

		// szczegoly
		public string PobierzSzczegoly()
		{
			string koniec = "---";
			if (DataZakonczenia != null)
			{
				koniec = DataZakonczenia.ToString();
			}

			string s = "";
			s = s + "KLIENT: " + Wlasciciel.ImieNazwisko + "\n";
			s = s + "TELEFON: " + Wlasciciel.Telefon + "\n";

			if (Wlasciciel.CzyFirma)
			{
				s = s + "NIP: " + Wlasciciel.Nip + "\n";
			}

			s = s + "SPRZĘT: " + Urzadzenie.Model + " (SN: " + Urzadzenie.NumerSeryjny + ")\n";
			s = s + "USTERKA: " + OpisUsterki + "\n";
			s = s + "SERWISANT: " + Wykonawca.Imie + "\n";
			s = s + "----------------------------------\n";
			s = s + "DATA PRZYJĘCIA: " + Data.ToString() + "\n";
			s = s + "DATA ZAKOŃCZENIA: " + koniec + "\n";
			s = s + "----------------------------------\n";
			s = s + "ROZLICZENIE:\n";
			s = s + "   Robocizna: " + KosztRobocizny + " PLN\n";
			s = s + "   Części:    " + KosztCzesci + " PLN\n";
			s = s + "   RAZEM:     " + DajCeneRazem() + " PLN";

			return s;
		}
		public override string ToString()
		{
			return Urzadzenie.Model + " - " + Wlasciciel.ImieNazwisko;
		}
	}
}