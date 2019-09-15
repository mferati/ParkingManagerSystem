using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagerSystem.DAL;

namespace ParkingManagerSystem.BLL
{
	public class LoginValidationsBLL
	{
		public static bool ValidateUserInputs(string username, string password)
		{

			if (LoginValidationsDAL.ValidateUserLogin(username, password))
			{
				UserBLL.Username = username;
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}
