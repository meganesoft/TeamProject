using System;
using System.Windows;
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
		private List<string> Index_Palameter = new List<string> { "1", "10", "50", "100", "500","1000"};

		//Plus_Coin用の変数
		private int PlusOne = 1;

		//エラー用数値
		private int ErrorZero = 0;

		//一時金額格納
		private int Instant_Coin_Total;

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
				new Coin_Index {CoinType = Index_Palameter[5],CoinCount = "0" },
			};
		}
		
		//読み込んだ数値と判定用のリスト照らし合わせて、どの硬化項目にカウントを追加するか判断する
		public void Coin_Index_Judgement(List<Coin_Index> Coin_Index_List,string Judege_Number)
		{
			//読み込んできた値と一致するCoin.Typeを含むリスト項目を抽出する
			Coin_Index Coin_Found_Index = Coin_Index_List.Find(x => x.CoinType == Judege_Number);
			Coin_Found_Index.CoinCount = Return_Plus_Coin(Coin_Found_Index.CoinCount);	
						
		}

		public string Return_Plus_Coin(string Coin_Index_Count)
		{
			//１を加算して文字列に変換して返す。
			return (Convert.ToInt32(Coin_Index_Count)+PlusOne).ToString();		
		}

		public void Coin_Index_Clear(List<Coin_Index> Coin_Index_List)
		{
			Coin_Index_List.ForEach(x =>
			{
				x.CoinCount = "0";
				x.Clear_Coin_Total();
			});
		}
		
		public void Convergence_Coin_Child( List<Coin_Index> Coin_Index_List)
		{
			Coin_Index_List.ForEach(x =>
			{
			  Instant_Coin_Total += x.Coin_Total_Child();
			});
		}

		public int get_Coin_Instant()
		{
			return Instant_Coin_Total;
		}
		
			
	}
}
