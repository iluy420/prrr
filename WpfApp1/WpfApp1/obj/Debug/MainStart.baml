   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.MainStart   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  	MainStart��5	       N� 
Background 5
      �� 5   
    �� ImageSource$ .\imagg\im.jpg��6   .��5      � -   5         �Name$ 
MainStartt��5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� -   5         ��Name$ Sphere��5!   S   $��1��6   $��2��6   $��3��6.   $��
Сфера��6B   $��	10,5,10,0q�6c   $��47��6v   $	��Top=�6�   6�   �� 5"   
   -   5        $
 Cone��5"   R   $��2��6   $��2��6   $��3��6.   $��
Конус��6B   $��	10,5,10,5q�6`   6s   �� 5#   
   -   5        $ Cylinder��5#   T   $��3��6   $��2��6   $��3��6.   $��Цилиндр��6B   $��	10,5,10,5q�6f   6y   �� 5$   
   -   5        $ TruncatedCone��5$   \   $��4��6   $��2��6   $��3��6.   $#��Усеченный конус��6B   $��	10,5,10,5q�6s   6�   �� 5%   
   -   5        $
 Exit��5%   R   $��6��6   $��2��6   $��3��6.   $��
Выход��6B   $��	40,5,40,5q�6a   6t   5&      5'      