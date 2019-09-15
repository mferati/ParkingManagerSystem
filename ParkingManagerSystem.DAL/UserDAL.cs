using ParkingManagerSystem.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.DAL
{
	public class UserDAL
	{
		public static bool Create(UserBO user)
		{
			IDbConnection conn = DBConfigDAL.GetConnection();
			try
			{
				string sqlProcedure = "dbo.CreateUser";

				SqlCommand sqlCommand = new SqlCommand(sqlProcedure, (SqlConnection)conn);
				sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;


				SqlParameter sqlPrm = sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.name;

				sqlPrm = sqlCommand.Parameters.Add("@lastName", SqlDbType.NVarChar);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.lastName;

				sqlPrm = sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.email;

				sqlPrm = sqlCommand.Parameters.Add("@registerDate", SqlDbType.Date);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.RegisterDate;

				sqlPrm = sqlCommand.Parameters.Add("@username", SqlDbType.NVarChar);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.userName;

				sqlPrm = sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar);
				sqlPrm.Direction = ParameterDirection.Input;
				sqlPrm.Value = user.password;

				conn.Open();
				sqlCommand.ExecuteScalar();

				return true;

			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				DBConfigDAL.CloseConnection((SqlConnection)conn);
			}
		}
	}
}
