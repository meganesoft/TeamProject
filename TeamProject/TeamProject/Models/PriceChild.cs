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

		public void Change_Coin_Price_Total(int Coin)
		{
			base.Coin_Price_Total += Coin;
		}

	}
}
