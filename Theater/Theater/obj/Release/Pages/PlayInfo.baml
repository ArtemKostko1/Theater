   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.PlayInfo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  PerformanceInfo��.��� .+��  � ColumnDefinitions �� $��* � � RowDefinitions �� $	��200 ��� $��25 ��� $��* �.+��� $��1��$��2��$	��550��$	��1.5��$��0q�$��Center=����	#FF6015FF#��["�� $��0�� �� $	��200 ��� $��* �.+�� $��0��$	��200��$	��200��.+��� 
���   �$��2q� �� CornerRadius$ 35�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   	Direction$	 315Q�   Opacity$	 .25Q�   ShadowDepth$ 10Q�	   Color$	 Black��'  !MaterialDesignThemes.Wpf.PackIcon  $	��200��$	��200��
�������
   Kind$
 Theaters=�   $ 5Q�$	 315Q�$	 .25Q�$ 10Q�$	 Black��� $��1�� �� $��* ��� $��2* ��� $��* �.+�� $��0��$��40��$��40��$��15,0,0,0q�$
��Left=�.+��� ���	#FF3C3C3C$ 10���� -    ��Name$' !ButtonBackFromPerformanceInfoPage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��40��$��25��$��Center=�$��Center=�
�������$
 	ArrowBack=��� $��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FFИнформация� $��0��$��40��$��40��$��Right=�.+��� ���	#FF3C3C3C$ 10���� -   $ ButtonPlayEdit��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��25��$��25��$��Center=�$��Center=�
�������$
 Pencil=��� -    ��Name$ TextBlockPlayInfoName��$��1��$	��450��$��Center=�$��Center=�$��
Arial Bold)�$��30(�
���   � �� TextAlignment$ Center=�$
��Wrap=�� $��2��$��2�� �� $��0.25* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��0�� �� Padding$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF
Автор�� -   $ TextBlockPlayInfoAuthor��$��0��$��1��$	��500��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(�$ Right=�$
��Wrap=��� $��1��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF
Жанр�� -   $ TextBlockPlayInfoGenre��$��1��$��1��$	��235��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(�$ Right=�$
��Wrap=��� $��2��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFВозраст�� -   $' !TextBlockPlayInfoParentalGuidance��$��2��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��3��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFПримьера�� -   $ TextBlockPlayInfoPremiere��$��3��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(�