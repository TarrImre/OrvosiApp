   M S B A M L   `   `   `  ����H  DWebApi_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_ClientWebApi_Client  5   	       WebApi_Client.EditPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WebApi_Client     5   	     � Title$  Doktor | Módosítás��5   	   $	��520��5	   	   $	��340��5
   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#D0E1D9 � AllowsTransparency$
 True��5   	    � Icon$+ %https://toxy.hu/csharpimages/ikon.ico��5   	   .��5      �� 
������ 
������ $��0q�6@   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      $��* �6'    5      �� 5      $
��auto �6$   �� 5       $
��auto �6$   �� 5!      $
��auto �6$   �� 5"      $
��auto �6$   �� 5#      $
��auto �6$   �� 5$      $
��auto �6$   �� 5%      $
��auto �6$   �� 5&      $
��auto �6$   �� 5'      $
��auto �6$   .+�5)      �� -   5         ��Name$ 	MovePanel��5)   c   $��0��6   $��0��6*   $��2��6:   ���#044123.+�5*      �� $
��Wrap=�6    $��Beteg módosítás��64   $��10,2,0,0q�6K   $
��Bold"�6]   ���#03b4846o   5+      �� 5,      -   5        $��0��5,   4   $��0��6A   $��2��6Q   
������ 
������ $��0,0,5,0q�6�   $��20��6�   $��20��6�   $��Right=�6�   .��5-      �� $��/z_closelight.png��6   69   5.      �� 50      $��0��6   $��1��6(   $��Vezetéknév��65   $��10q�6J   �� 51      -   5        	 ��Name$	 FirstNameTextBoxEDIT��51   @      TextBoxStyle#��[  6   $��1��6^   $��1��6n   $��10q�6{   �� 53      $��0��6   $��2��6(   $��Leírás��65   $��10q�6F   �� 54      -   5        $	 LastNameTextBoxEDIT��54   @   #��[  6   $��1��6]   $��2��6m   $��10q�6z   �� 56      $��0��6   $��3��6(   $��Születési idő:��65   $��10q�6N   (  "System.Windows.Controls.DatePicker  57      -   5        
  Name$
 DateOfBirthDatePickerEDIT��57      $��1��6@   $��3��6P   $��20,10,20,10q�6]   �� 59      $��0��6   $��4��6(   $��Város��65   $��10q�6E   �� 5:      -   5        $	 CityTextBoxEDIT��5:   @   #��[  6   $��1��6Y   $��4��6i   $��10q�6v   �� 5<      $��0��6   $��5��6(   $��Utca-házszám��65   $��10q�6L   �� 5=      -   5        $	 StreetHouseTextBoxEDIT��5=   @   #��[  6   $��1��6`   $��5��6p   $��10q�6}   �� 5?      $��0��6   $��6��6(   $��Tajszám��65   $��10q�6G   �� 5@      -   5        $	 CardNumTextBoxEDIT��5@   @   #��[  6   $��1��6\   $��6��6l   $��10q�6y   �� 5B      $��0��6   $��7��6(   $��Panasz��65   $��10q�6F   �� 5C      -	   5        $	 ProblemTextBoxEDIT��5C   @   #��[  6   $��1��6\   $��7��6l   $��10q�6y   �� 5E      $��0��6   $��8��6(   $��
Diagnózis��65   $��10q�6I   �� 5F      -
   5        $	 DiagnoseTextBoxEDIT��5F   @   #��[  6   $��1��6]   $��8��6m   $��90��6z   $��10q�6�    �� TextWrapping$
 Wrap=�6�   5H      �� 5J      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Bottom=�6?   .+�5K      �� -   5         ��Name$ CreateButton��5K        LightGreenButton#��[ 6/   $��	Felvétel��6Y   6l   �� 5L      -   5        $ UpdateButton��5L      #��[ 6/   $��Frissítés��6Y   6m   �� 5M      -   5        $ DeleteButton��5M      #��[ 6/   $��Törlés��6Y   6j   5N      5Q      5R      5S      