namespace AdoSample.UI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstKargolar = new System.Windows.Forms.ListBox();
			this.txtKargoAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnKargoEkle = new System.Windows.Forms.Button();
			this.txtTel = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// lstKargolar
			// 
			this.lstKargolar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstKargolar.FormattingEnabled = true;
			this.lstKargolar.ItemHeight = 17;
			this.lstKargolar.Location = new System.Drawing.Point(44, 36);
			this.lstKargolar.Name = "lstKargolar";
			this.lstKargolar.Size = new System.Drawing.Size(163, 225);
			this.lstKargolar.TabIndex = 0;
			// 
			// txtKargoAdi
			// 
			this.txtKargoAdi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKargoAdi.Location = new System.Drawing.Point(356, 48);
			this.txtKargoAdi.Name = "txtKargoAdi";
			this.txtKargoAdi.Size = new System.Drawing.Size(180, 23);
			this.txtKargoAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(267, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Kargo Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(281, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Telefon";
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(261, 282);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 23);
			this.btnEkle.TabIndex = 5;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnKargoEkle
			// 
			this.btnKargoEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKargoEkle.Location = new System.Drawing.Point(452, 158);
			this.btnKargoEkle.Name = "btnKargoEkle";
			this.btnKargoEkle.Size = new System.Drawing.Size(75, 23);
			this.btnKargoEkle.TabIndex = 6;
			this.btnKargoEkle.Text = "EKLE";
			this.btnKargoEkle.UseVisualStyleBackColor = true;
			this.btnKargoEkle.Click += new System.EventHandler(this.btnKargoEkle_Click);
			// 
			// txtTel
			// 
			this.txtTel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTel.Location = new System.Drawing.Point(356, 102);
			this.txtTel.Mask = "(999) 000-0000";
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(180, 23);
			this.txtTel.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 317);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.btnKargoEkle);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtKargoAdi);
			this.Controls.Add(this.lstKargolar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstKargolar;
		private System.Windows.Forms.TextBox txtKargoAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnKargoEkle;
		private System.Windows.Forms.MaskedTextBox txtTel;
	}
}

