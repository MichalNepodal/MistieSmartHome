   M S B A M L   `   `   `  ����E  AMistie_v_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Mistie_v_3.FrontEnd.Pages.HomeMistie_v_3.FrontEnd.Pages.Home  5      .    (Mistie_v_3.FrontEnd.Pages.Home.HomePage1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Mistie_v_3.FrontEnd.Pages.Home     5        N� Title$  	HomePage1��5	       � 	Resources 5         SomeButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType��%�   &	        �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5      5      5      5      5      .��5      � $��40,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $	��465 �6   �� 5      $	��465 �6    � RowDefinitions 5   
   �� 5       $	��73* �6   �� 5!      $	��35* �6   �� 5"      $	��34* �6   .+�5%   
   �� $��0��6   $��0��6%   $��Bottom=�62   $
��Left=�6M   $	��254��6h   $	��376��6u   $��52,0,0,0q�6�   ��5&      �� 5'       �� ImageSource$A ;/Mistie_v_3;component/Pictures/Icons/teplotaUvnitrIcon1.png��6   	 j� Stretch$	 Uniform=�6g   
 �� Opacity$	
 0.2Q�6y    j� Viewbox$ 0,-0.07,1,1.2�6�   .+�5*      �� -   5         ��Name$ teplotaINTextBlock��5*      $
��Wrap=�64   $��Century Gothic)�6H    �� Padding$ 	55,55,0,0q�6d   $��0,0,0,10q�6x   $	��110(�6�   $	��378��6�   $	��244��6�   ���	#E5FFFFFF$
��Bold"�6�   $��Bottom=�6�   $��Right=�6�   $��21 °C ��6  ��5+      �� 5,      $B </Mistie_v_3;component/Pictures/BackGround/teplotaPozadi1.png��6!   5.      5/      �� 52   
   $��1��6   $��0��6%   $��Bottom=�62   $��Right=�6M   $	��254��6i   $	��379��6v    �� Orientation$ 
Horizontal=�6�   $��0,0,50,0q�6�   ��53      �� 54      $@ :/Mistie_v_3;component/Pictures/Icons/teplotaVenkuIcon1.png��6   $	
 0.2Q�6f   $	 Uniform=�6t   $ 0,-0.06,1,1.15�6�   .+�57      �� -   5        $ teplotaOUTTextBlock��57      $
��Wrap=�65   $��Century Gothic)�6I   $��0,0,0,10q�6e   $ 0,55,0,0q�6w   $	��110(�6�   $	��378��6�   $	��244��6�   ���	#E5FFFFFF$
��Bold"�6�   $��Center=�6�   $��Center=�6�   $�� -5 °C��6  ��58      �� 59      $B </Mistie_v_3;component/Pictures/BackGround/teplotaPozadi1.png��6!   5;      5=      �� 5?   
   $��0��6   $��1��6%   $ 
Horizontal=�62   $
��Left=�6K   $��Bottom=�6f   $	��175��6�   $	��430��6�   .+�5@      �� -   5         ��Name$ kolekceButton��5@      #��[  6,   $�� ��6U   $
��Left=�6`   $��	50,0,0,10q�6{   $��Arial)�6�   $��65(�6�   $	��165��6�   $	��165��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5A      �� 5B      $D >/Mistie_v_3;component/Pictures/Buttons/Small/kolekceSmall1.png��6!   $	 UniformToFill=�6n   5D      �� 5E      -   5        $ svetlaButton��5E      #��[  6+   $�� ��6T   $��Right=�6_   $��	50,0,0,10q�6{   $��Arial)�6�   $��65(�6�   $	��165��6�   $	��165��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5F      �� 5G      $C =/Mistie_v_3;component/Pictures/Buttons/Small/svetlaSmall1.png��6!   $	 UniformToFill=�6m   5I      5J      �� 5L   
   $��1��6   $��1��6%   $ 
Horizontal=�62   $��Right=�6K   $��Bottom=�6g   $	��175��6�   $	��430��6�   .+�5M      �� -   5        $ hudbaButton��5M      #��[  6*   $�� ��6S   $
��Left=�6^   $��	0,0,50,10q�6y   $��Arial)�6�   $��65(�6�   $	��165��6�   $	��165��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5N      �� 5O      $D >/Mistie_v_3;component/Pictures/Buttons/Small/prehratSmall1.png��6!   $	 UniformToFill=�6n   5Q      �� 5R      -   5        $ youtubeButton��5R      #��[  6,   $�� ��6U   $��Right=�6`   $��	0,0,50,10q�6|   $��Arial)�6�   $��65(�6�   $	��165��6�   $	��165��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5S      �� 5T      $D >/Mistie_v_3;component/Pictures/Buttons/Small/youtubeSmall1.png��6!   $	 UniformToFill=�6n   5V      5W      �� 5Y   
   $��0��6   $��2��6%   $��Bottom=�62   $	��170��6M   .+�5Z      �� -   5        $ spanekButton��5Z      #��[  6+   $�� ��6T   $
��Left=�6_   $��	50,0,0,20q�6z   $��Arial)�6�   $��65(�6�   $	��377��6�   $	��150��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5[      �� 5\      $? 9/Mistie_v_3;component/Pictures/Buttons/Big/spanekBig1.PNG��6!   $	 UniformToFill=�6i   5^      5_      �� 5a   
   $��1��6   $��2��6%   $��Bottom=�62   $��Right=�6M   $	��170��6i   $	��428��6v   .+�5b      �� -   5        $ odchodButton��5b      #��[  6+   $�� ��6T   $��Right=�6_   $��	0,0,50,20q�6{   $��Arial)�6�   $��65(�6�   $	��377��6�   $	��150��6�   ���	#E5FFFFFF$
��Bold"�6�   ��6�   Z� ��5c      �� 5d      $? 9/Mistie_v_3;component/Pictures/Buttons/Big/odchodBig1.PNG��6!   $	 UniformToFill=�6i   5f      5g      5m      5n      