   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   #    StudentInfoSystem.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  Вход в УИСС��5   	   $	��250��6   $	��350��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   .��5	      � $��10,10,10,10q�6    � ColumnDefinitions 5
   
   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��25 �6   �� 5      $��35 �6   �� 5      $��25 �6   �� 5      $��35 �6   �� 5      $��1* �6   .+�5   
   �� $��Вход в УИСС��6   $��Center=�6&   $��0��6C   $��20(�6P   $��Center=�6^   6{   �� 5   
   $��Username��6   $��1��6#   $
��Left=�60   $��Bottom=�6K   6h   �� 5   
   -   5         ��Name$ 
tbUsrename��5      $��2��6&   $��0,5,0,5q�63    ^� ShowDuration$
 5000��6D   .��6i    � ToolTip 5      _� 5      .��5      �� .+�5      �� $
��Bold"�6$   Username box6D   �� 5      Enter your username.6:   5      5      .��5      5       �� 5!   
   $��Password��6   $��3��6#   $
��Left=�60   $��Bottom=�6K   6h   G� 5"   
   -   5         G�Name$ 
tbPassword��5"      $��4��6*   $��0,5,0,5q�67   $
 5000��6H    5#      _� 5$      .��5%      �� .+�5&      �� $
��Bold"�6$   Password box6D   �� 5'      Enter your password.6:   5(      5)      5+      �� 5,   
   -   5        	 ��Name$	 btnLogin��5,      $��5��6#   .��6G   Login6N   5-      5.      