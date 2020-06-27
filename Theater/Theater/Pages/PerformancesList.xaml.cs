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
	public partial class PerformancesList : Page
	{
		public PerformancesList()
		{
			InitializeComponent();

			using (TheaterDBContext context = new TheaterDBContext())
			{
				IEnumerable<PlaysName> enumerable;

				enumerable = (from pe in context.Performances
							  join pl in context.Plays on pe.PlayId equals pl.PlayId
							  select new PlaysName()
							  {
								  PerformanceId = pe.PerformanceId,
								  PlayName = pl.PlayName,
								  PerformanceDate = pe.PerformanceDate.ToString(),
								  PerformanceTime = pe.PerformanceTime.ToString(),
								  PerformanceLocation = pe.PerformanceLocation,
								  PerformancePrice = pe.PerformancePrice,
							  });

				enumerable = enumerable.Reverse();
				PerformancesListBox.ItemsSource = enumerable;
			}
		}

		private void ButtonOpenNewPerformancePage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new NewPerformance();
		}

		private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Frames.frame.Content = new PerformanceInfo(((PlaysName)PerformancesListBox.SelectedItem).PerformanceId);
		}
	}
}
