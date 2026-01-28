namespace SerwisNapraw
{
	partial class FormKonfiguracja
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSprzet = new System.Windows.Forms.TabPage();
			this.grpUsterki = new System.Windows.Forms.GroupBox();
			this.btnUsunCzynnosc = new System.Windows.Forms.Button();
			this.btnDodajCzynnosc = new System.Windows.Forms.Button();
			this.txtNowaCzynnosc = new System.Windows.Forms.TextBox();
			this.lstCzynnosci = new System.Windows.Forms.ListBox();
			this.grpTypy = new System.Windows.Forms.GroupBox();
			this.btnUsunTyp = new System.Windows.Forms.Button();
			this.btnDodajTyp = new System.Windows.Forms.Button();
			this.txtNowyTyp = new System.Windows.Forms.TextBox();
			this.lstTypy = new System.Windows.Forms.ListBox();
			this.tabSerwisanci = new System.Windows.Forms.TabPage();
			this.grpDodajSerwisanta = new System.Windows.Forms.GroupBox();
			this.btnDodajSerwisanta = new System.Windows.Forms.Button();
			this.clbKwalifikacje = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtImie = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUsunSerwisanta = new System.Windows.Forms.Button();
			this.lstSerwisanci = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbTypSprzetu = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabSprzet.SuspendLayout();
			this.grpUsterki.SuspendLayout();
			this.grpTypy.SuspendLayout();
			this.tabSerwisanci.SuspendLayout();
			this.grpDodajSerwisanta.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabSprzet);
			this.tabControl1.Controls.Add(this.tabSerwisanci);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(650, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// tabSprzet
			// 
			this.tabSprzet.Controls.Add(this.grpUsterki);
			this.tabSprzet.Controls.Add(this.grpTypy);
			this.tabSprzet.Location = new System.Drawing.Point(4, 24);
			this.tabSprzet.Name = "tabSprzet";
			this.tabSprzet.Padding = new System.Windows.Forms.Padding(3);
			this.tabSprzet.Size = new System.Drawing.Size(642, 422);
			this.tabSprzet.TabIndex = 0;
			this.tabSprzet.Text = "Sprzęt i Usterki";
			this.tabSprzet.UseVisualStyleBackColor = true;
			// 
			// grpUsterki
			// 
			this.grpUsterki.Controls.Add(this.btnUsunCzynnosc);
			this.grpUsterki.Controls.Add(this.btnDodajCzynnosc);
			this.grpUsterki.Controls.Add(this.txtNowaCzynnosc);
			this.grpUsterki.Controls.Add(this.lstCzynnosci);
			this.grpUsterki.Controls.Add(this.label3);
			this.grpUsterki.Controls.Add(this.cmbTypSprzetu);
			this.grpUsterki.Location = new System.Drawing.Point(330, 15);
			this.grpUsterki.Name = "grpUsterki";
			this.grpUsterki.Size = new System.Drawing.Size(300, 390);
			this.grpUsterki.TabIndex = 1;
			this.grpUsterki.TabStop = false;
			this.grpUsterki.Text = "Usterki dla wybranego typu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Wybierz typ:";
			// 
			// cmbTypSprzetu
			// 
			this.cmbTypSprzetu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTypSprzetu.FormattingEnabled = true;
			this.cmbTypSprzetu.Location = new System.Drawing.Point(10, 40);
			this.cmbTypSprzetu.Name = "cmbTypSprzetu";
			this.cmbTypSprzetu.Size = new System.Drawing.Size(280, 23);
			this.cmbTypSprzetu.TabIndex = 5;
			// 
			// btnUsunCzynnosc
			// 
			this.btnUsunCzynnosc.Location = new System.Drawing.Point(10, 350);
			this.btnUsunCzynnosc.Name = "btnUsunCzynnosc";
			this.btnUsunCzynnosc.Size = new System.Drawing.Size(280, 30);
			this.btnUsunCzynnosc.TabIndex = 3;
			this.btnUsunCzynnosc.Text = "Usuń zaznaczoną";
			this.btnUsunCzynnosc.UseVisualStyleBackColor = true;
			// 
			// btnDodajCzynnosc
			// 
			this.btnDodajCzynnosc.Location = new System.Drawing.Point(210, 315);
			this.btnDodajCzynnosc.Name = "btnDodajCzynnosc";
			this.btnDodajCzynnosc.Size = new System.Drawing.Size(80, 25);
			this.btnDodajCzynnosc.TabIndex = 2;
			this.btnDodajCzynnosc.Text = "Dodaj";
			this.btnDodajCzynnosc.UseVisualStyleBackColor = true;
			// 
			// txtNowaCzynnosc
			// 
			this.txtNowaCzynnosc.Location = new System.Drawing.Point(10, 316);
			this.txtNowaCzynnosc.Name = "txtNowaCzynnosc";
			this.txtNowaCzynnosc.PlaceholderText = "Nazwa nowej usterki...";
			this.txtNowaCzynnosc.Size = new System.Drawing.Size(190, 23);
			this.txtNowaCzynnosc.TabIndex = 1;
			// 
			// lstCzynnosci
			// 
			this.lstCzynnosci.FormattingEnabled = true;
			this.lstCzynnosci.ItemHeight = 15;
			this.lstCzynnosci.Location = new System.Drawing.Point(10, 70);
			this.lstCzynnosci.Name = "lstCzynnosci";
			this.lstCzynnosci.Size = new System.Drawing.Size(280, 230);
			this.lstCzynnosci.TabIndex = 0;
			// 
			// grpTypy
			// 
			this.grpTypy.Controls.Add(this.btnUsunTyp);
			this.grpTypy.Controls.Add(this.btnDodajTyp);
			this.grpTypy.Controls.Add(this.txtNowyTyp);
			this.grpTypy.Controls.Add(this.lstTypy);
			this.grpTypy.Location = new System.Drawing.Point(15, 15);
			this.grpTypy.Name = "grpTypy";
			this.grpTypy.Size = new System.Drawing.Size(300, 390);
			this.grpTypy.TabIndex = 0;
			this.grpTypy.TabStop = false;
			this.grpTypy.Text = "Typy Sprzętu";
			// 
			// btnUsunTyp
			// 
			this.btnUsunTyp.Location = new System.Drawing.Point(10, 350);
			this.btnUsunTyp.Name = "btnUsunTyp";
			this.btnUsunTyp.Size = new System.Drawing.Size(280, 30);
			this.btnUsunTyp.TabIndex = 3;
			this.btnUsunTyp.Text = "Usuń zaznaczony typ";
			this.btnUsunTyp.UseVisualStyleBackColor = true;
			// 
			// btnDodajTyp
			// 
			this.btnDodajTyp.Location = new System.Drawing.Point(210, 315);
			this.btnDodajTyp.Name = "btnDodajTyp";
			this.btnDodajTyp.Size = new System.Drawing.Size(80, 25);
			this.btnDodajTyp.TabIndex = 2;
			this.btnDodajTyp.Text = "Dodaj";
			this.btnDodajTyp.UseVisualStyleBackColor = true;
			// 
			// txtNowyTyp
			// 
			this.txtNowyTyp.Location = new System.Drawing.Point(10, 316);
			this.txtNowyTyp.Name = "txtNowyTyp";
			this.txtNowyTyp.PlaceholderText = "Nazwa nowego typu...";
			this.txtNowyTyp.Size = new System.Drawing.Size(190, 23);
			this.txtNowyTyp.TabIndex = 1;
			// 
			// lstTypy
			// 
			this.lstTypy.FormattingEnabled = true;
			this.lstTypy.ItemHeight = 15;
			this.lstTypy.Location = new System.Drawing.Point(10, 25);
			this.lstTypy.Name = "lstTypy";
			this.lstTypy.Size = new System.Drawing.Size(280, 274);
			this.lstTypy.TabIndex = 0;
			// 
			// tabSerwisanci
			// 
			this.tabSerwisanci.Controls.Add(this.grpDodajSerwisanta);
			this.tabSerwisanci.Controls.Add(this.btnUsunSerwisanta);
			this.tabSerwisanci.Controls.Add(this.lstSerwisanci);
			this.tabSerwisanci.Location = new System.Drawing.Point(4, 24);
			this.tabSerwisanci.Name = "tabSerwisanci";
			this.tabSerwisanci.Padding = new System.Windows.Forms.Padding(3);
			this.tabSerwisanci.Size = new System.Drawing.Size(642, 422);
			this.tabSerwisanci.TabIndex = 1;
			this.tabSerwisanci.Text = "Serwisanci";
			this.tabSerwisanci.UseVisualStyleBackColor = true;
			// 
			// grpDodajSerwisanta
			// 
			this.grpDodajSerwisanta.Controls.Add(this.btnDodajSerwisanta);
			this.grpDodajSerwisanta.Controls.Add(this.clbKwalifikacje);
			this.grpDodajSerwisanta.Controls.Add(this.label1);
			this.grpDodajSerwisanta.Controls.Add(this.txtImie);
			this.grpDodajSerwisanta.Controls.Add(this.label2);
			this.grpDodajSerwisanta.Location = new System.Drawing.Point(300, 15);
			this.grpDodajSerwisanta.Name = "grpDodajSerwisanta";
			this.grpDodajSerwisanta.Size = new System.Drawing.Size(320, 390);
			this.grpDodajSerwisanta.TabIndex = 2;
			this.grpDodajSerwisanta.TabStop = false;
			this.grpDodajSerwisanta.Text = "Dodaj nowego serwisanta";
			// 
			// btnDodajSerwisanta
			// 
			this.btnDodajSerwisanta.Location = new System.Drawing.Point(15, 340);
			this.btnDodajSerwisanta.Name = "btnDodajSerwisanta";
			this.btnDodajSerwisanta.Size = new System.Drawing.Size(290, 40);
			this.btnDodajSerwisanta.TabIndex = 4;
			this.btnDodajSerwisanta.Text = "Dodaj serwisanta";
			this.btnDodajSerwisanta.UseVisualStyleBackColor = true;
			// 
			// clbKwalifikacje
			// 
			this.clbKwalifikacje.CheckOnClick = true;
			this.clbKwalifikacje.FormattingEnabled = true;
			this.clbKwalifikacje.Location = new System.Drawing.Point(15, 100);
			this.clbKwalifikacje.Name = "clbKwalifikacje";
			this.clbKwalifikacje.Size = new System.Drawing.Size(290, 220);
			this.clbKwalifikacje.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kwalifikacje:";
			// 
			// txtImie
			// 
			this.txtImie.Location = new System.Drawing.Point(15, 45);
			this.txtImie.Name = "txtImie";
			this.txtImie.Size = new System.Drawing.Size(290, 23);
			this.txtImie.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Imię i nazwisko:";
			// 
			// btnUsunSerwisanta
			// 
			this.btnUsunSerwisanta.Location = new System.Drawing.Point(15, 365);
			this.btnUsunSerwisanta.Name = "btnUsunSerwisanta";
			this.btnUsunSerwisanta.Size = new System.Drawing.Size(260, 40);
			this.btnUsunSerwisanta.TabIndex = 1;
			this.btnUsunSerwisanta.Text = "Usuń zaznaczonego";
			this.btnUsunSerwisanta.UseVisualStyleBackColor = true;
			// 
			// lstSerwisanci
			// 
			this.lstSerwisanci.FormattingEnabled = true;
			this.lstSerwisanci.ItemHeight = 15;
			this.lstSerwisanci.Location = new System.Drawing.Point(15, 15);
			this.lstSerwisanci.Name = "lstSerwisanci";
			this.lstSerwisanci.Size = new System.Drawing.Size(260, 334);
			this.lstSerwisanci.TabIndex = 0;
			// 
			// FormKonfiguracja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 450);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormKonfiguracja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Konfiguracja systemu";
			this.tabControl1.ResumeLayout(false);
			this.tabSprzet.ResumeLayout(false);
			this.grpUsterki.ResumeLayout(false);
			this.grpUsterki.PerformLayout();
			this.grpTypy.ResumeLayout(false);
			this.grpTypy.PerformLayout();
			this.tabSerwisanci.ResumeLayout(false);
			this.grpDodajSerwisanta.ResumeLayout(false);
			this.grpDodajSerwisanta.PerformLayout();
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSprzet;
		private System.Windows.Forms.TabPage tabSerwisanci;
		private System.Windows.Forms.GroupBox grpTypy;
		private System.Windows.Forms.ListBox lstTypy;
		private System.Windows.Forms.TextBox txtNowyTyp;
		private System.Windows.Forms.Button btnUsunTyp;
		private System.Windows.Forms.Button btnDodajTyp;
		private System.Windows.Forms.GroupBox grpUsterki;
		private System.Windows.Forms.ListBox lstCzynnosci;
		private System.Windows.Forms.Button btnUsunCzynnosc;
		private System.Windows.Forms.Button btnDodajCzynnosc;
		private System.Windows.Forms.TextBox txtNowaCzynnosc;
		private System.Windows.Forms.ListBox lstSerwisanci;
		private System.Windows.Forms.Button btnUsunSerwisanta;
		private System.Windows.Forms.GroupBox grpDodajSerwisanta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtImie;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox clbKwalifikacje;
		private System.Windows.Forms.Button btnDodajSerwisanta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTypSprzetu;
	}
}