   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  &     Theater.Pages.PerformanceEditing   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  'localclr-namespace:Theater.Pages    N� Title$  PerformanceEditing��.���  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+�� $��0��$��40��$��40��$
��Left=�.+��� ���	#FF3C3C3C �� CornerRadius$ 10���� -    ��Name$* $ButtonBackFromPerformanceEditingPage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��40��$��25��$��Center=�$��Center=�
�������   Kind$ 	ArrowBack=��� $��Center=�$��
Arial Bold)�$��34(����	#FF6015FF$7��1Редактирование постановки��� $��1�� � ColumnDefinitions �� $��* ��� $��5 ��� $��* �.+��� $��1��$��1��$	��400��$��0q����	#FF6015FF#��["�� $��0��$
��15,0q� �� $��* ��� $��5 ��� $��3* �.+��� $��1��$	��250��$	��1.5��$��0q����	#FF6015FF#��["��� $��0��$��Center=�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Спектакль���� -    ��Name$$ ComboBoxPerformancePlayEditing��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(�����  �� Path$ PlayName��� $��2��$��Center=�.+��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Режиссёр���� -   $( "ComboBoxPerformanceDirectorEditing��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Постановщик���� -   $+ %ComboBoxPerformanceArtDirectorEditing��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO��� $
��0,25q�.+��� $��
Arial bold)�$��22(����	#FF6015FF$��Костюмер���� -   $' !ComboBoxPerformanceDresserEditing��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ UserFIO�� $��2��$
��15,0q� �� $��3* ��� $��5 ��� $��* �.+��� $��1��$	��250��$��1��$��0q����	#FF6015FF#��["�� $��0��$��Center=� �� $	��100 ��� $	��100 ��� $	��100 � �� $��* ��� $
��1.5* �.+��� $��0��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��Дата���� $��1��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��
Время���� $��2��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��
Место���� -    ��Name$# TextBoxPerformanceTimeEditing��$��1��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �	 �� TextAlignment$	 Center=��� -   $# TextBoxPerformanceDateEditing��$��0��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=��� -   $' !TextBoxPerformanceLocationEditing��$��2��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=�� $��2��$��Center=� �� $��* ��� $
��1.5* �.+��� $��0��$��0��$��Center=�$��
Arial bold)�$��22(����	#FF6015FF$��Цена���� -	   $$ TextBoxPerformancePriceEditing��$��1��$��1��$��30��$��Center=�$��Arial)�$��18(�
���   �$	 Center=�� $��2��$	��150��$��40��$��Right=�$��Center=�.+��� -
   $" ButtonSavePerformanceEditing�����	#FFFF4E4E$��Сохранить��
�������   ButtonCornerRadius10#��[  �� -   
 ��Name$&
  TextBlockPerformanceEditingError��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(�
���  �� �� TextAlignment$ Center=�$
��Wrap=��� -   $#
 TextBlockPerformanceEditingOk��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��16(����	#FF5DFF00$ Center=�$
��Wrap=�