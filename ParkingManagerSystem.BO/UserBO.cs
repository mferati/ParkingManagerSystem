using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BO
{
	public class UserBO
	{
		public string name { get; set; }
		public string lastName { get; set; }
		public string email { get; set; }

		private DateTime registerDate;
		public DateTime RegisterDate
		{
			get { return registerDate.Date; }
			set { registerDate = value; }
		}

		public string userName { get; set; }
		public string password { get; set; }

		public UserBO(string name, string lastName, string email, DateTime regDate, string userName, string password)
		{
			this.name = name;
			this.lastName = lastName;
			this.email = email;
			this.RegisterDate = regDate;
			this.userName = userName;
			this.password = password;
		}
	}
}
