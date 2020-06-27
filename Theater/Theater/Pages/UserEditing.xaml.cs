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
	public partial class UserEdit : Page
	{
		private int userId;
		public UserEdit(int uId)
		{
			InitializeComponent();

			userId = uId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var user = context.Users.Single(u => u.UserId == userId);

				ComboBoxUserEditingProfession.ItemsSource = context.Professions.ToList();
				ComboBoxUserEditingProfession.SelectedItem = context.Professions.Single(p => p.ProfessionId == user.ProfessionId);

				TextBoxUserEditingFIO.Text = user.UserFIO;
				TextBoxUserEditingDOB.Text = (user.UserDOB ?? DateTime.Now).ToString("d");
				TextBoxUserEditingHight.Text = user.UserHight;
				TextBoxUserEditingSex.Text = user.UserSex;
				TextBoxUserEditingSalary.Text = user.UserSalary;
				TextBoxUserEditingChildrens.Text = user.UserСhildrens.ToString();
				TextBoxUserEditingExperience.Text = user.UserExperience;
				TextBoxUserEditingAwards.Text = user.UserAwards;
			}
		}

		private void ButtonSaveUserEditing_Click(object sender, RoutedEventArgs e)
		{
			if (TextBoxUserEditingFIO.Text != "" & ComboBoxUserEditingProfession.SelectedIndex >= 0 & TextBoxUserEditingDOB.Text != "" & TextBoxUserEditingSex.Text != "" & TextBoxUserEditingHight.Text != "" &
				TextBoxUserEditingExperience.Text != "" & TextBoxUserEditingSalary.Text != "" & TextBoxUserEditingChildrens.Text != "" & TextBoxUserEditingAwards.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					var user = context.Users.Single(u => u.UserId == userId);

					user.UserFIO = TextBoxUserEditingFIO.Text;
					user.ProfessionId = (ComboBoxUserEditingProfession.SelectedItem as Professions).ProfessionId;
					user.UserDOB = Convert.ToDateTime(TextBoxUserEditingDOB.Text);
					user.UserSex = TextBoxUserEditingSex.Text;
					user.UserHight = TextBoxUserEditingHight.Text;
					user.UserExperience = TextBoxUserEditingExperience.Text;
					user.UserSalary = TextBoxUserEditingSalary.Text;
					user.UserСhildrens = Convert.ToInt32(TextBoxUserEditingChildrens.Text);
					user.UserAwards = TextBoxUserEditingAwards.Text;

					context.SaveChanges();

					TextBoxUserEditingFIO.Text = "";
					ComboBoxUserEditingProfession.SelectedItem = null;
					TextBoxUserEditingDOB.Text = "";
					TextBoxUserEditingSex.Text = "";
					TextBoxUserEditingHight.Text = "";
					TextBoxUserEditingExperience.Text = "";
					TextBoxUserEditingSalary.Text = "";
					TextBoxUserEditingChildrens.Text = "";
					TextBoxUserEditingAwards.Text = "";

					TextBlockUserEditingError.Text = "";
					TextBlockUserEditingOk.Text = "Пользователь отредактирован";
				}
			}
			else
			{
				TextBlockUserEditingOk.Text = "";
				TextBlockUserEditingError.Text = "Все поля должны быть заполнены";
			}
		}

		private void ButtonBackFromUserEditPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new UsersList();
		}
	}
}
