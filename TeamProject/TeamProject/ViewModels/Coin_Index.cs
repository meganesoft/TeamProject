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

		public string CoinCount
		{
			get { return _CoinCount; }
			set
			{
				this._CoinCount = value;
				NotifyPropertyChanged("CoinCount");
			}
		}
	}
}
