   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.AdminWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	     � Title$  AdminWindow��5   	   $	��674��6   $	��947��6*   ���#004B66.��5	      � -   5        $��	0,0,10,-6q�5	       .+�5
   
   �� -   5         ��Name$ 	txtUserId��5
      $
��Left=�6%   $��40��6@   $��
125,65,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��338��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -   5        $ txtUsername��5      $
��Left=�6'   $��40��6B   $��125,134,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��338��6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��40��6?   $��125,210,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��338��6�   �� 5   
   -   5         ��Name$ cbRole��5      $
��Left=�6#   $��40��6>   $��125,277,0,0q�6J   $	��Top=�6_   $	��338��6w    J� RenderTransformOrigin$ 0.733,0.526&�6�   �� 5   
   $��ID��6   $
��Left=�6   $��	10,65,0,0q�68   $	��Top=�6K   $
��Bold"�6c   ���	#FFF8F1F16u   �� 5   
   $
��Name��6   $
��Left=�6   $��
10,139,0,0q�6:   $	��Top=�6N   $
��Bold"�6f   ���	#FFF8F1F16x   �� 5   
   $��Email��6   $
��Left=�6    $��
10,210,0,0q�6;   $	��Top=�6O   $
��Bold"�6g   ���	#FFF8F1F16y   �� 5   
   $�� ��6   $
��Left=�6   $��
10,277,0,0q�66   $	��Top=�6J   $
��Bold"�6b   ���	#FFF8F1F16t   �� 5   
   $
��Role��6   $
��Left=�6   $��
10,284,0,0q�6:   $	��Top=�6N   $
��Bold"�6f   ���	#FFF8F1F16x   �� 5   
   $��USER MANAGEMENT��6   $��Center=�6*   $��0,10,0,0q�6G   $	��Top=�6Y   $
��Bold"�6q   $��25(�6�   ���	#FFF8F1F15      �� 5   
   -   5         ��Name$ 	btnCreate��5      $��Create��6$   $
��Left=�65   $��49��6P   $��125,580,0,0q�6\   $	��Top=�6q   $	��154��6�   ���	#FF1C4EDF$
��Bold"�6�   ���	#FFF2E5E56�   �� 5   
   -   5        $ 
btnUpdate1��5      $��Update��6%   $
��Left=�66   $��49��6Q   $��329,580,0,0q�6]   $	��Top=�6r   $	��170��6�   ���	#FFE2CB05$
��Bold"�6�   ���	#FFF8F8F86�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��49��6P   $��525,580,0,0q�6\   $	��Top=�6q   $	��170��6�   ���	#FFEA5B1A$
��Bold"�6�   ���	#FFEFECEC6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dgUser��5      $
��Left=�6#   $	��222��6>   $��125,332,0,0q�6K   $	��Top=�6`   $	��763��6x   6�   �� 5   
   -
   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��49��6N   $��718,580,0,0q�6Z   $	��Top=�6o   $	��170��6�   ���	#FFF10A51$
��Bold"�6�   ���	#FFEE0000���	#FFF8F1F16�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6(   $��40��6C   $��
550,65,0,0q�6O   $	��Top=�6d   $	��338��6|   �� 5   
   $��Password��6   $
��Left=�6#   $��
488,67,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   ���	#FFF8F1F16|   �� 5   
   $�� ��6   $
��Left=�6   $��488,278,0,0q�66   $	��Top=�6K   $
��Bold"�6c   ���	#FFF8F1F16u   5      5      