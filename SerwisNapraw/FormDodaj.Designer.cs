namespace SerwisNapraw
{
	partial class FormDodaj
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			label1 = new Label();
			cmbTyp = new ComboBox();
			label2 = new Label();
			txtModel = new TextBox();
			label3 = new Label();
			txtSN = new TextBox();
			label4 = new Label();
			txtKlientImie = new TextBox();
			label5 = new Label();
			txtKlientNazwisko = new TextBox();
			label6 = new Label();
			txtKlientTel = new TextBox();
			label7 = new Label();
			clbCzynnosci = new CheckedListBox();
			btnZapisz = new Button();
			label8 = new Label();
			txtOpis = new TextBox();
			rbOsoba = new RadioButton();
			rbFirma = new RadioButton();
			txtRecznaCzynnosc = new TextBox();
			btnDodajCzynnosc = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(85, 15);
			label1.TabIndex = 0;
			label1.Text = "Typ urządzenia";
			// 
			// cmbTyp
			// 
			cmbTyp.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbTyp.FormattingEnabled = true;
			cmbTyp.Location = new Point(12, 33);
			cmbTyp.Name = "cmbTyp";
			cmbTyp.Size = new Size(200, 23);
			cmbTyp.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 69);
			label2.Name = "label2";
			label2.Size = new Size(79, 15);
			label2.TabIndex = 2;
			label2.Text = "Marka/Model";
			// 
			// txtModel
			// 
			txtModel.Location = new Point(12, 87);
			txtModel.Name = "txtModel";
			txtModel.Size = new Size(200, 23);
			txtModel.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 123);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 4;
			label3.Text = "Numer seryjny";
			// 
			// txtSN
			// 
			txtSN.Location = new Point(12, 141);
			txtSN.Name = "txtSN";
			txtSN.Size = new Size(200, 23);
			txtSN.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(250, 40);
			label4.Name = "label4";
			label4.Size = new Size(30, 15);
			label4.TabIndex = 6;
			label4.Text = "Imię";
			// 
			// txtKlientImie
			// 
			txtKlientImie.Location = new Point(250, 58);
			txtKlientImie.Name = "txtKlientImie";
			txtKlientImie.Size = new Size(200, 23);
			txtKlientImie.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(250, 94);
			label5.Name = "label5";
			label5.Size = new Size(57, 15);
			label5.TabIndex = 8;
			label5.Text = "Nazwisko";
			// 
			// txtKlientNazwisko
			// 
			txtKlientNazwisko.Location = new Point(250, 112);
			txtKlientNazwisko.Name = "txtKlientNazwisko";
			txtKlientNazwisko.Size = new Size(200, 23);
			txtKlientNazwisko.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(250, 148);
			label6.Name = "label6";
			label6.Size = new Size(46, 15);
			label6.TabIndex = 10;
			label6.Text = "Telefon";
			// 
			// txtKlientTel
			// 
			txtKlientTel.Location = new Point(250, 166);
			txtKlientTel.Name = "txtKlientTel";
			txtKlientTel.Size = new Size(200, 23);
			txtKlientTel.TabIndex = 11;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 180);
			label7.Name = "label7";
			label7.Size = new Size(64, 15);
			label7.TabIndex = 12;
			label7.Text = "Czynności:";
			// 
			// clbCzynnosci
			// 
			clbCzynnosci.CheckOnClick = true;
			clbCzynnosci.FormattingEnabled = true;
			clbCzynnosci.Location = new Point(12, 198);
			clbCzynnosci.Name = "clbCzynnosci";
			clbCzynnosci.Size = new Size(438, 94);
			clbCzynnosci.TabIndex = 13;
			// 
			// btnZapisz
			// 
			btnZapisz.Location = new Point(12, 430); // Przesunięte w dół
			btnZapisz.Name = "btnZapisz";
			btnZapisz.Size = new Size(438, 40);
			btnZapisz.TabIndex = 14;
			btnZapisz.Text = "Dodaj zlecenie";
			btnZapisz.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 335); // Przesunięte w dół
			label8.Name = "label8";
			label8.Size = new Size(73, 15);
			label8.TabIndex = 15;
			label8.Text = "Uwagi / opis";
			// 
			// txtOpis
			// 
			txtOpis.Location = new Point(12, 353); // Przesunięte w dół
			txtOpis.Multiline = true;
			txtOpis.Name = "txtOpis";
			txtOpis.Size = new Size(438, 60);
			txtOpis.TabIndex = 16;
			// 
			// rbOsoba
			// 
			rbOsoba.AutoSize = true;
			rbOsoba.Checked = true;
			rbOsoba.Location = new Point(250, 12);
			rbOsoba.Name = "rbOsoba";
			rbOsoba.Size = new Size(111, 19);
			rbOsoba.TabIndex = 20;
			rbOsoba.TabStop = true;
			rbOsoba.Text = "Osoba prywatna";
			rbOsoba.UseVisualStyleBackColor = true;
			// 
			// rbFirma
			// 
			rbFirma.AutoSize = true;
			rbFirma.Location = new Point(366, 12);
			rbFirma.Name = "rbFirma";
			rbFirma.Size = new Size(55, 19);
			rbFirma.TabIndex = 21;
			rbFirma.Text = "Firma";
			rbFirma.UseVisualStyleBackColor = true;
			// 
			// txtRecznaCzynnosc
			// 
			txtRecznaCzynnosc.Location = new Point(12, 298);
			txtRecznaCzynnosc.Name = "txtRecznaCzynnosc";
			txtRecznaCzynnosc.Size = new Size(330, 23);
			txtRecznaCzynnosc.TabIndex = 22;
			txtRecznaCzynnosc.PlaceholderText = "Wpisz inną czynność...";
			// 
			// btnDodajCzynnosc
			// 
			btnDodajCzynnosc.Location = new Point(348, 297);
			btnDodajCzynnosc.Name = "btnDodajCzynnosc";
			btnDodajCzynnosc.Size = new Size(102, 25);
			btnDodajCzynnosc.TabIndex = 23;
			btnDodajCzynnosc.Text = "Dodaj";
			btnDodajCzynnosc.UseVisualStyleBackColor = true;
			// 
			// FormDodaj
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(474, 480);
			Controls.Add(btnDodajCzynnosc);
			Controls.Add(txtRecznaCzynnosc);
			Controls.Add(rbFirma);
			Controls.Add(rbOsoba);
			Controls.Add(txtOpis);
			Controls.Add(label8);
			Controls.Add(btnZapisz);
			Controls.Add(clbCzynnosci);
			Controls.Add(label7);
			Controls.Add(txtKlientTel);
			Controls.Add(label6);
			Controls.Add(txtKlientNazwisko);
			Controls.Add(label5);
			Controls.Add(txtKlientImie);
			Controls.Add(label4);
			Controls.Add(txtSN);
			Controls.Add(label3);
			Controls.Add(txtModel);
			Controls.Add(label2);
			Controls.Add(cmbTyp);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormDodaj";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Dodaj nowe zlecenie";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cmbTyp;
		private Label label2;
		private TextBox txtModel;
		private Label label3;
		private TextBox txtSN;
		private Label label4;
		private TextBox txtKlientImie;
		private Label label5;
		private TextBox txtKlientNazwisko;
		private Label label6;
		private TextBox txtKlientTel;
		private Label label7;
		private CheckedListBox clbCzynnosci;
		private Button btnZapisz;
		private Label label8;
		private TextBox txtOpis;
		private RadioButton rbOsoba;
		private RadioButton rbFirma;
		private TextBox txtRecznaCzynnosc;
		private Button btnDodajCzynnosc;
	}
}