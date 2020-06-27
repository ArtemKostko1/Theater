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
	public partial class UserProfile : Page
	{
		private int userId;
		public UserProfile(int uId)
		{
			InitializeComponent();

			userId = uId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var users = context.Users.ToList();

				foreach(Users u in users)
				{
					if(u.UserId == userId)
					{
						TextBlockUserProfileName.Text = u.UserFIO;
						TextBlockUserProfileProfession.Text = context.Professions.Single(p => p.ProfessionId == u.ProfessionId).ProfessionName;
						TextBlockUserProfileDOB.Text = (u.UserDOB ?? DateTime.Now).ToString("d");
						TextBlockUserProfileExperience.Text = u.UserExperience;
						TextBlockUserProfileHeight.Text = u.UserHight;
						TextBlockUserProfileSex.Text = u.UserSex;
						TextBlockUserProfileSalary.Text = u.UserSalary;
						TextBlockUserProfileСhildrens.Text = u.UserСhildrens.ToString();
						TextBlockUserProfileAwards.Text = u.UserAwards;
					}
				}
			}	
		}

		private void ButtonBackFromUserProfilePage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new UsersList();
		}

		private void ButtonEditUser_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new UserEdit(userId);
		}
	}
}
