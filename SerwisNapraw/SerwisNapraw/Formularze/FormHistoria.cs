using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormHistoria : Form
	{
		private ZarzadzanieSerwisem serwis;
		private KontrolerHistorii kontroler;

		public FormHistoria(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;
			kontroler = new KontrolerHistorii(serwis);

			chkPokazAktywne.CheckedChanged += ZmianaFiltra;
			chkPokazZakonczone.CheckedChanged += ZmianaFiltra;
			txtSzukaj.TextChanged += ZmianaTekstu;
			lstHistoria.SelectedIndexChanged += WyborElementu;

			Odswiez();
		}

		private void Odswiez()
		{
			lstHistoria.Items.Clear();
			var wyniki = kontroler.Szukaj(chkPokazZakonczone.Checked, chkPokazAktywne.Checked, txtSzukaj.Text);
			
			foreach (var n in wyniki)
			{
				lstHistoria.Items.Add(n);
			}
		}

		private void ZmianaFiltra(object sender, EventArgs e)
		{
			Odswiez();
		}

		private void ZmianaTekstu(object sender, EventArgs e)
		{
			Odswiez();
		}

		private void WyborElementu(object sender, EventArgs e)
		{
			if (lstHistoria.SelectedItem != null)
			{
				Naprawa n = lstHistoria.SelectedItem as Naprawa;
				lblSzczegolyHistorii.Text = n.PobierzSzczegoly();
			}
		}
	}
}