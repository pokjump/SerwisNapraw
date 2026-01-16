using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormKonfiguracja : Form
	{
		private ZarzadzanieSerwisem serwis;

		public FormKonfiguracja(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;

			serwis.ZmianaDanych += (s, e) => { OdswiezTypy(); OdswiezSerwisantow(); };

			OdswiezTypy();
			OdswiezSerwisantow();

			btnDodajTyp.Click += DodajTyp;
			btnUsunTyp.Click += UsunTyp;
			
			btnDodajCzynnosc.Click += DodajCzynnosc;
			btnUsunCzynnosc.Click += UsunCzynnosc;
			
			btnDodajSerwisanta.Click += DodajSerwisanta;
			btnUsunSerwisanta.Click += UsunSerwisanta;

			lstTypy.SelectedIndexChanged += WyborTypu;
			cmbTypSprzetu.SelectedIndexChanged += WyborTypuCombo;
		}

		private void OdswiezTypy()
		{
			string wybrany = null;
			if (lstTypy.SelectedItem != null) wybrany = lstTypy.SelectedItem.ToString();

			lstTypy.Items.Clear();
			cmbTypSprzetu.Items.Clear();
			clbKwalifikacje.Items.Clear();

			string[] typy = serwis.DajTypySprzetu();
			lstTypy.Items.AddRange(typy);
			cmbTypSprzetu.Items.AddRange(typy);
			clbKwalifikacje.Items.AddRange(typy);

			if (wybrany != null && lstTypy.Items.Contains(wybrany))
			{
				lstTypy.SelectedItem = wybrany;
				cmbTypSprzetu.SelectedItem = wybrany;
			}
			else if (lstTypy.Items.Count > 0)
			{
				lstTypy.SelectedIndex = 0;
				cmbTypSprzetu.SelectedIndex = 0;
			}
			OdswiezCzynnosci();
		}

		private void WyborTypu(object sender, EventArgs e)
		{
			if (lstTypy.SelectedItem != null)
			{
				cmbTypSprzetu.SelectedItem = lstTypy.SelectedItem;
				OdswiezCzynnosci();
			}
		}

		private void WyborTypuCombo(object sender, EventArgs e)
		{
			if (cmbTypSprzetu.SelectedItem != null)
			{
				lstTypy.SelectedItem = cmbTypSprzetu.SelectedItem;
				OdswiezCzynnosci();
			}
		}

		private void OdswiezCzynnosci()
		{
			lstCzynnosci.Items.Clear();
			if (lstTypy.SelectedItem != null)
			{
				foreach (var c in serwis.DajUsterkiDlaTypu(lstTypy.SelectedItem.ToString()))
				{
					lstCzynnosci.Items.Add(c);
				}
			}
		}

		private void DodajTyp(object sender, EventArgs e)
		{
			serwis.DodajNowyTypSprzetu(txtNowyTyp.Text);
			txtNowyTyp.Text = "";
		}

		private void UsunTyp(object sender, EventArgs e)
		{
			if (lstTypy.SelectedItem != null)
			{
				serwis.UsunTypSprzetu(lstTypy.SelectedItem.ToString());
			}
		}

		private void DodajCzynnosc(object sender, EventArgs e)
		{
			string typ = cmbTypSprzetu.SelectedItem?.ToString();
			serwis.DodajCzynnosc(typ, txtNowaCzynnosc.Text);
			txtNowaCzynnosc.Text = "";
		}

		private void UsunCzynnosc(object sender, EventArgs e)
		{
			if (lstTypy.SelectedItem != null && lstCzynnosci.SelectedItem != null)
			{
				string typ = lstTypy.SelectedItem.ToString();
				string czynnosc = lstCzynnosci.SelectedItem.ToString();
				serwis.UsunCzynnosc(typ, czynnosc);
			}
		}

		private void OdswiezSerwisantow()
		{
			lstSerwisanci.Items.Clear();
			foreach (var s in serwis.DajSerwisantow()) lstSerwisanci.Items.Add(s);
		}

		private void DodajSerwisanta(object sender, EventArgs e)
		{
			List<string> kwalifikacje = new List<string>();
			foreach (var item in clbKwalifikacje.CheckedItems) kwalifikacje.Add(item.ToString());

			serwis.DodajSerwisanta(txtImie.Text, kwalifikacje);
			
			txtImie.Text = "";
			for (int i = 0; i < clbKwalifikacje.Items.Count; i++) clbKwalifikacje.SetItemChecked(i, false);
		}

		private void UsunSerwisanta(object sender, EventArgs e)
		{
			if (lstSerwisanci.SelectedItem is Serwisant s)
			{
				serwis.UsunSerwisanta(s.Imie);
			}
		}
	}
}