using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSample.MyProvider
{
	public class SqlDbService
	{
		private SqlConnection conn;
		private SqlCommand cmd;
		SqlTransaction tran;

		public SqlDbService(string connectionQuery, string connectionString = "Data Source = LAPTOP-BVA50RVR; Initial Catalog = NORTHWND; Integrated Security = True")
		{
			conn = new SqlConnection(connectionString);
			cmd = new SqlCommand();
			cmd.CommandText = connectionQuery;
			cmd.Connection = conn;
		}

		public void ParametreEkle(SqlParameter[] sqlParameters)
		{
			cmd.Parameters.AddRange(sqlParameters);
		}
		public void BaglantiAc()
		{
			if (conn.State == ConnectionState.Closed) conn.Open();
		}
		public void BaglantiKapat()
		{
			if (conn.State == ConnectionState.Open) conn.Close();
		}

		public SqlDataReader ExReader()
		{
			return cmd.ExecuteReader();
		}
		public int ExecuteNonQuery()
		{
			return cmd.ExecuteNonQuery();
		}

		public object ExecuteScalar()
		{
			return cmd.ExecuteScalar();
		}
		
		public void ExecuteTransaction(string queryType, string command, SqlParameter[] parameter)
		{
			BaglantiAc();
			tran = conn.BeginTransaction();
			cmd.CommandText = command;
			cmd.Transaction = tran;
			int etkilenenSatirSayisi = 0;
			try
			{
				if (parameter != null)
				{
					ParametreEkle(parameter);
				}

				if (queryType == "insert" || queryType == "update" || queryType == "delete")
				{
					etkilenenSatirSayisi = ExecuteNonQuery();
					if (etkilenenSatirSayisi == 0)
					{
						throw new Exception("hata");
					}
				}
				else
				{
					throw new Exception("hata");
				}

				cmd.Parameters.Clear();
				tran.Commit();

			}
			catch (Exception ex)
			{
				tran.Rollback();

			}
			finally
			{
				BaglantiKapat();
			}
		}

		public void ExecuteTransaction(SqlCommand[] sqlCommands)
		{
			BaglantiAc();
			tran = conn.BeginTransaction();
			try
			{
				foreach (SqlCommand command in sqlCommands)
				{
					command.Connection = conn;
					command.Transaction = tran;
					//cmd = new SqlCommand(command, conn, tran);
					int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
					if (etkilenenSatirSayisi == 0)
					{
						throw new Exception("hata");
					}
				}
				tran.Commit();
			}
			catch
			{
				tran.Rollback();
			}
			finally
			{
				BaglantiKapat();
			}
		}

	}
}
