   M S B A M L   `   `   `  ����M  INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF  5   	   $    NguyễnAnhKhoaWPF.OrderDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � Title$  	New Order��5   	   $	��500��6   $	��600��6(    � WindowStartupLocation$ CenterOwner=�5	   	    � 
ResizeMode$ NoResize=�6-   .��5
      � $��0,0,0,-6q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	#FFFF0000��6    � Offset$	 0.0Q�61   � 5      $ 	#FFFF5F5F��6   $	 0.5Q�61   � 5      $ 	#FFB22222��6   $	 1.0Q�61   5      .+�5   
   ��  �� Orientation$ Vertical=�6   $��0,0,0,10q�6,   .+�5      �� $��	Customer:��6   �� 5      -   5        	 ��Name$	 
cbCustomer��5      
 �� DisplayMemberPath$
 ContactName��6+    �� SelectedValuePath$ 
CustomerID��6K   $	��300��6j   �� 5      $��Order Date:��6   �� 5      -   5         ��Name$ txtDate��5       �� 
IsReadOnly$
 True��6'   $	��300��69   5      �� 5"   
   $��Add Product��6   $��1��6(   $��	0,10,0,10q�65   .��5#      �� $��10q�6   .+�5$      �� $ 
Horizontal=�6   $��0,0,0,10q�66   .+�5%      �� $��Product:��6   $��80��6/   �� 5&      -   5        $	 	cbProduct��5&      $	��200��62   $
 ProductName��6>   $ 	ProductID��6^   5'      �� 5)      $ 
Horizontal=�6   $��0,0,0,10q�66   .+�5*      �� $��	Quantity:��6   $��80��60   �� 5+      -   5        $ txtQty��5+      $	��100��6.   �� 5,      $��Discount (0-1):��6   $	��130��66   $��10,0,0,0q�6B   �� 5-      -   5        $ txtDiscount��5-      $��80��63   �� 5.      -   5        $��Add Item��5.      $	��100��60   $��10,0,0,0q�6<   6N   5/      &   System.Windows.Controls.DataGrid  51      -   5          Name$ dgItems��51         AutoGenerateColumns$ False��6,   $	��180��6H      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Product ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	ProductID+6_     54      $ 
Unit Price��6-   $	 100 6_    6A   �� *	UnitPrice+6_     55      $ Quantity��6-   $	 100 6\    6?   �� *
Quantity+6\     56      $ Discount��6-   $	 100 6\    6?   �� *
Discount+6\   58      59      5:      �� 5<   
   $��2��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5=      �� -   5        $��
Save Order��5=      $	��100��6*   $��5q�66   6A   �� 5>      -	   5        $��Cancel��5>      $��80��6&   $��5q�61   6<   5?      5@      5A      