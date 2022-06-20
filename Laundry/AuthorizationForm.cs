using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
	public partial class AuthorizationForm : Form
	{
		LaundryEntities db = new LaundryEntities();
		public AuthorizationForm()
		{
			InitializeComponent();
		}

		private void Autorization_btn_Click(object sender, EventArgs e)
		{
			String loginUser = LoginField.Text; // переменные принимающие значения из полей
			String passwordUser = PasswordField.Text;

			var staff = db.Staff.FirstOrDefault(a => a.Login == loginUser && a.Password == passwordUser);
			if (staff == null)
			{
				MessageBox.Show("Не правильный логин или пароль");
			}
			else 
			{

				ActiveForm activeForm = new ActiveForm();
				activeForm.Show();
				this.Hide();
			}
		}


	}
	
}
