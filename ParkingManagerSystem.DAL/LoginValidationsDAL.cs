using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagerSystem.DAL
{
	public class LoginValidationsDAL
	{

		public static bool ValidateUserLogin(string username, string password)
		{

			SqlConnection sqlConnection = (SqlConnection)DBConfigDAL.GetConnection();
			try
			{
				string SQLprocedure = "dbo.CheckPassword";

				SqlCommand sqlCommand = new SqlCommand(SQLprocedure, (SqlConnection)sqlConnection);
				sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

				sqlCommand.Parameters.AddWithValue("@username", username);
				sqlCommand.Parameters.AddWithValue("@password", password);

				sqlConnection.Open();
				string validate = sqlCommand.ExecuteScalar().ToString();
				if (validate == "true")
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				DBConfigDAL.CloseConnection((SqlConnection)sqlConnection);
			}

		}
	}
}
