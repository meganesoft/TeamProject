using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace TeamProject.Views.Behaviors
{
	class MessageNotifyBehavior :Behavior<Button>
	{
		public static readonly DependencyProperty MessageProperety
			= DependencyProperty.Register("Message", typeof(string), typeof(MessageNotifyBehavior), null);
	}
}
