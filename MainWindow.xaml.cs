using System.Windows;

namespace TestScrollBarHideThumb
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void chkSameMinMax_Checked(object sender, RoutedEventArgs e)
		{
			vscrlScroll.Maximum = vscrlScroll.Minimum;
			hscrlScroll.Maximum = hscrlScroll.Minimum;
		}

		private void chkSameMinMax_Unchecked(object sender, RoutedEventArgs e)
		{
			vscrlScroll.Maximum = vscrlScroll.Minimum + 10;
			hscrlScroll.Maximum = hscrlScroll.Minimum + 10;
		}
	}
}
