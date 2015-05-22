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
		public static string filepass = @"..\ReSource\Python_test.exe";
		TestModel T_Model = new TestModel();
		IDRead IR = new IDRead(@"C:\Users\Meganesoft\Documents\Visual Studio 2015\Projects\TeamProject\Resource\Python_test.exe");
		

		private void label_Loaded(object sender, RoutedEventArgs e)
		{
			//this.DataContext = new { Price_Bind = T_Model.Draw(50) };
			//数値の表示
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Window_ContentRendered(object sender, EventArgs e)
		{
			
		}
	}
}
