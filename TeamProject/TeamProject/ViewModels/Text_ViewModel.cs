using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.ViewModels
{
	class Text_ViewModel:ViewModelBase
	{
		private string _VMText;

		public string VMText
		{ 
			set { this._VMText = value; }
			get { return this._VMText; }
		}
	
		
		public string get_Change_Text()
		{
			return this.VMText;
		}

		public int get_Change_Text_Int()
		{
			return int.Parse(this.VMText);
		}

		

	}
}
