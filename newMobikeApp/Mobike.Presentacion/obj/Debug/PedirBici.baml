   M S B A M L   `   `   `  ����N  JMobike.Presentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Mobike.PresentaciónMobike.Presentación  5   	   $    Mobike.Presentación.PedirBici   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Mobike.Presentación     5   	     � Title$  Mobike - Pedir Bicicleta��5   	   $	��500��6*   $	��480��67   .��5	      � ���	#FFF8F8F8$	��469��6"   $	��Top=�6/   .+�5
   
   �� ���	#FFFF4611$
��Left=�6%   $��75��6@   $	��Top=�6L   $	��472��6d   �� 5   
   $��Mobike��6   
�������$��48(�6J   $
��Bold"�6X   $��Microsoft JhengHei UI)�6j   $��75��6�   $	��Top=�6�   $��Center=�6�   $��Center=�6�   ��6!   Z� 6�   �� 5   
   $��Indique estacionamiento: ��6   $
��Left=�64   $��
75,130,0,0q�6O   $	��Top=�6c   �� 5   
   $&�� Seleccione codigo de bicicleta: ��6   $
��Left=�6;   $��
75,180,0,0q�6V   $	��Top=�6j   �� 5   
   $ ��Información del Recorrido��6   $��0,80,0,0q�64   $	��Top=�6F   $��20(�6^   $��Center=�6l   $��Center=�6�   $��Center=�6�   $	��239��6�   �� 5   
   -   5         ��Name$ cmbEst��5      $��Right=�6#   $��
0,130,75,0q�6?   $	��Top=�6S   $	��120��6k   $��26��6�   $��0��6�   �� 5   
   -   5         ��Name$ btnComienzo��5      $��Comienzar Recorrido��6&   $��154,0,154,75q�6D   $��Bottom=�6Z   $��50��6�   $	��150��6�   �� 5   
   -   5        $ 
cmbPatente��5      $��Right=�6'   $��
0,180,75,0q�6C   $	��Top=�6W   $	��120��6o   $��26��6{   $��1��6�   �� 5   
   -   5        $ btnFin��5      $��Terminar Recorrido��6!   $��Right=�6>   $��	0,0,25,75q�6Z   $	��125��6m   $��50��6�   $��Bottom=�6�   �� 5   
   ���	#FFFF4611$
��Left=�6%   $	��472��6@   $��50��6L   $��Bottom=�6X   �� 5   
   -   5        $ 	btnVolver��5      $��Volver al Menú��6$   $
��Left=�6=   $��	25,0,0,75q�6X   $	��125��6k   $��50��6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ lblValor��5      $��Valor del Recorrido: $��6"   $��	0,280,0,0q�6C   $	��Top=�6V   $��Center=�6n   $y�Hidden=�6�   �� 5   
   -   5        $ lblKm��5      $��Kilómetros recorridos:��6   $
��Left=�6@   $��
75,230,0,0q�6[   $	��Top=�6o   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ txtKm��5      $��Right=�6!   $��26��6=   $��
0,230,75,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��Center=�6�   $y�Hidden=�6�   �� 5   
   -	   5        $ cmbEst2��5      $��Right=�6$   $��
0,130,75,0q�6@   $	��Top=�6T   $	��120��6l   $��26��6x   $��0��6�   $y�Hidden=�6�   5      5      