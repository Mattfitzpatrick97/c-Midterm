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

namespace Matthew_991524179_Midterm
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
		private void Functionalities_Click(object sender, RoutedEventArgs e)
		{
			Functionalities functions = new Functionalities();
			Functionalities.Show();
			this.Close();
		}

		private void Quit_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
