   M S B A M L   `   `   `  ���� X  TInvoice365, Version=1.0.3989.38771, Culture=neutral, PublicKeyToken=db2d1b37798ad79b'clr-namespace:Invoice365
Invoice365  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms     Invoice365.SalesReport   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     *localclr-namespace:Invoice365     5z-http://schemas.microsoft.com/wpf/2008/toolkit  Gy9http://schemas.microsoft.com/netfx/2007/xaml/presentation     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Omy@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms        Invoice365.Inv365Sortable    Initialized$  Window_Initialized�� N� Title$ Sales Report��$��Center=� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=�.��(� $	��Top=�$��Center=� (� Stretch$
 Fill=�.��� $
��1064������  � ColumnDefinitions �� $
��510* ��� $
��382* ��� $
��172* � � RowDefinitions �� $	��25* ��� $
��Auto �.+��� -   $��
rectangle2��
�����F�$��0,-1,0,2q�	 J� OpacityMask	 �	#FF318E8E
���   �$��2��$
��Left=�$	��839���� -   $��invView��$��Arial)�$��14(�$��
0,90,53,77q�}�. 
 J� 	AllowDrop
 .  � IsSharedSizeScope .  
������ $��2q�
�����p�$��1��$	��349��$��2�� �� View �� .P���  �� Width$	 140��$��	Item Code���� $	 140��$
��Item���� $	 100��$��	Qty Sold ���� $	 100��$��Amount���� -   $��
rectangle1�����#FFFFFF$��86��$��	0,28,53,0q�
���   �$	��Top=�$��2��$��2���� -   $��reportTitle��$��Product Sales Report��$
��Bold"�
�������$��23.331��$��325,0,301,6q�$��2��+  %Microsoft.Windows.Controls.DatePicker  -   $��	startDate��   SelectedDateFormat$
 Long=�   FirstDayOfWeek$ Monday=�$��94,26,201,460q�$��1��  -   $��endDate��$ Monday=�$��408,25,270,461q�$
 Long=�$��1��$��2��   Text$  ���� -   $��label2��$��
Start Date��$
��Bold"�
���   �$��27.775��$
��Left=�$��	29,29,0,0q�$	��Top=�$��70��$��1���� -   $��label1��$��End Date��$
��Bold"�
���   �$��27.775��$��Right=�$��
0,29,108,0q�$	��Top=�$��60��$��1���� -	   $��generate��$��Generate Report��$��12(�$��Normal"�$��26.02��$��Right=�$��
0,24,101,0q�$��11��$	��Top=�$	��115��$��1��$��1���� -
   $��button1��$��Export to Csv File��$��12(�$��Normal"�$��26.02��$��Right=�$��0,445,370,0q�$��11��$	��Top=�$	��106��$��1��$��2�� N� 
Background �� 