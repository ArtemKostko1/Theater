   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.UsersList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006    N� Title$  Users��.��� .+��  � RowDefinitions �� $��40 ��� $��* ��� $��40 �.+��� $��0��$��Center=�$��Center=�$��
Arial bold)�$��34(����	#FF6015FF$��Пользователи��� $��1��.+��� -    ��Name$ UsersListBox��$	��680��$	��410����.  $��Hidden=����� .R�� $	��680��$��75��.+��� 
������� �� CornerRadius$ 10���  � ColumnDefinitions �� $
��2.5* ��� $��* �.+���  ��Name$ TextBlockUserName��$��0��$	��485�� �� Padding$ 25,0,0,0q�$��Center=�$��Arial)�$��20(�
���   � �� TextAlignment$
 Left=�$
��Wrap=�����  �� Path$ UserFIO��� $ TextBlockUserProfession��$��1��$	��190��$��Center=�$��Center=�$��Arial)�$��20(�
���   �$ Center=�$
��Wrap=����� $ ProfessionName����� 	 �� 
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
TargetType" ��.R�� #��z��.+���  ��Name$ contentPresenter��#��z��#��z��#��z��#��z���� -    ��Name$ ButtonOpenNewUserPage��$��2��$��40��$��Center=����	#FFFF4E4E$-��'Создать пользователя�����#FFFF   ButtonCornerRadius10#��[  