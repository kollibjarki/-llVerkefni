   M S B A M L   `   `   `  ����  	SampleApp"    SampleApp.NavigationControls   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          >�Name$
  this��5   5    � 	Resources 5         BackgroundBrush �� Color  HighlightedBrush  NormalBrush  
FlatButton �� 
TargetType �� Property �� Value �� ElementName �� Path �� 
TargetType	 �� Padding
 J� SnapsToDevicePixels � DataContext �� Stretch �� Triggers P� Property P� Value  EmptyTemplate  SliderThumbTemplate F�Name �� 
StartPoint �� EndPoint � Offset � Color �� 
TargetName  
ZoomSlider � ColumnDefinitions m� Fill m� 	Placement ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton��%T	  &	        &	      &	 >     &	 ]     7  7  7  7  &	     &	 H    7  7  &	 3    7  7  7  7  �� 5      $ #C222��6.   �� 5      $ #FFFF��6/   �� 5      $ #7FFF��6*   �� 5	      " ��6   .�5
      ��  � ��
 ���� 6&   �� 5       � �� 6(   �� $
 this��$	 Map��� 5       � |� .  6$   �� 5       � ��8   6%   �� 5       � ��$ 3q�6"   �� 5       � �� 5   
   �� 5      " ��6   .R�5      �� #��z��6   $��1q�6A   
������ #	 z��6n   
 . ._�5      F� # z��6   #��z��6N   #��z��6r   $
 Fill=�6�   ��6=   �� 6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� 8   � ��60   �� 5      8   � ��6/   5      P� 5       � �� . . �5      �� 8   � ��60   5      5      5    	   5!      �� 5#      " ��6,   .R�5$      �� 
������ 6   5%      �� 5'      " n�62   .R�5(      F� $
 path��6   $��9��6   4���� 	=     �@B     �    @B �@B �� � 	= �� 	8��  $
 Fill=�6k   ��5)   
   �� 5*      $	 0,0&�6    $	 1,0&�61   .��5+      � $
 0.05Q�6   $
 #666��6)   � 5,      $
 0.25Q�6   $ #404040��6)   � 5-      $
 0.95Q�6   $ 	#FF222222��6)   5.      50   	    51      P� 52   
    �@J�IsMouseOver . . �53      �� $
 path��6%   8   � ��67   54      56      �� 58      " ��6   .�59      ��  � ��8   6%   �� 5:       �@��Orientation$ Vertical=�6&   �� 5;       �@��TickPlacement$ TopLeft=�6(   �� 5<       � �� 5=   
   �� 5>      " ��6   .R�5?      �  5@      �� 5A      $
��Auto �6#   �� 5B      .+�5D      m� $��0��6   $��5��6(   # z��62   $
 Left=�6V   $
��Left=�6g   F� 5E      $��1��6   $��0,4,4,4q�6%   +����    @B �        �@KL     �@B @B 	$
 Fill=�6Q   #��z��6`   ��5F      �� 5G      $	 0,1&�6(   $	 0,0&�69   .��5H      � $ 0Q�6#   $ #3000��6.   � 5I      $	 0.8Q�6#   $ 	#407F7F7F��60   5J      5L      ]� 5M      $ 
PART_Track��6&   $��1��6    5N      �� 5O      $��Slider.DecreaseLarge��6!   8�� 6@    5Q      n� 5R      8�� 6    5T      �� 5U      $��Slider.IncreaseLarge��6!   8�� 6@   5W      5X      5Y      5[   	   5\      5]      .��5^      �� $	��Top=�6   $
��Left=�6'    �� Orientation$ 
Horizontal=�6B   .+�5`      � #��[  6   $
��Left=�69   $��Bottom=�6T   .+�5a      �� .+�5b   
   �� $��5q�6   $��1q�6   #��[ 6(   $��IncreaseZoom��6L   $��M0,1 L 2,1 M1,0 L 1,2��6c   $��15��6�   $��15��6�   �� 5c   
   $	��5,0q�6   $��20��6   $	��150��6)    � Minimum$ 0Q�66    � Maximum$ 18Q�6B   #��[ 6O     � Value  5d      �� $
 this��$ Map.Zoom��� 5e   
   $��5q�6   $��1q�6   #��[ 6(   $��DecreaseZoom��6L   $��
M0,0 L 1,0��6c   $��15��6x   $��15��6�   5f   	   5g      � 5i      #��[  6   $
��Left=�69   $	��Top=�6T   .+�5j      � $��30��6   $��30��6   $��5q�6$   ! � LayoutTransform! 5k   
   �� 5l      " �� Angle$" 45Q�6    5n   
   �� 5o      �� 5p      # � RowDefinitions# 5r   
   �� 5s      �� 5t      .+�5v   
   �� $��2��6   $��2��6(   ���#7FFF69   �� 5w   
   $��0��6   $��0��6!   #��[ 6.   $��MoveUp��6R   $��M0,0 L1,0 0,1 Z��6c   $ � ToolTip$$ Pan up��6}   �� 5x   
   $��1��6   $��0��6!   #��[ 6.   $��	MoveRight��6R   $��M0,0 L1,0 1,1 Z��6f   $$ 	Pan right��6�   �� 5y   
   $��0��6   $��1��6!   #��[ 6.   $��MoveLeft��6R   $��M0,0 L0,1 1,1 Z��6e   $$ Pan left��6   �� 5z   
   $��1��6   $��1��6!   #��[ 6.   $��MoveDown��6R   $��M0,1 L1,1 1,0 Z��6e   $$ Pan down��6   5{   	   5|      5}      5~      