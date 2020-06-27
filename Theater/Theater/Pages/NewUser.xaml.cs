using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public partial class NewUser : Page
	{
		public NewUser()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var professions = (from u in context.Professions where u.ProfessionId != 1 select u).ToList();
				ComboBoxNewUserProfession.ItemsSource = professions;
			}
		}

		private void ButtonBackFromNewUserPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new UsersList();
		}

		private void ButtonSaveNewUser_Click(object sender, RoutedEventArgs e)
		{
			if (TextBoxNewUserFIO.Text != "" & ComboBoxNewUserProfession.SelectedIndex >= 0 & TextBoxNewUserDOB.Text != "" & TextBoxNewUserSex.Text != "" & TextBoxNewUserHight.Text != "" & TextBoxNewUserExperience.Text != "" &
				TextBoxNewUserSalary.Text != "" & TextBoxNewUserChildrens.Text != "" & TextBoxNewUserAwards.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					Users user = new Users();

					user.UserFIO = TextBoxNewUserFIO.Text;
					user.ProfessionId = (ComboBoxNewUserProfession.SelectedItem as Professions).ProfessionId;
					user.UserDOB = Convert.ToDateTime(TextBoxNewUserDOB.Text);
					user.UserSex = TextBoxNewUserSex.Text;
					user.UserHight = TextBoxNewUserHight.Text;
					user.UserExperience = TextBoxNewUserExperience.Text;
					user.UserSalary = TextBoxNewUserSalary.Text;
					user.UserСhildrens = Convert.ToInt32(TextBoxNewUserChildrens.Text);
					user.UserAwards = TextBoxNewUserAwards.Text;

					context.Users.Add(user);
					context.SaveChanges();

					TextBoxNewUserFIO.Text = "";
					ComboBoxNewUserProfession.SelectedItem = null;
					TextBoxNewUserDOB.Text = "";
					TextBoxNewUserSex.Text = "";
					TextBoxNewUserHight.Text = "";
					TextBoxNewUserExperience.Text = "";
					TextBoxNewUserSalary.Text = "";
					TextBoxNewUserChildrens.Text = "";
					TextBoxNewUserAwards.Text = "";

					TextBlockNewUserError.Text = "";
					TextBlockUserEditOk.Text = "Новый пользователь создан";
				}
			}
			else
			{
				TextBlockUserEditOk.Text = "";
				TextBlockNewUserError.Text = "Все поля должны быть заполнены";
			}
		}
	}
}
