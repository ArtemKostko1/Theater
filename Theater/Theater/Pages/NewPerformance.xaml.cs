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
	public partial class NewPerformance : Page
	{
		public NewPerformance()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var plays = context.Plays.ToList();
				var directors = (from u in context.Users where u.ProfessionId == 3 select u).ToList();
				var artDirectors = (from u in context.Users where u.ProfessionId == 4 select u).ToList();
				var dresser = (from u in context.Users where u.ProfessionId == 6 select u).ToList();

				ComboBoxNewPerformancePlay.ItemsSource = plays;
				ComboBoxNewPerformanceDirector.ItemsSource = directors;
				ComboBoxNewPerformanceArtDirector.ItemsSource = artDirectors;
				ComboBoxNewPerformanceDresser.ItemsSource = dresser;
			}
		}

		private void ButtonSaveNewPerformance_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxNewPerformancePlay.SelectedIndex >= 0 & ComboBoxNewPerformanceDirector.SelectedIndex >= 0 & ComboBoxNewPerformanceArtDirector.SelectedIndex >= 0 & ComboBoxNewPerformanceDresser.SelectedIndex >= 0 &
				TextBoxNewPerformanceDate.Text != "" & TextBoxNewPerformanceTime.Text != "" & TextBoxNewPerformanceLocation.Text != "" & TextBoxNewPerformancePrice.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					Performances performance = new Performances();

					performance.PlayId = (ComboBoxNewPerformancePlay.SelectedItem as Plays).PlayId;
					performance.PerformanceDirector = (ComboBoxNewPerformanceDirector.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceArtDirector = (ComboBoxNewPerformanceArtDirector.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceDresser = (ComboBoxNewPerformanceDresser.SelectedItem as Users).UserFIO.ToString();
					performance.PerformanceDate = Convert.ToDateTime(TextBoxNewPerformanceDate.Text);
					performance.PerformanceTime = Convert.ToDateTime(TextBoxNewPerformanceTime.Text);
					performance.PerformanceLocation = TextBoxNewPerformanceLocation.Text;
					performance.PerformancePrice = TextBoxNewPerformancePrice.Text;

					context.Performances.Add(performance);
					context.SaveChanges();

					ComboBoxNewPerformancePlay.SelectedItem = null;
					ComboBoxNewPerformanceDirector.SelectedItem = null;
					ComboBoxNewPerformanceArtDirector.SelectedItem = null;
					ComboBoxNewPerformanceDresser.SelectedItem = null;
					TextBoxNewPerformanceDate.Text = "";
					TextBoxNewPerformanceTime.Text = "";
					TextBoxNewPerformanceLocation.Text = "";
					TextBoxNewPerformancePrice.Text = "";

					TextBlockNewPerformanceError.Text = "";
					TextBlockNewPerformanceOk.Text = "Новая постановка добавлена";
				}
			}
			else
			{
				TextBlockNewPerformanceOk.Text = "";
				TextBlockNewPerformanceError.Text = "Все поля должны быть заполнены";
			}
		}

		private void ButtonBackFromPerformanceEditingPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PerformancesList();
		}
	}
}
