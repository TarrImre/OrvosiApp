   M S B A M L   `   `   `  ����H  DWebApi_Assist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_ClientWebApi_Client  5   	        WebApi_Client.PersonWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WebApi_Client     5   	     � Title$  Asszisztens | Felvétel��5   	   $	��450��5	   	   $	��340��5
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
��auto �6$   .+�5*      �� -   5         ��Name$ 	MovePanel��5*   c   $��0��6   $��0��6*   $��2��6:   ���#044123.+�5+      �� $
��Wrap=�6    $��Betegfelvétel��64   $��10,2,0,0q�6I   $
��Bold"�6[   ���#03b4846m   5,      �� 5-      -   5        $��0��5-   4   $��0��6A   $��2��6Q   
������ 
������ $��0,0,5,0q�6�   $��20��6�   $��20��6�   $��Right=�6�   .��5.      �� $��/z_closelight.png��6   69   5/      �� 51      $��0��6   $��1��6(   $��Vezetéknév��65   $��10q�6J   �� 52      -   5        	 ��Name$	 FirstNameTextBox��52   @      TextBoxStyle#��[  6   $��1��6Z   $��1��6j   $��10q�6w   �� 54      $��0��6   $��2��6(   $��Keresztnév��65   $��10q�6J   �� 55      -   5        $	 LastNameTextBox��55   @   #��[  6   $��1��6Y   $��2��6i   $��10q�6v   �� 57      $��0��6   $��3��6(   $��Születési idő��65   $��10q�6M   (  "System.Windows.Controls.DatePicker  58      -   5        
  Name$
 DateOfBirthDatePicker��58      $��1��6<   $��3��6L   $��16,10,18,10q�6Y   �� 5:      $��0��6   $��4��6(   $��Város��65   $��10q�6E   �� 5;      -   5        $	 CityTextBox��5;   @   #��[  6   $��1��6U   $��4��6e   $��10q�6r   �� 5=      $��0��6   $��5��6(   $��Utca-házszám��65   $��10q�6L   �� 5>      -   5        $	 StreetHouseTextBox��5>   @   #��[  6   $��1��6\   $��5��6l   $��10q�6y   �� 5@      $��0��6   $��6��6(   $��Tajszám��65   $��10q�6G   �� 5A      -   5        $	 CardNumTextBox��5A   @   #��[  6   $��1��6X   $��6��6h   $��10q�6u   �� 5C      $��0��6   $��7��6(   $��Panasz��65   $��10q�6F   �� 5D      -	   5        $	 ProblemTextBox��5D   @   #��[  6   $��1��6X   $��7��6h   $��10q�6u   �� 5F      $��0��6   $��8��6(   $��
Diagnózis��65   $��10q�6I   $y�	Collapsed=�6U   �� 5G      -
   5        $	 DiagnoseTextBox��5G      $��1��63   $��8��6C   $��10q�6P   ${�False��6\   $y�	Collapsed=�6n   �� 5I      -   5         ��Name$ AddedTimeText��5I      $��2��63   $��Center=�6G   $��0,0,0,0q�6d   $��0��6u   $��9��6�   $
��Wrap=�6�   $�� ��6�   $	��Top=�6�   5K      �� 5M      -   5         ��Name$ CreateButton��5M   "   $��1��6     LightGreenButton#��[ 6S   $��	Felvétel��6}   $��Right=�6�   $��Bottom=�6�   $
��Left=�6�   $	��100��6�   $��30��6�   $��
0 0 120 30q�6  5N      5O      5P      5Q      