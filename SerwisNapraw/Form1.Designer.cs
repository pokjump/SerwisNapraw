namespace SerwisNapraw
{
	partial class Form1
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
			lstNaprawy = new ListBox();
			label1 = new Label();
			btnNoweZlecenie = new Button();
			btnZakonczZlecenie = new Button();
			btnHistoria = new Button();
			btnSerwisanci = new Button();
			btnWykresy = new Button();
			btnKonfiguracja = new Button();
			SuspendLayout();
			// 
			// lstNaprawy
			// 
			lstNaprawy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lstNaprawy.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
			lstNaprawy.FormattingEnabled = true;
			lstNaprawy.Location = new Point(12, 33);
			lstNaprawy.Name = "lstNaprawy";
			lstNaprawy.Size = new Size(500, 429);
			lstNaprawy.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(184, 21);
			label1.TabIndex = 1;
			label1.Text = "Lista aktywnych napraw:";
			// 
			// btnNoweZlecenie
			// 
			btnNoweZlecenie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnNoweZlecenie.BackColor = Color.Transparent;
			btnNoweZlecenie.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnNoweZlecenie.Location = new Point(530, 30);
			btnNoweZlecenie.Name = "btnNoweZlecenie";
			btnNoweZlecenie.Size = new Size(242, 70);
			btnNoweZlecenie.TabIndex = 2;
			btnNoweZlecenie.Text = "Nowe zlecenie";
			btnNoweZlecenie.UseVisualStyleBackColor = false;
			btnNoweZlecenie.Click += btnNoweZlecenie_Click;
			// 
			// btnZakonczZlecenie
			// 
			btnZakonczZlecenie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnZakonczZlecenie.BackColor = Color.Transparent;
			btnZakonczZlecenie.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnZakonczZlecenie.Location = new Point(530, 110);
			btnZakonczZlecenie.Name = "btnZakonczZlecenie";
			btnZakonczZlecenie.Size = new Size(242, 60);
			btnZakonczZlecenie.TabIndex = 3;
			btnZakonczZlecenie.Text = "Zakończ zlecenie";
			btnZakonczZlecenie.UseVisualStyleBackColor = false;
			btnZakonczZlecenie.Click += btnZakonczZlecenie_Click;
			// 
			// btnHistoria
			// 
			btnHistoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnHistoria.BackColor = Color.Transparent;
			btnHistoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnHistoria.Location = new Point(530, 180);
			btnHistoria.Name = "btnHistoria";
			btnHistoria.Size = new Size(242, 60);
			btnHistoria.TabIndex = 4;
			btnHistoria.Text = "Historia napraw";
			btnHistoria.UseVisualStyleBackColor = false;
			btnHistoria.Click += btnHistoria_Click;
			// 
			// btnSerwisanci
			// 
			btnSerwisanci.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSerwisanci.BackColor = Color.Transparent;
			btnSerwisanci.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnSerwisanci.Location = new Point(530, 250);
			btnSerwisanci.Name = "btnSerwisanci";
			btnSerwisanci.Size = new Size(242, 60);
			btnSerwisanci.TabIndex = 5;
			btnSerwisanci.Text = "Serwisanci";
			btnSerwisanci.UseVisualStyleBackColor = false;
			btnSerwisanci.Click += btnSerwisanci_Click;
			// 
			// btnWykresy
			// 
			btnWykresy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnWykresy.BackColor = Color.Transparent;
			btnWykresy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnWykresy.Location = new Point(530, 320);
			btnWykresy.Name = "btnWykresy";
			btnWykresy.Size = new Size(242, 60);
			btnWykresy.TabIndex = 6;
			btnWykresy.Text = "Zestawienia";
			btnWykresy.UseVisualStyleBackColor = false;
			btnWykresy.Click += btnWykresy_Click;
			// 
			// btnKonfiguracja
			// 
			btnKonfiguracja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnKonfiguracja.BackColor = Color.Transparent;
			btnKonfiguracja.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
			btnKonfiguracja.Location = new Point(530, 390);
			btnKonfiguracja.Name = "btnKonfiguracja";
			btnKonfiguracja.Size = new Size(242, 60);
			btnKonfiguracja.TabIndex = 7;
			btnKonfiguracja.Text = "Konfiguracja";
			btnKonfiguracja.UseVisualStyleBackColor = false;
			btnKonfiguracja.Click += btnKonfiguracja_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 469);
			Controls.Add(btnKonfiguracja);
			Controls.Add(btnWykresy);
			Controls.Add(btnSerwisanci);
			Controls.Add(btnHistoria);
			Controls.Add(btnZakonczZlecenie);
			Controls.Add(btnNoweZlecenie);
			Controls.Add(label1);
			Controls.Add(lstNaprawy);
			this.Name = "Form1";
			this.Text = "Serwis komputerowy v2.0";
			this.ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox lstNaprawy;
		private Label label1;
		private Button btnNoweZlecenie;
		private Button btnZakonczZlecenie;
		private Button btnHistoria;
		private Button btnSerwisanci;
		private Button btnWykresy;
		private Button btnKonfiguracja;
	}
}