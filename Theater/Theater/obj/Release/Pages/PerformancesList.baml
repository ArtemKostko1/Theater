   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  $    Theater.Pages.PerformancesList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       N� Title$  PerformancesStaging��.��� .+��  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+��� $��0��$��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FF$��Постановки��� $��1��.+��� -    ��Name$ PerformancesListBox��$	��680��$	��410����.  $��Hidden=����� .R�� $	��680��$��75��.+��� 
������� �� CornerRadius$ 10���  � ColumnDefinitions �� $��1.25* ��� $
��0.5* ��� $��* ��� $
��0.5* �.+���  ��Name$ TextBlockPerformanceName��$��0��$	��261�� �� Padding$ 25,0,0,0q�$��Center=�$��Arial)�$��20(�
���   � �� TextAlignment$
 Left=�$
��Wrap=�����  �� Path$ PlayName��� $ TextBlockPerformanceDate��$��1��$��Center=�$��Center=�$��Arial)�$��20(�
���   ����� $ PerformanceDate��� $" TextBlockPerformanceLocation��$��2��$	��209��$��Center=�$��Arial)�$��20(�
���   �$ Center=�$
��Wrap=����� $ PerformanceLocation��� $ TextBlockPerformancePrice��$��3��$��Center=�$��Center=�$��Arial)�$��20(�
���   ����� $ PerformancePrice����� 	 �� 
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
TargetType" ��.R�� #��z��.+���  ��Name$ contentPresenter��#��z��#��z��#��z��#��z���� -    ��Name$" ButtonOpenNewPerformancePage��$��2��$��40��$��Center=����	#FFFF4E4E$-��'Постановка спектакля�����#FFFF   ButtonCornerRadius10#��[  