using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerwisNapraw
{
	public class KomunikatEventArgs : EventArgs
	{
		public string Tresc { get; }
		public KomunikatEventArgs(string tresc)
		{
			Tresc = tresc;
		}
	}

	public class PytanieEventArgs : EventArgs
	{
		public string Pytanie { get; }
		public bool Odpowiedz { get; set; }
		public PytanieEventArgs(string pytanie)
		{
			Pytanie = pytanie;
		}
	}

	public class ZarzadzanieSerwisem
	{
		public event EventHandler<KomunikatEventArgs> ZglosKomunikat;
		public event EventHandler<KomunikatEventArgs> ZglosBlad;
		public event EventHandler<PytanieEventArgs> ZadajPytanie;
		public event EventHandler ZmianaDanych;
		public event EventHandler ZlecenieDodane;
		public event EventHandler NaprawaRozliczona;

		private List<Naprawa> bazaNapraw;
		private List<Serwisant> listaSerwisantow;

		public ZarzadzanieSerwisem()
		{
			listaSerwisantow = KonfiguracjaSystemu.DajSerwisantow();
			try { bazaNapraw = ObslugaDanych.Wczytaj(); }
			catch { bazaNapraw = new List<Naprawa>(); }
		}

		public void Zapisz()
		{
			ObslugaDanych.Zapisz(bazaNapraw);
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public string[] DajTypySprzetu() => KonfiguracjaSystemu.DajNazwyTypow();

		public List<string> DajUsterkiDlaTypu(string typ) => KonfiguracjaSystemu.DajCzynnosci(typ);

		public void DodajNowyTypSprzetu(string nazwa)
		{
			if (string.IsNullOrWhiteSpace(nazwa))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Nazwa typu sprzętu nie może być pusta."));
				return;
			}
			
			if (KonfiguracjaSystemu.DajNazwyTypow().Contains(nazwa))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Taki typ sprzętu już istnieje."));
				return;
			}

			KonfiguracjaSystemu.ZarejestrujNowyTyp(nazwa);
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Pomyślnie dodano typ: " + nazwa));
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public void UsunTypSprzetu(string nazwa)
		{
			if (string.IsNullOrWhiteSpace(nazwa)) return;
			
			var pyt = new PytanieEventArgs("Czy na pewno usunąć typ sprzętu: " + nazwa + "?");
			ZadajPytanie?.Invoke(this, pyt);
			if (!pyt.Odpowiedz) return;

			KonfiguracjaSystemu.UsunTyp(nazwa);
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Usunięto typ sprzętu: " + nazwa));
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public void DodajCzynnosc(string typ, string nazwa)
		{
			if (string.IsNullOrEmpty(typ))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Nie wybrano typu sprzętu."));
				return;
			}
			if (string.IsNullOrWhiteSpace(nazwa))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Nazwa czynności nie może być pusta."));
				return;
			}

			KonfiguracjaSystemu.DodajCzynnosc(typ, nazwa);
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Dodano czynność do: " + typ));
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public void UsunCzynnosc(string typ, string nazwa)
		{
			if (string.IsNullOrEmpty(typ) || string.IsNullOrEmpty(nazwa)) return;

			var pyt = new PytanieEventArgs("Czy usunąć czynność: " + nazwa + "?");
			ZadajPytanie?.Invoke(this, pyt);
			if (!pyt.Odpowiedz) return;

			KonfiguracjaSystemu.UsunCzynnosc(typ, nazwa);
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Usunięto czynność: " + nazwa));
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public void DodajSerwisanta(string imie, List<string> kwalifikacje)
		{
			if (string.IsNullOrWhiteSpace(imie))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Imię i nazwisko serwisanta jest wymagane."));
				return;
			}

			if (kwalifikacje == null || kwalifikacje.Count == 0)
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Serwisant musi posiadać przynajmniej jedną kwalifikację."));
				return;
			}

			Serwisant s = new Serwisant(imie);
			s.Kwalifikacje = kwalifikacje;
			
			KonfiguracjaSystemu.DodajSerwisantaObiekt(s);
			listaSerwisantow = KonfiguracjaSystemu.DajSerwisantow();
			
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Zarejestrowano nowego serwisanta."));
			ZmianaDanych?.Invoke(this, EventArgs.Empty);
		}

		public void UsunSerwisanta(string imie)
		{
			var s = listaSerwisantow.FirstOrDefault(x => x.Imie == imie);
			if (s != null)
			{
				var pyt = new PytanieEventArgs("Czy na pewno usunąć serwisanta: " + imie + "?");
				ZadajPytanie?.Invoke(this, pyt);
				if (!pyt.Odpowiedz) return;

				KonfiguracjaSystemu.UsunSerwisanta(s);
				listaSerwisantow = KonfiguracjaSystemu.DajSerwisantow();
				ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Usunięto serwisanta z systemu."));
				ZmianaDanych?.Invoke(this, EventArgs.Empty);
			}
		}

		public string RozpoznajTypSprzetu(Sprzet sprzet)
		{
			if (sprzet == null) return "Nieznany";
			return sprzet.NazwaTypu;
		}

		public Dictionary<string, bool> PrzygotujCzynnosciDoWeryfikacji(Naprawa naprawa)
		{
			var wynik = new Dictionary<string, bool>();
			string typ = RozpoznajTypSprzetu(naprawa.Urzadzenie);
			var standardowe = DajUsterkiDlaTypu(typ);
			string opis = naprawa.OpisUsterki ?? "";

			foreach (var usterka in standardowe)
			{
				if (opis.Contains(usterka)) wynik.Add(usterka, true);
				else wynik.Add(usterka, false);
			}
			return wynik;
		}

		public List<Naprawa> PobierzAktywne() => bazaNapraw.Where(n => !n.CzyZakonczona).ToList();

		public List<Naprawa> PobierzAktywneDlaSerwisanta(Serwisant s)
		{
			return bazaNapraw.Where(n => !n.CzyZakonczona && n.Wykonawca != null && n.Wykonawca.Imie == s.Imie).ToList();
		}

		public List<Naprawa> PrzeszukajHistorie(bool zakonczone, bool aktywne, string tekst)
		{
			string szukaj = tekst.ToLower();
			var wynik = new List<Naprawa>();

			foreach (var n in bazaNapraw)
			{
				bool pasuje = (n.CzyZakonczona && zakonczone) || (!n.CzyZakonczona && aktywne);
				if (pasuje)
				{
					string dane = (n.Urzadzenie.Model + " " + n.Wlasciciel.ImieNazwisko + " " + n.Urzadzenie.NumerSeryjny).ToLower();
					if (string.IsNullOrEmpty(szukaj) || dane.Contains(szukaj)) wynik.Add(n);
				}
			}
			return wynik;
		}

		public void WyswietlSzczegolyNaprawy(Naprawa naprawa)
		{
			if (naprawa != null)
			{
				ZglosKomunikat?.Invoke(this, new KomunikatEventArgs(naprawa.PobierzSzczegoly()));
			}
		}

		public void DodajZlecenie(string typ, string model, string sn, string imie, string nazwisko, string tel, bool firma, string usterki, string uwagi)
		{
			if (string.IsNullOrWhiteSpace(model))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Musisz podać model urządzenia!"));
				return;
			}
			if (string.IsNullOrWhiteSpace(sn))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Numer seryjny jest wymagany!"));
				return;
			}

			if (firma)
			{
				if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
				{
					ZglosBlad?.Invoke(this, new KomunikatEventArgs("Dla firmy wymagana jest nazwa i NIP."));
					return;
				}
				string czystyNip = nazwisko.Replace("-", "").Trim();
				if (!Regex.IsMatch(czystyNip, @"^\d{10}$"))
				{
					ZglosBlad?.Invoke(this, new KomunikatEventArgs("Nieprawidłowy format NIP (10 cyfr)."));
					return;
				}
			}
			else
			{
				if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
				{
					ZglosBlad?.Invoke(this, new KomunikatEventArgs("Podaj imię i nazwisko klienta."));
					return;
				}
			}

			if (!Regex.IsMatch(tel, @"^\d{9}$") && !Regex.IsMatch(tel, @"^\d{12}$"))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Nieprawidłowy numer telefonu."));
				return;
			}

			string opis = usterki.TrimEnd(',', ' ');
			if (string.IsNullOrWhiteSpace(opis) || opis.Length < 3)
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Opis usterki jest wymagany."));
				return;
			}

			if (!string.IsNullOrWhiteSpace(uwagi)) opis += " | Uwagi: " + uwagi;
			
			Serwisant serwisant = listaSerwisantow.FirstOrDefault();
			Sprzet sprzet = KonfiguracjaSystemu.StworzSprzet(typ);
			
			if (sprzet == null)
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Błąd krytyczny: Nieznany typ sprzętu."));
				return;
			}

			sprzet.Model = model;
			sprzet.NumerSeryjny = sn;
			
			Klient k = new Klient { Telefon = tel, CzyFirma = firma };
			if (firma) { k.ImieNazwisko = imie; k.Nip = nazwisko; }
			else { k.ImieNazwisko = imie + " " + nazwisko; k.Nip = ""; }

			bazaNapraw.Add(new Naprawa
			{
				Urzadzenie = sprzet, Wlasciciel = k, Wykonawca = serwisant,
				OpisUsterki = opis, Data = DateTime.Now
			});

			Zapisz();
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Zlecenie przyjęte."));
			ZlecenieDodane?.Invoke(this, EventArgs.Empty);
		}

		public void RozliczNaprawe(Naprawa naprawa, decimal robocizna, decimal czesci, string opisCzesci, string czynnosci)
		{
			if (naprawa == null) return;
			if (robocizna < 0 || czesci < 0)
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Koszty nie mogą być ujemne."));
				return;
			}
			if (czesci > 0 && string.IsNullOrWhiteSpace(opisCzesci))
			{
				ZglosBlad?.Invoke(this, new KomunikatEventArgs("Podaj wykaz użytych części."));
				return;
			}
			if (robocizna == 0)
			{
				var pyt = new PytanieEventArgs("Zamykasz zlecenie z kosztem robocizny 0 zł. Kontynuować?");
				ZadajPytanie?.Invoke(this, pyt);
				if (!pyt.Odpowiedz) return;
			}

			naprawa.OpisUsterki = czynnosci.TrimEnd(',', ' ');
			naprawa.KosztRobocizny = robocizna;
			naprawa.KosztCzesci = czesci;
			naprawa.UzyteCzesciOpis = string.IsNullOrWhiteSpace(opisCzesci) ? "Brak" : opisCzesci;
			naprawa.CzyZakonczona = true;
			naprawa.DataZakonczenia = DateTime.Now;
			
			Zapisz();
			ZglosKomunikat?.Invoke(this, new KomunikatEventArgs("Zlecenie zamknięte."));
			NaprawaRozliczona?.Invoke(this, EventArgs.Empty);
		}

		public Dictionary<string, int> DajStatystykiSerwisantow()
		{
			var s = new Dictionary<string, int>();
			foreach (var n in bazaNapraw)
			{
				if (n.CzyZakonczona && n.Wykonawca != null)
				{
					if (s.ContainsKey(n.Wykonawca.Imie)) s[n.Wykonawca.Imie]++;
					else s.Add(n.Wykonawca.Imie, 1);
				}
			}
			return s;
		}

		public Dictionary<string, int> DajStatystykiSprzetu()
		{
			var s = new Dictionary<string, int>();
			foreach (var n in bazaNapraw)
			{
				string t = RozpoznajTypSprzetu(n.Urzadzenie);
				if (s.ContainsKey(t)) s[t]++;
				else s.Add(t, 1);
			}
			return s;
		}

		public Dictionary<int, int> DajDaneWykresu(int rok, string kategoria)
		{
			var w = new Dictionary<int, int>();
			for (int i = 1; i <= 12; i++) w[i] = 0;

			foreach (var n in bazaNapraw)
			{
				DateTime? d = n.CzyZakonczona && kategoria == "Zakończone" ? n.DataZakonczenia : n.Data;
				
				if (d.HasValue && d.Value.Year == rok)
				{
					int m = d.Value.Month;
					if (kategoria == "Zakończone") w[m]++;
					else if (kategoria == "Nowe") w[m]++;
					else if (kategoria.StartsWith("Serwisant:") && n.CzyZakonczona && n.Wykonawca?.Imie == kategoria.Substring(10)) w[m]++;
					else if (RozpoznajTypSprzetu(n.Urzadzenie) == kategoria) w[m]++;
				}
			}
			return w;
		}

		public List<Serwisant> DajSerwisantow() => listaSerwisantow;
	}
}