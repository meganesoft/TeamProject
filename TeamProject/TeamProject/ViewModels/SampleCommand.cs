using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeamProject.ViewModels
{
	public delegate void EventDelegare();

	/// <summary>
	/// ICCommandインターンを実装するコマンド
	/// </summary>

	class SampleCommand :ICommand
	{
		EventDelegare e_delegate;

		///<summary>
		/// 引数で実行したいメソッドを指定する
		/// </summary>
		/// <param name="ed"></param>

		public SampleCommand(EventDelegare ed)
		{	
			e_delegate = ed;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public event EventHandler CanExecuteChanged;

		///<summary>
		/// コンストラクタで渡されたメソッドを実行する
		///</summary>
		///<param name="parameter"></param>

		public void Execute(object parameter)
		{
			e_delegate();
		}
	}
}
