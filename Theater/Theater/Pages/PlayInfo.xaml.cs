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
	public partial class PlayInfo : Page
	{
		private int playId;
		public PlayInfo(int pId)
		{
			InitializeComponent();

			playId = pId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var plays = context.Plays.ToList();

				foreach (Plays p in plays)
				{
					if (p.PlayId == playId)
					{
						TextBlockPlayInfoName.Text = p.PlayName;
						TextBlockPlayInfoAuthor.Text = p.PlayAuthor;
						TextBlockPlayInfoGenre.Text = context.Genres.Single(g => g.GenreId == p.GenreId).GenreName;
						TextBlockPlayInfoParentalGuidance.Text = context.ParentalGuidances.Single(pa => pa.ParentalGuidanceId == p.ParentalGuidanceId).ParentalGuidanceValue;
						TextBlockPlayInfoPremiere.Text = p.PlayPremiere;
					}
				}
			}
		}

		private void ButtonBackFromPerformanceInfoPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PlaysList();
		}

		private void ButtonPlayEdit_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PlayEdit(playId);
		}
	}
}
