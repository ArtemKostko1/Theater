   M S B A M L   `   `   `  ����B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  5          Theater.Pages.UsersList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Theater.Pages     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        N� Title$  Users��5	      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    �� 5      $��40 �6    .+�5      �� $��0��5      $��Center=�5      $��Center=�5      $��
Arial bold)�5      $��34(�5      ���	#FF6015FF$��Пользователи��5      � 5      $��1��6   .+�5       �� -   5         ��Name$ UsersListBox��5!      $	��680��5"      $	��410��5#      ��.  $��Hidden=�5%      ��5'      �� 5(      .R�5)      � $	��680��6#   $��75��6/   .+�5*   "   �� 
������� �� CornerRadius$ 10��6<   � 5+   "    � ColumnDefinitions 5,   &   �� 5-   *   $
��2.5* �6;   �� 5.   *   $��* �6;   .+�50   &   ��  ��Name$ TextBlockUserName��51   )   $��0��52   )   $	��485��53   )    �� Padding$ 25,0,0,0q�54   )   $��Center=�55   )   $��Arial)�56   )   $��20(�57   )   
���   � �� TextAlignment$
 Left=�5:   )   $
��Wrap=�5;   )   ��59   )   ��  �� Path$ UserFIO�5;   )   �� 5<   &   $ TextBlockUserProfession��5=   )   $��1��5>   )   $	��190��5?   )   $��Center=�5@   )   $��Center=�5A   )   $��Arial)�5B   )   $��20(�5C   )   
���   �$ Center=�5F   )   $
��Wrap=�5G   )   ��5E   )   �� $ ProfessionName�5G   )   5H   #   5I      5J      ��5M      �� 5N      	 �� 
TargetType"	 ��6    .�5O      �� 
 �� Property
 � �� �� Value$ 0q�68   �� 5P      
 � ��$ 0,5,0,0q�67   �� 5Q      
 � ��$ Center=�6D   �� 5R      
 � ��$ Stretch=�6K   �� 5S      
 � ��$ Center=�6I   �� 5T      
 � ��
 ���� 6;   �� 5U      
 � ��
 ���� 6<   �� 5V      
 � ��$ 0q�6@   -   5        �� 5X      
 � �� 5Y   "   �� 5Z   &    �� 
TargetType" ��66   .R�5[   *   � #��z��6/   .+�5\   .   ��  ��Name$ contentPresenter��5]   1   #��z��5^   1   #��z��5_   1   #��z��5`   1   #��z��5a   1   5b   +   5d   '   5f      5g      5i      5j      �� 5l      -   5         ��Name$ ButtonOpenNewUserPage��5m      $��2��5n      $��40��5o      $��Center=�5p      ���	#FFFF4E4E$-��'Создать пользователя��5s      ���#FFFF   ButtonCornerRadius10#��[  5u      5v      5w      5x      