   M S B A M L   `   `   `  ����H  DUtil.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Util.Controls;assembly=Util.ControlsUtil.Controls  5      I EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY=clr-namespace:Infrastructure.Business;assembly=InfrastructureInfrastructure.Business 5      G4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure 5      G CMediaLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MediaLibrary.ViewMediaLibrary.View 5	      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5
      T PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      #   MediaLibrary.View.ToolMenuBar   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Bxly2clr-namespace:Util.Controls;assembly=Util.Controls     5      Rbusiness=clr-namespace:Infrastructure.Business;assembly=Infrastructure     5      Oinfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure     5      1localclr-namespace:MediaLibrary.View     5	      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5
      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � 	Resources  5       �� MergedDictionaries �� Source �� 
TargetType   DefaultMenuItem �� BasedOn  DefaultMenu  buttontemplate)  #Infrastructure.BoolReverseConverter  booleanreverse�� 5   
    5      �� 5      $K Epack://application:,,,/Util.Controls;component/Style/Themes/Menu.xaml?�6%   %�   'm�       7   'o� "     7  &	 D     &	 x     �� 5      " m�6   8   6`   �� 5      " o�6   8   6X   �� 5      .R�5      �� #��z��6   5        5      6K   5      .��5      � ���#404040 � ColumnDefinitions 5   
   �� 5       $	��80* �6   6-   �� 5!      $
��Auto �6   6.    � RowDefinitions 5#   
   �� 5$      $��30 �6   �� 5%      $��* �6   .+�5'   
   ]� $��4q�6   
�������$��0��62   .+�5(      �� $��0q�6   $
��Left=�6'   $	��300��5)      
������ $��0q�69   $��Hidden=�5*      $��Hidden=�5+      ��5(   =   �� *FolderItemList+ �� Mode$ TwoWay=���5,      �� 5-      .R�5.      � $��0,0,0,0q�6$    � Orientation$ 
Horizontal=�65   5/      50      ��52      �� 53      .R�54      � .+�55      �� $
��Wrap=�6(   �� 56   "   	 �� Command	 6,   �� *(&DataContext.BreadCrumbItemClickCommand+
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType$ UserControlL� �� CommandParameter 6�   �� *Index+.�6�   .�57   &   �� �6*   �� *
FileName+58   #   59      �� 5:      $V��Ppack://application:,,,/Infrastructure;component/Resources/Images/arrow_right.png��6%   $
��None=�6   5;      5<      5?      5@      � 5A   
   $��RightToLeft=�6   $��1��60   $��	10,0,10,2q�6@   $��0��6S   
������ $��Center=�6y   .+�5E      �� $��50��6   ��6%   Z� .+�5G      "   Util.Controls.BulletCheckBox     Text$ 列表��6%      CheckedText$ 大图��6/    d� 	IsChecked 6@   �� *	IsThumb+5J      5L      �� 5N   
   $��1��6   $��2��6$    �� Orientation$ 
Horizontal=�68   $
��Left=�6Q   .+�5O         Util.Controls.FButton     FIcon$	 ��6   $��5,0,0,0q�6+      CornerRadius$ 0��6<      AllowsAnimation . 
������ .��6}   新建文件夹6�     5P      $	 ��6   $ 0��6+   
������ .��6U   删除6Y     5Q      $	 ��6   $ 0��6+   
������ .��6U   上传6Y     5R      $	 ��6   $ 0��6+   
������ .��6V   下载6Z     5S      $ 0��6    . 
������ $	 ��6\   .��6m   	移动到6r     5T      $ 0��6    . 
������ $	 ��6\   .��6m   更多6q   5U      5V      5X      