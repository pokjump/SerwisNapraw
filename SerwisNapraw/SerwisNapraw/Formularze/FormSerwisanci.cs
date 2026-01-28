using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormSerwisanci : Form
	{
		private ZarzadzanieSerwisem serwis;
		private KontrolerSerwisantow kontroler;

		public FormSerwisanci(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			serwis = z;
			kontroler = new KontrolerSerwisantow(serwis);

			foreach (var s in kontroler.DajSerwisantow())
			{
				lstSerwisanci.Items.Add(s);
			}

			lstSerwisanci.SelectedIndexChanged += WyborSerwisanta;
			lstZadania.DoubleClick += WyborZadania;
		}

		private void WyborSerwisanta(object sender, EventArgs e)
		{
			lstZadania.Items.Clear();
			if (lstSerwisanci.SelectedItem != null)
			{
				Serwisant s = lstSerwisanci.SelectedItem as Serwisant;
				var zadania = kontroler.DajZadania(s);
				foreach (var z in zadania)
				{
					lstZadania.Items.Add(z);
				}
			}
		}

		private void WyborZadania(object sender, EventArgs e)
		{
			if (lstZadania.SelectedItem != null)
			{
				Naprawa n = lstZadania.SelectedItem as Naprawa;
				kontroler.PokazSzczegoly(n);
			}
		}
	}
}