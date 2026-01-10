using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SerwisNapraw
{
	
	[JsonDerivedType(typeof(Komputer), typeDiscriminator: "komputer")] // helper plik
	[JsonDerivedType(typeof(Monitor), typeDiscriminator: "monitor")] // helper plik
	[JsonDerivedType(typeof(Drukarka), typeDiscriminator: "drukarka")] // helper plik
	[JsonDerivedType(typeof(Telefon), typeDiscriminator: "telefon")] // helper plik
	public class Sprzet
	{
		public string Model { get; set; }
		public string NumerSeryjny { get; set; }

		public virtual List<string> DajUsterki()
		{
			return new List<string>();
		}
	}
}