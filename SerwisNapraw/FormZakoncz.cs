using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormZakoncz : Form
	{
		List<Naprawa> _baza;

		public FormZakoncz(List<Naprawa> baza)
		{
			InitializeComponent();
			_baza = baza;

			btnZatwierdz.Click += btnZatwierdz_Click;
			cmbNaprawy.SelectedIndexChanged += cmbNaprawy_SelectedIndexChanged;

			Zaladuj();
		}

		private void Zaladuj()
		{
			cmbNaprawy.Items.Clear();
			foreach (Naprawa n in _baza)
			{
				if (n.CzyZakonczona == false)
				{
					cmbNaprawy.Items.Add(n);
				}
			}

			if (cmbNaprawy.Items.Count > 0) cmbNaprawy.SelectedIndex = 0;
		}

		private void cmbNaprawy_SelectedIndexChanged(object sender, EventArgs e)
		{
			Naprawa n = cmbNaprawy.SelectedItem as Naprawa;
			if (n != null)
			{
				lblSzczegoly.Text = n.PobierzSzczegoly();
			}
		}

		private void btnZatwierdz_Click(object sender, EventArgs e)
		{
			Naprawa n = cmbNaprawy.SelectedItem as Naprawa;
			if (n == null) return;

			n.KosztRobocizny = numRobocizna.Value;
			n.KosztCzesci = numCzesci.Value;

			if (txtUzyteCzesci.Text == "") n.UzyteCzesciOpis = "Brak";
			else n.UzyteCzesciOpis = txtUzyteCzesci.Text;

			n.CzyZakonczona = true;
			n.DataZakonczenia = DateTime.Now;

			MessageBox.Show("Rozliczono!");
			Close();
		}
	}
}