using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeamProject.Models;

namespace TeamProject.ViewModels
{
	class ViewModel :ViewModelBase
	{
		//モデルを書く(未実装)
		TestModel tm = new TestModel();
		IDRead IR = new IDRead(@"C:\Users\Meganesoft\Documents\Visual Studio 2015\Projects\TeamProject\Resource\Python_test.exe");
		public SampleCommand Command { get; set; }
		

		private string price;

		public string Price_Bind
		{			
			get { return price; }
			set
			{
				this.price = value;
				NotifyPropertyChanged("Price_Bind");
			}
		}

		public ViewModel()
		{
			this.Command = new SampleCommand(new EventDelegare(Sum));
			tm = new TestModel();
			this.Price_Bind = "0";
			IR = new IDRead(@"C:\Users\Meganesoft\Documents\Visual Studio 2015\Projects\TeamProject\Resource\Python_test.exe");
			
		}

		public void Sum()
		{
			this.Price_Bind = tm.Draw(int.Parse(Price_Bind)).ToString();
		}

		public void Read_ID()
		{
			this.Price_Bind = IR.ID_library;
		}

	}
}
