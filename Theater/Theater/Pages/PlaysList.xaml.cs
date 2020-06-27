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
	public partial class PlaysList : Page
	{
		public PlaysList()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				IEnumerable<ParentalGuidancesGenresValue> enumerable;

				enumerable = (from pl in context.Plays
							  join pa in context.ParentalGuidances on pl.ParentalGuidanceId equals pa.ParentalGuidanceId
							  join g in context.Genres on pl.GenreId equals g.GenreId
							  select new ParentalGuidancesGenresValue()
							  {
								  PlayId = pl.PlayId,
								  PlayName = pl.PlayName,
								  PlayAuthor = pl.PlayAuthor,
								  GenreName = g.GenreName,
								  ParentalGuidanceValue = pa.ParentalGuidanceValue,
								  PlayPremiere = pl.PlayPremiere
							  });

				enumerable = enumerable.Reverse();
				PlaysListBox.ItemsSource = enumerable;
			}
		}

		private void ButtonOpenNewPerformancePage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new NewPlay();
		}

		private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Frames.frame.Content = new PlayInfo(((ParentalGuidancesGenresValue)PlaysListBox.SelectedItem).PlayId);
		}
	}
}
