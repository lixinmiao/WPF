   M S B A M L   `   `   `  ����I  EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure  5   	   G CMFAdminPrism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MFAdminPrismMFAdminPrism 5   	   T PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	      MFAdminPrism.Shell   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ` \Microsoft.Practices.Prism, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35)prismhttp://www.codeplex.com/prism  5   	   Iinfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   &localclr-namespace:MFAdminPrism  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	     � Title$  
MainWindow��5   	   $	��768��6   $
��1024��6)    � WindowState$ 	Maximized=�66    � 	Resources 5       �� MergedDictionaries �� Source   backgroundimage �� ImageSource  AppThemeMenuIcon �� Mode  AccentMenuIcon  AppThemeMenuItemStyle  MetroMenuItem �� BasedOn �� 
TargetType	 �� Property
 �� Value  AccentColorMenuItemStyle�� 5   
    5      �� 5      $K Epack://application:,,,/MahApps.Metro;component/Styles/FlatSlider.xaml?�6%   %b  &	        &	 i    &	    &	 �    7  7  &	 P    7  7  �� 5      $U Opack://application:,,,/Infrastructure;component/Resources/Images/background.png��61   A� 5      $��16��5      $��16��5      $��1��5      ��5      �� *
ColorBrush+$ OneWay=���5      �� *BorderColorBrush+$ OneWay=�5      A� 5      $��16��5      $��16��5      ��5      �� *
ColorBrush+$ OneWay=�5      �� 5      8   " m�5!      .�5"      �� 	 �@m�Command
 6,   �� *ChangeAccentCommand+�� 5#      	 � ��
 6+   �� *Name+$ OneWay=��� 5$      	 �@m�Icon8
  6)   5%      �� 5'      8   " m�5)      .�5*      �� 	 �@m�Command
 6,   �� *ChangeAccentCommand+�� 5+      	 � ��
 6+   �� *Name+$ OneWay=��� 5,      	 �@m�Icon8
  6)   5-      50      .��54      � #��[  6    � RowDefinitions 55   
   �� 56      $	��100 �6   �� 57      $��* �6   �� 58      $��50 �6   .+�5:   
   � $��0��6   .+�5;        MFAdminPrism.MainMenu  6   5<      �� 5=   
   $��1��6       Infrastructure.RegionNames   
MainRegion5  /Microsoft.Practices.Prism.Regions.RegionManager   
RegionName# Z 6&   5?      �� 5@   
   $��2��6   
�������5B      5C      5D      