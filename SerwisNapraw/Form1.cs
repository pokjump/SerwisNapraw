using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerwisNapraw
{
    public partial class Form1 : Form
    {
        List<Naprawa> naprawy = new List<Naprawa>();
        List<Naprawa> widoczneNaprawy = new List<Naprawa>();
        List<Serwisant> serwisanci = new List<Serwisant>();

        public Form1()
        {
            InitializeComponent();

            lstNaprawy.DoubleClick += lstNaprawy_DoubleClick;

            serwisanci = Serwisant.DajWszystkich();

            try
            {
                naprawy = ObslugaDanych.Wczytaj();
            }
            catch
            {
                // pusta lista jak blad
            }

            OdswiezListe();
        }

        private void btnNoweZlecenie_Click(object sender, EventArgs e)
        {
            FormDodaj okno = new FormDodaj(naprawy, serwisanci);

            if (okno.ShowDialog() == DialogResult.OK)
            {
                naprawy.Add(okno.NowaNaprawa);
                Zapisz();
                MessageBox.Show("Dodano zlecenie.");
            }
        }

        private void btnZakonczZlecenie_Click(object sender, EventArgs e)
        {
            if (widoczneNaprawy.Count == 0)
            {
                MessageBox.Show("Brak aktywnych napraw.");
                return;
            }

            FormZakoncz okno = new FormZakoncz(naprawy);
            okno.ShowDialog();

            Zapisz();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            FormHistoria okno = new FormHistoria(naprawy);
            okno.ShowDialog();
        }

        private void lstNaprawy_DoubleClick(object sender, EventArgs e)
        {
            int index = lstNaprawy.SelectedIndex;
            if (index > -1)
            {
                Naprawa n = widoczneNaprawy[index];
                MessageBox.Show(n.PobierzSzczegoly(), "Szczegó³y");
            }
        }

        private void Zapisz()
        {
            OdswiezListe();
            try
            {
                ObslugaDanych.Zapisz(naprawy);
            }
            catch { }
        }

        private void OdswiezListe()
        {
            lstNaprawy.Items.Clear();
            widoczneNaprawy.Clear();

            foreach (Naprawa n in naprawy)
            {
                if (n.CzyZakonczona == false)
                {
                    widoczneNaprawy.Add(n);
                    lstNaprawy.Items.Add(n.Info());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}