using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormHistoria : Form
	{
		List<Naprawa> _wszystkie;
		List<Naprawa> _przefiltrowane = new List<Naprawa>();

		public FormHistoria(List<Naprawa> baza)
		{
			InitializeComponent();
			_wszystkie = baza;

			chkPokazAktywne.CheckedChanged += FiltrChanged;
			chkPokazZakonczone.CheckedChanged += FiltrChanged;

			// designer err
			txtSzukaj.TextChanged += txtSzukaj_TextChanged;
			lstHistoria.SelectedIndexChanged += lstHistoria_SelectedIndexChanged;

			Odswiez();
		}

		private void FiltrChanged(object sender, EventArgs e)
		{
			Odswiez();
		}

		
		private void txtSzukaj_TextChanged(object sender, EventArgs e) //designer req
		{
			Odswiez();
		}

		private void Odswiez()
		{
			lstHistoria.Items.Clear();
			_przefiltrowane.Clear();

			string fraza = txtSzukaj.Text.ToLower();

			foreach (Naprawa n in _wszystkie)
			{
				bool pokaz = false;

				if (n.CzyZakonczona == true && chkPokazZakonczone.Checked) pokaz = true;
				if (n.CzyZakonczona == false && chkPokazAktywne.Checked) pokaz = true;

				if (pokaz == true && fraza != "")
				{
					string tekst = n.Urzadzenie.Model + " " + n.Wlasciciel.ImieNazwisko + " " + n.Urzadzenie.NumerSeryjny;
					tekst = tekst.ToLower();

					if (tekst.Contains(fraza) == false) pokaz = false;
				}

				if (pokaz)
				{
					_przefiltrowane.Add(n);
					lstHistoria.Items.Add(n.Info());
				}
			}
		}

		private void lstHistoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = lstHistoria.SelectedIndex;
			if (i > -1)
			{
				Naprawa n = _przefiltrowane[i];
				lblSzczegolyHistorii.Text = n.PobierzSzczegoly();
			}
		}
	}
}