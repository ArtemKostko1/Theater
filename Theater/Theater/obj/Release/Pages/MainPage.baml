   M S B A M L   `   `   `  ���� B  >Theater, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Theater.PagesTheater.Pages  -clr-namespace:Theater.PagesTheater.Pages      Theater.Pages.MainPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:Theater.Pages     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  #pclr-namespace:Theater.Pages    N� Title$  MainPage�� N� 
Background
 ����� � 	Resources    MenuOpen �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose  SupportOpen  SupportClose   Theater.Pages.ClearPage  
InMainPage��%�  &	        &	 q     &	 �     &	 U    &	 �    �� .��U� $ GridMenu��$ (FrameworkElement.Width)�.\�  $ 0��$ 60Q�  $ 0:0:0.5��$	 200Q��� .��U� $ GridMenu��$ (FrameworkElement.Width)�.\�  $ 0��$	 200Q�  $ 0:0:0.5��$ 60Q��� .��U� $ GridSupport��$ (FrameworkElement.Width)�.\�  $ 0��$ 0Q�  $ 0:0:0.5��$	 200Q��� .��U� $ GridSupport��$ (FrameworkElement.Width)�.\�  $ 0��$	 200Q�  $ 0:0:0.5��$ 0Q�   � Triggers :�  :� RoutedEvent$ ButtonBase.Click��	 :� 
SourceName$	 ButtonOpenMenu��.[��� #��[  :� $ ButtonBase.Click��$	 ButtonCloseMenu��.[��� #��[ :� $ ButtonBase.Click��$	 ButtonOpenSupport��.[��� #��[ :� $ ButtonBase.Click��$	 ButtonCloseSupport��.[��� #��[ .��� ����   MainPageBackground
 �� ImageSource#
 [ .+�� $	��770��$	��515��.+��� 
������� �� CornerRadius$ 50�� J� Opacity$	 0.6Q�� -    �Name$ GridMenu��$��60��$
��Left=� K� ZIndex$	 100��.+��� ���	#FF3C3C3C$ 50,10,10,50���� .+��� $��60�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ ButtonCloseMenu��$��50��$��50��$��5,0,0,0q�$��Right=�$��Center=�$y�	Collapsed=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  $��50��$��25��$��Center=�$��Center=����#FFFF   Kind$ 	ArrowLeft=��� -   $ ButtonOpenMenu��$��50��$��50��$��5,0,0,0q�$��Right=�$��Center=���Z� ��Z� .��  $��50��$��35��$��Center=�$��Center=����#FFFF$
 Menu=��� $��5,0,0,0q�$��Center=�$��
Arial bold)�$��34(����#FFFF
Меню�� $��Disabled=�.@��� $��95��$��0q�  ListViewItem#��[ .���� -   $ ButtonOpenUsersPage��$	��200��$��95��$��0q���Z� ��Z� .���� $	��200��$ 
Horizontal=�.+�  $��30��$��30��$��15,0,0,0q�$��Center=����#FFFF$
 User=��� $��15,0,0,0q�$��Center=�$��Arial)�$��20(����#FFFFПользователи�� $��Disabled=�.@��� $��95��$��0q�#��[ .���� -   $ ButtonOpenPlaysPage��$	��200��$��95��$��0q���Z� ��Z� .���� $	��200��$ 
Horizontal=�.+�  $��30��$��30��$��15,0,0,0q�$��Center=����#FFFF$ Theaters=��� $��15,0,0,0q�$��Center=�$��Arial)�$��20(����#FFFFСпектакли�� ���#FFDDC2$��Disabled=�.@��� $��95��$��0q�#��[ .���� -   $  ButtonOpenPerformancesPage��$	��200��$��95��$��0q���Z� ��Z� .���� $	��200��$ 
Horizontal=�.+�  $��30��$��30��$��15,0,0,0q�$��Center=����#FFFF$ Theater=��� $��15,0,0,0q�$��Center=�$��Arial)�$��20(����#FFFFПостановки�� ���#FFDDC2$��Disabled=�.@��� $��95��$��0q�#��[ � $	��200��$��60��.+��� -   $ ButtonOpenSupport��$��1��$	��100��$��30��$��15,0,0,0q�$��Center=�$��Center=�  TransparentButton#��[ .���� $��Arial)�$��18(����	#FFFF5050$��Поддержка��� -   $ GridSupport��$��0��$	��515��$��Right=�$	 100��$y�Visible=�.+��� ���	#FF3C3C3C$ 10,50,50,10���  � RowDefinitions �� $��60 ��� $��* �.+��� $��0��$��60��$ 
Horizontal=�.+��� -	   $ ButtonCloseSupport��$��30��$��30��$��10,0,0,0q�$��0q�$
��Left=�$��Center=���Z� ��Z� .��  $��30��$��30��$��Center=�$��Center=����#FFFF$ Close=��� $��10,0,0,0q�$��Center=�$��
Arial bold)�$��22(����#FFFFПоддержка�� $��1��.+��� $��	10,20,0,0q�$��Arial)�$��20(����#FFFFИмя продукта:�� $��	0,0,10,30q�$��Right=�$��Arial)�$��16(�
�������
Театр�� $��10,0,0,0q�$��Arial)�$��20(����#FFFFИмя компании:�� $	��150��$��	0,0,10,30q�$��Right=�$��Arial)�$��16(�
������� �� TextAlignment$ Right=�$
��Wrap=�МГК электроники�� $��10,0,0,0q�$��Arial)�$��20(����#FFFFРазработчик:�� $	��180��$��	0,0,10,30q�$��Right=�$��Arial)�$��16(�
�������$ Right=�$
��Wrap=�20Костко Артём Владимирович�� $��10,0,0,0q�$��Arial)�$��20(����#FFFFКонтактный E-mail:�� $	��120��$��	0,0,10,30q�$��Right=�$��Arial)�$��16(�
�������$ Right=�$
��Wrap=�artem.kostko@mail.ru�� $ 
Horizontal=�.+��� $��10,0,0,0q�$��Arial)�$��20(����#FFFFВерсия:�� $��85,0,0,0q�$��Bottom=�$��Arial)�$��16(�
�������1.1� $	��680��$	��490��$��75,0,0,0q�$
��Left=�.+� � -
     �Name$ InMainPageFrame��#��[ |�.    � NavigationUIVisibility$ Hidden=�