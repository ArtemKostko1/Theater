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
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
			Frames.frame = InMainPageFrame;
		}

		private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonOpenMenu.Visibility = Visibility.Visible;
			ButtonCloseMenu.Visibility = Visibility.Collapsed;
		}

		private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonOpenMenu.Visibility = Visibility.Collapsed;
			ButtonCloseMenu.Visibility = Visibility.Visible;
		}

		private void ButtonOpenUsersPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new UsersList();
		}

		private void ButtonOpenPerformancesPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PlaysList();
		}

		private void ButtonOpenPerformancesStagingPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PerformancesList();
		}
	}
}
