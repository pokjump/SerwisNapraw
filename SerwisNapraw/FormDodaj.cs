using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormDodaj : Form
	{
		private ZarzadzanieSerwisem serwis;

		public FormDodaj(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;

			serwis.ZlecenieDodane += (s, e) => this.DialogResult = DialogResult.OK;

			cmbTyp.Items.AddRange(serwis.DajTypySprzetu());
			cmbTyp.SelectedIndex = 0;

			cmbTyp.SelectedIndexChanged += WyborTypu;
			btnDodajCzynnosc.Click += DodajRecznaczynnosc;
			rbFirma.CheckedChanged += ZmianaKlienta;
			rbOsoba.CheckedChanged += ZmianaKlienta;
			btnZapisz.Click += Zapisz;

			OdswiezUsterki();
		}

		private void WyborTypu(object sender, EventArgs e)
		{
			OdswiezUsterki();
		}

		private void DodajRecznaczynnosc(object sender, EventArgs e)
		{
			if (txtRecznaCzynnosc.Text != "")
			{
				clbCzynnosci.Items.Add(txtRecznaCzynnosc.Text, true);
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

		private void OdswiezUsterki()
		{
			clbCzynnosci.Items.Clear();
			foreach (var usterka in serwis.DajUsterkiDlaTypu(cmbTyp.Text))
			{
				clbCzynnosci.Items.Add(usterka);
			}
		}

		private void Zapisz(object sender, EventArgs e)
		{
			string wybrane = "";
			foreach (var item in clbCzynnosci.CheckedItems)
			{
				wybrane += item + ", ";
			}

			serwis.DodajZlecenie(
				cmbTyp.Text, 
				txtModel.Text, 
				txtSN.Text,
				txtKlientImie.Text, 
				txtKlientNazwisko.Text, 
				txtKlientTel.Text,
				rbFirma.Checked, 
				wybrane, 
				txtOpis.Text
			);
		}
	}
}