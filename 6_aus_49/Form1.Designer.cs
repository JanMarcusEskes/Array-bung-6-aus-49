namespace _6_aus_49
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMethodeThünnes = new System.Windows.Forms.Button();
			this.btnMethodeScheel = new System.Windows.Forms.Button();
			this.lblZiehung = new System.Windows.Forms.Label();
			this.gpbZiehung = new System.Windows.Forms.GroupBox();
			this.btnMethodeMe = new System.Windows.Forms.Button();
			this.gpbZiehung.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMethodeThünnes
			// 
			this.btnMethodeThünnes.Location = new System.Drawing.Point(12, 62);
			this.btnMethodeThünnes.Name = "btnMethodeThünnes";
			this.btnMethodeThünnes.Size = new System.Drawing.Size(120, 25);
			this.btnMethodeThünnes.TabIndex = 0;
			this.btnMethodeThünnes.Text = "Thünnes Methode";
			this.btnMethodeThünnes.UseVisualStyleBackColor = true;
			this.btnMethodeThünnes.Click += new System.EventHandler(this.btnMethodeThünnes_Click);
			// 
			// btnMethodeScheel
			// 
			this.btnMethodeScheel.Location = new System.Drawing.Point(138, 62);
			this.btnMethodeScheel.Name = "btnMethodeScheel";
			this.btnMethodeScheel.Size = new System.Drawing.Size(120, 25);
			this.btnMethodeScheel.TabIndex = 1;
			this.btnMethodeScheel.Text = "Scheels Methode";
			this.btnMethodeScheel.UseVisualStyleBackColor = true;
			this.btnMethodeScheel.Click += new System.EventHandler(this.btnMethodeScheel_Click);
			// 
			// lblZiehung
			// 
			this.lblZiehung.AutoSize = true;
			this.lblZiehung.Location = new System.Drawing.Point(6, 16);
			this.lblZiehung.Name = "lblZiehung";
			this.lblZiehung.Size = new System.Drawing.Size(210, 13);
			this.lblZiehung.TabIndex = 2;
			this.lblZiehung.Text = "Bitte wählen Sie eine Methode zur Ziehung";
			// 
			// gpbZiehung
			// 
			this.gpbZiehung.Controls.Add(this.lblZiehung);
			this.gpbZiehung.Location = new System.Drawing.Point(12, 12);
			this.gpbZiehung.Name = "gpbZiehung";
			this.gpbZiehung.Size = new System.Drawing.Size(246, 44);
			this.gpbZiehung.TabIndex = 3;
			this.gpbZiehung.TabStop = false;
			this.gpbZiehung.Text = "Ziehung";
			// 
			// btnMethodeMe
			// 
			this.btnMethodeMe.Location = new System.Drawing.Point(12, 93);
			this.btnMethodeMe.Name = "btnMethodeMe";
			this.btnMethodeMe.Size = new System.Drawing.Size(246, 25);
			this.btnMethodeMe.TabIndex = 4;
			this.btnMethodeMe.Text = "Meine Methode";
			this.btnMethodeMe.UseVisualStyleBackColor = true;
			this.btnMethodeMe.Click += new System.EventHandler(this.btnMethodeMe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 129);
			this.Controls.Add(this.btnMethodeMe);
			this.Controls.Add(this.gpbZiehung);
			this.Controls.Add(this.btnMethodeScheel);
			this.Controls.Add(this.btnMethodeThünnes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Lottoziehung";
			this.gpbZiehung.ResumeLayout(false);
			this.gpbZiehung.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMethodeThünnes;
		private System.Windows.Forms.Button btnMethodeScheel;
		private System.Windows.Forms.Label lblZiehung;
		private System.Windows.Forms.GroupBox gpbZiehung;
		private System.Windows.Forms.Button btnMethodeMe;
	}
}

