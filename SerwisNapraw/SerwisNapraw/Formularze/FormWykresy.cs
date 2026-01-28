using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SerwisNapraw
{
	public partial class FormWykresy : Form
	{
		private KontrolerWykresow kontroler;

		public FormWykresy(ZarzadzanieSerwisem z)
		{
			InitializeComponent();
			kontroler = new KontrolerWykresow(z);

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
			foreach (var s in kontroler.Serie)
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
					var bmp = kontroler.GenerujObraz(w, h, (int)numRok.Value);
					bmp.Save(sfd.FileName, ImageFormat.Png);
					bmp.Dispose();
					
					MessageBox.Show("Zapisano wykres do pliku.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void Rysuj(object sender, PaintEventArgs e)
		{
			kontroler.RysujNa(e.Graphics, pbWykres.ClientRectangle, (int)numRok.Value);
		}
	}
}