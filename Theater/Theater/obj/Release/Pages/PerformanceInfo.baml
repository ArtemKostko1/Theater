   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  #    Theater.Pages.PerformanceInfo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  PerformanceStagingInfo��.��� .+��  � ColumnDefinitions �� $	��200 ��� $��5 ��� $��* � � RowDefinitions �� $	��200 ��� $��5 ��� $��* �.+��� $��2��$��1��$	��1.5��$	��225��$��0q����	#FF6015FF#��["��� $��1��$��2��$	��410��$	��1.5��$��0q����	#FF6015FF#��["�� $	��200��$	��200��.+��� 
���   �$��2q� �� CornerRadius$ 35�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   	Direction$	 315Q�   Opacity$	 .25Q�   ShadowDepth$ 10Q�	   Color$	 Black��'  !MaterialDesignThemes.Wpf.PackIcon  $	��200��$	��200��$��0,00,0,0q�
�������
   Kind$
 Theater=�   $ 5Q�$	 315Q�$	 .25Q�$ 10Q�$	 Black��� $��0��$��2�� �� $��* ��� $��2* ��� $��* �.+�� $��0��$��40��$��40��$��15,0,0,0q�$
��Left=�.+��� ���	#FF3C3C3C$ 10���� -    ��Name$. (ButtonBackFromPerformanceStagingInfoPage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��40��$��25��$��Center=�$��Center=�
�������$
 	ArrowBack=��� $��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FFИнформация� $��0��$��40��$��40��$��0,0,15,0q�$��Right=�.+��� ���	#FF3C3C3C$ 10���� -   $ ButtonPerformanceEditing��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��25��$��25��$��Center=�$��Center=�
�������$
 Pencil=��� -    ��Name$" TextBlockPerformanceInfoName��$��1��$	��445��$��Center=�$��Center=�$��
Arial Bold)�$��30(�
���   � �� TextAlignment$ Center=�$
��Wrap=�� $��2��$��2�� �� $
��0.5* ��� $��* � �� $��* ��� $��* ��� $��* �.+��� $��0��$��0�� �� Padding$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial bold)�$��22(����	#FF6015FFРежиссёр�� -   $&  TextBlockPerformanceInfoDirector��$��0��$��1��$	��315��$ Right=�$
��Wrap=�$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��1��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial bold)�$��22(����	#FF6015FFПотановщик�� -   $) #TextBlockPerformanceInfoArtDirector��$��1��$��1��$ 0,0,15,0q�$	��315��$ Right=�$
��Wrap=�$��Right=�$��Center=�$��Arial)�$��22(��� $��2��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial bold)�$��22(����	#FF6015FFКостюмер�� -   $% TextBlockPerformanceInfoDresser��$��2��$��1��$ 0,0,15,0q�$	��315��$ Right=�$
��Wrap=�$��Right=�$��Center=�$��Arial)�$��22(�� $��2��$��0��$
��15,0q�.+��� $��Center=�.+��� $	��0,5q�.+��� $
��Left=�$��
Arial bold)�$��22(����	#FF6015FF$��Дата���� -   $" TextBlockPerformanceInfoDate��$��Right=�$��Arial)�$��20(��� $	��0,5q�.+��� $
��Left=�$��
Arial bold)�$��22(����	#FF6015FF$��
Время���� -   $" TextBlockPerformanceInfoTime��$��Right=�$��Arial)�$��20(��� $	��0,5q�.+��� $
��Left=�$��
Arial bold)�$��22(����	#FF6015FF$��
Место���� -	   $&  TextBlockPerformanceInfoLocation��$	��170��$ Right=�$
��Wrap=�$��Arial)�$��20(��� $	��0,5q�.+��� $
��Left=�$��
Arial bold)�$��22(����	#FF6015FF$��Цена���� -
   $# TextBlockPerformanceInfoPrice��$��Right=�$��Arial)�$��20(�