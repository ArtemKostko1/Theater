   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.UserProfile   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  UserProfile��.��� .+��  � ColumnDefinitions �� $	��200 ��� $��5 ��� $��* � � RowDefinitions �� $	��200 ��� $��5 ��� $
��151* �.+��� $��2��$��1��$	��1.5��$	��225��$��0q����	#FF6015FF#��["��� $��1��$��2��$	��410��$	��1.5��$��0q����	#FF6015FF#��["�� $	��200��$	��200��.+��� 
���   �$��2q� �� CornerRadius$ 35�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   	Direction$	 315Q�   Opacity$	 .25Q�   ShadowDepth$ 10Q�	   Color$	 Black��'  !MaterialDesignThemes.Wpf.PackIcon  $	��200��$	��200��
�������
   Kind$

 User=�   $ 5Q�$	 315Q�$	 .25Q�$ 10Q�$	 Black��� $��0��$��2�� �� $��50 ��� $��2* ��� $��50 �.+�� $��0��$��40��$��40��$��15,0,0,0q�$
��Left=�.+��� ���	#FF3C3C3C$ 10���� -    ��Name$# ButtonBackFromUserProfilePage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��40��$��25��$��Center=�$��Center=����#FFFF$
 	ArrowBack=��� $��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FFПрофиль� $��0��$��40��$��40��$��0,0,15,0q�$��Right=�.+��� ���	#FF3C3C3C$ 10���� -   $ ButtonEditUser��$��40��$��40��$��0q�$��0q���Z� ��Z� .��  $��25��$��25��$��Center=�$��Center=����#FFFF$
 Pencil=��� -    ��Name$ TextBlockUserProfileName��$��1��$	��445��$��Center=�$��Center=�$��
Arial Bold)�$��30(�
���   � �� TextAlignment$ Center=�$
��Wrap=��� -   $$ TextBlockUserProfileProfession��$��2��$��0��$��Center=�$��Center=�$��
Arial Bold)�$��22(�� $��2��$��2�� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��0�� �� Padding$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFДата рождения�� -   $ TextBlockUserProfileDOB��$��0��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��1��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFПол�� -   $ TextBlockUserProfileSex��$��1��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��2��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF
Рост�� -   $  TextBlockUserProfileHeight��$��2��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��3��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFСтаж работы�� -   $$ TextBlockUserProfileExperience��$��3��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��4��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFСредняя з\п�� -	   $  TextBlockUserProfileSalary��$��4��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(��� $��5��$��0��$ 15,0,0,0q�$
��Left=�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FFКол-во детей�� -
   $$ TextBlockUserProfileСhildrens��$��6��$��1��$ 0,0,15,0q�$��Right=�$��Center=�$��Arial)�$��22(�� $��2��$��0��.+��  �� $��30 ��� $��* �.+��� $��0��$��Center=�$��Center=�$��
Arial Bold)�$��26(����	#FF6015FFНаграды�� -   $  TextBlockUserProfileAwards��$��1��$	��200��$��0,0,0,30q�$��Center=�$��Arial)�$��18(�
���   �$ Center=�$
��Wrap=�