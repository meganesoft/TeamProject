using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.Models;

namespace TeamProject.ViewModels
{
	class Coin_ViewModel:ViewModelBase
	{
		
		//バインディングリスト
		public List<Coin_Index> IndexData { get; set; }

		//効果の種類をまとめたリスト
		public List<string> Index_Palameter = new List<string> { "1", "10", "50", "100", "500" };

		public Coin_ViewModel()
		{
			this.IndexData = new List<Coin_Index>
			{
				new Coin_Index {CoinType = Index_Palameter[0],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[1],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[2],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[3],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[4],CoinCount = "0" },
			};
		}
	}
}
