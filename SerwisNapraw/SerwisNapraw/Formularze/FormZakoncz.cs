using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormZakoncz : Form
	{
		private ZarzadzanieSerwisem serwis;
		private KontrolerZakonczeniaZlecenia kontroler;

		public FormZakoncz(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;
			kontroler = new KontrolerZakonczeniaZlecenia(serwis);

			serwis.NaprawaRozliczona += (s, e) => Close();

			foreach (var n in kontroler.DajAktywne())
			{
				cmbNaprawy.Items.Add(n);
			}

			if (cmbNaprawy.Items.Count > 0)
			{
				cmbNaprawy.SelectedIndex = 0;
			}

			cmbNaprawy.SelectedIndexChanged += WyborNaprawy;
			btnZatwierdz.Click += Zatwierdz;
			btnDodajReczne.Click += DodajReczne;
		}

		private void WyborNaprawy(object sender, EventArgs e)
		{
			if (cmbNaprawy.SelectedItem != null)
			{
				Naprawa n = cmbNaprawy.SelectedItem as Naprawa;
				lblSzczegoly.Text = n.PobierzSzczegoly();
				
				clbDodatkowe.Items.Clear();
				foreach (var item in kontroler.PrzygotujWeryfikacje(n))
				{
					clbDodatkowe.Items.Add(item.Key, item.Value);
				}
			}
		}

		private void DodajReczne(object sender, EventArgs e)
		{
			if (kontroler.CzyMoznaDodacCzynnosc(txtDodatkoweReczne.Text))
			{
				clbDodatkowe.Items.Add(txtDodatkoweReczne.Text, true);
			}
		}

		private void Zatwierdz(object sender, EventArgs e)
		{
			Naprawa n = cmbNaprawy.SelectedItem as Naprawa;

			kontroler.Rozlicz(n, numRobocizna.Value, numCzesci.Value, txtUzyteCzesci.Text, clbDodatkowe.CheckedItems);
		}
	}
}