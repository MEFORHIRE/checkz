   M S B A M L   `   `   `  ���� [  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  X TInvoice365, Version=1.0.3989.38771, Culture=neutral, PublicKeyToken=db2d1b37798ad79b'clr-namespace:Invoice365
Invoice365    Invoice365.CustomerFrame   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     *localclr-namespace:Invoice365       Invoice365.Inv365Sortable    Initialized$  Window_Initialized�� N� Title$ 	Dashboard�� N� 
Foreground �	#FF35496A � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.��]� $
��Auto��$
��Auto����. 
������ $��Center=�$	��Top=�.+�(� $	��Top=�$��Center=� (� Stretch$
 Fill=�.��� $	��Top=�$��Center=�$	��556��$
��1111��$��-1q� � RowDefinitions �� $
��268* ��� $
��288* �	 � ColumnDefinitions	 �� $��226.407* ��� $	��102 ��� $
��181* ��� $��215.297 ��� $
��178* �.+��� -   $��
rectangle2��$��4��$��18,12,27,232q�
 J� OpacityMask
 �	#FF318E8E
���   �
�����F��� -   $��custView��$��19,257,27,34q�}�.  J� 	AllowDrop .  � IsSharedSizeScope . $��2q����	#FF809AB2$��4��$��Arial)�$��14(�$��13��$��2�� �� View �� .P���  �� Width$	 150��$��Company���� $	 150��$��Phone���� $	 150��$��	FirstName���� $	 150��$��LastName���� $	 150��$��Address���� $	 150��$
��City���� $	 150��$��State������ �� -   $��title��
�������$��23.331��$��1��$��	77,13,0,0q�$	��Top=�$
��Bold"�$
��Left=�$��93��$��2��$��Add Customer���� -   $��savecustomer��$��12(�$��Normal"�$��291,0,224,13q�$��11��$��22��$��Bottom=�$��3��.��Save Customer�� -   $��label2��$
��Bold"�
���   �$��28��$��68��$
��Left=�$��	48,42,0,0q�$	��Top=�.��	CompanytOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 7  1System.Windows.Forms.Integration.WindowsFormsHost  ^myOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     -   $��customerCBHost��$��20.775��   TabIndex$ 1��$��128,42,50,0q�$	��Top=�   Child. #   System.Windows.Forms.ComboBox  -      AutoCompleteMode$ SuggestAppend=�   AutoCompleteSource$ 	ListItems=�
customerCB��"   System.Windows.Forms.Control   TabIndex$ 1��   	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 �� -   $��deleteCustomer��$��12(�$��Normal"�$��22��$
��Left=�$��	27,0,0,12q�$��12��$��Bottom=�$��138.966��$��2��.��Delete Customer�� -	   $��tabControl1��$	��158��$
��Left=�$��	21,70,0,0q�$	��Top=�$	��825��$��4��$��0q����� .@��� -
   $��billing��$��Billing Address��.���� -   $��canvas1��$	��118��$	��818��.+��� -   $��label7��$
��Bold"�
���   � �� Left$ 33��
 �� Top$ 87��.��City�� -   $��label4��$
��Bold"�
���   �$��28��$ 28��$ 16��.��	Street1�� -   $��street1��$��23��$��4��$ 93��$ 16��$	��131���� -   $��label1��$
��Bold"�
���   �$��28��$ 29��$ 51��.��	Street2�� -   $��street2��$��23��$��5��$ 93��$ 51��$	��132���� -   $
��city��$��6��$��129.402��$ 93��$ 87���� -   $��label5��$
��Bold"�
���   �$��53��$��28��$	 276��$ 85��.��Phone�� -   $��phone��$��23��$��8��$	 333��$ 87��$	��125���� -   $��label8��$
��Bold"�
���   �$��28��$��46.297��$	 275��$ 15��.��State�� -   $��state��$��23��$��7��$	 335��$ 20��$	��127���� -   $��label10��$
��Bold"�
���   �$��53��$	 515��$ 25��.��Fax�� -   $	��fax��$��9��$	 576��$ 23��$	��126���� -   $��label11��$
��Bold"�
���   �$��28��$��53��$	 515��$ 57��.��Email�� -   $��email��$��23��$��10��$	 578��$ 55��$	��126���� -   $��label3��$	 274��$ 51��$	��Zip��$
��Bold"�
���   �$��28��$��46.297���� -   $	��zip��$	 334��$ 56��$��23��$��7��$	��127���� -   $��shipping��$��Shipping Address��.���� $��Stretch=�$��Stretch=�.+��� -   $��label6��$ 15��$ 82��$
��City��$
��Bold"�
���   ��� -   $��label9��$ 10��$ 11��$��Street1��$
��Bold"�
���   �$��28���� -   $��	s_street1��$ 75��$ 11��$��23��$��4��$	��131���� -    $��label12��$ 11��$ 46��$��Street2��$
��Bold"�
���   �$��28���� -!   $��	s_street2��$ 75��$ 46��$��23��$��5��$	��132���� -"   $��s_city��$ 75��$ 82��$��6��$��129.402���� -#   $��label13��$	 258��$ 80��$��Phone��$
��Bold"�
���   �$��28��$��53���� -$   $��s_phone��$	 315��$ 82��$��23��$��8��$	��125���� -%   $��label14��$	 257��$ 10��$��State��$
��Bold"�
���   �$��28��$��46.297���� -&   $��s_state��$	 317��$ 15��$��23��$��7��$	��127���� -'   $��label15��$	 497��$ 20��$	��Fax��$
��Bold"�
���   �$��53���� -(   $��s_fax��$	 558��$ 18��$��9��$	��126���� -)   $��label16��$	 497��$ 52��$��Email��$
��Bold"�
���   �$��28��$��53���� -*   $��s_email��$	 560��$ 50��$��23��$��10��$	��126���� -+   $��label17��$	 256��$ 46��$	��Zip��$
��Bold"�
���   �$��28��$��46.297���� -,   $��s_zip��$	 316��$ 51��$��23��$��7��$	��127���� --   $��firstNameLabel��$
��Bold"�
���   �$��28��$��63��$��2��$��273,46,73,194q�.��
First Name�� -.   $��	firstName��$��23��$��2��$	��129��$��1��$��2��$��46,42,172,203q��� -/   $��lastNameLabel��$
��Bold"�
���   �$��63��$��2��$��98,48,84,204q�.��	Last Name�� -0   $��lastName��$��3��$	��131��$��2��$��2��$��178,44,152,202q�����  N� 
Background �� 