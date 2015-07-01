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
using TeamProject.Models;
using TeamProject.ViewModels;
using System.Threading;


namespace TeamProject.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();			
			this.DataContext = new ViewModel();
			
		}
		
		private void label_Loaded(object sender, RoutedEventArgs e)
		{
			
			
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private  void Window_ContentRendered(object sender, EventArgs e)
		{
			
		}

		private void button_Click_1(object sender, RoutedEventArgs e)
		{

		}
	}
}
