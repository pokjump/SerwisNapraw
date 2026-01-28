using System.Collections.Generic;
using System.Drawing;

namespace SerwisNapraw
{
    public class KontrolerWykresow
    {
        private WykresPresenter dane;
        private WykresRenderer rysownik;
        public List<SeriaDanych> Serie => dane.Serie;

        public KontrolerWykresow(ZarzadzanieSerwisem z)
        {
            dane = new WykresPresenter(z);
            rysownik = new WykresRenderer();
        }

        public void RysujNa(Graphics g, Rectangle r, int rok)
        {
             var d = dane.PobierzDane(rok);
             rysownik.Rysuj(g, r, d, rok);
        }

        public Bitmap GenerujObraz(int width, int height, int rok)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                RysujNa(g, new Rectangle(0, 0, width, height), rok);
            }
            return bmp;
        }
    }
}