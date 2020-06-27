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
	public partial class NewPlay : Page
	{
		public NewPlay()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				ComboBoxNewPlayGenre.ItemsSource = context.Genres.ToList();
				ComboBoxNewPlayParentalGuidance.ItemsSource = context.ParentalGuidances.ToList();
			}
		}

		private void ButtonBackFromNewPerformancePage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PlaysList();
		}

		private void ButtonSaveNewPlay_Click(object sender, RoutedEventArgs e)
		{
			if (TextBoxNewPlayName.Text != "" & TextBoxNewPlayAuthor.Text != "" & ComboBoxNewPlayGenre.SelectedIndex >= 0 & ComboBoxNewPlayParentalGuidance.SelectedIndex >= 0 & TextBoxNewPlayPremiere.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					Plays play = new Plays();

					play.PlayName = TextBoxNewPlayName.Text;
					play.PlayAuthor = TextBoxNewPlayAuthor.Text;
					play.GenreId = (ComboBoxNewPlayGenre.SelectedItem as Genres).GenreId;
					play.ParentalGuidanceId = (ComboBoxNewPlayParentalGuidance.SelectedItem as ParentalGuidances).ParentalGuidanceId;
					play.PlayPremiere = TextBoxNewPlayPremiere.Text;

					context.Plays.Add(play);
					context.SaveChanges();

					TextBoxNewPlayName.Text = "";
					ComboBoxNewPlayGenre.SelectedItem = null;
					ComboBoxNewPlayParentalGuidance.SelectedItem = null;
					TextBoxNewPlayAuthor.Text = "";
					TextBoxNewPlayPremiere.Text = "";

					TextBlockNewPlayError.Text = "";
					TextBlockNewPlayOk.Text = "Новый спектакль добавлен";
				}
			}
			else
			{
				TextBlockNewPlayOk.Text = "";
				TextBlockNewPlayError.Text = "Все поля должны быть заполнены";
			}
		}
	}
}

