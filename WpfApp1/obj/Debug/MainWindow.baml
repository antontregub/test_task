   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��793��6)    � 	Resources 5	          WpfApp1.IdToColorConverter   IdToColorConverter  IdStyleMaths �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 	Converter  IdStyleDrawing  IdStyleLiterature��%S  &	        &	      7   &	 j     7   &	 �     7     5
   
   6$   �� 5   
   "  6%   .�5      ��  � �� 6+   �� *Maths+8   5      �� 5   
   "  6'   .�5      ��  � �� 6+   �� *	Drawing+8   5      �� 5   
   "  6*   .�5      ��  � �� 6+   �� *
Literature+8   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ docGrid��5   /      AutoGenerateColumns .  $��	142,3,0,7q�6@   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id_Gradebook_Numberdoc��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Gradebook_Number+6j     5       $

 Name��6>   $	 100 6L    6%   �� *Name+6L     5!      $
 Groups��6@   $	 110 6P    6%   �� *Groups+6P     5"      $
 Maths��6?   $	 100 6N      	CellStyle# [ 6[    6%   �� *Maths+6[     5#      $
 Drawing��6A   $	 100 6R   # [ 6^    6%   �� *	Drawing+6^     5$      $
 
Literature��6D   $	 100 6X   # [ 6d    6%   �� *
Literature+6d   5'      �� 5)   
   $��0,3,0,7q�6   $	��130��6'   $
��Left=�66   $	��137��6Q   .+�5*      �� -   5         ��Name$ lblName��5*      $
��Name��6)   $��Center=�65   $��Center=�6S   $��66��6p   $��23��6{   $��1��6�   �� 5+      -   5         ��Name$ txtName��5+      $��1��6'   $��Center=�67   $��26��6S   $��4,0,-4,0q�6_   �� 5,      -   5        $ lblGroup��5,      $��Group��6*   $��Center=�67   $��Center=�6U   $��66��6r   $��23��6}   $��1��6�   �� 5-      -   5        $��	GroupList��5-      $��27��6(   $	��Top=�64    J� RenderTransformOrigin$ 23.885,6.287&�6M   $��Right=�6r   $	��120��6�   $��1��6�   6�   �� 5.      -   5        $ lblGrade��5.      $��Grade��6*   $��Center=�67   $��Center=�6U   $��66��6r   $��23��6}   $��1��6�   �� 5/       �� Orientation$ 
Horizontal=�6   .+�50      �� -   5        $ Minvalue��50      $��1��6,   $��5,7,5,7q�6=   $��25��6N   $��44��6Z   �� 51      -   5        $ Maxvalue��51      $��1��6,   $��	30,7,12,7q�6<   $��25��6P   $��44��6\   52      �� 53      -	   5        $��Search��53      $��90��6&   $��	11,7,12,7q�6D   $��1��6W   �� 54      -
   5        $��Clear��54      $��90��6%   $��1��6B   55      56      57      