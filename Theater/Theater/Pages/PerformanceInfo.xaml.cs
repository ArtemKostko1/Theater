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
	public partial class PerformanceInfo : Page
	{
		private int performanceId;
		public PerformanceInfo(int perId)
		{
			InitializeComponent();

			performanceId = perId;

			using (TheaterDBContext context = new TheaterDBContext())
			{
				var performances = context.Performances.ToList();

				foreach (Performances p in performances)
				{
					if (p.PerformanceId == performanceId)
					{
						TextBlockPerformanceInfoName.Text = context.Plays.Single(pl => pl.PlayId == p.PlayId).PlayName;
						TextBlockPerformanceInfoDirector.Text = p.PerformanceDirector;
						TextBlockPerformanceInfoArtDirector.Text = p.PerformanceArtDirector;
						TextBlockPerformanceInfoDresser.Text = p.PerformanceDresser;
						TextBlockPerformanceInfoDate.Text = p.PerformanceDate.ToString("d");
						TextBlockPerformanceInfoTime.Text = p.PerformanceTime.ToString("t");
						TextBlockPerformanceInfoLocation.Text = p.PerformanceLocation;
						TextBlockPerformanceInfoPrice.Text = p.PerformancePrice;
					}
				}
			}
		}

		private void ButtonBackFromPerformanceStagingInfoPage_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PerformancesList();
		}

		private void ButtonPerformanceEditing_Click(object sender, RoutedEventArgs e)
		{
			Frames.frame.Content = new PerformanceEditing(performanceId);
		}
	}
}
