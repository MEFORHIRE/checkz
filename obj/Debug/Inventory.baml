   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   =   Y UCheckCasher, Version=1.0.4060.30418, Culture=neutral, PublicKeyToken=db2d1b37798ad79b)clr-namespace:CheckCasherCheckCasher 5         CheckCasher.Inventory   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      67   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     6=   +localclr-namespace:CheckCasher     5      [ WWPFLocalizeExtension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1949495244fd89a8;lex1http://schemas.root-project.org/xaml/presentation  5   D      CheckCasher.Inv365Sortable    Initialized$  Window_Initialized��6#   $��Center=�6    N� Title 5   .   6  0WPFLocalizeExtension.Extensions.LocTextExtension  *" CheckCasher:Inventory:Inventory1+ � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5	      .��5
      (� $	��Top=�6   $��Center=�6&    (� Stretch$
 Fill=�6C   .��5   
   � $	��585��6   $	��959��6    � ShowGridLines .   � ColumnDefinitions 5      �� 5      $��0* �6#   �� 5      $
��388* �6#   �� 5      $	��91* �6#   �� 5      $
��480* �6#   .+�5      �� -   5        $��
rectangle1��5   <   $��1��6   $��
7,33,123,0q�6(   
���   �$	��174��6]   $	��Top=�5      $��3��6*   ���#FFFFFF6>   �� 5      -   5        $��
rectangle2��5      
�����F�$��1��5   )   $��3��69   $��7,9,123,552q�6M   	 J� OpacityMask	 �	#FF318E8E
���   �5   <   �� 5      -   5        $��invView��5      $��5,222,123,35q�5   W   }�. 
 J� 	AllowDrop
 .  � IsSharedSizeScope . 
������ $��2q�5   +   
�����p�$��3��6W   $��1��5      $��Arial)�6N   $��14(�6a    �� View 5      �� 5      .P�5      ��  �� Width$	 100��6)   ��65     * CheckCasher:Inventory:ItemCode+�� 5      $	 140��6[   ��6)     *CheckCasher:Inventory:Item+6[   �� 5      $	 140��6]   ��6)     *CheckCasher:Inventory:Vendor+6]   �� 5       $ 80��6Z   ��6)     *CheckCasher:Inventory:Qty+6Z   �� 5"      $ 80��6_   ��6)     * CheckCasher:Inventory:PriceBuy+6_   �� 5#      $ 80��6`   ��6)     *!CheckCasher:Inventory:PriceSell+6`   5$      5&      �� 5'      -   5        $��label1��5'   4   $��20��6   $��
0,10,477,0q�6    $	��Top=�6B   $��12(�6Z   $
��Bold"�5(      
�������$��1��67   $��Right=�6G   $	��116��6c   $��3��5)      ��6&     *$"CheckCasher:Inventory:AddInventory+5*      �� 5+      -   5        $��label2��5,   %   $
��Bold"�5+      
���   �$��27.775��69   $
��Left=�6I   $��	15,66,0,0q�5,      $	��Top=�63   $��47��6K   $��1��6V   ��5-        *CheckCasher:Inventory:ItemNo+5.      �� 5/      -   5        $��Itemcodelbl��5/   X   $
��Bold"�6   
���   �$��28��69   $��	22,66,0,0q�6E   $	��Top=�50      $��2��6*   $
��Left=�6:   $��40.969��6U   .��51        8 1http://schemas.root-project.org/xaml/presentation  6N   �  �WPFLocalizeExtension.BaseExtensions.BaseLocalizeExtension`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceIdentifierKey$! CheckCasher:Inventory:Item1��6   6N   52      �� 53      -   5        $��
barcodeLbl��53   Y   $
��Bold"�6   
���   �$��28��69   $��
221,66,0,0q�6E   $	��Top=�54      $��1��6*   $
��Left=�6:   $��49��6U   ��6`     *CheckCasher:Inventory:Barcode+55      tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 57      7  1System.Windows.Forms.Integration.WindowsFormsHost  56      XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  57      -   5        $��windowsFormsHost1��56   S    �� Left$ 82��6"   
 �� Top$ 93��63   $��20.775��6C   $	��123��57      $
��Left=�58      $��	86,66,0,0q�6-   $	��Top=�6@   $��1��6X      TabIndex$ 1��59         Child. 5:      #   System.Windows.Forms.ComboBox  -	   5           AutoCompleteMode$ SuggestAppend=�5:   Q      AutoCompleteSource$ 	ListItems=�5;      
itemCodeCB��"   System.Windows.Forms.Control   TabIndex$ 1��6I      	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 6g   5<      5=      �� 5>      -
   5        $��barCodeCombo��5>   Q   $��23��6   $��Right=�6"   $��	0,66,84,0q�6>   $	��Top=�5?      $	��124��6*   $��1��66   $��2��5@      $��2��6   �� 5A      -   5        $��qtyTB��5A   ;   $��23.331��6   $��0,104,454,0q�6&   $��9��6H   $	��Top=�6U   $��2��5B      $��Right=�6"   $��45��6>   $��2��6I   �� 5C      -   5        $��label6��5C   Y   $
��Bold"�6   
���   �$��28��69   $��
20,104,0,0q�6E   $	��Top=�5D      $��2��6*   $
��Left=�6:   $��59��6U   .��5E        8 1http://schemas.root-project.org/xaml/presentation  6Q   $$ CheckCasher:Inventory:Quantity��6   6Q   5F      �� 5G      -   5        $��label3��5G   Z   $
��Bold"�6   
���   �$��28��69   $��0,110,308,0q�6E   $	��Top=�5H      $��1��6*   $��Right=�6:   $��65��6V   .��5I        8 1http://schemas.root-project.org/xaml/presentation  6R   $% CheckCasher:Inventory:PriceBuy1��6   6R   5J      �� 5K      -   5        $��buyTB��5K   6   $��23��6   $��
86,106,0,0q�6"   $��5��6C   $	��Top=�6P   $��1��5L      $
��Left=�6"   $��60.969��6=   �� 5M      -   5        $
��save��5M   Y   $��12(�6   $��Normal"�6#   $��26.02��67   $��	0,171,6,0q�6F   $	��Top=�5N      $��1��6*   $��11��6M   $��Right=�6[   $��71��5O      ��6     *CheckCasher:Inventory:Save+5P      �� 5Q      -   5        $��remove��5Q   Z   $��12(�6   $��Normal"�6#   $��26.02��67   $��
0,171,12,0q�6F   $	��Top=�5R      $��2��6*   $��12��6O   $��Right=�6]   $��71��5S      .��5T        8 1http://schemas.root-project.org/xaml/presentation  6O   $" CheckCasher:Inventory:Remove��6   6O   5U      �� 5V      -   5        $
��unit��5V   K   $��1��6   $��23.331��6&   $��0,144,239,0q�66   $��7��6W   $	��Top=�5W      $��Right=�6*   $	��100��6F   $y�Hidden=�6R   �� 5X      -   5        $��label4��5Y      $
��Bold"�5X      
���   �$��1��69   $��28��6I   $��
15,144,0,0q�6U   $	��Top=�5Y       $
��Left=�68   $��38��6S   $y�Hidden=�6^   .��5Z        8 1http://schemas.root-project.org/xaml/presentation  6M   $  CheckCasher:Inventory:Unit��6   6M   5[      �� 5\      -   5        $��label5��5\   ^   $
��Bold"�6   
���   �$��1��69   $��170,144,0,0q�6I   $��28��5]      $	��Top=�6   $
��Left=�66   $��73��6Q   $y�Hidden=�6\   .��5^        8 1http://schemas.root-project.org/xaml/presentation  6R   $% CheckCasher:Inventory:UnitValue��6   6R   5_      �� 5`      -   5        $��	unitValue��5`   G   $��1��6   $��23��6&   $��239,144,0,0q�62   $��8��6X   $	��Top=�5a      $
��Left=�6*   $��61.031��6E   $y�Hidden=�6T   �� 5b      -   5        $��label7��5c      $
��Bold"�5b      
���   �$��1��69   $��28��6I   $��218,103,0,0q�6U   $	��Top=�5c       $
��Left=�68   $��53��6S   .��5d        8 1http://schemas.root-project.org/xaml/presentation  6S   $&  CheckCasher:Inventory:PriceSell1��6   6S   5e      �� 5f      -   5        $��sellTB��5f   F   $��1��6   $��23��6&   $��
0,104,54,0q�62   $��6��6T   $	��Top=�5g      $��Right=�6*   $��60.969��6F   �� 5h      -   5        $��indBox��5i      $��3��5h      $��17.901��6'   $��Right=�67   $��0,113,141,0q�6S   $	��Top=�5i       $��85.31��68   $��10��6F   $y�Hidden=�6T   .��5j        8 1http://schemas.root-project.org/xaml/presentation  6S   $&  CheckCasher:Inventory:Individual��6   6S   5k      �� 5l      -   5        $��label8��5m   a   $
��Bold"�5l   J   
���   �$��3��5m      $��27.775��6"   $
��Left=�62   $��
153,65,0,0q�6M   $	��Top=�5n      $��50��6*   ��5l        *CheckCasher:Inventory:Vendor1+5n   *     5o      -   5        $��windowsFormsHost2��5p   A   $ 82��5o      $ 93��60   $��3��6@   $��20.775��6P   $
��Left=�5p      $��
203,64,0,0q�6-   $ 4��6Z   $	��Top=�5q      $	��123��6*   . 5r        -   5        
vendor�� . $ SuggestAppend=�5r   ?   $ 	ListItems=�6`   $ 162,58,197,0 5s      $ 1��6_   5t      �� 5u      -   5        $��itemCB��5u   J   $��26��6    �� 
IsEditable . $��67,64,335,0q�65   $��3��6X   $	��Top=�5v      $��2��6*   $��2��6:   5w      5x      5y      