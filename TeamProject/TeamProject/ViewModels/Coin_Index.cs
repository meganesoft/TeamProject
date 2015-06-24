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
		private string coin_t_c;

		public string CoinType {get;set;}

		public string CoinCount
		{
			get { return coin_t_c; }
			set
			{
				this.coin_t_c = value;
				NotifyPropertyChanged("CoinCount");
			}
		}
	}
}
