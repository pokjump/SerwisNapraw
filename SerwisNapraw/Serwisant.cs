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

		public static List<Serwisant> DajWszystkich()
		{
			List<Serwisant> lista = new List<Serwisant>();

			Serwisant s1 = new Serwisant("Marek Nowak");
			s1.Kwalifikacje.Add("Komputer");
			s1.Kwalifikacje.Add("Monitor");
			lista.Add(s1);

			Serwisant s2 = new Serwisant("Ewa Wiśniewska");
			s2.Kwalifikacje.Add("Drukarka");
			lista.Add(s2);

			Serwisant s3 = new Serwisant("Piotr Zieliński");
			s3.Kwalifikacje.Add("Komputer");
			s3.Kwalifikacje.Add("Monitor");
			s3.Kwalifikacje.Add("Drukarka");
			lista.Add(s3);

			Serwisant s4 = new Serwisant("Kamil Stoch");
			s4.Kwalifikacje.Add("Telefon");
			s4.Kwalifikacje.Add("Komputer");
			lista.Add(s4);

			return lista;
		}
	}
}