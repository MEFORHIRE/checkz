   M S B A M L   `   `   `  ����   CheckCasher    CheckCasher.PrintInvoice   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       N� 
Background
  ����� N� Title$ Print Invoice��$��Center=�$
��Auto��$
��1103�� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.���� -   $��viewbox����. $��Visible=�
�������.��� 
�������$
��1102��.+��� -   $��
rectangle2��
�������$��26,51,379,468q� J� OpacityMask �	#FF318E8E
���   ��� -   $��
rectangle1��
�������$	��132��$
��Left=�$��	26,76,0,0q�
���   �$	��Top=�$	��697���� -   $��printinvView��}�.  $
��Auto��$��Stretch=�$��Stretch=�$��Hidden=� J� 	AllowDrop . $��14(�$��Arial)�
�������
�����p�$��2q� � IsSharedSizeScope .  $��26,208,379,90q�	 �� View	 �� .P��� $
��Item��
 �� Width$	
 140���� $��Description��$	
 100���� $	��Qty��$	
 100���� $��
Price Sell��$	
 100���� $��Amount��$	
 100���� -   $��label1��$��Invoice No:��$��16(�$��Normal"�
���   �$��24��$
��Left=�$��	39,13,0,0q�$	��Top=�$��92���� -   $��label3��$��Total��$
��Bold"�
���   �$��28��$
��Left=�$��
540,0,0,35q�$��Bottom=�$��47���� -   $��totalTB��$��23��$��Right=� �� 
IsReadOnly . $��
0,0,404,40q�$��4��$��Bottom=�$��90��$��0q��� -   $��label2��$��Bill To��$
��Bold"�
���   �$��19��$
��Left=�$��
247,84,0,0q�$	��Top=�$��65���� -	   $��
customerTB��$	��108��$��Right=�$��
0,84,626,0q�$	��Top=�$	��185���� -
   $��print��$��Print��$��23��$��358,0,674,15q�$��Bottom=�$
��Bold"��� -   $��invNo��$��16(�$��Normal"�
�����F�$��27��$
��Left=�$��
137,12,0,0q�$	��Top=�$��49���� -   $��billerTB��$	��108��$
��Left=�$��	39,84,0,0q�$	��Top=�$	��185���� -   $
��date��$��16(�$
��Bold"�
���   �$��27��$��Right=�$��
0,13,390,0q�$	��Top=�$	��190���� -   $��label6��$��Ship To��$
��Bold"�
���   �$��19��$��Right=�$��
0,84,556,0q�$	��Top=�$��65���� -   $��shipTo��$	��108��$��Right=�$��
0,84,390,0q�$	��Top=�$	��185���� -   $��label9��$��Invoice��$
��Bold"�
���   �$��330,51,724,476q��� -   $��label4��$��Date:��$��16(�$��Normal"�
���   �$��37��$
��Left=�$��
416,12,0,0q�$	��Top=�$��45���� -   $��label5��$��$��$
��Bold"�
���   �$��28��$
��Left=�$��
593,0,0,33q�$��Bottom=�$��9��