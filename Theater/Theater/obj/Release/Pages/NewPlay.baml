   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.NewPlay   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  AddPerformance��.���  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+�� $��0��$��40��$��40��$
��Left=�.+��� ���	#FF3C3C3C �� CornerRadius$ 10���� -    ��Name$&  ButtonBackFromNewPerformancePage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��40��$��25��$��Center=�$��Center=�
�������   Kind$ 	ArrowBack=��� $��0��$��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FF$-��'Добавление спектакля��� $��1��$	��450��$	��350�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��Center=�.+��� $��Arial)�$��22(����	#FF6015FF$��Название���� -    ��Name$ TextBoxNewPlayName��$��30��$��Arial)�$��18(�
���   � �� TextAlignment$ Center=��� $��1��$��Center=�.+��� $��Arial)�$��22(����	#FF6015FF$��
Автор���� -   $ TextBoxNewPlayAuthor��$��30��$��Arial)�$��18(�
���   �$ Center=��� $��2��$��Center=�.+��� $��Arial)�$��22(����	#FF6015FF$��Жанр���� -    ��Name$ ComboBoxNewPlayGenre��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(�����  �� Path$ 	GenreName��� $��3��$��Center=�.+��� $��Arial)�$��22(����	#FF6015FF$��Возраст���� -   $% ComboBoxNewPlayParentalGuidance��$��25��$��0q�
������ $��16(����� .R��� $��Arial)�$��16(����� $ ParentalGuidanceValue��� $��4��$��Center=�.+��� $��Arial)�$��22(����	#FF6015FF$��Примьера���� -   $ TextBoxNewPlayPremiere��$��30��$��Arial)�$��18(�
���   �$ Center=�� $��2��$	��150��$��40��$��Right=�.+��� -   $ ButtonSaveNewPlay�����	#FFFF4E4E$��Сохранить��
�������   ButtonCornerRadius10#��[  �� -   	 ��Name$	 TextBlockNewPlayError��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(�
���  ��
 �� TextAlignment$
 Center=�$
��Wrap=��� -	   $	 TextBlockNewPlayOk��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(����	#FF00DA00$
 Center=�$
��Wrap=�