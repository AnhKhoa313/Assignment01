   M S B A M L   `   `   `  ����M  INguyễnAnhKhoaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyễnAnhKhoaWPFNguyễnAnhKhoaWPF  5   	   '    !NguyễnAnhKhoaWPF.CustomerDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyễnAnhKhoaWPF     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � 
ResizeMode$ NoResize=�6-   .��5	      � $	��318��6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	#FFFF0000��6    � Offset$	 0.0Q�61   � 5      $ 	#FFFF5F5F��6   $	 0.5Q�61   � 5      $ 	#FFB22222��6   $	 1.0Q�61   5      .+�5   
   �� .+�5      �� $��Customer ID:��6   �� 5      -   5         ��Name$ txtID��5      ${�False��6%   �� 5      $��Company Name:��6   �� 5      -   5        $ 
txtCompany��5      �� 5      $��Contact Name:��6   �� 5      -   5        $ 
txtContact��5      �� 5!      $��Contact Title:��6   �� 5"      -   5        $ txtTitle��5"      �� 5$      $��Address:��6   �� 5%      -   5        $ 
txtAddress��5%      �� 5'      $��Phone:��6   �� 5(      -   5        $ txtPhone��5(      5)      �� 5+   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,20,0,0q�6W   .+�5,      �� -   5        $
��Save��5,      $��80��6$   $��5q�6/   6:   �� 5-      -   5        $��Cancel��5-      $��80��6&   $��5q�61   6<   5.      5/      50      