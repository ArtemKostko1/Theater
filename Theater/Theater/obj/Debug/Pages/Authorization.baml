   M S B A M L   `   `   `  ����B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  5      !    Theater.Pages.Authorization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Theater.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  Authorization��5       N� 
Background
 �   �.��5      � ��5   
   �� 5         AuthorizationBackground �� ImageSource# [  6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��80 �6   .+�5   
   � -   5         �Name$ GridSignInAdmin��5      $��1��5      $��1��5       $	��425��5!      $y�Visible=�5"      .+�5$      �� 
������� �� CornerRadius$ 50��5&       J� Opacity$	 0.9Q�5'      � 5)       5*      �� 5+      $��50 �6$   �� 5,      $��* �6$   �� 5-      $��50 �6$   .+�50      �� $��0��51      $��Center=�52      $��
Arial bold)�53      $��34(�54      
�������Администратор57      � 59      $��1��6    5:      �� 5;      $��50 �6(   �� 5<      $��* �6(   �� 5=      $��* �6(   �� 5>      $��40 �6(   �� 5?      $��40 �6(   .+�5B      �� $��1��5C      $	��350��5D      $��Center=�5E      .+�5G      �� $��Arial)�6$   $��22(�67   
Логин5I      �� 5J      -   5         ��Name$ TextBoxSignInAdminLogin��5K      $��30��5L      $��Arial)�5M      $��18(�5N      5O      �� 5P      $��2��5Q      $	��350��5R      $��Center=�5S      .+�5U      �� $��Arial)�6$   $��22(�67   Пароль5W      G� 5X      -   5        	 G�Name$$	 PasswordBoxSignInAdminPassword��5Y      $��30��5Z      $��Arial)�5[      $��18(�5\      5]      �� 5_      -   5        
 ��Name$
 ButtonSignInAdmin��5`      $��3��5a      $	��150��5b      $��
Войти��5d      $��Arial)�5e      $��18(�5f      �� 5h      -   5         ��Name$ TextBlockAdminError��5i      $��4��5j      $��Center=�5k      $��Center=�5l      $��Arial)�5m      $��16(�5n      
���  ��5o      5p      5q      5r      5s      5t      