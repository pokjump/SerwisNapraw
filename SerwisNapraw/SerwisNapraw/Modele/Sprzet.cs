using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SerwisNapraw
{
	[JsonDerivedType(typeof(Komputer), typeDiscriminator: "komputer")]
	[JsonDerivedType(typeof(Monitor), typeDiscriminator: "monitor")]
	[JsonDerivedType(typeof(Drukarka), typeDiscriminator: "drukarka")]
	[JsonDerivedType(typeof(Telefon), typeDiscriminator: "telefon")]
	public abstract class Sprzet
	{
		public string Model { get; set; }
		public string NumerSeryjny { get; set; }

		[JsonIgnore] 
		public abstract string NazwaTypu { get; }

		public virtual List<string> DajUsterki()
		{
			return new List<string>();
		}
	}
}