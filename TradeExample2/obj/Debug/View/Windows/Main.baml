   M S B A M L   `   `   `  ����G  CTradeExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TradeExample.View.WindowsTradeExample.View.Windows  5   	   $    TradeExample.View.Windows.Main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TradeExample.View.Windows     5   	     � Title$  Авторизация��5   	   $	��450��5	   	   $	��800��6   $	��450��5
   	   $	��800��6   $��Comic Sans MS)�5   	    � Icon$0 */TradeExample;component/Resourses/icon.ico��6$    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      .+�5   
   �    ColorSecondary#��[  6   .+�5      �� $0��*/TradeExample;component/Resourses/logo.png��6   $
��Left=�5      $��Center=�5      �� 5      $��Авторизация��6   $��Center=�5      $��Center=�5      $��36(�63   5      � 5   
   $��1��6   .+�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5         ��Name$ LoginTB��5       $��35��5      $	��300��6&   5       �� 5!      -   5        $ 
PasswordTB��5#      $��35��5!      $	��300��6&   $��0, 10, 0, 0q�5"      5#      �� 5$      -   5         ��Name$ 	CaptchaTB��5&      $��Center=�5$      $��0, 10, 0, 0q�5%      $y�	Collapsed=�5'      $��Strikethrough{�5(      �� 5)      -   5        $ 
CaptchaTB1��5)       $��0, 0, -2, 0q�64   $��14(�6I   16Z    �� 5*      -   5        $ 
CaptchaTB2��5*   $   $��
0, 0, 0, 0q�68   $��12(�6L   26]    �� 5+      -   5        $ 
CaptchaTB3��5+   $   $��0, 0, -2, 0q�68   $��15(�6M   36^    �� 5,      -   5        $ 
CaptchaTB4��5,   $   $��11(�68   46I   5.      �� 5/      -   5        $ EntryCaptchaTB��52      $	��150��5/      $��35��50      $��0, 10, 0, 0q�51      $y�	Collapsed=�53      �� 54       �� Orientation$ 
Horizontal=�6   $��Center=�55      $��Center=�56      $��0, 10, 0, 0q�57      .+�58      �� -	   5         ��Name$ AuthBtn��5<      $��
Войти��58      $��30��6-   
�������$	��100��5:      5<      �� 5=      -
   5        $,��&Продолжить как гость��5=      $��10, 0, 0, 0q�5>      
�������$	��200��5@      5A      5B      5C      5D      5E      5F      