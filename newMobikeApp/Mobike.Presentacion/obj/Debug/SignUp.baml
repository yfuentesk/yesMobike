   M S B A M L   `   `   `  ����N  JMobike.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Mobike.PresentaciónMobike.Presentación  5   	   !    Mobike.Presentación.SignUp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Mobike.Presentación     5   	     � Title$"  Mobike - Registro de Usuario��5   	   $	��500��6.   $	��480��6;   .��5	      � ���	#FFF8F8F8.+�5
   
   �� ���	#FFFF4611$
��Left=�6%   $��75��6@   $	��Top=�6L   $	��472��6d   �� 5   
   $��Mobike��6   
�������$��48(�6J   $
��Bold"�6X   $��Microsoft JhengHei UI)�6j   $��Center=�6�   $��75��6�   $	��Top=�6�   $	��472��6�   $��Center=�6�   $��Center=�6�   ��6!   Z� 6�   �� 5   
   -   5         ��Name$ btnRegistro��5      $��Crear Usuario��6&   $��273,0,75,75q�6>   $��Bottom=�6S    J� RenderTransformOrigin$ 0.5,0.5&�6n   $��50��6�   $��9��6�   6�   �� 5   
   -   5         ��Name$ txtDireccion��5      $
��Left=�6(   $��24��6C   $��
95,162,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   $��Center=�6�   $��2��6�   �� 5   
   $��	Direccion��6   $
��Left=�6$   $��
23,162,0,0q�6?   $	��Top=�6S   $��65��6k   �� 5   
   -   5        $ 	txtNombre��5      $��Right=�6%   $��23��6A   $��
0,162,25,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   $��Center=�6�   $��3��6�   �� 5   
   $��Nombre��6   $��Right=�6!   $��0,162,150,0q�6=   $	��Top=�6R   $��65��6j   �� 5   
   -   5        $ txtRut��5      $
��Left=�6"   $��23��6=   $��
95,217,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��Center=�6�   $��4��6�   �� 5   
   $	��Rut��6   $
��Left=�6   $��
23,214,0,0q�69   $	��Top=�6M   $��65��6e   �� 5   
   -   5        $ 
txtTarjeta��5      $��Right=�6&   $��23��6B   $��
0,217,25,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   $��Center=�6�   $��5��6�   �� 5   
   $��Tarjeta��6   $��Right=�6"   $��0,214,150,0q�6>   $	��Top=�6S   $��65��6k   �� 5   
   $��Fecha de Vencimiento��6   $��Right=�6/   $��0,266,150,0q�6K   $	��Top=�6`   $��23��6x   �� 5   
   $	��CVC��6   $
��Left=�6   $��
25,266,0,0q�69   $	��Top=�6M   $��23��6e   �� 5   
   -   5        $ 	txtCorreo��5      $
��Left=�6%   $��23��6@   $��
95,113,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   $��Center=�6�   $��0��6�   �� 5   
   $��Correo��6   $
��Left=�6!   $��
23,110,0,0q�6<   $	��Top=�6P   $��65��6h   G� 5   
   -   5         G�Name$ txtPass��5      $��Right=�6'   $��23��6C   $��
0,113,25,0q�6O   $	��Top=�6c   $	��120��6{   $��1��6�   $��Center=�6�   �� 5   
   $��Password��6   $��Right=�6#   $��0,110,150,0q�6?   $	��Top=�6T   $��65��6l   �� 5   
   -   5         ��Name$ cmbDV��5      $
��Left=�6"   $��23��6=   $��
190,98,0,0q�6I   $	��Top=�6]   $��25��6u   $y�Hidden=�6�   �� 5   
   $��-��6   $
��Left=�6   $��
170,95,0,0q�67   $	��Top=�6K   $��26��6c   $y�Hidden=�6o   �� 5   
   $��/
��6   $��
0,266,32,0q�6!   $	��Top=�65   $��23��6M   $	��105��6Y   $��Right=�6e   $��Center=�6�   �� 5   
   -	   5        $
��Left=�5      $��23��6-   $��
95,266,0,0q�69   $
 Wrap=�6M   $	��Top=�6a   $��30��6y   $��Center=�6�   $��Center=�6�   $��6��6�   �� 5   
   -
   5        $ 	btnVolver��5      $��Iniciar Sesión��6$   $
��Left=�6=   $��	75,0,0,75q�6X   $��Bottom=�6k   $	��124��6�   $��50��6�   $��99��6�   �� 5    
   ���	#FFFF4611$
��Left=�6%   $	��472��6@   $��50��6L   $��Bottom=�6X   �� 5!   
   -   5        $ cmbAno��5!      $��
0,266,25,0q�6#   $	��Top=�67   $��23��6O   $��Right=�6[   $��50��6w    �� SelectedIndex$ 0��6�   $��8��6�   .@�5"      �� $
��Año��6   $
��Left=�6)   $��92��6D   �� 5#      $��18��6   $
��Left=�6(   $��92��6C   �� 5$      $��19��6   $
��Left=�6(   $��92��6C   �� 5%      $��20��6   $
��Left=�6(   $��92��6C   �� 5&      $��21��6   $
��Left=�6(   $��92��6C   �� 5'      $��22��6   $
��Left=�6(   $��92��6C   �� 5(      $��23��6   $
��Left=�6(   $��92��6C   �� 5)      $��24��6   $
��Left=�6(   $��92��6C   5*      �� 5+   
   -   5        $ cmbMes��5+      $��Right=�6#   $��
0,266,95,0q�6?   $	��Top=�6S   $��50��6k   $��23��6v   $ 0��6�   $��7��6�   .@�5,      �� $	��Mes��6   $
��Left=�6)   $��92��6D   �� 5-      $��01��6   $
��Left=�6(   $��92��6C   �� 5.      $��02��6   $
��Left=�6(   $��92��6C   �� 5/      $��03��6   $
��Left=�6(   $��92��6C   �� 50      $��04��6   $
��Left=�6(   $��92��6C   �� 51      $��05��6   $
��Left=�6(   $��92��6C   �� 52      $��06��6   $
��Left=�6(   $��92��6C   �� 53      $��07��6   $
��Left=�6(   $��92��6C   �� 54      $��08��6   $
��Left=�6(   $��92��6C   �� 55      $��09��6   $
��Left=�6(   $��92��6C   �� 56      $��10��6   $
��Left=�6(   $��92��6C   �� 57      $��11��6   $
��Left=�6(   $��92��6C   �� 58      $��12��6   $
��Left=�6(   $��92��6C   59      5;      5<      