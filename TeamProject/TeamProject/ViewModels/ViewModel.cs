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
		//PasoriからDBに接続するクラス
		IDRead IR;
		//ゲーム提示用ランダムクラス
		Random rnd = new Random();
		//数字を司るクラス
		Price Price_Operation;
		//コマンドクラス
		//読み取り用コマンド
		public SampleCommand Command { get; set; }
		//清算コマンド
		public SampleCommand JudgeTotal { get; set; }
		//バインディングリスト
		public List<Coin_Index> IndexData { get; set; }		
		//Coinクラス
		Coin Coin_Op = new Coin();
		

		private string price = "0";
		private string price_q;
		
		
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
			this.JudgeTotal = new SampleCommand(new EventDelegare(Judge));	
			this.IndexData = Coin_Op.Coin_Index_create();	
			IR = new IDRead();			
			IR.Create_Process();
			Price_Operation = new Price(rnd.Next(100, 1000));
			Price_Q_Bind = Price_Operation.get_Price_Total();
		}


		public async void Read_ID()
		{
			await IR.Reading_Id();
			Coin_Op.Coin_Index_Judgement(this.IndexData,IR.get_denomination());
			Price_Operation.Add_Price(int.Parse(IR.get_denomination()));
		}

		public void Judge()
		{
			Price_Operation.Judge_Price();
		}
	}
}
