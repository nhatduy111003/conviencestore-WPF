   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   ���#2C3E50.��5
      � .+�5   
   �� ���#34495E �� CornerRadius$ 15��6&    �� Padding$ 30q�68   $	��400��6E   $��Center=�6Q   $��Center=�6n    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6#      Opacity$	 0.5Q�61      
BlurRadius$ 15Q�6?   	   ShadowDepth$	 5Q�6O   ._�5      �� .+�5      �� $��Center=�6   $	��Top=�6:   $��0,0,0,20q�6R   .+�5      �� $��Login��6    $��28(�6-   $
��Bold"�6;   
�������$��Center=�6`   �� 5      $1��+Welcome back! Please login to your account.��6    $��14(�6S   ���#BDC3C7$��Center=�6v   $��0,5,0,0q�6�   5      �� 5      $��0,30,0,0q�6   .+�5      �� $��Email��6    ���#ECF0F1$��14(�6B   $��10,0,0,5q�6P   �� 5      -   5        
 ��Name$
 txtEmail��5      $	��340��60   $��35��6<   $��Center=�6H   ���#ECF0F1���#2C3E50$��0q�6�   $
��10,5q�6�   $��manager@example.com��5      �� 5       $��Password��6    ���#ECF0F1$��14(�6E   $��	10,20,0,5q�6S   G� 5!      -   5         G�Name$ txtPassword��5!   "   $	��340��67   $��35��6C   $��Center=�6O   ���#ECF0F1���#2C3E50$��0q�6�   $
��10,5q�6�    G� Password$ manager_password��5"   "   5#      �� 5&       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��0,30,0,0q�6S   .+�5'      �� -   5         ��Name$ btnLogin��5'      $��Login��6/   $	��140��6?   $��40��6K   ���#1ABC9C
�������$��0q�6   $
��Bold"�6�   6�   �� 5(      -   5        $ 	btnCancel��5(      $��Cancel��60   $	��140��6A   $��40��6M   ���#E74C3C
�������$��0q�6�   $
��Bold"�6�   6�   5)      5*      5+      5,      5-      