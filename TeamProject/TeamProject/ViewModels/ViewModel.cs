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
		IDRead IR;
		Random rnd = new Random();
		Price Price_Operation;
		public SampleCommand Command { get; set; }
		

		private string price;
		private string price_q;
		private string coint_c;
		
		public string Price_Bind
		{			
			get { return price; }
			set
			{
				this.price = value;
				NotifyPropertyChanged("Price_Bind");
			}
		}


		public string Price_Q_Bind
		{
			get {return price_q;}
			set
			{
				this.price_q = value;
				NotifyPropertyChanged("Price_Q_Bind");
			}
		}

		

		public ViewModel()
		{
			
			this.Command = new SampleCommand(new EventDelegare(Read_ID));
			this.Price_Bind = "0";			
			tm = new TestModel();
			IR = new IDRead(@"C:\Users\Meganesoft\Documents\Visual Studio 2015\Projects\TeamProject\TeamProject\Resource\exe.win32-2.7\icread.exe");
			Price_Operation = new Price(rnd.Next(100, 1000));
			
		}


		public async void Read_ID()
		{
			await IR.Reading_Id();
			this.Price_Bind = IR.get_denomination();
		}

	}
}
