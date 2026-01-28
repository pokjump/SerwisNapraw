using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace SerwisNapraw
{
	public class WykresRenderer
	{
		public void Rysuj(Graphics g, Rectangle obszar, Dictionary<SeriaDanych, Dictionary<int, int>> dane, int rok)
		{
			g.Clear(Color.White);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			
			int max = 0;
			foreach (var seria in dane.Values)
			{
				if (seria.Values.Count > 0)
				{
					int m = seria.Values.Max();
					if (m > max) max = m;
				}
			}

			int krok = 10;
			if (max > 100) krok = 20;
			if (max > 200) krok = 50;
			if (max > 500) krok = 100;

			int reszta = max % krok;
			if (reszta != 0 || max == 0)
			{
				max = max + (krok - reszta);
			}
			max += krok;

			int mL = 50;
			int mR = 20;
			int mT = 40;
			int mB = 100;

			int w = obszar.Width;
			int h = obszar.Height;
			int plotW = w - mL - mR;
			int plotH = h - mT - mB;

			g.FillRectangle(Brushes.WhiteSmoke, mL, mT, plotW, plotH);

			RysujOsie(g, mL, mT, plotW, plotH, max, krok, h - mB);
			RysujSlupki(g, dane, mL, mT, plotW, plotH, max, h - mB);
			RysujLegende(g, dane.Keys.ToList(), mL, h - mB + 30, w - mR);
		}

		private void RysujOsie(Graphics g, int x, int y, int w, int h, int max, int krok, int osY)
		{
			g.DrawLine(Pens.Black, x, y, x, osY);
			g.DrawLine(Pens.Black, x, osY, x + w, osY);

			int ileKrokow = max / krok;
			float skokPx = (float)h / ileKrokow;
			Font f = new Font("Segoe UI", 8);
			
			for (int i = 0; i <= ileKrokow; i++)
			{
				float posY = osY - (i * skokPx);
				int val = i * krok;
				
				g.DrawLine(Pens.LightGray, x, posY, x + w, posY);
				
				string lbl = val.ToString();
				SizeF s = g.MeasureString(lbl, f);
				g.DrawString(lbl, f, Brushes.Black, x - s.Width - 5, posY - s.Height / 2);
			}

			string[] miesiace = { "Sty", "Lut", "Mar", "Kwi", "Maj", "Cze", "Lip", "Sie", "Wrz", "Paź", "Lis", "Gru" };
			float skokX = (float)w / 12;

			for (int i = 0; i < 12; i++)
			{
				float posX = x + i * skokX;
				float center = posX + skokX / 2;
				
				SizeF s = g.MeasureString(miesiace[i], f);
				g.DrawString(miesiace[i], f, Brushes.Black, center - s.Width / 2, osY + 5);
			}
		}

		private void RysujSlupki(Graphics g, Dictionary<SeriaDanych, Dictionary<int, int>> dane, int x, int y, int w, int h, int max, int osY)
		{
			int ileSerii = dane.Count;
			if (ileSerii == 0) return;

			float widthMiesiac = (float)w / 12;
			float gap = widthMiesiac * 0.2f; 
			float dostepne = widthMiesiac - gap;
			float widthBar = dostepne / ileSerii;

			int idx = 0;
			foreach (var wpis in dane)
			{
				var seria = wpis.Key;
				var wartosci = wpis.Value;
				Brush b = new SolidBrush(seria.Kolor);
				Pen p = new Pen(Color.FromArgb(100, 0, 0, 0));

				for (int m = 1; m <= 12; m++)
				{
					int val = wartosci[m];
					if (val > 0)
					{
						float barH = ((float)val / max) * h;
						float startX = x + (m - 1) * widthMiesiac + (gap / 2) + (idx * widthBar);
						float startY = osY - barH;

						g.FillRectangle(b, startX, startY, widthBar, barH);
						g.DrawRectangle(p, startX, startY, widthBar, barH);
					}
				}
				idx++;
			}
		}

		private void RysujLegende(Graphics g, List<SeriaDanych> serie, int x, int y, int maxX)
		{
			int cx = x;
			int cy = y;
			Font f = new Font("Segoe UI", 9, FontStyle.Bold);
			int h = 20;
			
			foreach (var s in serie)
			{
				string t = s.Nazwa;
				SizeF size = g.MeasureString(t, f);
				int w = 12 + (int)size.Width + 15;

				if (cx + w > maxX)
				{
					cx = x;
					cy += h; 
				}

				g.FillRectangle(new SolidBrush(s.Kolor), cx, cy, 10, 10);
				g.DrawRectangle(Pens.Black, cx, cy, 10, 10);
				
				g.DrawString(t, f, Brushes.Black, cx + 12, cy - 2);
				
				cx += w;
			}
		}
	}
}