   M S B A M L   `   `   `  ����G  CMediaLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MediaLibrary.ViewMediaLibrary.View  5      I EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure 5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      (    "MediaLibrary.View.MediaLibraryMain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MediaLibrary.View     5      Oinfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      
�������  � 	Resources  5       �� MergedDictionaries �� Source �� 
TargetType   DefaultMenuItem �� BasedOn �� Property �� Value  DefaultMenu.  (Infrastructure.BoolToVisibilityConverter  BoolToVisibilityConverter5  /Infrastructure.BoolReverseToVisibilityConverter $  BoolReverseToVisibilityConverter2  ,Infrastructure.BoolReverseToEnabledConverter ! BoolReverseToEnabledConverter�� 5   
    5      �� 5      $P Jpack://application:,,,/Util.Controls;component/Style/Themes/Separator.xaml?�6%   �� 5      $K Epack://application:,,,/Util.Controls;component/Style/Themes/Menu.xaml?�6%   %a  'm�       7   'o� y     7  &	 �     &	     &	     �� 5      " m�6   8   .�5      ��  � ��
 �����5      �� 5       � ��
 �   �6?   5      �� 5      " o�6   8   .�5      ��  � ��
 �����6?   �� 5       � ��
 �   �6?   5        5      6[     5      6i     5      6c   5      .��5!      �  � RowDefinitions 5"   
   �� 5#      $��70 �6   6*   �� 5$      $��* �6   6)   .+�5&   
   � $��0��6   .+�5'      #   MediaLibrary.View.ToolMenuBar  5(      � 5)   
   $��2��6   .+�5*      �� ��6   �� *FileItemSelected.Index+5+      � 5,   
   $��1��6   .+�5-      )   #MediaLibrary.View.MediaLibraryThumb  y�6&   �� *	IsThumb+ �� 	Converter# [ 6|   (   "MediaLibrary.View.MediaLibraryList  5.      y�6%   �� *	IsThumb+# [ 6�   	 � ContextMenu	 5/      �� 50      .@�51      m� $��打开��6   ���#404040
 m� Icon$	
 ��6@   y�6P   �� *IsItemSelected+# [  m� Command 6�   �� *ViewDetailCommand+ m� CommandParameter 6�   �� *FileItemSelected.Index+52      m� 53      $��下载��6   ���#404040$	
 ��6@   y�6P   �� *IsItemSelected+# [ 54      m� 55      $��	移动到��6   ���#404040$	
 ��6A   y�6Q   �� *IsItemSelected+# [  6�   �� *MoveCommand+ 6�   �� *FileItemSelected.Index+56      m� 57      $��删除��6   ���#404040$	
 ��6@   y�6P   �� *IsItemSelected+# [ 58      m� 59      $��上传��6   ���#404040$	
 ��6@   y�6P   �� *IsItemSelected+# [ 5:      m� 5;      $��新建文件夹��6   ���#404040$	
 ��6C   y�6S   �� *IsItemSelected+# [ 5<      �� 5=      
���� �  HorizontalSeparatorStyle#��[ 69   y�6k   �� *IsItemSelected+# [ m� 5>      $��查看��6   $	
 ��6,   y�6<   �� *IsItemSelected+# [ .@�5?      m� $	
 ��6#   $��	缩略图��64   ���#404040$
 true��6�    6V   �� *ViewModeChangedCommand+{�6�   �� *	IsThumb+# [ m� 5@      $	
 ��6#   $��详细信息��63   ���#404040$ false��6�    6V   �� *ViewModeChangedCommand+{�6�   �� *	IsThumb+5A      5B      m� 5C      $��刷新��6   ���#404040$	
 ��6@    6P   �� *RefreshCommand+y�6s   �� *IsItemSelected+# [ 5D      5E      5I      5K      5L      