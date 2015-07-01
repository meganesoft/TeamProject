using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.Models;

namespace TeamProject.ViewModels
{
	class Coin_Index:ViewModelBase
	{
		//ゲーム内で処理する貨幣の金額	
		private string _CoinCount;

		public string CoinType {get;set;}

		Coin Coin_OP = new Coin();
		PriceChild PChild_OP = new PriceChild();

		public string CoinCount
		{
			get { return _CoinCount; }
			set
			{
				this._CoinCount = value;
				NotifyPropertyChanged("CoinCount");
			}
		}

		public void Index_Count_Add()
		{
			this.CoinCount = Coin_OP.Return_Plus_Coin(this.CoinCount);
			PChild_OP.Change_Coin_Price_Total(int.Parse(this.CoinType));
		}

		
	}
}
