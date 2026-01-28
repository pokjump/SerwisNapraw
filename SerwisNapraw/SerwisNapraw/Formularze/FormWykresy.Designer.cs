namespace SerwisNapraw
{
	partial class FormWykresy
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

        private void InitializeComponent()
        {
            pbWykres = new PictureBox();
            label1 = new Label();
            numRok = new NumericUpDown();
            grpOpcje = new GroupBox();
            flpOpcje = new FlowLayoutPanel();
            chkNowe = new CheckBox();
            chkZakonczone = new CheckBox();
            chkKomputery = new CheckBox();
            chkTelefony = new CheckBox();
            chkMonitory = new CheckBox();
            chkDrukarki = new CheckBox();
            btnEksport = new Button();
            ((System.ComponentModel.ISupportInitialize)pbWykres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRok).BeginInit();
            grpOpcje.SuspendLayout();
            flpOpcje.SuspendLayout();
            SuspendLayout();
            // 
            // pbWykres
            // 
            pbWykres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbWykres.BackColor = Color.White;
            pbWykres.BorderStyle = BorderStyle.FixedSingle;
            pbWykres.Location = new Point(12, 190);
            pbWykres.Name = "pbWykres";
            pbWykres.Size = new Size(760, 359);
            pbWykres.TabIndex = 1;
            pbWykres.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 2;
            label1.Text = "Rok:";
            // 
            // numRok
            // 
            numRok.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            numRok.Location = new Point(58, 12);
            numRok.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numRok.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numRok.Name = "numRok";
            numRok.Size = new Size(120, 29);
            numRok.TabIndex = 3;
            numRok.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // grpOpcje
            // 
            grpOpcje.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpOpcje.Controls.Add(flpOpcje);
            grpOpcje.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            grpOpcje.Location = new Point(12, 47);
            grpOpcje.Name = "grpOpcje";
            grpOpcje.Size = new Size(760, 100);
            grpOpcje.TabIndex = 4;
            grpOpcje.TabStop = false;
            grpOpcje.Text = "Wybierz dane do wyświetlenia";
            // 
            // flpOpcje
            // 
            flpOpcje.AutoScroll = true;
            flpOpcje.Controls.Add(chkNowe);
            flpOpcje.Controls.Add(chkZakonczone);
            flpOpcje.Controls.Add(chkKomputery);
            flpOpcje.Controls.Add(chkTelefony);
            flpOpcje.Controls.Add(chkMonitory);
            flpOpcje.Controls.Add(chkDrukarki);
            flpOpcje.Dock = DockStyle.Fill;
            flpOpcje.Location = new Point(3, 21);
            flpOpcje.Name = "flpOpcje";
            flpOpcje.Size = new Size(754, 76);
            flpOpcje.TabIndex = 0;
            // 
            // chkNowe
            // 
            chkNowe.AutoSize = true;
            chkNowe.Checked = true;
            chkNowe.CheckState = CheckState.Checked;
            chkNowe.ForeColor = Color.Blue;
            chkNowe.Location = new Point(3, 3);
            chkNowe.Name = "chkNowe";
            chkNowe.Size = new Size(149, 21);
            chkNowe.TabIndex = 0;
            chkNowe.Text = "Nowe zlecenia (Ilość)";
            chkNowe.UseVisualStyleBackColor = true;
            // 
            // chkZakonczone
            // 
            chkZakonczone.AutoSize = true;
            chkZakonczone.ForeColor = Color.Green;
            chkZakonczone.Location = new Point(158, 3);
            chkZakonczone.Name = "chkZakonczone";
            chkZakonczone.Size = new Size(134, 21);
            chkZakonczone.TabIndex = 1;
            chkZakonczone.Text = "Zakończone (Ilość)";
            chkZakonczone.UseVisualStyleBackColor = true;
            // 
            // chkKomputery
            // 
            chkKomputery.AutoSize = true;
            chkKomputery.Location = new Point(298, 3);
            chkKomputery.Name = "chkKomputery";
            chkKomputery.Size = new Size(91, 21);
            chkKomputery.TabIndex = 2;
            chkKomputery.Text = "Komputery";
            chkKomputery.UseVisualStyleBackColor = true;
            // 
            // chkTelefony
            // 
            chkTelefony.AutoSize = true;
            chkTelefony.Location = new Point(395, 3);
            chkTelefony.Name = "chkTelefony";
            chkTelefony.Size = new Size(75, 21);
            chkTelefony.TabIndex = 3;
            chkTelefony.Text = "Telefony";
            chkTelefony.UseVisualStyleBackColor = true;
            // 
            // chkMonitory
            // 
            chkMonitory.AutoSize = true;
            chkMonitory.Location = new Point(476, 3);
            chkMonitory.Name = "chkMonitory";
            chkMonitory.Size = new Size(80, 21);
            chkMonitory.TabIndex = 4;
            chkMonitory.Text = "Monitory";
            chkMonitory.UseVisualStyleBackColor = true;
            // 
            // chkDrukarki
            // 
            chkDrukarki.AutoSize = true;
            chkDrukarki.Location = new Point(562, 3);
            chkDrukarki.Name = "chkDrukarki";
            chkDrukarki.Size = new Size(75, 21);
            chkDrukarki.TabIndex = 5;
            chkDrukarki.Text = "Drukarki";
            chkDrukarki.UseVisualStyleBackColor = true;
            // 
            // btnEksport
            // 
            btnEksport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEksport.Location = new Point(622, 153);
            btnEksport.Name = "btnEksport";
            btnEksport.Size = new Size(150, 31);
            btnEksport.TabIndex = 5;
            btnEksport.Text = "Generuj do pliku";
            btnEksport.UseVisualStyleBackColor = true;
            // 
            // FormWykresy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnEksport);
            Controls.Add(grpOpcje);
            Controls.Add(numRok);
            Controls.Add(label1);
            Controls.Add(pbWykres);
            Name = "FormWykresy";
            Text = "Wykresy roczne";
            ((System.ComponentModel.ISupportInitialize)pbWykres).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRok).EndInit();
            grpOpcje.ResumeLayout(false);
            flpOpcje.ResumeLayout(false);
            flpOpcje.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbWykres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numRok;
		private System.Windows.Forms.GroupBox grpOpcje;
		private System.Windows.Forms.FlowLayoutPanel flpOpcje;
		private System.Windows.Forms.CheckBox chkNowe;
		private System.Windows.Forms.CheckBox chkZakonczone;
		private System.Windows.Forms.CheckBox chkDrukarki;
		private System.Windows.Forms.CheckBox chkMonitory;
		private System.Windows.Forms.CheckBox chkTelefony;
		private System.Windows.Forms.CheckBox chkKomputery;
		private System.Windows.Forms.Button btnEksport;
	}
}