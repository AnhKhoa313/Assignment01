   M S B A M L   `   `   `  ����M  INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF  5   	   $    NguyễnAnhKhoaWPF.OrderWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � Title$  Order Management��5      $	��400��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,0,-6q�6   $��Center=�6   $	��800��6:    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ 	#FF00416A��6    � Offset$	 0.0Q�61   � 5      $ 	#FF00B4DB��6   $	 0.4Q�61   � 5      $ 	#FF00C9A7��6   $	 0.7Q�61   � 5      $ 	#FF6DD5ED��6   $	 1.0Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrders��5         AutoGenerateColumns$ False��6%   	   
IsReadOnly$
	 True��6A   
   SelectionMode$
 Single=�6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	OrderID+6S     5      $ Customer ID��6%   $	 100 6Y    6:   �� *
CustomerID+6Y     5      $ Employee ID��6%   $	 100 6Y    6:   �� *
EmployeeID+6Y     5      $ 
Order Date��6%   $	 150 6W    69   �� *	OrderDate+6W   5       �� 5"   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5#      �� -   5        $��	Add Order��5#      $	��100��6)   $��5q�65   6@   �� 5$      -   5        $��Close��5$      $��80��6%   $��5q�60   6;   5%      5&      5'      