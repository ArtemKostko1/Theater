   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  "    Theater.Pages.NewPerformance   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  PerformanceStaging��.���  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+�� $��0��$��40��$��40��$
��Left=�.+��� ���	#FF3C3C3C �� CornerRadius$ 10���� -    ��Name$* $ButtonBackFromPerformanceEditingPage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��40��$��25��$��Center=�$��Center=�
�������   Kind$ 	ArrowBack=��� $��Center=�$��
Arial Bold)�$��34(����	#FF6015FF$-��'Постановка спектакля��� $��1�� � ColumnDefinitions �� $��* ��� $��5 ��� $��* �.+��� $��1��$��1��$	��400��$��0q����	#FF6015FF#��["�� $��0��$
��15,0q� �� $��* ��� $��5 ��� $��3* �.+��� $��1��$	��250��$	��1.5��$��0q����	#FF6015FF#��["��� $��0��$��Center=�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Спектакль���� -    ��Name$  ComboBoxNewPerformancePlay��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(�����  �� Path$ PlayName��� $��2��$��Center=�.+��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Режиссёр���� -   $$ ComboBoxNewPerformanceDirector��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Постановщик���� -   $' !ComboBoxNewPerformanceArtDirector��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Костюмер���� -   $# ComboBoxNewPerformanceDresser��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO�� $��2��$
��15,0q� �� $��3* ��� $��5 ��� $��* �.+��� $��1��$	��250��$��1��$��0q����	#FF6015FF#��["�� $��0��$��Center=� �� $	��100 ��� $	��100 ��� $	��100 � �� $��* ��� $
��1.5* �.+��� $��0��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��Дата���� $��1��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��
Время���� $��2��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��
Место���� -    ��Name$ TextBoxNewPerformanceTime��$��1��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �	 �� TextAlignment$	 Center=��� -   $ TextBoxNewPerformanceDate��$��0��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=��� -   $# TextBoxNewPerformanceLocation��$��2��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=�� $��2��$��Center=� �� $��* ��� $
��1.5* �.+��� $��0��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��Цена���� -	   $  TextBoxNewPerformancePrice��$��1��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=�� $��2��$	��150��$��40��$��Right=�$��Center=�.+��� -
   $ ButtonSaveNewPerformance�����	#FFFF4E4E$��Сохранить��
�������   ButtonCornerRadius10#��[  �� -   
 ��Name$"
 TextBlockNewPerformanceError��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(�
���  �� �� TextAlignment$ Center=�$
��Wrap=��� -   $
 TextBlockNewPerformanceOk��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��16(����	#FF5DFF00$ Center=�$
��Wrap=�