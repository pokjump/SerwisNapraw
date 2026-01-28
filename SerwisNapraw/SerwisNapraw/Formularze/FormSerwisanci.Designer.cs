namespace SerwisNapraw
{
	partial class FormSerwisanci
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblSerwisanci = new System.Windows.Forms.Label();
			this.lstSerwisanci = new System.Windows.Forms.ListBox();
			this.lblZadania = new System.Windows.Forms.Label();
			this.lstZadania = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lstSerwisanci);
			this.splitContainer1.Panel1.Controls.Add(this.lblSerwisanci);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lstZadania);
			this.splitContainer1.Panel2.Controls.Add(this.lblZadania);
			this.splitContainer1.Size = new System.Drawing.Size(784, 461);
			this.splitContainer1.SplitterDistance = 261;
			this.splitContainer1.TabIndex = 0;
			// 
			// lblSerwisanci
			// 
			this.lblSerwisanci.AutoSize = true;
			this.lblSerwisanci.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblSerwisanci.Location = new System.Drawing.Point(12, 9);
			this.lblSerwisanci.Name = "lblSerwisanci";
			this.lblSerwisanci.Size = new System.Drawing.Size(90, 21);
			this.lblSerwisanci.TabIndex = 0;
			this.lblSerwisanci.Text = "Serwisanci";
			// 
			// lstSerwisanci
			// 
			this.lstSerwisanci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstSerwisanci.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lstSerwisanci.FormattingEnabled = true;
			this.lstSerwisanci.ItemHeight = 20;
			this.lstSerwisanci.Location = new System.Drawing.Point(12, 33);
			this.lstSerwisanci.Name = "lstSerwisanci";
			this.lstSerwisanci.Size = new System.Drawing.Size(237, 404);
			this.lstSerwisanci.TabIndex = 1;
			// 
			// lblZadania
			// 
			this.lblZadania.AutoSize = true;
			this.lblZadania.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblZadania.Location = new System.Drawing.Point(13, 9);
			this.lblZadania.Name = "lblZadania";
			this.lblZadania.Size = new System.Drawing.Size(183, 21);
			this.lblZadania.TabIndex = 0;
			this.lblZadania.Text = "Przypisane naprawy";
			// 
			// lstZadania
			// 
			this.lstZadania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstZadania.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lstZadania.FormattingEnabled = true;
			this.lstZadania.ItemHeight = 17;
			this.lstZadania.Location = new System.Drawing.Point(17, 33);
			this.lstZadania.Name = "lstZadania";
			this.lstZadania.Size = new System.Drawing.Size(490, 412);
			this.lstZadania.TabIndex = 1;
			// 
			// FormSerwisanci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.splitContainer1);
			this.Name = "FormSerwisanci";
			this.Text = "Zadania serwisantów";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lblSerwisanci;
		private System.Windows.Forms.ListBox lstSerwisanci;
		private System.Windows.Forms.Label lblZadania;
		private System.Windows.Forms.ListBox lstZadania;
	}
}