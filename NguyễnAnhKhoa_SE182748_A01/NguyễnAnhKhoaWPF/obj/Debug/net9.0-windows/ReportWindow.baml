   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   M INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF 5   	   %   NguyễnAnhKhoaWPF.ReportWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � Title$  Order Reports��5	      $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��0,0,0,-6q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ 	#FF00416A��6    � Offset$	 0.0Q�61   � 5      $ 	#FF00B4DB��6   $	 0.4Q�61   � 5      $ 	#FF00C9A7��6   $	 0.7Q�61   � 5      $ 	#FF6DD5ED��6   $	 1.0Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   $	��Top=�6@   .+�5      �� $��From:��6   $��Center=�6$   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpFrom��5      
	 �� Now
   SelectedDate#
 Z	 6)   $	��150��6T   $	��5,0q�6`   �� 5      $	��To:��6   $��Center=�6"     5       -   5        $
 dpTo��5       #
 Z	 6'   $	��150��6R   $	��5,0q�6^   �� 5!      -   5        $��Generate Report��5!      $	��120��6/   $
��10,0q�6;   6I   5"      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dgReport��5$      $��1��6%      AutoGenerateColumns$ False��62      
IsReadOnly$
 True��6N      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	OrderID+6S     5'      $ Customer ID��6%   $	 100 6Y    6:   �� *
CustomerID+6Y     5(      $ Employee ID��6%   $	 100 6Y    6:   �� *
EmployeeID+6Y     5)      $ 
Order Date��6%   $	 150 6W    69   �� *	OrderDate+6W   5+      �� 5-   
   -   5        $��2��5-      $��Close��6   $��80��6.   $��Right=�69   $��0,10,0,0q�6U   6g   5.      5/      