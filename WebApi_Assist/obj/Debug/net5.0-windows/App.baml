   M S B A M L   `   `   `  ����H  DWebApi_Assist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WebApi_AssistWebApi_Assist  5      b ^PresentationFramework.Aero2, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          WebApi_Assist.App   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:WebApi_Assist     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5       �� 
TargetType   LightGreenButton �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value  TextBoxStyle  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow*  $System.Windows.Controls.DataGridCell ��Name	 J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid
 � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter  ColumnHeaderGripperStyle �� Padding  DataGridColumnHeaderStyle1=
  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder   	IsPressed J� IsMouseOver   	IsHovered 
  CanUserSort   IsClickable 
  SortDirection   SortDirection 
  SeparatorVisibility    SeparatorVisibility! 
  SeparatorBrush"   SeparatorBrush# n�Name��%�  &	        &	     &	 2    &	 �    &	 �	    7  7  �� 5
   
   " ��6   .�5      ��  � ��$ 
Montserrat)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � ��$ 6q�6'   �� 5       � �� �#03b4846+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� �#038f6963   5      5      �� 5!   
   " ��6   .�5"      ��  � ��
 �����6+   �� 5#       � ��$ 5,5,0,0q�6(   �� 5$       � ��$ 0q�60   �� 5%       � ��$ Bottom=�62   �� 5&       � ��$ Center=�64   �� 5'       � ��$	 200��6&   �� 5(       � ��$ 30��6'   5)      �� 5,   
   "  6*   .�5-      ��  � ��
 �����6+   �� 5.       � ��$ 2q�6'   �� 5/       � ��$ 30��6'   �� 50       �@J�SnapsToDevicePixels$
 true��64   �� 51       �@=�ErrorTemplate 69   Z� �� 52       �@ ValidationErrorTemplate 53      �� 54      "  6&   55      57      �� 58       � �� 59      �� 5:      "  6&   .R�5;      �� $ 
DGR_Border��6!   #��z��65   #��z��6_   #��z��6�   $
	 True��6�   ._�5<        
 5=   "   �� 5>   &   $
��Auto �67   �� 5?   &   $��* �67    5A   "   �� 5B   &   $��* �64   �� 5C   &   $
��Auto �64   .+�5E   "     $��1��69   #��z 6I   #	 z	 6s     5F   "   $��1��6;   $��1��6K   #y�z 6o   6X   �� *AreRowDetailsFrozen+# Z # Z  �� "  6o    5G   "   $��2��64   $ Vertical=�6E   y�6�   �� *HeadersVisibility+# Z # Z  �� "  5H      5I      5J      5L       5M      P� 5N       �@ 	IsNewItem$
 True��6/   . �5O      ��  � �� 6/   �� *NewItemMargin+ �� "  5P      P� 5Q       �@J�IsMouseOver$
 True��61   . �5R      ��  � �� �#e1ebe263   5S      P� 5T       �@ 
IsSelected$
 True��60   . �5U      ��  � �� �#e1ebe263   �� 5V       � ��
 �   �63   5W      5Y      �� 5\   
   " n�61   .�5]      ��  � ��$ 8��6&   �� 5^       � ��
 ���� 6+   �� 5_       �@�Cursor$ SizeWE��6'   �� 5`       � �� 5a      �� 5b      " n�6&   .R�5c      �� #��z��6!   # z��6K   5d      5f      5g      �� 5h   
   " 
 63   .�5i      ��  � ��
 ���� 6+   �� 5j       � ��$ 30��6'   �� 5k       � ��$ Center=�62   �� 5l       � ��$ Center=�69   �� 5m       � ��$ Center=�64   �� 5n       � ��$
 Bold"�6+   �� 5o       � �� 5p      �� 5q      " 
 6&   .R�5r      � .+�5s        #��z��69   #��z��6c   #��z��6�   # z��6�   # z 6�   # z 6  # z��6A  # z 6e  #  z 6�  #" z! 6�  ._�5t   "   �� #��z��63   $
��True��6v   #	 z	 6�   #��z��6�   5u      n� 5v      $# PART_LeftHeaderGripper��6$   $
��Left=�6D   8��  6_   n� 5w      $# PART_RightHeaderGripper��6$   $��Right=�6E   8�� 6a   5x      5y      5{      5|      5}      5~      