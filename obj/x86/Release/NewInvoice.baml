   M S B A M L   `   `   `  ���� [  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  M ICheckCasher, Version=1.0.4063.31950, Culture=neutral, PublicKeyToken=null)clr-namespace:CheckCasherCheckCasher    CheckCasher.NewInvoice   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     +localclr-namespace:CheckCasher     [ WWPFLocalizeExtension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=1949495244fd89a8;lex1http://schemas.root-project.org/xaml/presentation  -     N� Title  6  0WPFLocalizeExtension.Extensions.LocTextExtension  *" CheckCasher:NewInvoice:Dashboard+ � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.��(� $	��Top=�$��Center=� (� Stretch$
 Fill=�.��]� $
��Auto��$
��Auto����. 
������ $��Center=�$	��Top=�.+�� $	��Top=�$��Center=�$	��556��$
��1111��$��-1q� � RowDefinitions �� $��225.533* ��� $
��194* ��� $
��136* � � ColumnDefinitions �� $��226.407* ��� $	��102 ��� $
��181* ��� $��215.297 ��� $
��178* �.+��� -   $��canvas1��$��	8,0,57,31q����#FFFFFF$��3��$	��154��$��Bottom=� K� ZIndex$
 -500��.+��� -   $��
rectangle3�����#FFFFFF$	��169��
���   �$	��589��	 �� Left$	 0��

 �� Top$
 -6���� -   $
��save��$��Normal"�$��12(�$��11��$��22��$		 227��$	
 126��$��66��.��  8 1http://schemas.root-project.org/xaml/presentation  �  �WPFLocalizeExtension.BaseExtensions.BaseLocalizeExtension`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   ResourceIdentifierKey$  CheckCasher:NewInvoice:Add���� -   $��Itemcodelbl��$
��Bold"�
���   �$��28��$��39��$		 196��$
 22��.��  8 1http://schemas.root-project.org/xaml/presentation  $! CheckCasher:NewInvoice:Item���� -   $��
barcodeLbl��$
��Bold"�
���   �$��61.105��$��28��$		 381��$
 19��.��  8 1http://schemas.root-project.org/xaml/presentation  $$ CheckCasher:NewInvoice:BarCode���� -    ��Name$ itemCB��$��28�� �� 
IsEditable . $��2��$	��104��$		 256��$
 19���� -   $��barCodeCombo��$��3��$��23��$		 448��$
 18��$	��112���� -	   $��label1��$
��Bold"�
���   �$��27.775��$��68��$	 11��$
 22��.��  8 1http://schemas.root-project.org/xaml/presentation  $% CheckCasher:NewInvoice:ItemCode��tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 7  1System.Windows.Forms.Integration.WindowsFormsHost  XmyOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  -
   $��windowsFormsHost1��$	 500��$��20.775��   TabIndex$ 1��$	 76��$
 22��$	��103��   Child. #   System.Windows.Forms.ComboBox  -      AutoCompleteMode$ SuggestAppend=�   AutoCompleteSource$ 	ListItems=�
itemCodeCB��"   System.Windows.Forms.Control   TabIndex$ 1��   	AllowDrop .    Margin+   %System.Windows.Forms.PaddingConverter$ 162,58,197,0 �� -   $��remove��$��12(�$��Normal"�$��12��$��22��$		 299��$	
 126��$��59��.��  8 1http://schemas.root-project.org/xaml/presentation  $# CheckCasher:NewInvoice:Remove���� -   $��qtyTB��$��6��$��0,88,55,138q�$��Right=�$��47��$��2��$		 448��$	
 -21���� -   $��label6��$
��Bold"�
���   �$��0,83,95,143q�$��Right=�$��34.312��$��2��$		 381��$	
 -12��.��  8 1http://schemas.root-project.org/xaml/presentation  $  CheckCasher:NewInvoice:Qty���� -   $��label3��$
��Bold"�
���   �$��191,88,194,138q�$��3��$��2��$
	 -180��$	
 -22��.��  8 1http://schemas.root-project.org/xaml/presentation  $&  CheckCasher:NewInvoice:PriceSell���� -   $��	priceSell��$	 500��$��4��$$��74.437,113.556,102.212,131.444q� �� 
IsReadOnly .  $��4��$	 2��$	
 -52��$	��102���� -   $��curQty��$
��Bold"�$��196,84,212,142q�$��2��$��2��$		 196��$	
 -22������ �� -   $��unitVal��$
��Bold"�$
��Left=�$��
9,86,0,140q�$��11.11��$��3��$		 201��$	
 -36������ �� -   $��label2��$		 196��$
 66��$
��Bold"�
���   �$��3��$��2����  *" CheckCasher:NewInvoice:EditPrice+�� -   $��	editPrice��$		 258��$
 62��$��4�� .  $	 500��$��5��$	��104���� -   $��	savePrint��$��1��$��22��$��68,0,166,75q�$��Bottom=�$��15��$��2��$��2��.��  8 1http://schemas.root-project.org/xaml/presentation  $( "CheckCasher:NewInvoice:SaveInvoice���� -   $��txnView��}�.  J� 	AllowDrop .  � IsSharedSizeScope .  
������ $��2q�
�����p�$��5��$��8,201,228,103q�$��3��$��Arial)�$��14(� �� View �� .P���  �� Width$	 150����  *" CheckCasher:NewInvoice:ItemCode1+�� $	 150����  *CheckCasher:NewInvoice:Item1+�� $	 150����  *CheckCasher:NewInvoice:Qty1+�� $	 150����  *#!CheckCasher:NewInvoice:PriceSell1+�� $	 150����  *CheckCasher:NewInvoice:Amount+�� -   $��
rectangle2��
�����F�$��5��$��8,14,228,185q� J� OpacityMask �	#FF318E8E
���   ��� -   $��	invHeader��
�������$��23.331��$
��Bold"�$��2��$��0,18,165,185q���  *$"CheckCasher:NewInvoice:NewInvoice1+�� -   $��
rectangle1��$��2��$��3��$	��162��$
��Left=�$��
186,41,0,0q�
���   �$	��Top=�$	��288�����#FFFFFF�� -   $��label4��$
��Bold"�
���   �$��27.775��$��209,59,184,139q�$��68��$��2��$��2����  *!CheckCasher:NewInvoice:Customer+  -   $��windowsFormsHost2��$��20.775��$��0,59,29,146q�$	 500��$ 8��$	��149��$��3��$��Right=�.   -   customer�� . $ SuggestAppend=�$ 	ListItems=�$ 162,58,197,0 $ 1���� -   $��label5��$
��Bold"�
���   �$��27.775��$��209,86,184,112q�$��68��$��2��$��2����  *CheckCasher:NewInvoice:Phone+�� -   $��label7��$
��Bold"�
���   �$��209,120,199,90q�$��2��$��2����  *CheckCasher:NewInvoice:Biller+�� -   $��	custPhone��$��23��$��38,86,29,117q�$��9��$��3��  -    $��windowsFormsHost3��$��20.775��$��Right=�$��0,120,29,85q�$	 500��$ 8��$	��149��$��3��.   -!   
biller�� . $ SuggestAppend=�$ 	ListItems=�$ 162,58,197,0 $ 1������  N� 
Background �� 