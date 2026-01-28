namespace SerwisNapraw
{
	partial class FormZakoncz
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
			this.cmbNaprawy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numRobocizna = new System.Windows.Forms.NumericUpDown();
			this.btnZatwierdz = new System.Windows.Forms.Button();
			this.lblSzczegoly = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numCzesci = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUzyteCzesci = new System.Windows.Forms.TextBox();
			this.labelDodatkowe = new System.Windows.Forms.Label();
			this.clbDodatkowe = new System.Windows.Forms.CheckedListBox();
			this.txtDodatkoweReczne = new System.Windows.Forms.TextBox();
			this.btnDodajReczne = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numRobocizna)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCzesci)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbNaprawy
			// 
			this.cmbNaprawy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNaprawy.FormattingEnabled = true;
			this.cmbNaprawy.Location = new System.Drawing.Point(12, 30);
			this.cmbNaprawy.Name = "cmbNaprawy";
			this.cmbNaprawy.Size = new System.Drawing.Size(560, 23);
			this.cmbNaprawy.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wybierz naprawę do zakończenia";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Koszt usługi (zł):";
			// 
			// numRobocizna
			// 
			this.numRobocizna.Location = new System.Drawing.Point(12, 88);
			this.numRobocizna.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.numRobocizna.Name = "numRobocizna";
			this.numRobocizna.Size = new System.Drawing.Size(120, 23);
			this.numRobocizna.TabIndex = 1;
			// 
			// btnZatwierdz
			// 
			this.btnZatwierdz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnZatwierdz.Location = new System.Drawing.Point(12, 388);
			this.btnZatwierdz.Name = "btnZatwierdz";
			this.btnZatwierdz.Size = new System.Drawing.Size(833, 50);
			this.btnZatwierdz.TabIndex = 4;
			this.btnZatwierdz.Text = "ZATWIERDŹ I ROZLICZ";
			this.btnZatwierdz.UseVisualStyleBackColor = true;
			// 
			// lblSzczegoly
			// 
			this.lblSzczegoly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSzczegoly.Location = new System.Drawing.Point(12, 130);
			this.lblSzczegoly.Name = "lblSzczegoly";
			this.lblSzczegoly.Padding = new System.Windows.Forms.Padding(5);
			this.lblSzczegoly.Size = new System.Drawing.Size(560, 243);
			this.lblSzczegoly.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(150, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Koszt części (zł):";
			// 
			// numCzesci
			// 
			this.numCzesci.Location = new System.Drawing.Point(150, 88);
			this.numCzesci.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.numCzesci.Name = "numCzesci";
			this.numCzesci.Size = new System.Drawing.Size(120, 23);
			this.numCzesci.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(290, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lista użytych części:";
			// 
			// txtUzyteCzesci
			// 
			this.txtUzyteCzesci.Location = new System.Drawing.Point(290, 87);
			this.txtUzyteCzesci.Name = "txtUzyteCzesci";
			this.txtUzyteCzesci.PlaceholderText = "np. Zasilacz, Dysk SSD...";
			this.txtUzyteCzesci.Size = new System.Drawing.Size(282, 23);
			this.txtUzyteCzesci.TabIndex = 3;
			// 
			// labelDodatkowe
			// 
			this.labelDodatkowe.AutoSize = true;
			this.labelDodatkowe.Location = new System.Drawing.Point(588, 9);
			this.labelDodatkowe.Name = "labelDodatkowe";
			this.labelDodatkowe.Size = new System.Drawing.Size(200, 15);
			this.labelDodatkowe.TabIndex = 8;
			this.labelDodatkowe.Text = "Wykonane czynności (weryfikacja):";
			// 
			// clbDodatkowe
			// 
			this.clbDodatkowe.CheckOnClick = true;
			this.clbDodatkowe.FormattingEnabled = true;
			this.clbDodatkowe.Location = new System.Drawing.Point(588, 30);
			this.clbDodatkowe.Name = "clbDodatkowe";
			this.clbDodatkowe.Size = new System.Drawing.Size(257, 310);
			this.clbDodatkowe.TabIndex = 9;
			// 
			// txtDodatkoweReczne
			// 
			this.txtDodatkoweReczne.Location = new System.Drawing.Point(588, 350);
			this.txtDodatkoweReczne.Name = "txtDodatkoweReczne";
			this.txtDodatkoweReczne.Size = new System.Drawing.Size(176, 23);
			this.txtDodatkoweReczne.TabIndex = 10;
			// 
			// btnDodajReczne
			// 
			this.btnDodajReczne.Location = new System.Drawing.Point(770, 349);
			this.btnDodajReczne.Name = "btnDodajReczne";
			this.btnDodajReczne.Size = new System.Drawing.Size(75, 24);
			this.btnDodajReczne.TabIndex = 11;
			this.btnDodajReczne.Text = "Dodaj";
			this.btnDodajReczne.UseVisualStyleBackColor = true;
			// 
			// FormZakoncz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 450);
			this.Controls.Add(this.btnDodajReczne);
			this.Controls.Add(this.txtDodatkoweReczne);
			this.Controls.Add(this.clbDodatkowe);
			this.Controls.Add(this.labelDodatkowe);
			this.Controls.Add(this.txtUzyteCzesci);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numCzesci);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblSzczegoly);
			this.Controls.Add(this.btnZatwierdz);
			this.Controls.Add(this.numRobocizna);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbNaprawy);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormZakoncz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rozliczanie naprawy";
			((System.ComponentModel.ISupportInitialize)(this.numRobocizna)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCzesci)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbNaprawy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numRobocizna;
		private System.Windows.Forms.Button btnZatwierdz;
		private System.Windows.Forms.Label lblSzczegoly;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numCzesci;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUzyteCzesci;

		public System.Windows.Forms.Label labelDodatkowe;
		public System.Windows.Forms.CheckedListBox clbDodatkowe;
		public System.Windows.Forms.TextBox txtDodatkoweReczne;
		public System.Windows.Forms.Button btnDodajReczne;
	}
}