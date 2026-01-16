using System.Collections.Generic;

namespace SerwisNapraw
{
	public class SprzetGeneryczny : Sprzet
	{
		private string nazwaTypu;

		public SprzetGeneryczny() 
		{
			nazwaTypu = "Nieznany"; 
		}

		public SprzetGeneryczny(string nazwa)
		{
			nazwaTypu = nazwa;
		}

		public override string NazwaTypu => nazwaTypu;
	}
}