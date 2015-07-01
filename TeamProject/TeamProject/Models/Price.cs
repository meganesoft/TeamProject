using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.ViewModels;
using System.Windows;

namespace TeamProject.Models
{
	class Price
	{
		//提示用の値の初期値を保持する変数
		private int Price_Original;		
		//ゲーム内で使う提示用の値段
		private int Price_Total;
		//読込んできた値段を司る変数
		protected int Coin_Price_Total;
		
		

		//値段の初期値(コンストラクタ)
		public Price(int Setting_Price)
		{
			this.Price_Original = Setting_Price;
			Price_Total = Price_Original;		
		}

		public void Add_Price(int Add_Coin)
		{
			this.Coin_Price_Total += Add_Coin;
		}

		public void Judge_Price()
		{
			if(Price_Total > Coin_Price_Total)
			{
				//足りない金額を出す
				int Difference = Price_Total - Coin_Price_Total;
				System.Windows.MessageBox.Show(Difference.ToString() + "円足りません");
			}
			else if(Price_Total < Coin_Price_Total)
			{
				//お釣はいくらか出す
				int Difference = Coin_Price_Total - Price_Total;
				System.Windows.MessageBox.Show("お釣は" + Difference.ToString() + "円です");
			}
			else
			{
				//丁度払えました
				System.Windows.MessageBox.Show("丁度になります");
			}
		}

		//提示用の値の初期値の呼び出し
		public string get_Price_Original()
		{
			return Price_Original.ToString();
		}

		//提示用値の呼び出し
		public string get_Price_Total()
		{
			return this.Price_Total.ToString();
		}

		//新しくゲームを始める時用の初期値書き換え
		public void ReStart_Insert_Price(int Setting_Price)
		{
			this.Price_Original = Setting_Price;
			this.Price_Total = this.Price_Original;
			this.Coin_Price_Total = 0;
		}

		//提示された値段から金額分を引く
		public void Coin_Use(int Price_Total,int Coin_Price)
		{		
			this.Price_Total =  Price_Total - Coin_Price;
		}
	
			
			
		public int Kill_Price(int price_total,int coin_price)
		{
			price_total -= coin_price;
			if (this.Price_Total < 0)
			{
				return Kill_Price(price_total, coin_price);
			}
			else
			{
				return price_total;
			}
		}
		
	}
}
