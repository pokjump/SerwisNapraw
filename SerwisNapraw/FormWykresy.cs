using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormWykresy : Form
	{
		private WykresPresenter dane;
		private WykresRenderer rysownik;

		public FormWykresy(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			dane = new WykresPresenter(z);
			rysownik = new WykresRenderer();

			numRok.Value = DateTime.Now.Year;

			Inicjalizuj();

			numRok.ValueChanged += Odswiez;
			pbWykres.Paint += Rysuj;
			pbWykres.Resize += Odswiez;
			btnEksport.Click += Eksportuj;
		}

		private void Inicjalizuj()
		{
			flpOpcje.Controls.Clear();
			foreach (var s in dane.Serie)
			{
				CheckBox cb = new CheckBox();
				cb.Text = s.Nazwa;
				cb.ForeColor = s.Kolor;
				cb.Checked = s.CzyAktywna;
				cb.AutoSize = true;
				
				if (s.Nazwa.StartsWith("Zakończone naprawy:"))
				{
					cb.Width = 250;
				}

				cb.CheckedChanged += (sender, e) => 
				{
					s.CzyAktywna = cb.Checked;
					pbWykres.Invalidate();
				};

				flpOpcje.Controls.Add(cb);
			}
		}

		private void Odswiez(object sender, EventArgs e)
		{
			pbWykres.Invalidate();
		}

		private void Eksportuj(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "PNG Image|*.png";
				sfd.FileName = "Wykres_" + numRok.Value + ".png";
				
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					int w = 1000;
					int h = 800;
					Bitmap bmp = new Bitmap(w, h);
					
					using (Graphics g = Graphics.FromImage(bmp))
					{
						var d = dane.PobierzDane((int)numRok.Value);
						rysownik.Rysuj(g, new Rectangle(0, 0, w, h), d, (int)numRok.Value);
					}
					
					bmp.Save(sfd.FileName, ImageFormat.Png);
					MessageBox.Show("Zapisano wykres do pliku.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void Rysuj(object sender, PaintEventArgs e)
		{
			var d = dane.PobierzDane((int)numRok.Value);
			rysownik.Rysuj(e.Graphics, pbWykres.ClientRectangle, d, (int)numRok.Value);
		}
	}
}