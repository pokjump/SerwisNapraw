using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerwisNapraw
{
	class ObslugaDanych
	{
		public static void Zapisz(List<Naprawa> lista)
		{
			var opcje = new JsonSerializerOptions();
			opcje.WriteIndented = true;

			string tekst = JsonSerializer.Serialize(lista, opcje);
			File.WriteAllText("baza.json", tekst);
		}

		public static List<Naprawa> Wczytaj()
		{
			if (File.Exists("baza.json"))
			{
				string tekst = File.ReadAllText("baza.json");
				return JsonSerializer.Deserialize<List<Naprawa>>(tekst);
			}
			else
			{
				return new List<Naprawa>();
			}
		}
	}
}