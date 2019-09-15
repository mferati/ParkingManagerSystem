using ParkingManagerSystem.BO;
using ParkingManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BLL
{
	public class UserBLL
	{
		public static string Username { get; set; }

		public static bool CreateUser(UserBO user, out bool isInserted)
		{
			isInserted = false;
			try
			{
				if (UserDAL.Create(user))
					isInserted = true;
			}
			catch (Exception)
			{
				throw;
			}
			return isInserted;
		}
	}
}
