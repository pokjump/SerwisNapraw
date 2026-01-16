using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class Form1 : Form
	{
		private ZarzadzanieSerwisem serwis = new ZarzadzanieSerwisem();

		public Form1()
		{
			InitializeComponent();
			
			serwis.ZglosKomunikat += PokazKomunikat;
			serwis.ZglosBlad += PokazBlad;
			serwis.ZadajPytanie += ZadajPytanie;

			lstNaprawy.DoubleClick += KlikniecieNaListe;

			OdswiezListe();
		}

		private void PokazKomunikat(object sender, KomunikatEventArgs e)
		{
			MessageBox.Show(e.Tresc, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void PokazBlad(object sender, KomunikatEventArgs e)
		{
			MessageBox.Show(e.Tresc, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void ZadajPytanie(object sender, PytanieEventArgs e)
		{
			DialogResult dr = MessageBox.Show(e.Pytanie, "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				e.Odpowiedz = true;
			}
			else
			{
				e.Odpowiedz = false;
			}
		}

		private void OdswiezListe()
		{
			lstNaprawy.Items.Clear();
			foreach (var n in serwis.PobierzAktywne())
			{
				lstNaprawy.Items.Add(n);
			}
		}

		private void btnNoweZlecenie_Click(object sender, EventArgs e)
		{
			FormDodaj okno = new FormDodaj(serwis);
			if (okno.ShowDialog() == DialogResult.OK)
			{
				OdswiezListe();
			}
		}

		private void btnZakonczZlecenie_Click(object sender, EventArgs e)
		{
			if (lstNaprawy.Items.Count > 0)
			{
				FormZakoncz okno = new FormZakoncz(serwis);
				okno.ShowDialog();
				OdswiezListe();
			}
		}

		private void btnSerwisanci_Click(object sender, EventArgs e)
		{
			FormSerwisanci okno = new FormSerwisanci(serwis);
			okno.ShowDialog();
		}

		private void btnWykresy_Click(object sender, EventArgs e)
		{
			FormWykresy okno = new FormWykresy(serwis);
			okno.ShowDialog();
		}

		private void btnHistoria_Click(object sender, EventArgs e)
		{
			FormHistoria okno = new FormHistoria(serwis);
			okno.ShowDialog();
		}

		private void btnKonfiguracja_Click(object sender, EventArgs e)
		{
			FormKonfiguracja okno = new FormKonfiguracja(serwis);
			okno.ShowDialog();
		}

		private void KlikniecieNaListe(object sender, EventArgs e)
		{
			if (lstNaprawy.SelectedItem != null)
			{
				Naprawa n = lstNaprawy.SelectedItem as Naprawa;
				serwis.WyswietlSzczegolyNaprawy(n);
			}
		}
	}
}