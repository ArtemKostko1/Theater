   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.NewUser   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  NewUser�� � DataContext ��  �� RelativeSource �� *Self+.���  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+�� $��0��$��40��$��40��$
��Left=�.+��� ���	#FF3C3C3C �� CornerRadius$ 10���� -    ��Name$ ButtonBackFromNewUserPage��$��40��$��40��$��0q�$��0q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��40��$��25��$��Center=�$��Center=����#FFFF   Kind$ 	ArrowBack=��� $��0��$��Center=�$��Center=�$��
Arial Bold)�$��34(����	#FF6015FF$)��#Новый пользователь��� $��1�� �� $��* ��� $��5 ��� $
��1.5* ��� $��5 ��� $��* �.+��� $��1��$��0��$	��550��$	��1.5��$��0q�$��Center=�$��Center=����	#FF6015FF#��["��� $��3��$��0��$	��550��$	��1.5��$��0q�$��Center=�$��Center=����	#FF6015FF#��["�� $��0�� � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��$��Center=�.+��� $��0,0,15,0q�$��
Arial Bold)�$��22(����	#FF6015FF �� TextAlignment$
 Left=�	Ф.И.О.�� -   	 ��Name$	 TextBoxNewUserFIO��$	��325��$��30��$
��Left=�$��Arial)�$��18(��� $��1��$��Center=�.+��� $��15,0,0,0q�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Профессия�� -   
 ��Name$
 ComboBoxNewUserProfession��$	��325��$��25��$��0q�$��Right=�
������ $��16(����� .R��� $��Arial)�$��16(�����  �� Path$ ProfessionName�� $��2�� �� $��* ��� $��* �.+��� $��Center=�.+�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Дата рождения�� -   $	 TextBoxNewUserDOB��$��1��$	��155��$��30��$
��Left=�$��Center=�$��Arial)�$��18(� �� TextAlignment$ Center=�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Пол�� -   $	 TextBoxNewUserSex��$��1��$	��155��$��30��$
��Left=�$��Center=�$��Arial)�$��18(�$ Center=�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�
Рост�� -   $	 TextBoxNewUserHight��$��1��$	��155��$��30��$
��Left=�$��Center=�$��Arial)�$��18(�$ Center=��� $��2��$��1��$��Center=�.+�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��15,0,0,0q�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Стаж работы�� -   $	 TextBoxNewUserExperience��$��1��$	��155��$��30��$��Right=�$��Center=�$��Arial)�$��20(�$ Center=�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��15,0,0,0q�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Средняя з\п�� -   $	 TextBoxNewUserSalary��$��1��$	��155��$��30��$��Right=�$��Center=�$��Arial)�$��18(�$ Center=�� $	��0,5q� �� $��* ��� $��* �.+��� $��0��$��15,0,0,0q�$��Center=�$��
Arial Bold)�$��22(����	#FF6015FF$
 Left=�Кол-во детей�� -	   $	 TextBoxNewUserChildrens��$��1��$	��155��$��30��$��Right=�$��Center=�$��Arial)�$��18(�$ Center=��� $��4��$��Center=�.+��� $��
Arial Bold)�$��22(����	#FF6015FF$��Награды��$
 Left=��� -
   $	 TextBoxNewUserAwards��$	��680��$��30��$��Arial)�$��18(�$
 Left=�� $��2��$	��150��$��40��$��Right=�$��Center=�.+��� -   $ ButtonSaveNewUser�����	#FFFF4E4E$��Сохранить�����#FFFF   ButtonCornerRadius10#��[  �� -    ��Name$ TextBlockNewUserError��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(�
���  ��$ Center=�$
��Wrap=��� -   $ TextBlockUserEditOk��$��2��$	��350��$��Center=�$��Center=�$��Arial)�$��14(����	#FF5DFF00$ Center=�$
��Wrap=�