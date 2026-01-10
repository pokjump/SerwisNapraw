using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormDodaj : Form
	{
		List<Naprawa> _obecne;
		List<Serwisant> _serwisanci;

		public Naprawa NowaNaprawa { get; private set; }

		public FormDodaj(List<Naprawa> n, List<Serwisant> s)
		{
			InitializeComponent();
			_obecne = n;
			_serwisanci = s;
			cmbTyp.Items.Add("Komputer");
			cmbTyp.Items.Add("Telefon");
			cmbTyp.Items.Add("Monitor");
			cmbTyp.Items.Add("Drukarka");
			cmbTyp.SelectedIndex = 0;
			cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;
			btnZapisz.Click += btnZapisz_Click;
			btnDodajCzynnosc.Click += btnDodajCzynnosc_Click;  // manulane dod. czynnosci
			rbOsoba.CheckedChanged += ZmianaKlienta;
			rbFirma.CheckedChanged += ZmianaKlienta;
			WczytajUsterki();
		}
		private void btnDodajCzynnosc_Click(object sender, EventArgs e) // manulane dod. czynnosci
		{
			if (!string.IsNullOrWhiteSpace(txtRecznaCzynnosc.Text))
			{
				clbCzynnosci.Items.Add(txtRecznaCzynnosc.Text, true);
				txtRecznaCzynnosc.Text = "";
			}
		}

		private void ZmianaKlienta(object sender, EventArgs e)
		{
			if (rbFirma.Checked)
			{
				label4.Text = "Nazwa Firmy";
				label5.Text = "NIP";
			}
			else
			{
				label4.Text = "Imię";
				label5.Text = "Nazwisko";
			}
		}

		private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
		{
			WczytajUsterki();
		}

		private void WczytajUsterki()
		{
			string typ = cmbTyp.Text;
			clbCzynnosci.Items.Clear();

			Sprzet s = null;
			if (typ == "Komputer") s = new Komputer();
			else if (typ == "Telefon") s = new Telefon();
			else if (typ == "Monitor") s = new Monitor();
			else if (typ == "Drukarka") s = new Drukarka();

			if (s != null)
			{
				foreach (string u in s.DajUsterki())
				{
					clbCzynnosci.Items.Add(u);
				}
			}
		}

		private void btnZapisz_Click(object sender, EventArgs e)
		{
			if (txtKlientImie.Text == "" || txtKlientNazwisko.Text == "" || txtKlientTel.Text == "")
			{
				MessageBox.Show("Podaj dane klienta!");
				return;
			}
			string opis = "";
			foreach (var item in clbCzynnosci.CheckedItems)
			{
				opis = opis + item.ToString() + ", ";
			}
			opis = opis.TrimEnd(',', ' ');

			if (txtOpis.Text != "")
			{
				if (opis != "") opis = opis + " | ";
				opis = opis + "Uwagi: " + txtOpis.Text;
			}

			if (opis == "")
			{
				MessageBox.Show("Wybierz usterkę lub wpisz opis.");
				return;
			}

			// Sszuk serw
			string typ = cmbTyp.Text;
			Serwisant wybrany = null;
			int najmniejPracy = 99999;

			foreach (Serwisant serw in _serwisanci)
			{
				if (serw.Kwalifikacje.Contains(typ))
				{
					int ileMa = 0;
					foreach (Naprawa n in _obecne)
					{
						if (n.Wykonawca == serw && n.CzyZakonczona == false)
						{
							ileMa++;
						}
					}

					if (ileMa < najmniejPracy)
					{
						najmniejPracy = ileMa;
						wybrany = serw;
					}
				}
			}

			if (wybrany == null)
			{
				MessageBox.Show("Brak serwisanta.");
				return;
			}

			// tw klient
			Klient k = new Klient();
			k.Telefon = txtKlientTel.Text;

			if (rbFirma.Checked)
			{
				k.CzyFirma = true;
				k.ImieNazwisko = txtKlientImie.Text;
				k.Nip = txtKlientNazwisko.Text;
			}
			else
			{
				k.CzyFirma = false;
				k.ImieNazwisko = txtKlientImie.Text + " " + txtKlientNazwisko.Text;
				k.Nip = "";
			}

			// tw sprzet
			Sprzet sprzet = null;
			if (typ == "Komputer") sprzet = new Komputer();
			else if (typ == "Telefon") sprzet = new Telefon();
			else if (typ == "Monitor") sprzet = new Monitor();
			else sprzet = new Drukarka();

			sprzet.Model = txtModel.Text;
			sprzet.NumerSeryjny = txtSN.Text;

			// tw naprawa
			NowaNaprawa = new Naprawa();
			NowaNaprawa.Urzadzenie = sprzet;
			NowaNaprawa.Wykonawca = wybrany;
			NowaNaprawa.Wlasciciel = k;
			NowaNaprawa.OpisUsterki = opis;
			NowaNaprawa.Data = DateTime.Now;
			NowaNaprawa.CzyZakonczona = false;
			NowaNaprawa.KosztRobocizny = 0;
			NowaNaprawa.KosztCzesci = 0;

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}