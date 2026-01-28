using System.Collections.Generic;

namespace SerwisNapraw
{
	public class Serwisant
	{
		public string Imie { get; set; }
		public List<string> Kwalifikacje { get; set; } = new List<string>();

		public Serwisant() { }
		public Serwisant(string imie) { Imie = imie; }

		public override string ToString()
		{
			return Imie;
		}
	}
}