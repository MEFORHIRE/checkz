   M S B A M L   `   `   `  ���� [  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  X TInvoice365, Version=1.0.3989.38771, Culture=neutral, PublicKeyToken=db2d1b37798ad79b'clr-namespace:Invoice365
Invoice365    Invoice365.Inventory   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     *localclr-namespace:Invoice365       Invoice365.Inv365Sortable    Initialized$  Window_Initialized�� N� Title$ 	Inventory��$��Center=� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.��(� $	��Top=�$��Center=� (� Stretch$
 Fill=�.��� $	��585��$	��959�� � ShowGridLines .   � ColumnDefinitions �� $��0* ��� $
��388* ��� $	��91* ��� $
��480* �.+��� -   $��
rectangle1��$��1��$��
7,33,123,0q�
���   �$	��174��$	��Top=�$��3�����#FFFFFF�� -   $��
rectangle2��
�����F�$��1��$��3��$��7,9,123,552q�	 J� OpacityMask	 �	#FF318E8E
���   ��� -   $��invView��$��5,222,123,35q�}�. 
 J� 	AllowDrop
 .  � IsSharedSizeScope . 
������ $��2q�
�����p�$��3��$��1��$��Arial)�$��14(� �� View �� .P���  �� Width$	 100��$��	Item Code���� $
��Item��$	 140���� $��Vendor��$	 140���� $	��Qty��$ 80���� $��	Price Buy��$ 80���� $��
Price Sell��$ 80���� -   $��label1��$��20��$��
0,10,477,0q�$	��Top=�$��12(�$
��Bold"�
�������$��1��$��Right=�$	��116��$��3��$��Add Inventory���� -   $��label2��$
��Bold"�
���   �$��27.775��$
��Left=�$��	15,66,0,0q�$	��Top=�$��47��$��1��$��Item No���� -   $��Itemcodelbl��$
��Bold"�
���   �$��28��$��	22,66,0,0q�$	��Top=�$��2��$
��Left=�$��40.969��.��Item�� -   $��
barcodeLbl��$
��Bold"�
���   �$��28��$��
221,66,0,0q�$	��Top=�$��1��$
��Left=�$��49��$��Barcode��tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 7  1System.Windows.Forms.Integration.WindowsFormsHost  ^myOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     -   $��windowsFormsHost1�� �� Left$ 82��
 �� Top$ 93��$��20.775��$	��123��$
��Left=�$��	86,66,0,0q�$	��Top=�$��1��   TabIndex$ 1��   Child. #   System.Windows.Forms.ComboBox  -	      AutoCompleteMode$ SuggestAppend=�   AutoCompleteSource$ 	ListItems=�
itemCodeCB��"   System.Windows.Forms.Control   TabIndex$ 1��   	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 �� -
   $��barCodeCombo��$��23��$��Right=�$��	0,66,84,0q�$	��Top=�$	��124��$��1��$��2��$��2���� -   $��qtyTB��$��23.331��$��0,104,454,0q�$��9��$	��Top=�$��2��$��Right=�$��45��$��2���� -   $��label6��$
��Bold"�
���   �$��28��$��
20,104,0,0q�$	��Top=�$��2��$
��Left=�$��59��.��
Quantity�� -   $��label3��$
��Bold"�
���   �$��28��$��0,110,308,0q�$	��Top=�$��1��$��Right=�$��65��.��	Price Buy�� -   $��buyTB��$��23��$��
86,106,0,0q�$��5��$	��Top=�$��1��$
��Left=�$��60.969���� -   $
��save��$��12(�$��Normal"�$��26.02��$��	0,171,6,0q�$	��Top=�$��1��$��11��$��Right=�$��71��$
��Save���� -   $��remove��$��12(�$��Normal"�$��26.02��$��
0,171,12,0q�$	��Top=�$��2��$��12��$��Right=�$��71��.��Remove�� -   $
��unit��$��1��$��23.331��$��0,144,239,0q�$��7��$	��Top=�$��Right=�$	��100��$y�Hidden=��� -   $��label4��$
��Bold"�
���   �$��1��$��28��$��
15,144,0,0q�$	��Top=�$
��Left=�$��38��$y�Hidden=�.��Unit�� -   $��label5��$
��Bold"�
���   �$��1��$��170,144,0,0q�$��28��$	��Top=�$
��Left=�$��73��$y�Hidden=�.��
Unit Value�� -   $��	unitValue��$��1��$��23��$��239,144,0,0q�$��8��$	��Top=�$
��Left=�$��61.031��$y�Hidden=��� -   $��label7��$
��Bold"�
���   �$��1��$��28��$��218,103,0,0q�$	��Top=�$
��Left=�$��53��.��
Price Sell�� -   $��sellTB��$��1��$��23��$��
0,104,54,0q�$��6��$	��Top=�$��Right=�$��60.969���� -   $��indBox��$��3��$��17.901��$��Right=�$��0,113,141,0q�$	��Top=�$��85.31��$��10��$y�Hidden=�.��
Individual�� -   $��label8��$��Vendor��$
��Bold"�
���   �$��3��$��27.775��$
��Left=�$��
153,65,0,0q�$	��Top=�$��50��  -   $��windowsFormsHost2��$ 82��$ 93��$��3��$��20.775��$
��Left=�$��
203,64,0,0q�$ 4��$	��Top=�$	��123��.   -   
vendor�� . $ SuggestAppend=�$ 	ListItems=�$ 162,58,197,0 $ 1���� -   $��itemCB��$��26�� �� 
IsEditable . $��67,64,335,0q�$��3��$	��Top=�$��2��$��2��