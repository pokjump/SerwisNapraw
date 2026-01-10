namespace SerwisNapraw
{
	public class Telefon : Sprzet
	{
		public override List<string> DajUsterki()
		{
			List<string> lista = new List<string>();
			lista.Add("Wymiana baterii");
			lista.Add("Wymiana ekranu");
			lista.Add("Gniazdo ładowania");
			lista.Add("Simlock");
			return lista;
		}
	}
}