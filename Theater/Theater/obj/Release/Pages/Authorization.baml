   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  !    Theater.Pages.Authorization   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       N� Title$  Authorization�� N� 
Background
 �   �.��� ����    AuthorizationBackground �� ImageSource# [   � ColumnDefinitions �� $��* ��� $
��1.5* � � RowDefinitions �� $��80 ��� $��* ��� $��80 �.+�� -    �Name$ GridSignInAdmin��$��1��$��1��$	��425��$y�Visible=�.+��� 
������� �� CornerRadius$ 50�� J� Opacity$	 0.9Q��  �� $��50 ��� $��* ��� $��50 �.+��� $��0��$��Center=�$��
Arial bold)�$��34(�
�������Администратор� $��1�� �� $��50 ��� $��* ��� $��* ��� $��40 ��� $��40 �.+��� $��1��$	��350��$��Center=�.+��� $��Arial)�$��22(�
Логин�� -    ��Name$ TextBoxSignInAdminLogin��$��30��$��Arial)�$��18(��� $��2��$	��350��$��Center=�.+��� $��Arial)�$��22(�ПарольG� -   	 G�Name$$	 PasswordBoxSignInAdminPassword��$��30��$��Arial)�$��18(��� -   
 ��Name$
 ButtonSignInAdmin��$��3��$	��150��$��
Войти��$��Arial)�$��18(��� -    ��Name$ TextBlockAdminError��$��4��$��Center=�$��Center=�$��Arial)�$��16(�
���  ��