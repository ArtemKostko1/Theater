   M S B A M L   `   `   `  ����B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TheaterTheater  5          Theater.Pages.PlaysList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Theater     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  Performances��5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    �� 5      $��40 �6    .+�5      �� $��0��5      $��Center=�5      $��Center=�5      $��
Arial bold)�5      $��34(�5      ���	#FF6015FF$��Спектакли��5      � 5      $��1��6   .+�5      �� -   5         ��Name$ PlaysListBox��5       $	��680��5!      $	��410��5"      ��.  $��Hidden=�5$      ��5&      �� 5'      .R�5(      � $	��680��6#   $��75��6/   .+�5)   "   �� 
������� �� CornerRadius$ 10��6<   � 5*   "    � ColumnDefinitions 5+   &   �� 5,   *   $��* �6;   �� 5-   *   $
��0.5* �6;   �� 5.   *   $
��0.2* �6;   .+�50   &   ��  ��Name$ TextBlockPlayName��51   )   $��0��52   )   $	��400��53   )    �� Padding$ 25,0,0,0q�54   )   $��Center=�55   )   $��Arial)�56   )   $��20(�57   )   
���   � �� TextAlignment$
 Left=�59   )   $
��Wrap=�5:   )   ��5;   )   ��  �� Path$ PlayName��� 5<   &   $ TextBlockPlayGenre��5=   )   $��1��5>   )   $	��200��5?   )   $��Center=�5@   )   $��Center=�5A   )   $��Arial)�5B   )   $��20(�5C   )   
���   �$ Center=�5E   )   $
��Wrap=�5F   )   ��5G   )   �� $ 	GenreName��� 5H   &   $# TextBlockPlayParentalGuidance��5I   )   $��2��5J   )   $��80��5K   )   $��Center=�5L   )   $��Center=�5M   )   $��Arial)�5N   )   $��20(�5O   )   
���   �$ Center=�5Q   )   $
��Wrap=�5R   )   ��5S   )   �� $ ParentalGuidanceValue�5T   #   5U      5V      ��5X      �� 5Y      	 �� 
TargetType"	 ��6    .�5Z      �� 
 �� Property
 � �� �� Value$ 0q�68   �� 5[      
 � ��$ 0,5,0,0q�67   �� 5\      
 � ��$ Center=�6D   �� 5]      
 � ��$ Stretch=�6K   �� 5^      
 � ��$ Center=�6I   �� 5_      
 � ��
 ���� 6;   �� 5`      
 � ��
 ���� 6<   �� 5a      
 � ��$ 0q�6@   -   5        �� 5c      
 � �� 5d   "   �� 5e   &    �� 
TargetType" ��66   .R�5f   *   � #��z��6/   .+�5g   .   ��  ��Name$ ItemOpenPlayInfoPage��5h   1   #��z��5i   1   #��z��5j   1   #��z��5k   1   #��z��5l   1   5m   +   5n   '   5p      5q      5s      5t      �� 5v      -   5         ��Name$" ButtonOpenNewPerformancePage��5w      $��2��5x      $��40��5y      $��Center=�5z      ���	#FFFF4E4E$)��#Добавить спектакль��5}      ���#FFFF   ButtonCornerRadius10#��[  5      5�      5�      5�      