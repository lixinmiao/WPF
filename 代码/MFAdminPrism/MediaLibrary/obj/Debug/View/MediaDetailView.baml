   M S B A M L   `   `   `  ����G  CMediaLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MediaLibrary.ViewMediaLibrary.View  5      H DUtil.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:Util.Controls;assembly=Util.ControlsUtil.Controls 5      I EInfrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Infrastructure;assembly=InfrastructureInfrastructure 5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5	      '    !MediaLibrary.View.MediaDetailView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MediaLibrary.View     5      Bxly2clr-namespace:Util.Controls;assembly=Util.Controls     5      Oinfrastructure4clr-namespace:Infrastructure;assembly=Infrastructure     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5	        � 	Resources  5      5  /Infrastructure.BoolReverseToVisibilityConverter $   boolReverseToVisibilityConverter.  (Infrastructure.BoolToVisibilityConverter  boolToVisibilityConverter �� 
TargetType �� Property �� Value��%9  &	        &	      '�� &       5   
   6:     5   
   63   �� 5   
   " ��6   .�5      ��  � ��$ 80��6&   �� 5       � ��$ 25��6'   �� 5       �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$ Right=�64   6D   �� 5       � ��$	 Top=�62   5      5      .��5      ��  �� CornerRadius$ 5��6   $��1q�6   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    6.   �� 5      $	��60* �6    6/   �� 5      $	��20* �6    6/   .+�5      �� $��0��6   y�6&   �� *
IsEditMode+ �� 	Converter# [  .+�5        Util.Controls.FButton     FIcon$	 ��6   $��0,0,0,0q�6/      CornerRadius$ 0��6@   $��40��6Q   $��25��6\   	 � Cursor$
	 Hand��6h   6x     5       $	 ��6   $ 0��6/   
   AllowsAnimation
 . $��40��6W   $��25��6b   $
	 Hand��6�   ��6n   �� *DataContext.EditCommand+ �� RelativeSource ��  �� AncestorType$ UserControlL�5!      5"      �� 5#      $��0��6   y�6&   �� *
IsEditMode+# [ .+�5$        $	 ��6   $��5,0,0,0q�6/   $ 0��6@   $��40��6Q   $��25��6\   
��� � �$
	 Hand��6  ��6{   �� *DataContext.SaveCommand+ �� $ UserControlL���6�   �� *Text+ �� ElementName$ eidttext��6'    5%      $	 ��6   $ 0��6/   
 . $��40��6W   $��25��6b   
���  ��$
	 Hand��6�   ��6   �� *DataContext.CancelCommand+ �� $ UserControlL�6�   5&      �� 5'      $��1��66   $
��None=�6C   ��6   �� *FileItem.Image+6T   �� 5(      $��2��6G    �� TextAlignment$ Center=�6T   
���   �$��Center=�6�   ��6   �� *FileItem.FileName+ �� Mode$ OneWay=�y�6~   �� *
IsEditMode+# [  6�   �� 5)      -   5         ��Name$ eidttext��5)   �   $��2��6F   $��Center=�6S   
���   �$��Center=�6�   ��6   �� *FileItem.FileName+$ OneWay=�y�6�   �� *
IsEditMode+# [ 6  5*      5+      .  (System.Windows.Interactivity.Interaction   Triggers 5,      /  )System.Windows.Interactivity.EventTrigger  5-   
      	EventName$ Unloaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5.      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *UnloadedCommand+5/        50   
   $ Loaded��6   . 51         6$   �� *LoadedCommand+52      55      