using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Theater.Classes;

namespace Theater.Pages
{
	public partial class Authorization : Page
	{
		public Authorization()
		{
			InitializeComponent();
		}

		private void ButtonSignInAdmin_Click(object sender, RoutedEventArgs e)
		{
			if (TextBoxSignInAdminLogin.Text != "" & PasswordBoxSignInAdminPassword.Password != "")  //проверка на пустые поля ввода
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					var users = context.Users.ToList();
					Users user = new Users();
					bool checkUser = false;

					foreach (Users u in users)
					{
						if (u.UserLogin == TextBoxSignInAdminLogin.Text & u.UserPassword == PasswordBoxSignInAdminPassword.Password)  //авторизация пользователя в базе
						{
							checkUser = true;
							user = u;
							break;
						}
						else
							checkUser = false;
					}
					if (checkUser)
					{
						Frames.frame.Content = new MainPage();  //переход на главное окно
					}
					else
						TextBlockAdminError.Text = "Введены неверные данные";
				}
			}
			else
				TextBlockAdminError.Text = "Все поля должны быть заполнены";
		}
	}
}
