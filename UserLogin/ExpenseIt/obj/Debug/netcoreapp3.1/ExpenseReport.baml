   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$ ExpenseIt - View Expense��5	   	   $	��450��6*   $	��800��67   .��5
      � ��5   
   �� 5       �� ImageSource$ /watermark.jpg��6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Expense Report For:��6   $��25(�6.   $��Bottom=�6<   
�������$��SemiBold"�6j   $��1��6�   $��0��6�   $��0,0,0,15q�6�   6�   � 5   
   $��1��6   $��1��6   ��5      �� 5       �� Color$ White��6"    5      �� 5      $
��Auto �6     5       �� 5!      $��* �6#   �� 5"      $��3* �6#   .+�5$      �� $��Name:��6   $��DemiBold"�6$   $��0��6:   $��0��6J   6Y   �� 5%      -   5         ��Name$ lblName��5%      $��SemiBold"�6%   $��Italic$�6;   $��1��6N   $��0��6^   ��6l   �� *Name+5&      � 5'   
   $��1��6   $��2��6   ��5(      �� 5)      $ White��6"    5+      �� 5,      $
��Auto �6     5.      �� 5/      $��* �6#   �� 50      $��3* �6#   .+�52      �� $��Departament:��6   $��DemiBold"�6+   $��0��6A   $��0��6Q   6`   �� 53      -   5        $ 
lblDepName��53      $��1��6G   $��0��6W   $��Italic$�6d   ��6(   �� *
Department+6y   54      &   System.Windows.Controls.DataGrid  56   
   $��1��6   $��3��6#      AutoGenerateColumns$ False��6V      RowHeaderWidth$ 0Q�6r   ��60   �� 	 �� Path$	 Expenses�
   Columns
 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Expense Type��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� $	 ExpenseType�  59      $ Amount��6%    65   �� $	 ExpenseAmount�5;      5=      5>      