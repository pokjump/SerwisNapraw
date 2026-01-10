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
            btnNoweZlecenie.AutoSize = true;
            btnNoweZlecenie.BackColor = Color.Transparent;
            btnNoweZlecenie.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNoweZlecenie.Location = new Point(530, 33);
            btnNoweZlecenie.Name = "btnNoweZlecenie";
            btnNoweZlecenie.Size = new Size(242, 80);
            btnNoweZlecenie.TabIndex = 2;
            btnNoweZlecenie.Text = "NOWE ZLECENIE";
            btnNoweZlecenie.UseVisualStyleBackColor = false;
            btnNoweZlecenie.Click += btnNoweZlecenie_Click;
            // 
            // btnZakonczZlecenie
            // 
            btnZakonczZlecenie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZakonczZlecenie.BackColor = Color.Transparent;
            btnZakonczZlecenie.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZakonczZlecenie.Location = new Point(530, 130);
            btnZakonczZlecenie.Name = "btnZakonczZlecenie";
            btnZakonczZlecenie.Size = new Size(242, 60);
            btnZakonczZlecenie.TabIndex = 3;
            btnZakonczZlecenie.Text = "ZAKOŃCZ ZLECENIE";
            btnZakonczZlecenie.UseVisualStyleBackColor = false;
            btnZakonczZlecenie.Click += btnZakonczZlecenie_Click;
            // 
            // btnHistoria
            // 
            btnHistoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHistoria.BackColor = Color.Transparent;
            btnHistoria.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnHistoria.Location = new Point(530, 397);
            btnHistoria.Name = "btnHistoria";
            btnHistoria.Size = new Size(242, 60);
            btnHistoria.TabIndex = 4;
            btnHistoria.Text = "HISTORIA NAPRAW";
            btnHistoria.UseVisualStyleBackColor = false;
            btnHistoria.Click += btnHistoria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 469);
            Controls.Add(btnHistoria);
            Controls.Add(btnZakonczZlecenie);
            Controls.Add(btnNoweZlecenie);
            Controls.Add(label1);
            Controls.Add(lstNaprawy);
            Name = "Form1";
            Text = "Serwis Komputerowy v1.31";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNaprawy;
		private Label label1;
		private Button btnNoweZlecenie;
		private Button btnZakonczZlecenie;
		private Button btnHistoria;
	}
}