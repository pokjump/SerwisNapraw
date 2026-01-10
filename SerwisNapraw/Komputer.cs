using System.Collections.Generic;

namespace SerwisNapraw
{
	public class Komputer : Sprzet
	{
		public override List<string> DajUsterki()
		{
			List<string> lista = new List<string>();
			lista.Add("Formatowanie");
			lista.Add("Czyszczenie");
			lista.Add("Wymiana dysku");
			lista.Add("Diagnostyka");
			lista.Add("Instalacja systemu");
			return lista;
		}
	}
}