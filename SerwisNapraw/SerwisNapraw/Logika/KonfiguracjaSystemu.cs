using System;
using System.Collections.Generic;
using System.Linq;

namespace SerwisNapraw
{
	public static class KonfiguracjaSystemu
	{
		private static Dictionary<string, Func<Sprzet>> fabrykaSprzetu = new Dictionary<string, Func<Sprzet>>();
		private static Dictionary<string, List<string>> usterkiDlaTypu = new Dictionary<string, List<string>>();
		private static List<Serwisant> dostepniSerwisanci = new List<Serwisant>();

		public static void ZarejestrujSprzet<T>(string nazwa) where T : Sprzet, new()
		{
			if (!fabrykaSprzetu.ContainsKey(nazwa))
			{
				fabrykaSprzetu.Add(nazwa, () => new T());
				InicjalizujListeUsterek(nazwa);
			}
		}

		public static void ZarejestrujNowyTyp(string nazwa)
		{
			if (!fabrykaSprzetu.ContainsKey(nazwa))
			{
				fabrykaSprzetu.Add(nazwa, () => new SprzetGeneryczny(nazwa));
				InicjalizujListeUsterek(nazwa);
			}
		}

		private static void InicjalizujListeUsterek(string nazwa)
		{
			if (!usterkiDlaTypu.ContainsKey(nazwa))
			{
				usterkiDlaTypu.Add(nazwa, new List<string>());
			}
		}

		public static void UsunTyp(string nazwa)
		{
			if (fabrykaSprzetu.ContainsKey(nazwa))
			{
				fabrykaSprzetu.Remove(nazwa);
				usterkiDlaTypu.Remove(nazwa);
			}
		}

		public static void DodajSerwisanta(string imie, params string[] kwalifikacje)
		{
			var s = new Serwisant(imie);
			foreach (var k in kwalifikacje) s.Kwalifikacje.Add(k);
			dostepniSerwisanci.Add(s);
		}

		public static void DodajSerwisantaObiekt(Serwisant s)
		{
			dostepniSerwisanci.Add(s);
		}

		public static void UsunSerwisanta(Serwisant s)
		{
			var doUsuniecia = dostepniSerwisanci.FirstOrDefault(x => x.Imie == s.Imie);
			if (doUsuniecia != null) dostepniSerwisanci.Remove(doUsuniecia);
		}

		public static void DodajCzynnosc(string typ, string nazwa)
		{
			if (usterkiDlaTypu.ContainsKey(typ))
			{
				if (!usterkiDlaTypu[typ].Contains(nazwa))
					usterkiDlaTypu[typ].Add(nazwa);
			}
		}

		public static void UsunCzynnosc(string typ, string nazwa)
		{
			if (usterkiDlaTypu.ContainsKey(typ))
			{
				usterkiDlaTypu[typ].Remove(nazwa);
			}
		}

		public static string[] DajNazwyTypow()
		{
			return fabrykaSprzetu.Keys.ToArray();
		}

		public static Sprzet StworzSprzet(string nazwa)
		{
			if (fabrykaSprzetu.ContainsKey(nazwa))
			{
				return fabrykaSprzetu[nazwa]();
			}
			return null;
		}

		public static List<Serwisant> DajSerwisantow()
		{
			return new List<Serwisant>(dostepniSerwisanci);
		}

		public static List<string> DajCzynnosci(string typ)
		{
			if (usterkiDlaTypu.ContainsKey(typ))
			{
				return new List<string>(usterkiDlaTypu[typ]);
			}
			return new List<string>();
		}

		public static void ZaladujDomyslne()
		{
			ZarejestrujSprzet<Komputer>("Komputer");
			ZarejestrujSprzet<Telefon>("Telefon");
			ZarejestrujSprzet<Monitor>("Monitor");
			ZarejestrujSprzet<Drukarka>("Drukarka");

			usterkiDlaTypu["Komputer"].AddRange(new[] { "Formatowanie", "Czyszczenie", "Wymiana dysku", "Diagnostyka", "Instalacja systemu" });
			usterkiDlaTypu["Telefon"].AddRange(new[] { "Wymiana baterii", "Wymiana ekranu", "Gniazdo ładowania", "Simlock" });
			usterkiDlaTypu["Monitor"].AddRange(new[] { "Wymiana matrycy", "Naprawa zasilacza", "Martwe piksele" });
			usterkiDlaTypu["Drukarka"].AddRange(new[] { "Czyszczenie głowicy", "Wymiana rolek", "Toner", "Zacięcie papieru" });

			DodajSerwisanta("Marek Nowak", "Komputer", "Monitor");
			DodajSerwisanta("Ewa Wiśniewska", "Drukarka");
			DodajSerwisanta("Piotr Zieliński", "Komputer", "Monitor", "Drukarka");
			DodajSerwisanta("Kamil Stoch", "Telefon", "Komputer");
		}
	}
}