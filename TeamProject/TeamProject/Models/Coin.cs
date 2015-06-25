using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TeamProject.ViewModels;

namespace TeamProject.Models
{
	class Coin
	{
		private List<string> Index_Palameter = new List<string> { "1", "10", "50", "100", "500" };

		//Plus_Coin用の変数
		private int PlusOne = 1;
		

		public Coin()
		{
			
		}
	
		public List<Coin_Index> Coin_Index_create()
		{
			return new List<Coin_Index>
			{
				new Coin_Index {CoinType = Index_Palameter[0],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[1],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[2],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[3],CoinCount = "0" },
				new Coin_Index {CoinType = Index_Palameter[4],CoinCount = "0" },
			};
		}
		
		public bool Coin_Index_Judgement(int Judege_Number)
		{
			for(int count = 0;count < Index_Palameter.Count;count++)
			{
				if(Judege_Number == int.Parse(Index_Palameter[count]))
				{
					return true;
				}
			}
			return false;		
		}

		public string Return_Plus_Coin(string Coin_Index_Count)
		{
			//１を加算して文字列に変換して返す。
			return (Convert.ToInt32(Coin_Index_Count)+PlusOne).ToString();		
		}
		

			
	}
}
