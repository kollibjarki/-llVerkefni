   M S B A M L   `   `   `  ����  	SampleApp    SampleApp.SearchControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .��5      � $	��Top=�6	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Display=�6!    � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6    � RowDefinitions 5	      �� 5
      �� 5      $
��Auto �6   .+�5      �� -   5         ��Name$ 	searchBox��5      �� 5      -   5         ��Name$ 	searchBtn��5      $��1��6    $��Search��60    �� 	IsDefault . $��2,0,0,0q�6n   $	��5,0q�6   �� 5      -   5         ��Name$ statusLabel��5   1   $��2��6   $��1��6$   $��Center=�6F   $��Italic$�6a   $
��Wrap=�6t   9� 5      -   5         9�Name$ resultsArea��5      $��2��6$   $��1��68   $y�	Collapsed=�6E   ��5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��Search results��6   �� 5      $��10,0,0,0q�6   �� 5      -   5        .�5   6   Clear results6E   5      5      5      � 5      	 � AllowsTransparency	 . ��6&   �� 
 �� ElementName$
 resultsArea�� �� Path$ 
IsExpanded� � PlacementTarget 6b   �� $
 resultsArea��.��5      �� #��Z��6   #��Z�6@   $��1,0,1,1q�6x   $��	0,0,10,10q�5   K   ��6   �� $
 resultsArea��$ ActualWidth� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5    
   �� $	��200��6   $
��Auto=�6'   .��5!      �� -   5         ��Name$ searchResults��5!      $��5q�60   ��5"      �� 5#      .R�5$      � $��2q�6    5%      �� 5&      $��30 �6'   �� 5'      .+�5)      �� $��Center=�6   $��Center=�6<   ��6W   �� *Index+�� 5*      -   5        $��1��5*      $
��Left=�6+   ��5+      �� 5,       �� 
TargetType" ��6(   .R�5-      ��  ��Name$ border��6!   $��1q�6H   
������ ��61   Z� ._�5.      �� 5/       �� Triggers 50      P� 51       P� Property �@J�IsMouseOver P� Value . . �52      ��  �� 
TargetName$ border��6<    �� Value# Z��6P    �� Property � ��53      P� 54       � �� . . �55      �� $ border��6;   # Z�6O    � ��56      58      .��5:      �� $
��Wrap=�6=   ��6    �� *DisplayName+6=   5;      5<      5=      5?      5@      5A   	   5B      5C      5D      