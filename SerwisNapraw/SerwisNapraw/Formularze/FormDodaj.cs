using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormDodaj : Form
	{
		private ZarzadzanieSerwisem serwis;
		private KontrolerDodawaniaZlecenia kontroler;

		public FormDodaj(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;
			kontroler = new KontrolerDodawaniaZlecenia(serwis);

			serwis.ZlecenieDodane += (s, e) => this.DialogResult = DialogResult.OK;

			cmbTyp.Items.AddRange(kontroler.DajTypy());
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
			if (kontroler.CzyMoznaDodacCzynnosc(txtRecznaCzynnosc.Text))
			{
				clbCzynnosci.Items.Add(txtRecznaCzynnosc.Text, true);
			}
		}

		private void ZmianaKlienta(object sender, EventArgs e)
		{
			var etykiety = kontroler.PobierzEtykietyKlienta(rbFirma.Checked);
			label4.Text = etykiety.LabelImie;
			label5.Text = etykiety.LabelNazwisko;
		}

		private void OdswiezUsterki()
		{
			clbCzynnosci.Items.Clear();
			foreach (var usterka in kontroler.DajUsterki(cmbTyp.Text))
			{
				clbCzynnosci.Items.Add(usterka);
			}
		}

		private void Zapisz(object sender, EventArgs e)
		{
			kontroler.Zapisz(
				cmbTyp.Text, 
				txtModel.Text, 
				txtSN.Text,
				txtKlientImie.Text, 
				txtKlientNazwisko.Text, 
				txtKlientTel.Text,
				rbFirma.Checked, 
				clbCzynnosci.CheckedItems, 
				txtOpis.Text
			);
		}
	}
}