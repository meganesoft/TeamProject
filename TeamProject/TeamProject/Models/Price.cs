using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
	class Price
	{
		//値段の初期値(コンストラクタ)
		public Price(int x)
		{
			this.Price_Original = x;
			Price_Bind = x;
		}

		private int Price_Original;

		//ゲーム内で使う提示用の値段
		private int Price_Total;

		public int Price_Bind { get; set; }

		public int get_priceOL()
		{
			return Price_Original;
		}

		public void Insert_Price(int price)
		{
			this.Price_Original = price;
		}

		//提示された値段から金額分を引く
		public void Coin_Use(int Price_Total,int Coin_Price)
		{		
			this.Price_Total =  Price_Total - Coin_Price;
		}
	
		//加減算の結果の判定
		public int Coin_Judge(int Price_Total)
		{		
			if (Price_Total > 0) {
				return 0;
			}
			if (Price_Total < 0)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}	
	
		
	
		public int Price_Kill(int price_total,int coin_price)
		{
			price_total -= coin_price;
			if (this.Price_Total < 0)
			{
				return Price_Kill(price_total, coin_price);
			}
			else
			{
				return price_total;
			}
		}

		public void greed_Price()
		{

		}
	}
}
