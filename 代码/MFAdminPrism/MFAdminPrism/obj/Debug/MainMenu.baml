   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      G CMFAdminPrism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MFAdminPrismMFAdminPrism 5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5         MFAdminPrism.MainMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9System&clr-namespace:System;assembly=mscorlib     5      ,localclr-namespace:MFAdminPrism     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5        � 	Resources  5         menuitemtemplate � 	Resources �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value N� EnterActions	 �� TargetProperty	
 t� To g� Duration N� ExitActions �� Orientation ��Name �� CornerRadius
 � Tag ��Name.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   Actions6  0System.Windows.Interactivity.InvokeCommandAction   Command �� RelativeSource �� AncestorType   CommandParameter �� Triggers �� Value �� Binding �� 
TargetName��%�  &	        �� 5   
    5      ���� 5      '��       " ��6   .�5      ��  � ��
 � ���64    5      P� 5       �@J�IsMouseOver . . �5      ��  �@�Cursor$
 Hand��67    5      �� 5   "   .��5   &   �� .��5   *   t� $	 Margin�6=   $
 0X�6`   $ 0:0:.2D�6g   t� 5   *   $	 BorderThickness�6=   $	
 1.5X�6i   $ 0:0:.15D�6r   5   '   5   #    5      �� 5   "   .��5   &   �� .��5   *   t� $	 Margin�6=   $
 4X�6`   $ 0:0:.2D�6g   t� 5    *   $	 BorderThickness�6=   $
 1X�6i   $ 0:0:.15D�6p   5!   '   5"   #   5$      5-      56      .R�58      �� -   5        $ Vertical=�58      $	��100��60   $��Center=�6=   $��Center=�6X   $��80��6u   .+�5:      �� $ border��6f   $��1q�6   $ 7��6-   $	��2,0q�6?    6L   �� *	IsChecked+._�5;      �� $��50��6<   ��6   �� *ItemImageSrc+6<   5=      �� 5@      $ itemname��6�   $	��4,0q�6P   $��14(�6]   $��Center=�6k   $	��Top=�6�   $��Segoe UI)�6�   ��6   �� *
ItemName+ 66   �� *	IsChecked+5M       5P        5Q      $ MouseLeftButtonDown��6%   . 5R         60   �� *" DataContext.MouseLeftDownCommand+ �� *FindAncestor+$ WindowL� 6�   �� *Index+5T      5W       5Z      �� 5[      $
 True��6<    6   �� *	IsChecked+.a�5\      �� $ border��6G    � ��
 ������� 5]      $ border��6D    � ��
 �  ���� 5^      $ itemname��6C    � ��
 �  ��5a      P� 5b       �@J�IsMouseOver . . �5c      �� $ itemname��6F    � ��
 � ���5d      5g      5h      .��5i      �� -   5         ��Name$ itemsControl��5i      
�������$	��0 1q�6c   #��[  6y   ��6+   �� *MenuItemList+��5j   
   �� 5k      .R�5l      �  � Orientation$ 
Horizontal=�6   $��Center=�66   $
��Left=�6Q   5m      5p      5r      