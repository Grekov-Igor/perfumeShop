   M S B A M L   `   `   `  ����G  CTradeExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TradeExample.View.WindowsTradeExample.View.Windows  5   	   +    %TradeExample.View.Windows.OrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TradeExample.View.Windows     5   	     � Title$  
Заказ��5   	   $	��450��5	   	   $	��800��6   $	��450��5
   	   $	��800��6   $��Comic Sans MS)�5   	    � Icon$0 */TradeExample;component/Resourses/icon.ico��6$    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $	��100 �6   �� 5      $��50 �6   .+�5   
   �    ColorSecondary#��[  6   .+�5      �� $
��Left=�6   $��Center=�5      $0��*/TradeExample;component/Resourses/logo.png��5      �� 5      $��
Заказ��6   $��Center=�5      $��Center=�5      $��36(�63   �� 5      -   5         ��Name$ 
UserNameTB��5       $��Right=�5      $	��Top=�5      $��0, 0, 10, 0q�5!      5"      � 5&   
   $��1��6   .+�5)      �� -   5         ��Name$ 	ProductLB��5)      ��5+      �� 5,      .R�5-      ��  �� Orientation$ 
Horizontal=�6%   $��Right=�5/   %   ��5.   %   �� *
GetColor+.+�50      �� $��50��6$   $��0, 0, 10, 0q�52   $   ��51   $   �� *ProductPhoto+52   $   �� 53      $ Vertical=�6)   $	��200��54   )   .+�55   "   �� ��6,   �� *ProductName+�� 56   "   $
��Wrap=�57   ,   ��56   ,   �� *ProductDescription+57   ,   �� 58   "   ��6,   �� *Manufacturer.ManufacturerName+�� 59   "   $ 
Horizontal=�6-   .+�5:   &   �� $��Strikethrough{�5;   0   $��0, 0, 10, 0q�5<   0   ��5:   0   �� *ProductCost+y�5=   0   �� *HasDiscountVisability+�� 5>   &   ��60   �� *GetCostWithDiscount+5?   #   5A      �� 5B      $��Right=�5C   (   ��5B   (   �� *GetAmountDiscount+5C   (   �� 5D      $��50, 0, 0, 0q�6)   .+�5E   "   �� $��Количество:��6,   �� 5F   "    ��Name$ numOfProductsTB��6*   -   5        ��5G   *   ��  �� Mode$ OneWay=�	 �� Path$	 ProductCount�5I   *   �� 5K   "   -   5        $��Удалить��5K   )   5L   )   5M      5O      5Q      5S      5T      � 5V   
   $��2��6   .+�5W      �� .+�5X      �� .+�5Y      �� -   5        $ CreateDateTB��5Z       $!��Дата создания: ��5Y       5Z       �� 5[      -   5        $ DeliveryDateTB��5\       $!��Дата доставки: ��5[       5\       5]      �� 5^      .+�5_      �� $ 
Horizontal=�6!   .+�5`      �� $��Пункт выдачи: ��6$   �� 5a      -   5        
 ��Name$
 PickPointCB��5b   #   $��10, 0, 0, 0q�5a   #   ��5d      �� 5e   "   .R�5f   &   �� ��60   �� *PointAddress+5g   #   5i      5j      �� 5l      -   5        $ OrderCodeTB��5m       $!��Код получения: ��5l       $��18(�5m   5   $
��Bold"�5n       5o      5p      5t      � 5v   
   $��3��6   #��[  6   .+�5w      �� $ Vertical=�6   $
��Left=�5x      $��Center=�5y      .+�5z      �� $ 
Horizontal=�6   .+�5{      �� $��Сумма заказа:��6    �� 5|      -	   5        $ totalCostTB��5|       $��Strikethrough{�5}       $��10, 0, 0, 0q�5~       �� 5      -
   5        $ totalCostWithDiscountTB��5       $��10, 0, 0, 0q�5�       5�      �� 5�      $ 
Horizontal=�6   $��0, 10, 0, 0q�5�      .+�5�      �� $ ��Скидка заказа:��6    �� 5�      -   5        $ totalDiscountTB��5�       $��10, 0, 0, 0q�5�       5�      5�      �� 5�      -   5        $)��#Сформировать заказ��5�      $��Right=�5�      $��Center=�5�      $��0, 0, 10, 0q�5�      $	��150��5�      
�������5�      5�      5�      5�      