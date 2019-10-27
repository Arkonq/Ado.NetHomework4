using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SalesWinForms
{
	public class CustomerRepository
	{
		private const string CONNECTION_STRING = "Server=BorisHOME\\Boris;Database=SalesHW4;Trusted_Connection=True;";
		public void Add(Customer customer)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = $"INSERT INTO Customers (Id,FirstName,LastName)" +
						$"VALUES (" +
						$"@Id, " +
						$"@FirstName, " +
						$"@LastName);";
				sqlCommand.CommandText = query;

				SqlParameter parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
				parameter.ParameterName = "@Id";
				parameter.Value = customer.Id;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.NVarChar;
				parameter.ParameterName = "@FirstName";
				parameter.Value = customer.FirstName;
				sqlCommand.Parameters.Add(parameter);

				parameter = new SqlParameter();
				parameter.SqlDbType = System.Data.SqlDbType.NVarChar;
				parameter.ParameterName = "@LastName";
				parameter.Value = customer.LastName;
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
					catch
					{
						sqlTransaction.Rollback();
					}
				}
			}
		}

		public ICollection<Customer> GetAll()
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = "SELECT * FROM Customers";
				sqlCommand.CommandText = query;

				connection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				List<Customer> users = new List<Customer>();
				while (sqlDataReader.Read())
				{
					users.Add(new Customer
					{
						Id = Guid.Parse(sqlDataReader["Id"].ToString()),
						FirstName = sqlDataReader["FirstName"].ToString(),
						LastName = sqlDataReader["LastName"].ToString()
					});
				}
				return users;
			}
		}
	}
}
