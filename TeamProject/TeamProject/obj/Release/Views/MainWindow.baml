   M S B A M L   `   `   `  ���� F  BTeamProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TeamProjectTeamProject  5clr-namespace:TeamProject.ViewsTeamProject.Views  7 clr-namespace:TeamProject.ModelsTeamProject.Models  ?$clr-namespace:TeamProject.ViewModelsTeamProject.ViewModels  "    TeamProject.Views.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:TeamProject     1viewsclr-namespace:TeamProject.Views     3models clr-namespace:TeamProject.Models     ;
viewmodels$clr-namespace:TeamProject.ViewModels     c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  L HLivet, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b0b1d3f711ef38cb.l&http://schemas.livet-mvvm.net/2011/wpf  -     � Title$  
MainWindow��$	��350��$	��525�� � 	Resources    PriceAnimation �� 
TargetName �� TargetProperty	 W� To g� Duration��%M   &	        �� .��W� $ Price��$ (Canvas.Left)�$	 300X�$ 0:0:5D�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Closed��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 �� *
ShutDown+.��� 
 � ColumnDefinitions
 �� $	��34* � � RowDefinitions �� $
��200* ��� $
��100* �.+��� -    ��Name$ mycanvas��$��0��$��Stretch=�$��Stretch=�
�������$��2��.+���  �� Left$	 120��
�������
 �� Top$ 10��$	��136��$	��280��$��8q� �� CornerRadius$ 8��
���Gc��._��� -    ��Name$ label��$ 10��
���2͚�$ 10��$	��130��$	��270��
�������$��80(�$��Center=�����  �� Path$ Price_Q_Bind��� -    ��Name$ button��$
��Read��$	 432��$	 172��$��75������  �� 
TargetType" ��.R��� 
����ح�$ 30�� �� Padding$ 10q�$��0,0,3,3q�
�������._��� $��読み込み��$��Center=�$��Center=�   $ Click��.   	 �� *	Command+�� -   $ button1��$��Button��$	 333��$	 172��$��76������ " ��.R��� 
����ح�$ 30��$ 10q�$��0,0,3,3q�
�������._��� $��精算��$��Center=�$��Center=�   $ Click��.   	 �� *
JudgeTotal+�� $��1������ *	IndexData+���� " ��.R��� $��1q�
���   �
��� ���._�� $��10q� K� IsItemsHost . ���� .R��� 
���iii�$��2q�._��� $��5q�$��50��   $ Click��.   	 �� *Index_Action+  $ MouseUp��. +  %Livet.Behaviors.LivetCallMethodAction     
MethodName$ Index_Count_Add��   MethodTarget �� �� $��10(���� *
CoinType+ �� $
�:円���� �� $��10(���� *	CoinCount+ �� $
�:枚��