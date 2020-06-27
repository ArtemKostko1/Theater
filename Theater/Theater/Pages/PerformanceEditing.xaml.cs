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
	public partial class PerformanceEditing : Page
	{
		private int performanceId;
		public PerformanceEditing(int perId)
		{
			InitializeComponent();

			performanceId = perId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var performance = context.Performances.Single(p => p.PerformanceId == performanceId);

				var plays = context.Plays.ToList();
				var directors = (from u in context.Users where u.ProfessionId == 3 select u).ToList();
				var artDirectors = (from u in context.Users where u.ProfessionId == 4 select u).ToList();
				var dresser = (from u in context.Users where u.ProfessionId == 6 select u).ToList();

				ComboBoxPerformancePlayEditing.ItemsSource = plays;
				ComboBoxPerformanceDirectorEditing.ItemsSource = directors;
				ComboBoxPerformanceArtDirectorEditing.ItemsSource = artDirectors;
				ComboBoxPerformanceDresserEditing.ItemsSource = dresser;

				ComboBoxPerformancePlayEditing.SelectedItem = context.Plays.Single(per => per.PlayId == performance.PlayId);
				ComboBoxPerformanceDirectorEditing.SelectedItem = context.Users.Single(u => u.UserFIO == performance.PerformanceDirector);
				ComboBoxPerformanceArtDirectorEditing.SelectedItem = context.Users.Single(u => u.UserFIO == performance.PerformanceArtDirector); ;
				ComboBoxPerformanceDresserEditing.SelectedItem = context.Users.Single(u => u.UserFIO == performance.PerformanceDresser);

				TextBoxPerformanceDateEditing.Text = performance.PerformanceDate.ToString("d");
				TextBoxPerformanceTimeEditing.Text = performance.PerformanceTime.ToString("t");
				TextBoxPerformanceLocationEditing.Text = performance.PerformanceLocation;
				TextBoxPerformancePriceEditing.Text = performance.PerformancePrice;
			}
		}

		private void ButtonBackFromPerformanceEditingPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PerformancesList();
		}

		private void ButtonSavePerformanceEditing_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxPerformancePlayEditing.SelectedIndex >= 0 & ComboBoxPerformanceDirectorEditing.SelectedIndex >= 0 & ComboBoxPerformanceArtDirectorEditing.SelectedIndex >= 0 & 
				ComboBoxPerformanceDresserEditing.SelectedIndex >= 0 & TextBoxPerformanceDateEditing.Text != "" & TextBoxPerformanceTimeEditing.Text != "" & TextBoxPerformanceLocationEditing.Text != "" &
				TextBoxPerformancePriceEditing.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					var performance = context.Performances.Single(p => p.PerformanceId == performanceId);

					performance.PlayId = (ComboBoxPerformancePlayEditing.SelectedItem as Plays).PlayId;
					performance.PerformanceDirector = (ComboBoxPerformanceDirectorEditing.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceArtDirector = (ComboBoxPerformanceArtDirectorEditing.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceDresser = (ComboBoxPerformanceDresserEditing.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceDate = Convert.ToDateTime(TextBoxPerformanceDateEditing.Text);
					performance.PerformanceTime = Convert.ToDateTime(TextBoxPerformanceTimeEditing.Text);
					performance.PerformanceLocation = TextBoxPerformanceLocationEditing.Text;
					performance.PerformancePrice = TextBoxPerformancePriceEditing.Text;

					context.SaveChanges();

					ComboBoxPerformancePlayEditing.SelectedItem = null;
					ComboBoxPerformanceDirectorEditing.SelectedItem = null;
					ComboBoxPerformanceArtDirectorEditing.SelectedItem = null;
					ComboBoxPerformanceDresserEditing.SelectedItem = null;
					TextBoxPerformanceDateEditing.Text = "";
					TextBoxPerformanceTimeEditing.Text = "";
					TextBoxPerformanceLocationEditing.Text = "";
					TextBoxPerformancePriceEditing.Text = "";

					TextBlockPerformanceEditingError.Text = "";
					TextBlockPerformanceEditingOk.Text = "Постановка отредактирована";
				}
			}
			else
			{
				TextBlockPerformanceEditingOk.Text = "";
				TextBlockPerformanceEditingError.Text = "Все поля должны быть заполнены";
			}
		}
	}
}
