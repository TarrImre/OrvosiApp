   M S B A M L   `   `   `  ����H  DWebApi_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_ClientWebApi_Client  5   	       WebApi_Client.LoginDoctor   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WebApi_Client     5   	     � Title$  LoginAssistant��5   	   $	��450��5	   	   $	��340��5
   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#F3F5F9 � AllowsTransparency$
 True��5   	   $��
Montserrat)�5   	    � Icon$+ %https://toxy.hu/csharpimages/ikon.ico��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��340 �6   6-    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��* �6   6)   �� 5      $��20 �6   6*   .+�5   
   �� $��1��6   $.��(https://toxy.hu/csharpimages/shapev2.png��6   $��
0,-115,0,0q�6O   6e   �� 5   
   -   5         ��Name$ 	MovePanel��5   K   $��0��6   $��0��6"   
������ 6^   �� 5   
   -   5        $��0��5      $��0��69   
������ 
������ $��0,0,5,0q�6|   $��20��6�   $��20��6�   $��Right=�6�   .��5      �� $��/z_close.png��6   6,   5       �� 5!   
   -   5        $��0��5!      $��0��69   
������ 
������ $��0,0,25,0q�6|   $��20��6�   $��20��6�   $��Right=�6�   .��5"      �� $��/z_talca.png��6   6,   5#      �� 5%   
   -   5        $ 
LoginPanel��5%      $��1��6)   
�������$	��200��6I   $��70,20,70,65q�6U   	 J� Effect	 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'      
   ShadowDepth$
 0Q�5(         	Direction$	 270Q�5)         Color$ Black��5*         Opacity$	 0.1Q�5+         
BlurRadius$ 20Q�5,      .+�5.      �� $��/z_doctorv2.png��6   $��80��6-   $��	0,30,0,10q�68   6M   �� 5/      $
��Wrap=�6   $��Üdvözöllek!��6,   $��0 0 0 0q�6?   $��Center=�6Q   $��16(�6n   �� 50      $
��Wrap=�6   $��Bejelentkezés, mint��6,   $��0 20 0 0q�6G   $��Center=�6Z   $��12(�6w   �� 51      $
��Wrap=�6   $��Doktor��6,   $��0 0 0 0q�6:   $��Center=�6L   $
��Bold"�6i   ���#044123$��14(�6�   �� 52      -   5        $��	Belépés��52   1      LightGreenButton#��[  6C   $
��Left=�6m   $��Bottom=�6�   $
��Left=�6�   $	��100��6�   $��30��6�   $��	50 30 0 0q�6�   53      54      �� 55   
   -   5        $ LoginPanelLoading��55      $��1��60   
�������$	��300��6P   $��70,20,70,65q�6\   $	��320��6q   $��Center=�6~   $��Center=�6�   .+�56      �� $+��%https://toxy.hu/csharpimages/ikon.ico��6   $��0,70,0,0q�6D   $��Center=�6V   $��Center=�6t   $��80��6�   �� 57      $
��Wrap=�6   $��Belépés...��6,   $��0,60,0,0q�6>   $��Center=�6P   $��Center=�6n   ���#044123$��SemiBold"�6�   $��16(�6�   58      59      5:      