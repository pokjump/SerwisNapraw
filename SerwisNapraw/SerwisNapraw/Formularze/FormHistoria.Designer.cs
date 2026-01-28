namespace SerwisNapraw
{
	partial class FormHistoria
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
            lstHistoria = new ListBox();
            chkPokazAktywne = new CheckBox();
            chkPokazZakonczone = new CheckBox();
            lblSzczegolyHistorii = new Label();
            label1 = new Label();
            txtSzukaj = new TextBox();
            SuspendLayout();
            // 
            // lstHistoria
            // 
            lstHistoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstHistoria.FormattingEnabled = true;
            lstHistoria.Location = new Point(12, 41);
            lstHistoria.Name = "lstHistoria";
            lstHistoria.Size = new Size(525, 394);
            lstHistoria.TabIndex = 0;
            // 
            // chkPokazAktywne
            // 
            chkPokazAktywne.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkPokazAktywne.AutoSize = true;
            chkPokazAktywne.Location = new Point(543, 12);
            chkPokazAktywne.Name = "chkPokazAktywne";
            chkPokazAktywne.Size = new Size(104, 19);
            chkPokazAktywne.TabIndex = 1;
            chkPokazAktywne.Text = "Pokaż aktywne";
            chkPokazAktywne.UseVisualStyleBackColor = true;
            // 
            // chkPokazZakonczone
            // 
            chkPokazZakonczone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkPokazZakonczone.AutoSize = true;
            chkPokazZakonczone.Checked = true;
            chkPokazZakonczone.CheckState = CheckState.Checked;
            chkPokazZakonczone.Location = new Point(543, 49);
            chkPokazZakonczone.Name = "chkPokazZakonczone";
            chkPokazZakonczone.Size = new Size(122, 19);
            chkPokazZakonczone.TabIndex = 2;
            chkPokazZakonczone.Text = "Pokaż zakończone";
            chkPokazZakonczone.UseVisualStyleBackColor = true;
            // 
            // lblSzczegolyHistorii
            // 
            lblSzczegolyHistorii.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSzczegolyHistorii.BorderStyle = BorderStyle.FixedSingle;
            lblSzczegolyHistorii.Location = new Point(543, 99);
            lblSzczegolyHistorii.Name = "lblSzczegolyHistorii";
            lblSzczegolyHistorii.Padding = new Padding(5);
            lblSzczegolyHistorii.Size = new Size(245, 337);
            lblSzczegolyHistorii.TabIndex = 3;
            lblSzczegolyHistorii.Text = "Wybierz element z listy...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Szukaj:";
            // 
            // txtSzukaj
            // 
            txtSzukaj.Location = new Point(63, 10);
            txtSzukaj.Name = "txtSzukaj";
            txtSzukaj.PlaceholderText = "Wpisz model, nazwisko lub numer seryjny";
            txtSzukaj.Size = new Size(474, 23);
            txtSzukaj.TabIndex = 5;
            // 
            // FormHistoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSzukaj);
            Controls.Add(label1);
            Controls.Add(lblSzczegolyHistorii);
            Controls.Add(chkPokazZakonczone);
            Controls.Add(chkPokazAktywne);
            Controls.Add(lstHistoria);
            Name = "FormHistoria";
            Text = "Historia napraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHistoria;
		private CheckBox chkPokazAktywne;
		private CheckBox chkPokazZakonczone;
		private Label lblSzczegolyHistorii;
		private Label label1;
		private TextBox txtSzukaj;
	}
}