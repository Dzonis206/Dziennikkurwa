   M S B A M L   `   `   `  ����C  ?dziennik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:dziennik.Windowsdziennik.Windows  5   	   $    dziennik.Windows.StudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:dziennik.Windows     5   	     � Title$  StudentWindow��5   	   $	��450��6   $	��800��6,   .��5	      � $��50q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Imię i Nazwisko��6   $��0,0,10,0q�6+   �� 5   
   -   5        $��_textblock_imie_nazwisko��5      $��1��64   �� 5   
   $��PESEL��6   $��1��6!   $��0,0,10,0q�6.   �� 5   
   -   5        $��_textblock_pesel��5      $��1��6,   $��1��6=   �� 5   
   $��Ilość punktów��6   $��2��6)   $��0,0,10,0q�66   �� 5   
   -   5        $��_textblock_punkty��5      $��1��6-   $��2��6>   �� 5   
   $��Oceny��6   $��3��6!   $��0��6.   R� 5   
   -   5        $��_treeView_oceny��5      $��3��6*   $��1��67   5!      5"      