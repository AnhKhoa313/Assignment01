   M S B A M L   `   `   `  ����M  INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF  5   	   +    %NguyễnAnhKhoaWPF.CustomerMainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � Title$  Customer Portal��5      $	��450��6    $	��700��6-    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,0,-6q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ 	#FF00416A��6    � Offset$	 0.0Q�61   � 5      $ 	#FF00B4DB��6   $	 0.4Q�61   � 5      $ 	#FF00C9A7��6   $	 0.7Q�61   � 5      $ 	#FF6DD5ED��6   $	 1.0Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ 
txtWelcome��5      $��16(�6,   $
��Bold"�6:   5      �� 5   
   $��1��6   $��Your Order History��6    $��	0,10,0,10q�6<   .��5       &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dgOrders��5       
   AutoGenerateColumns$
 False��6)      
IsReadOnly$
 True��6E      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	OrderID+6W     5#      $ Employee ID��6)   $	 100 6]    6>   �� *
EmployeeID+6]     5$      $ 
Order Date��6)   $	 150 6[    6=   �� *	OrderDate+6[   5&      5'      �� 5)   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5*      �� -   5        $��Edit Profile��5*      $	��100��6,   $��5q�68   6C   �� 5+      -   5        $��Logout��5+      $��80��6&   $��5q�61   6<   5,      5-      5.      