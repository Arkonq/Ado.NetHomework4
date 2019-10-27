using SalesWinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalesWinForms
{
	public class PurchaseRepository
	{
		private const string CONNECTION_STRING = "Server=BorisHOME\\Boris;Database=SalesHW4;Trusted_Connection=True;";
		public void Add(Purchase purchase)
		{
			Console.WriteLine(purchase.CustomerId);
			Console.WriteLine(purchase.SellerId);
			Console.WriteLine(purchase.Sum);
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = $"INSERT INTO Purchases (Id,CustomerId,SellerId,Sum,CreationDate)" +
						$"VALUES (" +
						$"@Id, " +
						$"@CustomerId, " +
						$"@SellerId, " +
						$"@Sum, " +
						$"@CreationDate);";
				sqlCommand.CommandText = query;

				SqlParameter parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
				parameter.ParameterName = "@Id";
				parameter.Value = purchase.Id;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
				parameter.ParameterName = "@CustomerId";
				parameter.Value = purchase.CustomerId;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
				parameter.ParameterName = "@SellerId";
				parameter.Value = purchase.SellerId;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.Int;
				parameter.ParameterName = "@Sum";
				parameter.Value = purchase.Sum;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.DateTime;
				parameter.ParameterName = "@CreationDate";
				parameter.Value = purchase.CreationDate;
				sqlCommand.Parameters.Add(parameter);

				connection.Open();

				using (SqlTransaction sqlTransaction = connection.BeginTransaction())
				{
					try
					{
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.ExecuteNonQuery();
						sqlTransaction.Commit();
					}
					catch (Exception exception)
					{
						Console.WriteLine(exception.Message);
						sqlTransaction.Rollback();
					}
				}
			}
		}

		public ICollection<Purchase> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = "SELECT * FROM Purchases";
				sqlCommand.CommandText = query;

				connection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				List<Purchase> users = new List<Purchase>();
				while (sqlDataReader.Read())
				{
					users.Add(new Purchase
					{
						Id = Guid.Parse(sqlDataReader["id"].ToString()),
						CustomerId = Guid.Parse(sqlDataReader["customerId"].ToString()),
						SellerId = Guid.Parse(sqlDataReader["sellerId"].ToString()),
						Sum = Int32.Parse(sqlDataReader["sum"].ToString()),
						CreationDate = DateTime.Parse(sqlDataReader["creationDate"].ToString())
					});
				}
				return users;
			}
		}
	}
}
