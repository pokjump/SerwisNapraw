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
			cmbNaprawy = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			numRobocizna = new NumericUpDown();
			btnZatwierdz = new Button();
			lblSzczegoly = new Label();
			label3 = new Label();
			numCzesci = new NumericUpDown();
			label4 = new Label();
			txtUzyteCzesci = new TextBox(); // <--- NOWE POLE
			((System.ComponentModel.ISupportInitialize)numRobocizna).BeginInit();
			((System.ComponentModel.ISupportInitialize)numCzesci).BeginInit();
			SuspendLayout();
			// 
			// cmbNaprawy
			// 
			cmbNaprawy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbNaprawy.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbNaprawy.FormattingEnabled = true;
			cmbNaprawy.Location = new Point(12, 30);
			cmbNaprawy.Name = "cmbNaprawy";
			cmbNaprawy.Size = new Size(560, 23);
			cmbNaprawy.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(181, 15);
			label1.TabIndex = 1;
			label1.Text = "Wybierz naprawę do zakończenia";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 70);
			label2.Name = "label2";
			label2.Size = new Size(97, 15);
			label2.TabIndex = 2;
			label2.Text = "Koszt usługi (zł):";
			// 
			// numRobocizna
			// 
			numRobocizna.Location = new Point(12, 88);
			numRobocizna.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numRobocizna.Name = "numRobocizna";
			numRobocizna.Size = new Size(120, 23);
			numRobocizna.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(150, 70);
			label3.Name = "label3";
			label3.Size = new Size(96, 15);
			label3.TabIndex = 4;
			label3.Text = "Koszt części (zł):";
			// 
			// numCzesci
			// 
			numCzesci.Location = new Point(150, 88);
			numCzesci.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numCzesci.Name = "numCzesci";
			numCzesci.Size = new Size(120, 23);
			numCzesci.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(290, 70);
			label4.Name = "label4";
			label4.Size = new Size(106, 15);
			label4.TabIndex = 7;
			label4.Text = "Lista użytych części:";
			// 
			// txtUzyteCzesci
			// 
			txtUzyteCzesci.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtUzyteCzesci.Location = new Point(290, 87);
			txtUzyteCzesci.Name = "txtUzyteCzesci";
			txtUzyteCzesci.PlaceholderText = "np. Zasilacz, Dysk SSD...";
			txtUzyteCzesci.Size = new Size(282, 23);
			txtUzyteCzesci.TabIndex = 3;
			// 
			// lblSzczegoly
			// 
			lblSzczegoly.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lblSzczegoly.BorderStyle = BorderStyle.FixedSingle;
			lblSzczegoly.Location = new Point(12, 130);
			lblSzczegoly.Name = "lblSzczegoly";
			lblSzczegoly.Padding = new Padding(5);
			lblSzczegoly.Size = new Size(560, 160);
			lblSzczegoly.TabIndex = 6;
			// 
			// btnZatwierdz
			// 
			btnZatwierdz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnZatwierdz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnZatwierdz.Location = new Point(12, 309);
			btnZatwierdz.Name = "btnZatwierdz";
			btnZatwierdz.Size = new Size(560, 40);
			btnZatwierdz.TabIndex = 4;
			btnZatwierdz.Text = "ZATWIERDŹ I ROZLICZ";
			btnZatwierdz.UseVisualStyleBackColor = true;
			// 
			// FormZakoncz
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 361);
			Controls.Add(txtUzyteCzesci);
			Controls.Add(label4);
			Controls.Add(numCzesci);
			Controls.Add(label3);
			Controls.Add(lblSzczegoly);
			Controls.Add(btnZatwierdz);
			Controls.Add(numRobocizna);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cmbNaprawy);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FormZakoncz";
			Text = "Rozliczanie Naprawy";
			((System.ComponentModel.ISupportInitialize)numRobocizna).EndInit();
			((System.ComponentModel.ISupportInitialize)numCzesci).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbNaprawy;
		private Label label1;
		private Label label2;
		private NumericUpDown numRobocizna;
		private Button btnZatwierdz;
		private Label lblSzczegoly;
		private Label label3;
		private NumericUpDown numCzesci;
		private Label label4;
		private TextBox txtUzyteCzesci;
	}
}