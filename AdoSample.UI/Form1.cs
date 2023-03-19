using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AdoSample.DTO;
using AdoSample.MyProvider;

namespace AdoSample.UI
{
	public partial class Form1 : Form
	{
		SqlDbService _dbService;
		private SqlDataReader _reader;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			VerileriYukle();
		}

		private void Yukle()
		{
			lstKargolar.Items.Clear();
			// Connection
			// Command

			//SqlConnection conn = new SqlConnection();

			//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
			//sqlConnectionStringBuilder.DataSource = "localhost";
			//sqlConnectionStringBuilder.UserID = "sa";
			//sqlConnectionStringBuilder.Password = "123";
			//sqlConnectionStringBuilder.InitialCatalog = "Northwind";

			//SqlCommand cmd = new SqlCommand();
			//conn.ConnectionString = sqlConnectionStringBuilder.ConnectionString;
			//connection string appconfigte tanımlanabilir. builderda tanımlanabilir. 

			SqlConnection conn = new SqlConnection("Data Source = LAPTOP-BVA50RVR; Initial Catalog = NORTHWND; Integrated Security = True");

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select * from Shippers";
			cmd.Connection = conn;

			if (conn.State == ConnectionState.Closed)
			{
				conn.Open(); // Transaction başlatılır.

			}
			SqlDataReader reader = cmd.ExecuteReader();
			List<KargoBilgisi> kargolar = null;
			if (reader.HasRows)
			{
				kargolar = new List<KargoBilgisi>();
				while (reader.Read()) //bir sonraki satırda veri var ise true döner
				{
					kargolar.Add(new KargoBilgisi()
					{
						KargoId = reader.GetInt32(0), //içindeki sayı sütunun sıra numarası.
						KargoAdi = reader.GetString(1),
						Tel = reader.GetString(2),
						AktifMi = true,
					});

				}
			}

			if (conn.State == ConnectionState.Open)
			{
				conn.Close();

			}

			foreach (KargoBilgisi item in kargolar)
			{
				lstKargolar.Items.Add(item);
			}


			//execute 
			/*
            Connected Mimari => open, close yapınca connected mimari olur. 

            select => tablo executereader
            insert update delete => executenonquery
            select => tek değer => executescaler
             */
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			//insert yapıldıgında insert ile ilgili log kaydı alan bir kayıt daha database e atılmalı.
			
			SqlConnection conn = new SqlConnection("Data Source = LAPTOP-BVA50RVR; Initial Catalog = NORTHWND; Integrated Security = True");
			SqlTransaction tran = null;
			int etkilenenSatirSayisi = 0;
			int etkilenenLogSatirSayisi = 0;
			try
			{
				conn.Open();
				tran = conn.BeginTransaction();
				SqlCommand cmd = new SqlCommand("insert Shippers(CompanyName,Phone) values (@girilenKargo,@girilenTelefon)");
				cmd.Parameters.AddWithValue("@girilenKargo", txtKargoAdi.Text);
				cmd.Parameters.AddWithValue("@girilenTelefon", txtTel.Text);
				cmd.Connection = conn;
				cmd.Transaction = tran;
				SqlCommand cmd01 = new SqlCommand("insert into MyLogs(LogAciklama,LogTipi,LogDate) values(@aciklama,@logtipi,@logdate)", conn, tran);
				cmd01.Parameters.AddWithValue("@aciklama", "kargo ekleme işlemi yapıldı..");
				cmd01.Parameters.AddWithValue("@logtipi", "Information");
				cmd01.Parameters.AddWithValue("@logdate", DateTime.Now);
				etkilenenSatirSayisi = cmd.ExecuteNonQuery();
				etkilenenLogSatirSayisi = cmd01.ExecuteNonQuery();
				tran.Commit();
			}
			catch (Exception ex)
			{
				tran.Rollback();
			}
			finally
			{
				conn.Close();
			}
			MessageBox.Show(etkilenenSatirSayisi > 0 && etkilenenLogSatirSayisi > 0
				? "başarıyla kayıt yapılmıştır."
				: "hata oluştu.");
			Yukle();
			Temizle();
		}

		void Temizle()
		{
			txtKargoAdi.Text = txtTel.Text = null;
		}

		void VerileriYukle()
		{
			_dbService = new SqlDbService("select * from Shippers");
			_dbService.BaglantiAc();
			_reader = _dbService.ExReader();

			List<KargoBilgisi> kargolar = null;
			if (_reader.HasRows)
			{
				lstKargolar.Items.Clear();
				kargolar = new List<KargoBilgisi>();
				while (_reader.Read()) //bir sonraki satırda veri var ise true döner
				{
					kargolar.Add(new KargoBilgisi()
					{
						KargoId = _reader.GetInt32(0), //içindeki sayı sütunun sıra numarası.
						KargoAdi = _reader.GetString(1),
						Tel = _reader.GetString(2),
						//AktifMi = (bool)_reader["IsDeleted"],
					});

				}
			}
			_dbService.BaglantiKapat();
			foreach (KargoBilgisi item in kargolar)
			{
				lstKargolar.Items.Add(item);
			}
		}

		private void btnKargoEkle_Click(object sender, EventArgs e)
		{
			SqlParameter[] parameters =
			{
				new SqlParameter("@KargoAdi", txtKargoAdi.Text),
				new SqlParameter("@Tel", txtTel.Text),
			};
			
			_dbService.ExecuteTransaction("insert", "insert into Shippers (CompanyName,Phone) values (@KargoAdi, @Tel)", parameters);

			SqlParameter[] parametersLog =
			{
				new SqlParameter("@aciklama", "kargo ekleme işlemi yapıldı.."),
				new SqlParameter("@logtipi", "Information"),
				new SqlParameter("@logdate", DateTime.Now)
			};

			_dbService.ExecuteTransaction("insert", "insert into MyLog(LogAciklama,LogTipi,LogDate) values(@aciklama,@logtipi,@logdate", parametersLog);



			VerileriYukle();
			Temizle();
		}
	}
}
