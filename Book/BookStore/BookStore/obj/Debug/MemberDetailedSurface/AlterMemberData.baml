   M S B A M L   `   `   `  ����D  @BookStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:BookStore.MemberDetailedSurfaceBookStore.MemberDetailedSurface  5   	   5    /BookStore.MemberDetailedSurface.AlterMemberData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:BookStore.MemberDetailedSurface     5   	     � Title$  AlterMemberData��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $	��100 �6   �� 5      $��80 �6   �� 5      $	��100 �6   �� 5      .+�5   
   �� -   5         ��Name$ textBlockMemberID��5      $��18(�6/   $��0��6=   $��0��6M   $��0,14.62,0,10q�6Z   $
��Wrap=�6p   $��
会员号:��6�   �� 5   
   -   5        $ textBlockMemberName��5      $��18(�61   $��0��6?   $��1��6O   $��0,14.62,0,10q�6\   $
��Wrap=�6r   $��
会员名:��6�   �� 5   
   -   5        $ textBlockMemberPhoneNum��5      $��14(�65   $��0��6C   $��2��6S   $��0,14.62,0,10q�6`   $
��Wrap=�6v   $��会员手机号:��6�   �� 5   
   -   5        $ textBlockMemberOverage��5      $��18(�64   $��0��6B   $��3��6R   $��0,14.62,0,10q�6_   $
��Wrap=�6u   $��账户余额:��6�   �� 5   
   -   5        $" textBlockMemberFreezeOverage��5      $��12(�6:   $��2��6H   $��0��6X   $��0,14.62,0,10q�6e   $
��Wrap=�6{   $��会员冻结余额:��6�   �� 5   
   -   5        $ textBlockMemberState��5      $��18(�62   $��2��6@   $��1��6P   $��0,14.62,0,10q�6]   $
��Wrap=�6s   $��会员状态:��6�   �� 5   
   -   5        $ textBlockMemberRemarks��5      $��38(�64   $��2��6B   $��2��6R   $��22,6.507,0,8.113q�6_   $
��Wrap=�6y   $��备注��6�   $��2��6�   �� 5   
   -   5         ��Name$ textBoxMemberID��5      $��1��6+   $��0��6;   $��0,0,0,0q�6H    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   �� 5   
   -	   5        $ textBoxMemberName��5      $��1��6-   $��1��6=   $��0,0,0,0q�6J   $
 Wrap=�6[   $�� ��6o   �� 5    
   -
   5        $ textBoxMemberPhoneNum��5       $��1��61   $��2��6A   $��0,0,0,0q�6N   $
 Wrap=�6_   $�� ��6s   �� 5!   
   -   5        $ textBoxMemberOverage��5!      $��1��60   $��3��6@   $��0,0,0,0q�6M   $
 Wrap=�6^   $�� ��6r   �� 5"   
   -   5        $  textBoxMemberFreezeOverage��5"      $��3��66   $��0��6F   $��0,0,0,0q�6S   $
 Wrap=�6d   $�� ��6x   �� 5#   
   -   5        $ textBoxMemberState��5#      $��3��6.   $��1��6>   $��0,0,0,0q�6K   $
 Wrap=�6\   $�� ��6p   �� 5$   
   -   5        $ textBoxMemberRemarks��5$      $��3��60   $��2��6@   $��2��6M   $��0,0,0,0q�6^   $
 Wrap=�6o   $�� ��6�   �� 5%   
   -   5         ��Name$ 
buttonSave��5%      $��保存��6%   $��4��62   $��1��6B   $��2��6O   5&      5'      