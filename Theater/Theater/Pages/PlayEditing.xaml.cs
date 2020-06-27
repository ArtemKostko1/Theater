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
	public partial class PlayEdit : Page
	{
		private int playId;
		public PlayEdit(int pId)
		{
			InitializeComponent();

			playId = pId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var play = context.Plays.Single(u => u.PlayId == playId);

				ComboBoxPlayEditingGenre.ItemsSource = context.Genres.ToList();
				ComboBoxPlayEditingGenre.SelectedItem = context.Genres.Single(g => g.GenreId == play.GenreId);

				ComboBoxPlayEditingParentalGuidance.ItemsSource = context.ParentalGuidances.ToList();
				ComboBoxPlayEditingParentalGuidance.SelectedItem = context.ParentalGuidances.Single(pa => pa.ParentalGuidanceId == play.ParentalGuidanceId);

				TextBoxPlayEditingName.Text = play.PlayName;
				TextBoxPlayEditingAuthor.Text = play.PlayAuthor;
				TextBoxPlayEditingPremiere.Text = play.PlayPremiere;
			}
		}

		private void ButtonBackFromPlayEditPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PlaysList();
		}

		private void ButtonSavePlayEdit_Click(object sender, RoutedEventArgs e)
		{
			if (TextBoxPlayEditingName.Text != "" & ComboBoxPlayEditingGenre.SelectedIndex >= 0 & ComboBoxPlayEditingParentalGuidance.SelectedIndex >= 0 & TextBoxPlayEditingAuthor.Text != "" & TextBoxPlayEditingPremiere.Text != "")
			{
				using (TheaterDBContext context = new TheaterDBContext())
				{
					var play = context.Plays.Single(p => p.PlayId == playId);

					play.PlayName = TextBoxPlayEditingName.Text;
					play.PlayAuthor = TextBoxPlayEditingAuthor.Text;
					play.GenreId = (ComboBoxPlayEditingGenre.SelectedItem as Genres).GenreId;
					play.ParentalGuidanceId = (ComboBoxPlayEditingParentalGuidance.SelectedItem as ParentalGuidances).ParentalGuidanceId;
					play.PlayPremiere = TextBoxPlayEditingPremiere.Text;

					context.SaveChanges();

					TextBoxPlayEditingName.Text = "";
					TextBoxPlayEditingAuthor.Text = "";
					ComboBoxPlayEditingGenre.SelectedItem = null;
					ComboBoxPlayEditingParentalGuidance.SelectedItem = null;
					TextBoxPlayEditingPremiere.Text = "";

					TextBlockPlayEditingError.Text = "";
					TextBlockPlayEditingOk.Text = "Спектакль отредактирован";
				}
			}
			else
			{
				TextBlockPlayEditingOk.Text = "";
				TextBlockPlayEditingError.Text = "Все поля должны быть заполнены";
			}
		}
	}
}
