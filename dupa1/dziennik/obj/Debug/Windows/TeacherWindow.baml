   M S B A M L   `   `   `  ����C  ?dziennik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:dziennik.Windowsdziennik.Windows  5   	   $    dziennik.Windows.TeacherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:dziennik.Windows     5   	     � Title$  TeacherWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $
��Auto �6   �� 5      $��8* �6   .+�5   
   �� $��0��6   $��10q�6%   .+�5      �� -   5        $��_listBox_uczniowie��5      �� 5      -   5        $��AddStudentButton��5      $��Add Student��6-   $��0,10,0,0q�6b   $y�	Collapsed=�6t   5      �� 5   
   $��1��6   $��5��6'   $��Stretch=�61   � 5   
   $��2��6   $��10q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5       $
��auto �6     5"      �� 5#      $
��auto �6#   �� 5$      .+�5'      �� $��Imię i Nazwisko��6   $��0,0,10,0q�6/   �� 5(      -   5        $��_textblock_imie_nazwisko��5(      $��1��68   �� 5*      $��PESEL��6   $��1��6%   $��0,0,10,0q�62   �� 5+      -   5        $��_textblock_pesel��5+      $��1��60   $��1��6@   �� 5-      $��Ilość punktów��6   $��2��6-   $��0,0,10,0q�6:   �� 5.      -   5        $��_textblock_punkty��5.      $��1��61   $��2��6A   �� 50      $��Oceny��6   $��3��6%   $��0��62   R� 51      -   5        $��_treeView_oceny��51      $��3��6.   $��1��6;   �� 53      $��	Przedmiot��6   $��4��6)   $��0,0,10,0q�66   �� 54      -   5        $��_comboBox_subjects��54      $��4��61   $��1��6>   �� 56      $��Ocena��6   $��5��6%   $��0,0,10,0q�62   �� 57      -   5        $��_comboBox_grades��57      $��5��6/   $��1��6<   �� 59      -	   5        $��Dodaj ocenę��59      $��6��6+   $��1��68   6H   �� 5;      -
   5         ��Name$ AddPointsButton��5;      $��Dodaj Punkty��6.   $��7��6E   $��1��6R   6b   �� 5=      -   5        $ SubtractPointsButton��5=      $��Odejmij Punkty��63   $��7��6L   $��2��6v   $��92,20,0,-20q�6�   5>      �� 5@   
   -   5         ��Name$ _textblock_witaj��5@      $
��Left=�6.   $��Bottom=�6I   $��	10,10,0,0q�6d   $��16(�6w   $
��Bold"�6�   5A      5B      