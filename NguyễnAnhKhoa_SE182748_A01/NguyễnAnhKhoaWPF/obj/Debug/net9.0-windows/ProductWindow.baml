   M S B A M L   `   `   `  ����M  INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF  5   	   &     NguyễnAnhKhoaWPF.ProductWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � Title$  Product Management��5   
   $	��400��6%   $	��900��62    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,0,-6q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ 	#FF00416A��6    � Offset$	 0.0Q�61   � 5      $ 	#FF00B4DB��6   $	 0.4Q�61   � 5      $ 	#FF00C9A7��6   $	 0.7Q�61   � 5      $ 	#FF6DD5ED��6   $	 1.0Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� $��Search:��6   $��Center=�6'   �� 5      -   5         ��Name$ 	txtSearch��5      $	��200��6)   $
��10,0q�65   �� 5      -   5        $��Search��5      $��80��6&   $	��5,0q�61   6>   �� 5      -   5        $��Refresh��5      $��80��6'   $	��5,0q�62   6?   5       &   System.Windows.Controls.DataGrid  5"   
   -   5        	  Name$	 
dgProducts��5"      $��1��6'   
   AutoGenerateColumns$
 False��64      
IsReadOnly$
 True��6P      SelectionMode$ Single=�6b      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6O     5%      $ Product Name��6%   $	 150 6[    6;   �� *ProductName+6[     5&      $ Category ID��6%   $ 80 6Y    6:   �� *
CategoryID+6Y     5'      $ 
Unit Price��6%   $	 100 6W    69   �� *	UnitPrice+6W     5(      $ Units In Stock��6%   $	 120 6^    6=   �� *UnitsInStock+6^   5*      �� 5,   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5-      �� -   5        $	��Add��5-      $��80��6#   $��5q�6.   69   �� 5.      -   5        $
��Edit��5.      $��80��6$   $��5q�6/   6:   �� 5/      -   5        $��Delete��5/      $��80��6&   $��5q�61   6<   �� 50      -   5        $��Close��50      $��80��6%   $��5q�60   6;   51      52      53      