using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormZakoncz : Form
	{
		private ZarzadzanieSerwisem serwis;

		public FormZakoncz(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;

			serwis.NaprawaRozliczona += (s, e) => Close();

			foreach (var n in serwis.PobierzAktywne())
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
				foreach (var item in serwis.PrzygotujCzynnosciDoWeryfikacji(n))
				{
					clbDodatkowe.Items.Add(item.Key, item.Value);
				}
			}
		}

		private void DodajReczne(object sender, EventArgs e)
		{
			if (txtDodatkoweReczne.Text != "")
			{
				clbDodatkowe.Items.Add(txtDodatkoweReczne.Text, true);
			}
		}

		private void Zatwierdz(object sender, EventArgs e)
		{
			Naprawa n = cmbNaprawy.SelectedItem as Naprawa;

			string czynnosci = "";
			foreach (var item in clbDodatkowe.CheckedItems)
			{
				czynnosci += item + ", ";
			}

			serwis.RozliczNaprawe(n, numRobocizna.Value, numCzesci.Value, txtUzyteCzesci.Text, czynnosci);
		}
	}
}