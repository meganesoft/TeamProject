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

		//Coinクラス
		Coin Coin_Op = new Coin();

		public Coin_ViewModel()
		{
			this.IndexData = Coin_Op.Coin_Index_create();

		}
	}
}
