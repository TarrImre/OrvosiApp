   M S B A M L   `   `   `  ����H  DWebApi_Assist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_AssistWebApi_Assist  5   	       WebApi_Assist.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WebApi_Assist     5   	     � Title$  Asszisztens pult��5   	   $	��500��6"   $
��1050��6/    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   ���#D0E1D9 � AllowsTransparency$
 True��5   	    � Icon$+ %https://toxy.hu/csharpimages/ikon.ico��5   	    � DataContext 5      �� 5   
    �� RelativeSource 6   �� *Self+.��5      �� 
������ ���#044123$��2q�6<   ._�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� -   5        	 ��Name$	 	MovePanel��5   K   $��0��6   $��0��6&   ���#044123.+�5      �� $
��Wrap=�6   $��Asszisztens pult��60   $��15,5,0,0q�6H   $
��Bold"�6Z   ���#03b4846l   5      �� 5      -   5        $��0��5      $��0��6=   
������ 
������ $��0,0,5,0q�6�   $��20��6�   $��20��6�   $��Right=�6�   .��5      �� $��/z_closelight.png��6   65   5      �� 5       -   5        $��0��5       $��0��6=   
������ 
������ $��0,0,25,0q�6�   $��20��6�   $��20��6�   $��Right=�6�   .��5!      �� $��/z_talcalight.png��6   65   5"      �� 5#      -   5        $��0��5#      $��0��6>   
������ 
������ $��0,0,50,0q�6�   $��20��6�   $��20��6�   $��Right=�6�   .��5$      �� $��/z_logoutv2.png��6   63   5%      &   System.Windows.Controls.DataGrid  5'      -   5        
  Name$
 DataGrid��5(         DataGridRowStyle1   RowStyle# �   5'        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6F   $��1��6�      AutoGenerateColumns$ False��5*      $   HorizontalScrollBarVisibility$ Disabled=�5+         CanUserResizeColumns$ False��5,      
������ 
������    VerticalGridLinesBrush
 ����    HorizontalGridLinesBrush
 ����    RowHeaderWidth$ 0Q�51         CanUserAddRows$ false��52      ��5)      �� *PERSON+ �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 53      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value �� Color��%  '        (�� L     57   &   * SystemColors.HighlightBrushKey+)(�� q     58   &   *SystemColors.ControlBrushKey+)(�� �     59   &   *$"SystemColors.HighlightTextBrushKey+)(�� �     5:   &   *" SystemColors.ControlTextBrushKey+)'�� �     �� 54      "  6   .�55      ��  � ��$ Center=�6>   56      �� 57      $ Transparent��6X   �� 58      $ Transparent��6V   �� 59      $ Black��6\   �� 5:      $ Black��6Z   �� 5;      " ��6   .�5<      ��  � ��
 ���� 67   5=      5>         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 35 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5A      $ Vezetéknév��6)   $ 85 6[    6=   �� *	FirstName+6[     5B      $ Keresztnév��6)   $ 85 6Z    6=   �� *
LastName+6Z     5C      $ Születési idő��6)   $	 140 6`    6@   �� *DateOfBirth+6`     5D      $ Város��6)   $	 100 6Q    68   �� *City+6Q     5E      $ Utca-házszám��6)   $ 90 6_    6?   �� *StreetHouse+6_     5F      $	 TAJ��6)   $ 80 6R    66   �� *	Cardnum+6R     5G      $ 	Probléma��6)   $	 140 6W    6;   �� *	Problem+6W     5H      $ 
Diagnózis��6)   $	 140 6Y    6<   �� *
Diagnose+6Y     5I      $ Felvéve��6)   $	 140 6X    6:   �� *	AddedTime+6X   5K      �� 5M      -   5        $	 BottomBarHided��5M   &   $��2��6   .+�5N      �� -   5        $��Betegfelvétel��5N      $��	0,10,20,0q�61   $��Right=�6D   $	��100��6`     LightGreenButton#��[ 6l   6�   �� 5O      -   5        $��Frissítés��5O      $��0,-30,160,0q�6-   $��Right=�6B   #��[ 6^   $	��Top=�6�   6�   5P      �� 5Q      -	   5         ��Name$ 
HideButton��5Q   "   $��2��6   $��center=�67   $��0,14,0,4q�6T   $��Center=�6f   
������ 
������ $��32��6�   .��5R      �� $��/z_show.png��6   6/   5S      �� 5T      -
   5        $ 
ShowButton��5T   "   $��2��6   $��center=�66   $��0,14,0,4q�6S   
������ 
������ $��32��6�   $	��Top=�6�   .��5U      �� $��/z_hide.png��6   6/   5V      5W      5X      5Y      