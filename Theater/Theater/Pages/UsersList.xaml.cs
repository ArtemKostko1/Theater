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
	public partial class UsersList : Page
	{		
		public UsersList()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				IEnumerable<PrfessionsName> enumerable;

				enumerable = (from i in context.Users
							  join j in context.Professions on i.ProfessionId equals j.ProfessionId
							  select new PrfessionsName()
							  {
								  UserId = i.UserId,
								  UserLogin = i.UserLogin,
								  UserPassword = i.UserPassword,
								  UserFIO = i.UserFIO,
								  UserDOB = i.UserDOB,
								  ProfessionName = j.ProfessionName,
								  UserHight = i.UserHight,
								  UserSex = i.UserSex,
								  UserExperience = i.UserExperience,
								  UserSalary = i.UserSalary,
								  UserСhildrens = i.UserСhildrens,
								  UserAwards = i.UserAwards
							  });

				enumerable = enumerable.Reverse();
				UsersListBox.ItemsSource = enumerable;
			}
		}

		private void ButtonOpenNewUserPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new NewUser();
		}

		private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Frames.frame.Content = new UserProfile(((PrfessionsName)UsersListBox.SelectedItem).UserId);
		}
	}
}
