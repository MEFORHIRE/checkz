   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   =   Y UCheckCasher, Version=1.0.4060.30418, Culture=neutral, PublicKeyToken=db2d1b37798ad79b)clr-namespace:CheckCasherCheckCasher 5         CheckCasher.CustomerFrame   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      6;   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     6=   +localclr-namespace:CheckCasher     5      [ WWPFLocalizeExtension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1949495244fd89a8;lex1http://schemas.root-project.org/xaml/presentation  5   >      CheckCasher.Inv365Sortable    Initialized$  Window_Initialized��6    N� 
Foreground �	#FF35496A N� Title 5   .   6  0WPFLocalizeExtension.Extensions.LocTextExtension  *%#CheckCasher:CustomerFrame:Dashboard+ � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5	      .��5
      ]� $
��Auto��6   $
��Auto��6   ��. 
������ $��Center=�5   
   $	��Top=�6'   .+�5   
   (� $	��Top=�6   $��Center=�6*    (� Stretch$
 Fill=�6G   .��5      � $	��Top=�6   $��Center=�6+   $	��556��6H   $
��1111��6U   $��-1q�5       � RowDefinitions 5      �� 5      $
��268* �6$   �� 5      $
��288* �6$   	 � ColumnDefinitions	 5      �� 5      $��226.407* �6'   �� 5      $	��102 �6'   �� 5      $
��181* �6'   �� 5      $��215.297 �6'   �� 5      $
��178* �6'   .+�5      �� -   5        $��
rectangle2��5   F   $��4��6   $��18,12,27,232q�60   
 J� OpacityMask
 �	#FF318E8E
���   �
�����F�5   %   �� 5      -   5        $��custView��5   1   $��19,257,27,34q�6   }�.  J� 	AllowDrop .  � IsSharedSizeScope . $��2q�5   4   ���	#FF809AB2$��4��6`   $��Arial)�5   C   $��14(�6V   $��13��6d   $��2��5       �� View 5       �� 5!      .P�5"      ��  �� Width$	 150��6-   ��69     *#!CheckCasher:CustomerFrame:Company+�� 5#      $	 150��6-   ��69     *!CheckCasher:CustomerFrame:Phone+�� 5$      $	 150��6-   ��69     *%#CheckCasher:CustomerFrame:FirstName+�� 5%      $	 150��6-   ��69     *$"CheckCasher:CustomerFrame:LastName+�� 5&      $	 150��6-   ��69     *#!CheckCasher:CustomerFrame:Address+�� 5(      $	 150��6-   ��69     * CheckCasher:CustomerFrame:City+�� 5)      $	 150��6-   ��69     *!CheckCasher:CustomerFrame:State+5+      ��5-      �� 5.      50      �� 51      -   5        $��title��51   ;   
�������$��23.331��6+   $��1��6H   $��	77,13,0,0q�6X   $	��Top=�52      $
��Bold"�6.   $
��Left=�6@   $��93��6[   $��2��6f   ��53        *'%CheckCasher:CustomerFrame:AddCustomer+54      �� 55      -   5        $��savecustomer��55   Q   $��12(�6   $��Normal"�6'   $��291,0,224,13q�6;   $��11��56   1   $��22��6?   $��Bottom=�6K   $��3��6f   .��57        8 1http://schemas.root-project.org/xaml/presentation  6]   �  �WPFLocalizeExtension.BaseExtensions.BaseLocalizeExtension`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceIdentifierKey$, &CheckCasher:CustomerFrame:SaveCustomer��6   6]   58      �� 59      -   5        $��deleteCustomer��5:      $��12(�59      $��Normal"�6'   $��22��6;   $
��Left=�6G   $��	27,0,0,12q�6b   $��12��5:   ,   $��Bottom=�6:   $��138.966��6U   $��2��6e   .��5<        8 1http://schemas.root-project.org/xaml/presentation  6_   $. (CheckCasher:CustomerFrame:DeleteCustomer��6   6_   5=      �� 5>      -   5        $��tabControl1��5>   X   $	��158��6   $
��Left=�6*   $��	21,70,0,0q�6E   $	��Top=�5?      $	��825��6.   $��4��6:   $��0q�6N   ��5@      �� 5A      .@�5C      �� -   5        $��billing��5C   ^   ��6     **(CheckCasher:CustomerFrame:BillingAddress+.��5D      �� -   5        $��canvas1��5D   .   $	��118��6!   $	��818��6=   .+�5E      �� -	   5        $��label7��5E   I   $
��Bold"�6$   
���   � �� Left$ 33��6W   
 �� Top$ 87��6h   .��5F   "     8 1http://schemas.root-project.org/xaml/presentation  6b   $% CheckCasher:CustomerFrame:City1��6*   6b   5G      �� 5H      -
   5        $��label4��5H   I   $
��Bold"�6$   
���   �$��28��6W   $ 28��6c   $ 16��5I   "   .��5J   "     8 1http://schemas.root-project.org/xaml/presentation  6d   $' !CheckCasher:CustomerFrame:Street1��6*   6d   5K      �� 5L      -   5        $��street1��5L   2   $��23��6&   $��4��6A   $ 93��6N   $ 16��6_   $	��131��5M   "   �� 5N      -   5        $��label1��5N   U   $
��Bold"�6$   
���   �$��28��6I   $ 29��6c   $ 51��5O   "   .��5P   "     8 1http://schemas.root-project.org/xaml/presentation  6d   $' !CheckCasher:CustomerFrame:Street2��6*   6d   5Q      �� 5R      -   5        $��street2��5R   2   $��23��6&   $��5��6A   $ 93��6N   $ 51��6_   $	��132��5S   "   tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5U   T   7  1System.Windows.Forms.Integration.WindowsFormsHost  6   XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  6T   -   5        $��
cityCBHost��5U   B   $��20.775��62      TabIndex$ 1��5V      $��128,42,50,0q�6#   $	��Top=�68   $	��131��6P   $	 -35��6\   $ 46��6n      Child. 5W   "   #   System.Windows.Forms.ComboBox  -   5           AutoCompleteMode$ SuggestAppend=�5W   a      AutoCompleteSource$ 	ListItems=�5X      city��"   System.Windows.Forms.Control   TabIndex$ 1��6G      	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 6e   5Y   #   5Z      �� 5\      -   5        $��label8��5\   U   $
��Bold"�6$   
���   �$��28��6I   $��46.297��6c   $	 275��5]   "   $ 15��64   .��5^   "     8 1http://schemas.root-project.org/xaml/presentation  6c   $&  CheckCasher:CustomerFrame:State1��6*   6c   5_      �� 5`      -   5        $��state��5`   2   $��23��6&   $��7��6?   $	 335��6L   $ 20��6^   $	��127��6n   �� 5a      -   5        $��label10��5a   I   $
��Bold"�6$   
���   �$��53��6X   $	 515��6c   $ 25��5b   "   .��5c   "     8 1http://schemas.root-project.org/xaml/presentation  6`   $# CheckCasher:CustomerFrame:Fax��6*   6`   5d      �� 5e      -   5        $	��fax��5e   &   $��9��61   $	 576��6>   $ 23��6P   $	��126��6`   �� 5f      -   5        $��label11��5f   U   $
��Bold"�6$   
���   �$��28��6I   $��53��6d   $	 515��5g   "   $ 57��64   .��5h   "     8 1http://schemas.root-project.org/xaml/presentation  6b   $% CheckCasher:CustomerFrame:Email��6*   6b   5i      �� 5j      -   5        $��email��5j   2   $��23��6&   $��10��6?   $	 578��6M   $ 55��6_   $	��126��5k   "   �� 5l      -   5        $��label3��5m   S   $	 274��5l   $   $ 51��66   $
��Bold"�5m   "   
���   �$��28��6G   $��46.297��6a   ��5l   F     *CheckCasher:CustomerFrame:Zip+5m   a   �� 5n      -   5        $	��zip��5n   T   $	 334��6&   $ 56��68   $��23��6H   $��7��6_   $	��127��6l   tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5o   X     6   XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  6X   -   5        $��customerCBHost��5o   B   $��20.775��62   $ 1��6�   $	 580��6�   $ 87��6�   $	��125��6�   . 5p   "     -   5        $ SuggestAppend=�5p   a   $ 	ListItems=�6�   
customerCB��$ 1��6�    . $ 162,58,197,0 6�   6�   5q      �� 5r      -   5        $��label2��5r   U   $
��Bold"�6$   
���   �$��28��6I   $��68��6c   $	 511��6n   $ 86��6�   .��5s   "     8 1http://schemas.root-project.org/xaml/presentation  6e   $( "CheckCasher:CustomerFrame:Company1��6*   6e   5t      5u      5v      �� 5w      -   5        $��shipping��5w   _   ��6     *+)CheckCasher:CustomerFrame:ShippingAddress+.��5x      �� $��Stretch=�6!   $��Stretch=�6?   .+�5y      �� -   5        $��label6��5z   G   $ 15��5y   $   $ 82��65   $
��Bold"�5z   "   
���   ���5y   E     *!CheckCasher:CustomerFrame:City2+5z   G   �� 5{      -   5        $��label9��5|   S   $ 10��5{   $   $ 11��65   $
��Bold"�5|   "   
���   �$��28��6G   ��5{   E     *$"CheckCasher:CustomerFrame:Street11+5|   S   �� 5}      -   5        $��	s_street1��5}   S   $ 75��6&   $ 11��67   $��23��6G   $��4��6d   $	��131��5~   "   �� 5      -   5        $��label12��5�   S   $ 11��5   $   $ 46��65   $
��Bold"�5�   "   
���   �$��28��6G   ��5   E     *$"CheckCasher:CustomerFrame:Street21+5�   S   �� 5�      -    5        $��	s_street2��5�   S   $ 75��6&   $ 46��67   $��23��6G   $��5��6d   $	��132��5�   "   �� 5�      -!   5        $��s_city��5�   G   $ 75��6&   $ 82��67   $��6��6U   $��129.402��6b   �� 5�      -"   5        $��label13��5�   S   $	 258��5�   $   $ 80��66   $
��Bold"�5�   "   
���   �$��28��6G   $��53��6b   ��5�   F     *" CheckCasher:CustomerFrame:Phone2+5�   b   �� 5�      -#   5        $��s_phone��5�   T   $	 315��6&   $ 82��68   $��23��6H   $��8��6c   $	��125��5�   "   �� 5�      -$   5        $��label14��5�   S   $	 257��5�   $   $ 10��66   $
��Bold"�5�   "   
���   �$��28��6G   $��46.297��6b   ��5�   F     *" CheckCasher:CustomerFrame:State2+5�   b   �� 5�      -%   5        $��s_state��5�   T   $	 317��6&   $ 15��68   $��23��6H   $��7��6c   $	��127��5�   "   �� 5�      -&   5        $��label15��5�   G   $	 497��5�   $   $ 20��66   $
��Bold"�5�   "   
���   �$��53��6V   ��5�   F     * CheckCasher:CustomerFrame:Fax1+5�   V   �� 5�      -'   5        $��s_fax��5�   H   $	 558��6&   $ 18��68   $��9��6U   $	��126��6b   �� 5�      -(   5        $��label16��5�   S   $	 497��5�   $   $ 52��66   $
��Bold"�5�   "   
���   �$��28��6G   $��53��6b   ��5�   F     *" CheckCasher:CustomerFrame:Email1+5�   b   �� 5�      -)   5        $��s_email��5�   T   $	 560��6&   $ 50��68   $��23��6H   $��10��6c   $	��126��5�   "   �� 5�      -*   5        $��label17��5�   S   $	 256��5�   $   $ 46��66   $
��Bold"�5�   "   
���   �$��28��6G   $��46.297��6b   ��5�   F     * CheckCasher:CustomerFrame:Zip1+5�   b   �� 5�      -+   5        $��s_zip��5�   T   $	 316��6&   $ 51��68   $��23��6H   $��7��6a   $	��127��6n   5�      5�      5�      �� 5�      -,   5        $��firstNameLabel��5�   I   $
��Bold"�6   
���   �$��28��6=   $��63��6_   $��2��5�      $��273,46,73,194q�6*   .��5�        8 1http://schemas.root-project.org/xaml/presentation  6[   $* $CheckCasher:CustomerFrame:FirstName1��6   6[   5�      �� 5�      --   5        $��	firstName��5�   &   $��23��6   $��2��67   $	��129��6D   $��1��6P   $��2��6`   $��46,42,172,203q�5�      �� 5�      -.   5        $��lastNameLabel��5�   =   $
��Bold"�6   
���   �$��63��6R   $��2��6]   $��98,48,84,204q�5�      .��5�        8 1http://schemas.root-project.org/xaml/presentation  6Z   $) #CheckCasher:CustomerFrame:LastName1��6   6Z   5�      �� 5�      -/   5        $��lastName��5�      $��3��6*   $	��131��67   $��2��6C   $��2��6S   $��178,44,152,202q�5�      �� 5�      -0   5        $��label5��5�   =   $
��Bold"�6   
���   �$��53��6K   $��34,43,220,203q�6V   .��5�        8 1http://schemas.root-project.org/xaml/presentation  6W   $&  CheckCasher:CustomerFrame:Phone1��6   6W   5�      tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5�   I     6   XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  6I   -1   5        $��phoneCBHost��5�   6   $��20.775��6&   $ 1��6�   $��
91,42,85,0q�6�   $	��Top=�6�   $	��131��6�   . 5�        -2   5        $ SuggestAppend=�5�   V   $ 	ListItems=�6w   	phone��$ 1��6�    . $ 162,58,197,0 6�   6�   5�      ��5�      �� 5�      5�      5�      5�       N� 
Background 5�      �� 5�   
   5�      