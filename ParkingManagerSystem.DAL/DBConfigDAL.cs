using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.DAL
{
	class DBConfigDAL
	{
		public static string ConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["ParkingSystemConnectionString"].ConnectionString;
		}

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(ConnectionString());
		}

		public static void CloseConnection(SqlConnection sqlConnection)
		{
			if (sqlConnection.State != System.Data.ConnectionState.Open)
			{
				sqlConnection.Close();
			}
			sqlConnection.Dispose();
		}

		public IDbCommand Command(IDbConnection connection, string commandText)
		{
			return Command(connection, commandText, CommandType.Text);
		}

		public static IDbCommand Command(IDbConnection connection, string commandText, CommandType commandType)
		{
			IDbCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandType = commandType;
			command.CommandText = commandText;
			return command;
		}
	}
}
