using System.Collections.Generic;

namespace SerwisNapraw
{
	public class Monitor : Sprzet
	{
		public override List<string> DajUsterki()
		{
			List<string> lista = new List<string>();
			lista.Add("Wymiana matrycy");
			lista.Add("Naprawa zasilacza");
			lista.Add("Martwe piksele");
			return lista;
		}
	}
}