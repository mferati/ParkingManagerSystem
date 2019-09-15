using ParkingManagerSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagerSystem
{
	public partial class LoginForm : Form
	{
		public static string user { get; set; }
		public static int RoleID { get; set; }

		public LoginForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			if (LoginValidationsBLL.ValidateUserInputs(userNameTxt.Text, passwordTxt.Text))
			{
				user = userNameTxt.Text;
				MainPage main = new MainPage();
				main.Show(); // show the main page
				this.Hide(); // hide login form
			}
			else
			{
				MessageBox.Show("Error Username or Password!");
			}
			userNameTxt.Clear();
			passwordTxt.Clear();
		}
	}
}
