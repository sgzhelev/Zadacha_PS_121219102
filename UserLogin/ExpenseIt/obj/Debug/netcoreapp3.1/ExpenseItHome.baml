   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ExpenseIt - Home��5	   	   $	��350��6"   $	��500��6/   .��5
      � ��5   
   �� 5       �� ImageSource$ /watermark.jpg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6"   $��2��6/   ��6@   ��  �� Path$ PersonsChecked�6n   �� 5   
   $��0��6   $��3��6    $��Bottom=�6R   
���������6-   �� $ LastChecked�6t   �� 5   
   $��1��6w   $��20(�6�   
�������$��SemiBold"�6�   $��0,0,0,4q�6�   $��Bottom=�6�   ��6   ��  �� RelativeSource ��  �� AncestorType" �$ MainCaptionText�6�   �� 5   
   $��35��6    �� Padding$ 5q�6   ���#4E87D4$��1��6>   $��1��6N   ._�5      �� $��Center=�6   
�������.��6C   Names:6K   5      �� 5   
   -   5        $��peopleListBox��5      $��1��6'   $��2��67   ��6D   ��  �� " �$ ExpenseDataSource���5      �� 5       .R�5!      �� ��6   �� $
 Name�6<   5"      5$      �� 5%   
   -   5        $	��125��5%   W   $��25��6c   $	��Top=�6o   $��Right=�6�   $��
0,10,10,10q�6�   $��1��6�   $��3��6�   ��6   �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�6�   5&      5'      