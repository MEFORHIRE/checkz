   M S B A M L   `   `   `  ����Y  UCheckCasher, Version=1.0.4060.30418, Culture=neutral, PublicKeyToken=db2d1b37798ad79b)clr-namespace:CheckCasherCheckCasher  5      [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   �       CheckCasher.SalesReport   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +localclr-namespace:CheckCasher     5      5z-http://schemas.microsoft.com/wpf/2008/toolkit  5      Gy9http://schemas.microsoft.com/netfx/2007/xaml/presentation     5      @d2http://schemas.microsoft.com/expression/blend/2008     5   i   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   Omy@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     6�       CheckCasher.Inv365Sortable    Initialized$  Window_Initialized��6    N� Title$ Sales Report��6   $��Center=�6;    � 	Resources 5	       �� 
TargetType �� Property �� Value��%W   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5      .��5      (� $	��Top=�6   $��Center=�6&    (� Stretch$
 Fill=�6C   .��5      � $
��1064��6   ��5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $
��510* �6   �� 5      $
��382* �6   �� 5      $
��172* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��
rectangle2��5   7   
�����F�$��0,-1,0,2q�6%   	 J� OpacityMask	 �	#FF318E8E
���   �$��2��6p   $
��Left=�6�   $	��839��6�   �� 5   
   -   5        $��invView��5   (   $��Arial)�5   T   $��14(�6g   $��
0,90,53,77q�5      }�. 
 J� 	AllowDrop
 .  � IsSharedSizeScope .  
������ $��2q�5   -   
�����p�$��1��6Y   $	��349��5       $��2��6!    �� View 5!      �� 5"      .P�5#      ��  �� Width$	 140��6%   $��	Item Code��61   �� 5$      $	 140��6%   $
��Item��61   �� 5%      $	 100��6%   $��	Qty Sold ��61   �� 5'      $	 100��6%   $��Amount��61   5)      5+      �� 5-   
   -   5        $��
rectangle1��5-   B   ���#FFFFFF$��86��6#   $��	0,28,53,0q�6/   
���   �$	��Top=�6c   $��2��6{   $��2��6�   �� 5.   
   -   5        $��reportTitle��5.   y   $��Product Sales Report��6   $
��Bold"�6/   
�������$��23.331��6T   $��325,0,301,6q�6d   $��2��6�   +  %Microsoft.Windows.Controls.DatePicker  51   
   -   5        $��	startDate��52   N      SelectedDateFormat$
 Long=�51         FirstDayOfWeek$ Monday=�52      $��94,8,201,478q�6+   $��1��6A   6N     53   
   -   5        $��endDate��53   �   $ Monday=�6   $��408,7,270,479q�6/   $
 Long=�6F   $��1��6`   $��2��6m      Text$  ��6�   6�   �� 54   
   -   5        $��label2��54   �   $��
Start Date��6   $
��Bold"�6%   
���   �$��27.775��6J   $
��Left=�6Z   $��	29,11,0,0q�6u   $	��Top=�6�   $��70��6�   $��1��6�   �� 55   
   -   5        $��label1��55   �   $��End Date��6   $
��Bold"�6#   
���   �$��27.775��6H   $��Right=�6X   $��
0,11,108,0q�6t   $	��Top=�6�   $��60��6�   $��1��6�   �� 56   
   -	   5        $��generate��56   �   $��Generate Report��6   $��12(�6+   $��Normal"�69   $��26.02��6M   $��Right=�6\   $��
0,24,101,0q�6x   $��11��6�   $	��Top=�6�   $	��115��6�   $��1��6�   $��1��6�   6�   �� 57   
   -
   5        $��button1��57   �   $��Export to Csv File��6   $��12(�6.   $��Normal"�6<   $��26.02��6P   $��Right=�6_   $��0,445,370,0q�6{   $��11��6�   $	��Top=�6�   $	��106��6�   $��1��6�   $��2��6�   7  1System.Windows.Forms.Integration.WindowsFormsHost  58      -   5        $��windowsFormsHost1��58   a   $��20.775��6   $��Right=�6/   $��0,48,266,447q�6K    K� ZIndex$	 500��6z      TabIndex$ 8��6�   $	��149��6�   $��1��6�      Child. 59      #  System.Windows.Forms.ComboBox  -   5        customer��"  System.Windows.Forms.Control   	AllowDrop .    AutoCompleteMode$ SuggestAppend=�59   A      AutoCompleteSource$ 	ListItems=�6b      Margin+  %System.Windows.Forms.PaddingConverter$ 162,58,197,0 6�      TabIndex$ 1��6�   5:        5;      -   5        $��windowsFormsHost2��5;   a   $��20.775��6   $��Right=�6/   $��0,48,334,447q�6K   $	 500��6z   $ 8��6�   $	��149��6�   $��2��6�   $��1��6�   . 5<        -   5        	custphone�� . $ SuggestAppend=�5<   B   $ 	ListItems=�6c   $ 162,58,197,0 6�   $ 1��6�   5=      �� 5>      -   5        $��label3��5>   �   $��Customer��6   $
��Bold"�6'   
���   �$��27.775��6L   $
��Left=�6\   $��	29,47,0,0q�6w   $	��Top=�6�   $��63��6�   $��1��6�   �� 5?      -   5        $��label4��5?   �   $��Phone��6   $
��Bold"�6$   
���   �$��27.775��6I   $
��Left=�6Y   $��
341,46,0,0q�6t   $	��Top=�6�   $��61��6�   $��1��6�   5@      5A       N� 
Background 5B      �� 5C   
   5E      