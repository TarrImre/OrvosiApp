   M S B A M L   `   `   `  ����H  DWebApi_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_ClientWebApi_Client  5      b ^PresentationFramework.Aero2, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          WebApi_Client.App   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:WebApi_Client     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5       �� 
TargetType   LightGreenButton �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  TextBoxStyle  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow*  $System.Windows.Controls.DataGridCell ��Name	 J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid
 � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter  ColumnHeaderGripperStyle �� Padding  DataGridColumnHeaderStyle1=
  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder   	IsPressed J� IsMouseOver   	IsHovered 
  CanUserSort   IsClickable 
  SortDirection   SortDirection 
  SeparatorVisibility    SeparatorVisibility! 
  SeparatorBrush"   SeparatorBrush# n�Name��%�  &	        &	     &	 2    &	 �    &	 �	    7  7  �� 5	   
   " ��6   .�5
      ��  � ��$ 
Montserrat)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 6q�6'   �� 5       � �� �#03b4846+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� �#038f6963   5      5      �� 5   
   " ��6   .�5       ��  � ��
 �����6+   �� 5!       � ��$ 5,5,0,0q�6(   �� 5"       � ��$ 0q�60   �� 5#       � ��$ Bottom=�62   �� 5$       � ��$ Center=�64   �� 5%       � ��$	 200��6&   �� 5&       � ��$ 30��6'   5'      �� 5+   
   "  6*   .�5,      ��  � ��
 �����6+   �� 5-       � ��$ 2q�6'   �� 5.       � ��$ 30��6'   �� 5/       �@J�SnapsToDevicePixels$
 true��64   �� 50       �@=�ErrorTemplate 69   Z� �� 51       �@ ValidationErrorTemplate 52      �� 53      "  6&   54      56      �� 57       � �� 58      �� 59      "  6&   .R�5:      �� $ 
DGR_Border��6!   #��z��65   #��z��6_   #��z��6�   $
	 True��6�   ._�5;        
 5<   "   �� 5=   &   $
��Auto �67   �� 5>   &   $��* �67    5@   "   �� 5A   &   $��* �64   �� 5B   &   $
��Auto �64   .+�5D   "     $��1��69   #��z 6I   #	 z	 6s     5E   "   $��1��6;   $��1��6K   #y�z 6o   6X   �� *AreRowDetailsFrozen+# Z # Z  �� "  6o    5F   "   $��2��64   $ Vertical=�6E   y�6�   �� *HeadersVisibility+# Z # Z  �� "  5G      5H      5I      5K       5L      P� 5M       �@ 	IsNewItem$
 True��6/   . �5N      ��  � �� 6/   �� *NewItemMargin+ �� "  5O      P� 5P       �@J�IsMouseOver$
 True��61   . �5Q      ��  � �� �#e1ebe263   5R      P� 5S       �@ 
IsSelected$
 True��60   . �5T      ��  � �� �#e1ebe263   �� 5U       � ��
 �   �63   5V      5X      �� 5[   
   " n�61   .�5\      ��  � ��$ 8��6&   �� 5]       � ��
 ���� 6+   �� 5^       �@�Cursor$ SizeWE��6'   �� 5_       � �� 5`      �� 5a      " n�6&   .R�5b      �� #��z��6!   # z��6K   5c      5e      5f      �� 5g   
   " 
 63   .�5h      ��  � ��
 ���� 6+   �� 5i       � ��$ 30��6'   �� 5j       � ��$ Center=�62   �� 5k       � ��$ Center=�69   �� 5l       � ��$ Center=�64   �� 5m       � ��$
 Bold"�6+   �� 5n       � �� 5o      �� 5p      " 
 6&   .R�5q      � .+�5r        #��z��69   #��z��6c   #��z��6�   # z��6�   # z 6�   # z 6  # z��6A  # z 6e  #  z 6�  #" z! 6�  ._�5s   "   �� #��z��63   $
��True��6v   #	 z	 6�   #��z��6�   5t      n� 5u      $# PART_LeftHeaderGripper��6$   $
��Left=�6D   8��  6_   n� 5v      $# PART_RightHeaderGripper��6$   $��Right=�6E   8�� 6a   5w      5x      5z      5{      5|      5}      