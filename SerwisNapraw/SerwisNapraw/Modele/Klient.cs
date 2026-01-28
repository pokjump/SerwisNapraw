namespace SerwisNapraw
{
	public class Klient
	{
		public string ImieNazwisko { get; set; }
		public string Telefon { get; set; }
		public string Nip { get; set; }
		public bool CzyFirma { get; set; }

		public override string ToString()
		{
			if (CzyFirma == true)
			{
				return ImieNazwisko + " (NIP: " + Nip + ")";
			}
			else
			{
				return ImieNazwisko;
			}
		}
	}
}