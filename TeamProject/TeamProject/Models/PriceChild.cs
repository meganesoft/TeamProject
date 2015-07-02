using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
	class PriceChild:Price
	{
		private static readonly int Setting_Price;

		public PriceChild():base(Setting_Price)
		{
		}

		public void Add_Coin_Price_Child(int Coin)
		{
			base.Coin_Price_Total += Coin;
		}

		public int get_Coint_total_Child()
		{
			return get_Coin_Total();
		}

		public void Clear_Coin_Total()
		{
			base.Coin_Price_Total = 0;
		}

	}
}
