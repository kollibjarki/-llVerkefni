   M S B A M L   `   `   `  ����D  @SampleApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SampleApp	SampleApp  5   	   E AMapControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:MapControl;assembly=MapControl
MapControl 5   	       SampleApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )localclr-namespace:SampleApp     5   	   <map,clr-namespace:MapControl;assembly=MapControl     5   	     � Title$	  Map��5   	   $	��420��6   $	��370��6"    � WindowStartupLocation$ CenterScreen=�6.    � WindowStyle$ 
ToolWindow=�6S   .��5      � #��Z�6    � RowDefinitions 5      �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5         SampleApp.SearchControl     SampleApp.SearchControl   Navigate$ OnSearchControlNavigate��5      $��0��5      $��
10,10,10,0q�6'   $	��Top=�6;      
SearchArea 5   =   ��  �� ElementName$ 
tileCanvas�� �� Path$ Viewport��� 5      -   5         ��Name$ errorBar��5      $��1��6"   
�������
���  ��	 �� Padding$		 2,1q�6W   $y�	Collapsed=�6e   �� 5      $��2��6   #��Z�6   $��1q�6R   #��Z�6f   ._�5      � }�. .+�5        MapControl.MapCanvas  -   5        
  Name$
 
tileCanvas��5      .+�5      � -   5         �Name$ searchMarker��5      $��45��6'   $��30��63   $��-15,-45,0,0q�6>   $y�Hidden=�6S      Latitude 5      �� *
Latitude+   	Longitude 6=   �� *	Longitude+.+�5      F� ���	#E4949494���#C222$��2��63    �� Stretch$ Uniform=�6G    J� SnapsToDevicePixels . �����@KL ��[ � 	= ��[ ���- @T� р� ��[ �@B ��[ �    ��[ @KL �    @B �        �@KL     Ҁ�[     ��[ р�[ @KL Ҁ�[ ��[ @KL ��[ 	 � ToolTip 5   [   �� *DisplayName+�� 5      ���#FFF$��Consolas)�6*   $��18(�6@   $��0,0,0,15q�6N   $��Center=�6`   $��Center=�6}    J� IsHitTestVisible .  ��5   1   �� *Index+ J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 3Q�6#      Color$ #C222��62      ShadowDepth$ 2Q�6@   5      5       5!      � 5"   
   -   5        $ zoomGrid��5"       J� RenderTransformOrigin$ 0.5, 0.5&�6!    . $y�Hidden=�6]    � 	Resources 5#       
  zoomIn �� 
TargetName �� TargetProperty W� From	 W� To g� Duration  zoomOut��%�  &	        &	 F    �� 5$      -   5        .��5%      W� $ zoomGrid��6    $/ )(RenderTransform).(ScaleTransform.ScaleX)�6A   $	 1.0X�5&       $	 2.0X�6+   $ 
00:00:00.3D�64   W� 5'      $ zoomGrid��6    $/ )(RenderTransform).(ScaleTransform.ScaleY)�6A   $	 1.0X�5(       $	 2.0X�6+   $ 
00:00:00.3D�64   5)      �� 5*      -   5        .��5+      W� $ zoomGrid��6    $/ )(RenderTransform).(ScaleTransform.ScaleX)�6A   $	 1.0X�5,       $	 0.5X�6+   $ 
00:00:00.3D�64   W� 5-      $ zoomGrid��6    $/ )(RenderTransform).(ScaleTransform.ScaleY)�6A   $	 1.0X�5.       $	 0.5X�6+   $ 
00:00:00.3D�64   5/      50      .+�51      �� -   5         ��Name$ 	zoomImage��51      �� 52      -   5         ��Name$ zoomRectangle��52      
���  ��6-   53      "   SampleApp.NavigationControls  54   
   
   Map 6#   �� $ 
tileCanvas���� 55   
   $	��5,2q�6   $��Right=�6!   $��Bottom=�6=   $��10(�6X   �� 56      $	�© ��6    �� 57      -	   5        $#��http://www.openstreetmap.org/?�57      .�58   C   OpenStreetMap6R    �� 59      $�contributors, ��6    �� 5:      -
   5        $4��.http://creativecommons.org/licenses/by-sa/2.0/?�5:      .�5;   C   
CC-BY-SA6M   5<      5=   	   5>      �� 5?      $��3��6   .@�5@      � -   5          �Name$  progress��5@      $	��100��6&   $��15��62   $y�Hidden=�6>   �� 5A      -   5        $ label��5A      $y�Hidden=�6!   5B      5C      5D      