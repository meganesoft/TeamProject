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
		public int Price_Q_Bind { get; set; }
		
		

		//値段の初期値(コンストラクタ)
		public Price(int Setting_Price)
		{
			this.Price_Original = Setting_Price;
			Price_Total = Price_Original;		
		}

		//提示用の値の初期値の呼び出し
		public int get_Price_Original()
		{
			return Price_Original;
		}

		//提示用値の呼び出し
		public int get_Price_Total()
		{
			return this.Price_Total;
		}

		//新しくゲームを始める時用の初期値書き換え
		public void Insert_Price(int Setting_Price)
		{
			this.Price_Original = Setting_Price;
		}

		//提示された値段から金額分を引く
		public void Coin_Use(int Price_Total,int Coin_Price)
		{		
			this.Price_Total =  Price_Total - Coin_Price;
		}
	
		//加減算の結果の判定
		public int Coin_Judge(int Price_Total,int coin_price)
		{		
			if (Price_Total == 0) {
				Clear_Game();
				return 0;
			}else if (Price_Total < 0)
			{
				return Kill_Price(Price_Total, coin_price);
			}
			return 0;
			
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


		public void Clear_Game()
		{
			MessageBox.Show("ゲームクリア!");		
		}

		public void Greed_Price()
		{

		}
	}
}
