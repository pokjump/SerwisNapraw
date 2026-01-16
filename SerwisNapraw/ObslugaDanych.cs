using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerwisNapraw
{
	class ObslugaDanych
	{
		private static string SciezkaDoPliku => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "baza.json");

		public static void Zapisz(List<Naprawa> listaNapraw)
		{
			var opcjeSerializacji = new JsonSerializerOptions();
			opcjeSerializacji.WriteIndented = true;

			string zawartoscPliku = JsonSerializer.Serialize(listaNapraw, opcjeSerializacji);
			File.WriteAllText(SciezkaDoPliku, zawartoscPliku);
		}

		public static List<Naprawa> Wczytaj()
		{
			if (File.Exists(SciezkaDoPliku))
			{
				string zawartoscPliku = File.ReadAllText(SciezkaDoPliku);
				return JsonSerializer.Deserialize<List<Naprawa>>(zawartoscPliku);
			}
			else
			{
				return new List<Naprawa>();
			}
		}
	}
}