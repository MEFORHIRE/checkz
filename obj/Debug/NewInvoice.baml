   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   =   Y UCheckCasher, Version=1.0.4060.30418, Culture=neutral, PublicKeyToken=db2d1b37798ad79b)clr-namespace:CheckCasherCheckCasher 5         CheckCasher.NewInvoice   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      6(   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     6=   +localclr-namespace:CheckCasher     5      [ WWPFLocalizeExtension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1949495244fd89a8;lex1http://schemas.root-project.org/xaml/presentation  5   '   -   5          N� Title  5   .   6  0WPFLocalizeExtension.Extensions.LocTextExtension  *" CheckCasher:NewInvoice:Dashboard+ � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5	      .��5
      (� $	��Top=�6   $��Center=�6&    (� Stretch$
 Fill=�6C   .��5   
   ]� $
��Auto��6   $
��Auto��6!   ��. 
������ $��Center=�5      $	��Top=�6+   .+�5      � $	��Top=�6   $��Center=�6+   $	��556��6H   $
��1111��6U   $��-1q�5       � RowDefinitions 5      �� 5      $��225.533* �6$   �� 5      $
��194* �6$   �� 5      $
��136* �6$    � ColumnDefinitions 5      �� 5      $��226.407* �6'   �� 5      $	��102 �6'   �� 5      $
��181* �6'   �� 5      $��215.297 �6'   �� 5      $
��178* �6'   .+�5      �� -   5        $��canvas1��5   ,   $��	8,0,57,31q�6   ���#FFFFFF$��3��6P   $	��154��5      $��Bottom=�6#    K� ZIndex$
 -500��6>   .+�5      �� -   5        $��
rectangle3��5   <   ���#FFFFFF$	��169��6/   
���   �$	��589��6]   	 �� Left$	 0��5      

 �� Top$
 -6��6*   �� 5      -   5        $
��save��5      $��Normal"�6;   $��12(�6O   $��11��6]   $��22��5       $		 227��6&   $	
 126��68   $��66��6I   .��5!        8 1http://schemas.root-project.org/xaml/presentation  6U   �  �WPFLocalizeExtension.BaseExtensions.BaseLocalizeExtension`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceIdentifierKey$  CheckCasher:NewInvoice:Add��6"   6U   5"      �� 5#      -   5        $��Itemcodelbl��5#   M   $
��Bold"�6   
���   �$��28��6A   $��39��6`   $		 196��5$      $
 22��6,   .��5%        8 1http://schemas.root-project.org/xaml/presentation  6V   $! CheckCasher:NewInvoice:Item��6"   6V   5&      �� 5'      -   5        $��
barcodeLbl��5'   A   $
��Bold"�6   
���   �$��61.105��6S   $��28��6b   $		 381��5(      $
 19��6,   .��5)        8 1http://schemas.root-project.org/xaml/presentation  6Y   $$ CheckCasher:NewInvoice:BarCode��6"   6Y   5*      �� 5+      -   5         ��Name$ itemCB��5+   =   $��28��6    �� 
IsEditable . $��2��6M   $	��104��6Z   $		 256��6f   $
 19��5,      �� 5-      -   5        $��barCodeCombo��5-      $��3��6Y   $��23��6f   $		 448��5.      $
 18��6,   $	��112��6<   �� 5/      -	   5        $��label1��5/   Q   $
��Bold"�6   
���   �$��27.775��6A   $��68��6_   $	 11��50      $
 22��6+   .��51        8 1http://schemas.root-project.org/xaml/presentation  6Z   $% CheckCasher:NewInvoice:ItemCode��6"   6Z   52      tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 53   f   7  1System.Windows.Forms.Integration.WindowsFormsHost  6   XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  6f   -
   5        $��windowsFormsHost1��53   M   $	 500��6*   $��20.775��6=      TabIndex$ 1��54      $	 76��6'   $
 22��68   $	��103��6H      Child. 55      #   System.Windows.Forms.ComboBox  -   5           AutoCompleteMode$ SuggestAppend=�55   Y      AutoCompleteSource$ 	ListItems=�56      
itemCodeCB��"   System.Windows.Forms.Control   TabIndex$ 1��6Q      	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 6o   57      58      �� 59      -   5        $��remove��59   ?   $��12(�6   $��Normal"�6+   $��12��6b   $��22��5:      $		 299��6&   $	
 126��68   $��59��6I   .��5;        8 1http://schemas.root-project.org/xaml/presentation  6X   $# CheckCasher:NewInvoice:Remove��6"   6X   5<      �� 5=      -   5        $��qtyTB��5=      $��6��6+   $��0,88,55,138q�68   $��Right=�6M   $��47��5>      $��2��6%   $		 448��65   $	
 -21��6G   �� 5?      -   5        $��label6��5?   A   $
��Bold"�6   
���   �$��0,83,95,143q�6O   $��Right=�6d   $��34.312��5@      $��2��6)   $		 381��69   $	
 -12��6K   .��5A        8 1http://schemas.root-project.org/xaml/presentation  6U   $  CheckCasher:NewInvoice:Qty��6"   6U   5B      �� 5C      -   5        $��label3��5C   A   $
��Bold"�6   
���   �$��191,88,194,138q�6O   $��3��5D      $��2��6*   $
	 -180��6>   $	
 -22��6Q   .��5E        8 1http://schemas.root-project.org/xaml/presentation  6[   $&  CheckCasher:NewInvoice:PriceSell��6"   6[   5F      �� 5G      -   5        $��	priceSell��5G   1   $	 500��6   $��4��6B   $$��74.437,113.556,102.212,131.444q�6O    �� 
IsReadOnly .  $��4��5H   -   $	 2��6=   $	
 -52��6M   $	��102��6^   �� 5I      -   5        $��curQty��5I   F   $
��Bold"�6   $��196,84,212,142q�6.   $��2��6T   $��2��6d   $		 196��5J      $	
 -22��6,   ��5K      �� 5L      5N      �� 5O      -   5        $��unitVal��5O   ]   $
��Bold"�6   $
��Left=�6.   $��
9,86,0,140q�6I   $��11.11��5P      $��3��6(   $		 201��68   $	
 -36��6J   ��5Q      �� 5R      5T      �� 5U      -   5        $��label2��5V   c   $		 196��5U      $
 66��6.   $
��Bold"�5V      
���   �$��3��6?   $��2��6O   ��5U   >     *" CheckCasher:NewInvoice:EditPrice+5V   c   �� 5W      -   5        $��	editPrice��5W   c   $		 258��6   $
 62��60   $��4��6@    .  $	 500��5X      $��5��6-   $	��104��6:   5Y      �� 5Z      -   5        $��	savePrint��5Z   J   $��1��6   $��22��6)   $��68,0,166,75q�65   $��Bottom=�6[   $��15��5[      $��2��69   $��2��6F   .��5\        8 1http://schemas.root-project.org/xaml/presentation  6Y   $( "CheckCasher:NewInvoice:SaveInvoice��6   6Y   5]      �� 5^      -   5        $��txnView��5^      }�.  J� 	AllowDrop .  � IsSharedSizeScope .  
������ $��2q�5_   _   
�����p�$��5��5`   .   $��8,201,228,103q�6B   $��3��6Y   $��Arial)�5a      $��14(�6)    �� View 5b      �� 5c      .P�5d      ��  �� Width$	 150��6-   ��69     *" CheckCasher:NewInvoice:ItemCode1+�� 5e      $	 150��6-   ��69     *CheckCasher:NewInvoice:Item1+�� 5f      $	 150��6-   ��69     *CheckCasher:NewInvoice:Qty1+�� 5h      $	 150��6-   ��69     *#!CheckCasher:NewInvoice:PriceSell1+�� 5i      $	 150��6-   ��69     *CheckCasher:NewInvoice:Amount+5j      5l      �� 5m      -   5        $��
rectangle2��5m   W   
�����F�$��5��6-   $��8,14,228,185q�6A    J� OpacityMask �	#FF318E8E
���   �5n   .   �� 5o      -   5        $��	invHeader��5o   ;   
�������$��23.331��6+   $
��Bold"�6L   $��2��6^   $��0,18,165,185q�5p      ��6,     *$"CheckCasher:NewInvoice:NewInvoice1+5q      �� 5r      -   5        $��
rectangle1��5s   *   $��2��5r      $��3��6,   $	��162��6@   $
��Left=�6M   $��
186,41,0,0q�5s      
���   �$	��Top=�6K   $	��288��6c   ���#FFFFFF5t      �� 5u      -   5        $��label4��5v   >   $
��Bold"�5u   P   
���   �$��27.775��5v      $��209,59,184,139q�6&   $��68��6L   $��2��6W   $��2��6g   ��5u        *!CheckCasher:NewInvoice:Customer+5v   g     5w      -   5        $��windowsFormsHost2��5w   H   $��20.775��6#   $��0,59,29,146q�63   $	 500��6a   $ 8��5x      $	��149��6#   $��3��6/   $��Right=�6?   . 5y        -   5        customer�� . $ SuggestAppend=�5z   +   $ 	ListItems=�6L   $ 162,58,197,0 6k   $ 1��5{      5|      �� 5}      -   5        $��label5��5~   >   $
��Bold"�5}   M   
���   �$��27.775��5~      $��209,86,184,112q�6&   $��68��6L   $��2��6W   $��2��6g   ��5}        *CheckCasher:NewInvoice:Phone+5~   g   �� 5      -   5        $��label7��5�   .   $
��Bold"�5   N   
���   �$��209,120,199,90q�5�      $��2��6<   $��2��6L   ��5        *CheckCasher:NewInvoice:Biller+5�   L   �� 5�      -   5        $��	custPhone��5�   <   $��23��6   $��38,86,29,117q�6&   $��9��6M   $��3��6Z     5�      -    5        $��windowsFormsHost3��5�      $��20.775��5�   #   $��Right=�63   $��0,120,29,85q�6O   $	 500��5�   /   $ 8��6B   $	��149��6O   $��3��6[   . 5�        -!   5        
biller�� . $ SuggestAppend=�5�   C   $ 	ListItems=�6d   $ 162,58,197,0 5�      $ 1��6c   5�      ��5�      �� 5�      5�      5�      5�       N� 
Background 5�      �� 5�   
   5�      