namespace AdoSample.SiparisUI
{
	partial class Siparis
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
			this.listUrunler = new System.Windows.Forms.ListBox();
			this.cmbMusteri = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cmbKargoSirketi = new System.Windows.Forms.ComboBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSepeteEkle = new System.Windows.Forms.Button();
			this.btnSiparisOlustur = new System.Windows.Forms.Button();
			this.tbKargoUcreti = new System.Windows.Forms.TextBox();
			this.clbSepet = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// listUrunler
			// 
			this.listUrunler.FormattingEnabled = true;
			this.listUrunler.Location = new System.Drawing.Point(22, 30);
			this.listUrunler.Name = "listUrunler";
			this.listUrunler.Size = new System.Drawing.Size(235, 212);
			this.listUrunler.TabIndex = 0;
			// 
			// cmbMusteri
			// 
			this.cmbMusteri.FormattingEnabled = true;
			this.cmbMusteri.Location = new System.Drawing.Point(388, 30);
			this.cmbMusteri.Name = "cmbMusteri";
			this.cmbMusteri.Size = new System.Drawing.Size(172, 21);
			this.cmbMusteri.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(321, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Müşteri";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(388, 69);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// cmbKargoSirketi
			// 
			this.cmbKargoSirketi.FormattingEnabled = true;
			this.cmbKargoSirketi.Location = new System.Drawing.Point(388, 106);
			this.cmbKargoSirketi.Name = "cmbKargoSirketi";
			this.cmbKargoSirketi.Size = new System.Drawing.Size(172, 21);
			this.cmbKargoSirketi.TabIndex = 1;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(388, 152);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(172, 20);
			this.dateTimePicker2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(295, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sipariş Tarihi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(295, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kargo Şirketi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(276, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Kargolama Tarihi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(296, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Kargo Ücreti";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(60, 258);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(59, 20);
			this.numericUpDown2.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Adet";
			// 
			// btnSepeteEkle
			// 
			this.btnSepeteEkle.Location = new System.Drawing.Point(164, 254);
			this.btnSepeteEkle.Name = "btnSepeteEkle";
			this.btnSepeteEkle.Size = new System.Drawing.Size(93, 24);
			this.btnSepeteEkle.TabIndex = 5;
			this.btnSepeteEkle.Text = "Sepete Ekle";
			this.btnSepeteEkle.UseVisualStyleBackColor = true;
			// 
			// btnSiparisOlustur
			// 
			this.btnSiparisOlustur.Location = new System.Drawing.Point(467, 244);
			this.btnSiparisOlustur.Name = "btnSiparisOlustur";
			this.btnSiparisOlustur.Size = new System.Drawing.Size(93, 24);
			this.btnSiparisOlustur.TabIndex = 5;
			this.btnSiparisOlustur.Text = "Sipariş Oluştur";
			this.btnSiparisOlustur.UseVisualStyleBackColor = true;
			// 
			// tbKargoUcreti
			// 
			this.tbKargoUcreti.Location = new System.Drawing.Point(388, 197);
			this.tbKargoUcreti.Name = "tbKargoUcreti";
			this.tbKargoUcreti.Size = new System.Drawing.Size(172, 20);
			this.tbKargoUcreti.TabIndex = 6;
			// 
			// clbSepet
			// 
			this.clbSepet.FormattingEnabled = true;
			this.clbSepet.Location = new System.Drawing.Point(28, 311);
			this.clbSepet.Name = "clbSepet";
			this.clbSepet.Size = new System.Drawing.Size(559, 169);
			this.clbSepet.TabIndex = 7;
			// 
			// Siparis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 506);
			this.Controls.Add(this.clbSepet);
			this.Controls.Add(this.tbKargoUcreti);
			this.Controls.Add(this.btnSiparisOlustur);
			this.Controls.Add(this.btnSepeteEkle);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbKargoSirketi);
			this.Controls.Add(this.cmbMusteri);
			this.Controls.Add(this.listUrunler);
			this.Name = "Siparis";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listUrunler;
		private System.Windows.Forms.ComboBox cmbMusteri;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cmbKargoSirketi;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSepeteEkle;
		private System.Windows.Forms.Button btnSiparisOlustur;
		private System.Windows.Forms.TextBox tbKargoUcreti;
		private System.Windows.Forms.CheckedListBox clbSepet;
	}
}

