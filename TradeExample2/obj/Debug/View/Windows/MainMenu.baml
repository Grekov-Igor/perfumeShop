   M S B A M L   `   `   `  ����G  CTradeExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TradeExample.View.WindowsTradeExample.View.Windows  5   	   (    "TradeExample.View.Windows.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TradeExample.View.Windows     5   	     � Title$  MainMenu��5   	   $	��450��6   $	��800��6'   $	��450��5	   	   $	��800��6   $��Comic Sans MS)�5
   	    � Icon$0 */TradeExample;component/Resourses/icon.ico��6$    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �    ColorSecondary#��[  6   .+�5      �� $
��Left=�6   $��Center=�5      $0��*/TradeExample;component/Resourses/logo.png��5      �� 5      $��Товары��6   $��Center=�5      $��Center=�5      $��36(�63   �� 5      -   5         ��Name$ 
UserNameTB��5      $��Right=�5      $	��Top=�5      $��0, 0, 10, 0q�5      �� 5       -   5        $��
Выйти��5       $��Center=�5!      $��Right=�5"      $	��100��5#      $��0, 0, 10, 0q�5$      
�������5&      5(      � 5*   
   $��1��6   .+�5+      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5,      $��Center=�5-      .+�5.      �� -   5         ��Name$ 	SortingCB��50      $	��200��5.      $��30��5/      $	��Top=�51      $��Right=�52      53      �� 54      -   5        $ FilterCB��56      $	��200��54      $��30��55      $	��Top=�57      $��10, 0, 0, 0q�59      �� 5:      -   5         ��Name$ SearchTB��5:      $	��150��6,   $��30��5;      $��10, 0, 0, 0q�6&   $	��Top=�5<      5=      5>      �� 5?      -   5        $ CountTB��5?      $��0, 5, 10, 0q�5@      $��Bottom=�5A      $��Right=�5B      5C      � 5E   
   $��2��6   .+�5H      �� -   5         ��Name$ 	ProductLB��5H      	 � ContextMenu	 5I      �� 5J      .@�5K      m� -   5        $&�� Добавить к заказу��5K   #   5L   #   5M      ��5O      �� 5P      .R�5Q      �� $ 
Horizontal=�6%   $��Right=�5S   %   ��5R   %   �� *
GetColor+.+�5T      �� $��50��6$   $��0, 0, 10, 0q�5V   $   ��5U   $   �� *ProductPhoto+5V   $   �� 5W      $ Vertical=�6)   $	��200��5X   )   .+�5Y   "   �� ��6,   �� *ProductName+�� 5Z   "   $
��Wrap=�5[   ,   ��5Z   ,   �� *ProductDescription+5[   ,   �� 5\   "   ��6,   �� *Manufacturer.ManufacturerName+�� 5]   "   $ 
Horizontal=�6-   .+�5^   &   �� $��Strikethrough{�5_   0   $��0, 0, 10, 0q�5`   0   ��5^   0   �� *ProductCost+y�5a   0   �� *HasDiscountVisability+�� 5b   &   ��60   �� *GetCostWithDiscount+5c   #   5e      �� 5f      $��Right=�5g   (   ��5f   (   �� *GetAmountDiscount+5g   (   5h      5i      5k      5l      � 5n   
   $��3��6   #��[  6   .+�5o      �� -	   5        
 ��Name$
 GoToOrdersBTN��5u      $��Заказы��5o      $
��Left=�5p      $��Center=�5q      $��10, 0, 0, 0q�5r      $	��100��5s      
�������$y�	Collapsed=�5w      �� 5x      -
   5        $
 GoToOrderBTN��5      $��
Заказ��5x      $��Right=�5y      $��Center=�5z      $��0, 0, 10, 0q�5{      $	��100��5|      
�������$y�	Collapsed=�5~      5      5�      5�      5�      