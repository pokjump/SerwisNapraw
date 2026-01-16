using System;
using System.Collections.Generic;
using System.Drawing;

namespace SerwisNapraw
{
	public class WykresPresenter
	{
		private ZarzadzanieSerwisem serwis;
		private List<Color> kolory = new List<Color> 
		{ 
			Color.Blue, Color.Green, Color.Orange, Color.Red, Color.Purple, Color.Brown, 
			Color.Teal, Color.Magenta, Color.Olive, Color.Navy, Color.Maroon, Color.DarkCyan 
		};

		public List<SeriaDanych> Serie { get; private set; }

		public WykresPresenter(ZarzadzanieSerwisem z)
		{
			serwis = z;
			Serie = new List<SeriaDanych>();
			Inicjalizuj();
		}

		private void Inicjalizuj()
		{
			Dodaj("Nowe zlecenia", kolory[0], "Nowe", true);
			Dodaj("Zakończone (ogółem)", kolory[1], "Zakończone", false);
			Dodaj("Komputery", kolory[2], "Komputer", false);
			Dodaj("Telefony", kolory[3], "Telefon", false);
			Dodaj("Monitory", kolory[4], "Monitor", false);
			Dodaj("Drukarki", kolory[5], "Drukarka", false);

			var serwisanci = serwis.DajSerwisantow();
			int idx = 6;
			foreach (var s in serwisanci)
			{
				Color k = kolory[idx % kolory.Count];
				Dodaj("Zakończone: " + s.Imie, k, "Serwisant:" + s.Imie, false);
				idx++;
			}
		}

		private void Dodaj(string nazwa, Color k, string klucz, bool aktywne)
		{
			Serie.Add(new SeriaDanych 
			{ 
				Nazwa = nazwa, 
				Kolor = k, 
				KluczKategorii = klucz,
				CzyAktywna = aktywne
			});
		}

		public Dictionary<SeriaDanych, Dictionary<int, int>> PobierzDane(int rok)
		{
			var wynik = new Dictionary<SeriaDanych, Dictionary<int, int>>();
			foreach (var s in Serie)
			{
				if (s.CzyAktywna)
				{
					var dane = serwis.DajDaneWykresu(rok, s.KluczKategorii);
					wynik.Add(s, dane);
				}
			}
			return wynik;
		}
	}
}