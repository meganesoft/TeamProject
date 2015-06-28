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
		//数値判定用リスト
		private List<string> Index_Palameter = new List<string> { "1", "10", "50", "100", "500" };

		//Plus_Coin用の変数
		private int PlusOne = 1;

		//エラー用数値
		private int ErrorZero = 0;
		

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
		
		//読み込んだ数値と判定用のリスト照らし合わせて、どの硬化項目にカウントを追加するか判断する
		public void Coin_Index_Judgement(List<Coin_Index> Coin_Index_List,int Judege_Number)
		{
			for(int count = 0;count < Index_Palameter.Count;count++)
			{
				if(Judege_Number == int.Parse(Index_Palameter[count]))
				{
					//Coin_Index_List.Find(x => x.CoinCount)
					
				}
			}
			
		}

		public string Return_Plus_Coin(List<Coin_Index> Coin_Index_List,int Coin_Index_Count)
		{
			//１を加算して文字列に変換して返す。
			return (Convert.ToInt32(Coin_Index_Count)+PlusOne).ToString();		
		}
		
		
			
	}
}
