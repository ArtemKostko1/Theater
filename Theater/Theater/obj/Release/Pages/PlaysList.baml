   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TheaterTheater      Theater.Pages.PlaysList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Theater     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       N� Title$  Performances��.��� .+��  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+��� $��0��$��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FF$��Спектакли��� $��1��.+��� -    ��Name$ PlaysListBox��$	��680��$	��410����.  $��Hidden=����� .R�� $	��680��$��75��.+��� 
������� �� CornerRadius$ 10���  � ColumnDefinitions �� $��* ��� $
��0.5* ��� $
��0.2* �.+���  ��Name$ TextBlockPlayName��$��0��$	��400�� �� Padding$ 25,0,0,0q�$��Center=�$��Arial)�$��20(�
���   � �� TextAlignment$
 Left=�$
��Wrap=�����  �� Path$ PlayName��� $ TextBlockPlayGenre��$��1��$	��200��$��Center=�$��Center=�$��Arial)�$��20(�
���   �$ Center=�$
��Wrap=����� $ 	GenreName��� $# TextBlockPlayParentalGuidance��$��2��$��80��$��Center=�$��Center=�$��Arial)�$��20(�
���   �$ Center=�$
��Wrap=����� $ ParentalGuidanceValue����� 	 �� 
TargetType"	 ��.��� 
 �� Property
 � �� �� Value$ 0q��� 
 � ��$ 0,5,0,0q��� 
 � ��$ Center=��� 
 � ��$ Stretch=��� 
 � ��$ Center=��� 
 � ��
 ���� �� 
 � ��
 ���� �� 
 � ��$ 0q�-   �� 
 � �� ��  �� 
TargetType" ��.R�� #��z��.+���  ��Name$ ItemOpenPlayInfoPage��#��z��#��z��#��z��#��z���� -    ��Name$" ButtonOpenNewPerformancePage��$��2��$��40��$��Center=����	#FFFF4E4E$)��#Добавить спектакль�����#FFFF   ButtonCornerRadius10#��[  