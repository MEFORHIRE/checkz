   M S B A M L   `   `   `  ���� X  TInvoice365, Version=1.0.3989.38771, Culture=neutral, PublicKeyToken=db2d1b37798ad79b'clr-namespace:Invoice365
Invoice365  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms     Invoice365.Invoices   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     *localclr-namespace:Invoice365     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Omy@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms        Invoice365.Inv365Sortable    Initialized$  Window_Initialized�� N� Title$ Invoices��$��Center=� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.��(� $	��Top=�$��Center=� (� Stretch$
 Fill=�.��� $
��1064�� � ShowGridLines .  ����  � ColumnDefinitions �� $
��496* ��� $
��568* �	 � RowDefinitions	 �� $	��25* ��� $
��Auto �.+��� -   $��
rectangle2��
�����F�$��0,-1,0,2q�
 J� OpacityMask
 �	#FF318E8E
���   �$��2��$
��Left=�$	��839���� -   $��invView��$��Arial)�$��14(�$��0,90,225,77q�}�.  J� 	AllowDrop .  � IsSharedSizeScope .  
������ $��2q�
�����p�$��1��$��2�� �� View �� .P���  �� Width$	 140��$
��Date���� $	 100��$��
Invoice No���� $	 100��$��Customer���� $	 100��$��
Created By���� $	 100��$��Biller���� -   $��
rectangle1�����#FFFFFF$��86��$��
0,28,225,0q�
���   �$	��Top=�$��2��$��2���� -   $��
barcodeLbl��$��
Invoice No��$
��Bold"�
���   �$��28��$��137,31,298,457q�$��61.105��$��1���� -   $��	invoiceNo��$��23��$��0,30,180,463q�$��3��$	��112��$��Right=�$��1���� -   $��label4��$��Customer��$
��Bold"�
���   �$��27.775��$��357,34,71,454q�$��68��$��1��7  1System.Windows.Forms.Integration.WindowsFormsHost  -   $��windowsFormsHost2��$��20.775��$��Right=�$��0,34,493,461q� K� ZIndex$	 500��   TabIndex$ 8��$	��149��$��1��$��2��   Child. #  System.Windows.Forms.ComboBox  -   customer��"  System.Windows.Forms.Control   	AllowDrop .    AutoCompleteMode$ SuggestAppend=�   AutoCompleteSource$ 	ListItems=�   Margin+  %System.Windows.Forms.PaddingConverter$ 162,58,197,0    TabIndex$ 1���� -	   $��label9��$��Invoice Search��$
��Bold"�
�������$��23.331��$��403,1,395,5q�$��2���� -
   $
��save��$��Print Invoice��$��12(�$
��Bold"�$��22��$��281,454,120,40q�$��11��$��1���� -   $��remove��$��Edit Invoice��$��12(�$
��Bold"�$��22��$��0,454,564,40q�$��12��$��1��$��Right=�$��97��$��2�� N� 
Background �� 