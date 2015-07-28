using System;
using System.Windows;
using TeamProject.ViewModels;


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
