   M S B A M L   `   `   `  ����E  AMistie_v_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mistie_v_3
Mistie_v_3  5   	       Mistie_v_3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mistie_v_3     5   	     � Title$  
MainWindow��5   	   $	��730��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � AllowsTransparency .  � Icon$' !/Pictures/Icons/logoAplikace1.png��6[    � 	Resources 5         SomeButtonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType��%�   &	        �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      � #��z��6   .+�5      �� 5      5      5      5      5      ��5      �� 5   
   
 �� ImageSource$-
 'Pictures/BackGround/pozadiAplikace1.jpg��6    j� Stretch$ UniformToFill=�6K   .��5       �  � RowDefinitions 5!   
   �� 5"      $	��43* �6   �� 5#      $
��322* �6    � ColumnDefinitions 5%   
   �� 5&      $
��279* �6   $	��350��6,   �� 5'      $��1001* �6   .+�5+   
   �� $��1��6   $��2��6   $
��Auto��62   $
��Auto��6@   �� 5-   
   $��0q�6   $
��Auto��6%   $
��Auto��63   $��2��6@   $��1��6Q   �� 5.   
   $��1��6   $��0��6#    �� Orientation$ Vertical=�63   $��Center=�6J   $	��624��6e   $��Center=�6r   $	��252��6�   $��
20,10,7,10q�6�   .+�5/      �� -   5         ��Name$ 
homeButton��5/      #��[  6)   $�� ��6R   $��0q�6]   $��0,30,0,0q�6q   $��40��6�   $	��150��6�   $	��123��6�   $	��250��6�   $
��Bold"�6�   ���	#B2FFFFFF$��40(�6�   $��Ebrima)�6  ��50      �� 51      $'
 !Pictures/Buttons/Big/homeBig1.png��6!   $ UniformToFill=�6Q   53      �� 54      -   5        $ domacnostButton��54      #��[  6.   $�� ��6W   $��0,25,0,0q�6b   $��0q�6t   $��40��6�   $	��150��6�   $	��123��6�   $	��250��6�   $
��Bold"�6�   ���	#B2FFFFFF$��38(�6�   $��Ebrima)�6  ��55      �� 56      $,
 &Pictures/Buttons/Big/domacnostBig1.png��6!   58      �� 59      -   5        $ zabezpeceniPageButton��59      #��[  64   $�� ��6]   $��0,25,0,0q�6h   $��40��6z   $��0q�6�   $	��150��6�   $	��123��6�   $	��250��6�   $
��Bold"�6�   ���	#B2FFFFFF$��38(�6�   $��Ebrima)�6�   ��5:      �� 5;      $.
 (Pictures/Buttons/Big/zabezpeceniBig1.png��6!   $ UniformToFill=�6X   5=      �� 5>      -   5        $ nastaveniButton��5>      #��[  6.   $�� ��6W   $��0,25,2,0q�6b   $��0q�6t   $��40��6�   $	��150��6�   $	��123��6�   $	��250��6�   $��Ebrima)�6�   $
��Bold"�6�   ���	#B2FFFFFF$��38(�6�   ��5?      �� 5@      $,
 &Pictures/Buttons/Big/nastaveniBig1.png��6!   $ UniformToFill=�6V   5B      5C       � 5E   
   -   5          �Name$ mainWindowFrame��5E      $��0��6)   $��2��66   $��1��6G   $��0,10,0,0q�6W   $
��Auto��6i   $��	2.5,0,0,0q�6�   $��	1.8,0,0,0q�6�     � NavigationUIVisibility$ Hidden=�6�   ��6v   Z� 6�   �� 5G   
   $
��Auto��6   $
��Auto��6   $��0��6,   $��2��69   $��Stretch=�6M   $��Stretch=�6k   �� 5H   
   $
��Auto��6   $
��Auto��6   $��0��6,   $��2��69   $��Stretch=�6M   $��Stretch=�6k   �� 5I   
   $
��Auto��6   $
��Auto��6   $��0��6,   $��2��69   $��	0,0,0,0.0q�6M   ��5J      �� 5K       �� Color$ 	#FFC9C9C9��6"    �� Opacity$	 0.5Q�64   5M      �� 5O   
   -   5         ��Name$ teplotaTextBlock��5O      $��0��6/   $��0��6<   $��2��6L   $��70��6`   $ 
Horizontal=�6l   $��0,12,0,0q�6�   $
��Left=�6�   $��Center=�6�   $
��Auto��6�   .+�5Q      �� -   5         ��Name$ zamekONOFFBorder��5Q      $��1q�6/   $��70��6C   $��70��6N   $��10,0,0,0q�6Z    J� Opacity$	 0.1Q�6l   ��5R      �� 5S      $#
 Pictures/Icons/zamekIcon1.png��6!   5U      �� 5V      -   5        $ HomeZabezpeceniBorder��5V      $��1q�64   $��70��6H   $��70��6S   $��	10,10,0,0q�6_   $	 0.1Q�6s   ��5W      �� 5X      $-
 'Pictures/Icons/homeZabezpeceniIcon1.png��6!   $ UniformToFill=�6W   5Z      �� 5[      -	   5        $ MicrophoneOnOffBorder��5[      $��1q�64   $��70��6H   $��70��6S   $��10,0,0,0q�6_   $	 0.1Q�6r   ��5\      �� 5]      $(
 "Pictures/Icons/microphoneIcon1.PNG��6!   5_      �� 5`      -
   5        $ MessageOnOffBorder��5`      $��1q�61   $��70��6E   $��70��6P   $��	10,10,0,0q�6\   $	 0.1Q�6p   ��5a      �� 5b      $$
 Pictures/Icons/zpravaIcon1.PNG��6!   $ UniformToFill=�6N   5d      �� 5h      -   5        $ autorTextLabel��5h      $
��Auto��6-   $��www.mnsoftware.cz��6:   #��[  6V   $��20,0,0,0q�6   $��Bottom=�6�   $��Center=�6�   $��30(�6�   
�������$��Century Gothic)�6�   ��6  Z� 6  5j      �� 5l   
   $��0��6   $��1��6"   $��86��62   $
��Auto��6>   $��Right=�6K   $��Center=�6g   .+�5n      �� -   5         ��Name$ casTextBlock��5n      $
��Wrap=�6.   
�������$	��640��6U   $��75(�6a   $��Stretch=�6o   $��00.00.0000  00:00��6�   $��Century Gothic)�6�    �� Padding$ 25,0,0,0q�6�   $��87��6�   $��Right=�6�   5o      5q      5r      