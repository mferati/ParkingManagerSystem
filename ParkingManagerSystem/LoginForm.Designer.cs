namespace ParkingManagerSystem
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.userNameTxt = new System.Windows.Forms.TextBox();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.usernameLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// userNameTxt
			// 
			this.userNameTxt.Location = new System.Drawing.Point(282, 126);
			this.userNameTxt.Name = "userNameTxt";
			this.userNameTxt.Size = new System.Drawing.Size(155, 22);
			this.userNameTxt.TabIndex = 0;
			// 
			// passwordTxt
			// 
			this.passwordTxt.Location = new System.Drawing.Point(282, 171);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(155, 22);
			this.passwordTxt.TabIndex = 1;
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(360, 240);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(76, 28);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// usernameLbl
			// 
			this.usernameLbl.AutoSize = true;
			this.usernameLbl.Location = new System.Drawing.Point(172, 127);
			this.usernameLbl.Name = "usernameLbl";
			this.usernameLbl.Size = new System.Drawing.Size(77, 17);
			this.usernameLbl.TabIndex = 3;
			this.usernameLbl.Text = "Username:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Password:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 291);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usernameLbl);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.userNameTxt);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox userNameTxt;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label usernameLbl;
		private System.Windows.Forms.Label label1;
	}
}

