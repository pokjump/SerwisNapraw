using System.Collections.Generic;

namespace SerwisNapraw
{
	public class Drukarka : Sprzet
	{
		public override List<string> DajUsterki()
		{
			List<string> lista = new List<string>();
			lista.Add("Czyszczenie głowicy");
			lista.Add("Wymiana rolek");
			lista.Add("Toner");
			lista.Add("Zacięcie papieru");
			return lista;
		}
	}
}