   M S B A M L   `   `   `  ����B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  5      $    Theater.Pages.PerformancesList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Theater.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  PerformancesStaging��5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    �� 5      $��40 �6    .+�5      �� $��0��5      $��Center=�5      $��Center=�5      $��
Arial bold)�5      $��34(�5      ���	#FF6015FF$��Постановки��5      � 5      $��1��6   .+�5      �� -   5         ��Name$ PerformancesListBox��5       $	��680��5!      $	��410��5"      ��.  $��Hidden=�5$      ��5&      �� 5'      .R�5(      � $	��680��6#   $��75��6/   .+�5)   "   �� 
������� �� CornerRadius$ 10��6<   � 5*   "    � ColumnDefinitions 5+   &   �� 5,   *   $��1.25* �6;   �� 5-   *   $
��0.5* �6;   �� 5.   *   $��* �6;   �� 5/   *   $
��0.5* �6;   .+�52   &   ��  ��Name$ TextBlockPerformanceName��53   )   $��0��54   )   $	��261��55   )    �� Padding$ 25,0,0,0q�56   )   $��Center=�57   )   $��Arial)�58   )   $��20(�59   )   
���   � �� TextAlignment$
 Left=�5;   )   $
��Wrap=�5<   )   ��5=   )   ��  �� Path$ PlayName��� 5>   &   $ TextBlockPerformanceDate��5?   )   $��1��5@   )   $��Center=�5A   )   $��Center=�5B   )   $��Arial)�5C   )   $��20(�5D   )   
���   ���5F   )   �� $ PerformanceDate��� 5G   &   $" TextBlockPerformanceLocation��5H   )   $��2��5I   )   $	��209��5J   )   $��Center=�5K   )   $��Arial)�5L   )   $��20(�5M   )   
���   �$ Center=�5P   )   $
��Wrap=�5Q   )   ��5O   )   �� $ PerformanceLocation�5Q   )   �� 5R   &   $ TextBlockPerformancePrice��5S   )   $��3��5T   )   $��Center=�5U   )   $��Center=�5V   )   $��Arial)�5W   )   $��20(�5X   )   
���   ���5Z   )   �� $ PerformancePrice�5[   #   5\      5]      ��5`      �� 5a      	 �� 
TargetType"	 ��6    .�5b      �� 
 �� Property
 � �� �� Value$ 0q�68   �� 5c      
 � ��$ 0,5,0,0q�67   �� 5d      
 � ��$ Center=�6D   �� 5e      
 � ��$ Stretch=�6K   �� 5f      
 � ��$ Center=�6I   �� 5g      
 � ��
 ���� 6;   �� 5h      
 � ��
 ���� 6<   �� 5i      
 � ��$ 0q�6@   -   5        �� 5k      
 � �� 5l   "   �� 5m   &    �� 
TargetType" ��66   .R�5n   *   � #��z��6/   .+�5o   .   ��  ��Name$ contentPresenter��5p   1   #��z��5q   1   #��z��5r   1   #��z��5s   1   #��z��5t   1   5u   +   5v   '   5x      5y      5{      5|      �� 5~      -   5         ��Name$" ButtonOpenNewPerformancePage��5      $��2��5�      $��40��5�      $��Center=�5�      ���	#FFFF4E4E$-��'Постановка спектакля��5�      ���#FFFF   ButtonCornerRadius10#��[  5�      5�      5�      5�      