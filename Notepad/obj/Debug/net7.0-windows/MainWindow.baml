   M S B A M L   `   `   `  ����B  >Notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NotepadNotepad  5   	       Notepad.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Notepad     5   	     � Title$  Notepad��5   	   $	��450��6   $	��800��6&    � 	Resources 5
         HeaderFooterBackgroud �� Color  BodyBackground  HeaderFooterText  BodyText��%�   &	        &	 #     &	 F     &	 j     �� 5   
   $ 	#FF2c2c2c��68   �� 5   
   $ 	#FF3B3B3B��61   �� 5   
   $ 
WhiteSmoke��63   �� 5   
   $ 
WhiteSmoke��6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $��32 �6   �� 5      �� 5      $��28 �6   .+�5   
   �� $��0��6   #��[  6!   o� 5   
   
������ $��Center=�5   &   .@�5      m� $
��File��5      $��Lucida Console)�5      #��[ 5      $��15(�5      $��Center=�6   $��Center=�6:   $��Center=�6\   $��Center=�6y   .@�5      m� -   5        $
��_New��5       m� InputGestureText$ Ctrl + N��6)   $��Lucida Console)�6E   6a   m� 5      -   5        $��_Open��5      $ Ctrl + O��6*   $��Lucida Console)�6F   6b   m� 5       -   5        $��_Save��5       $ Ctrl + S��6*   $��Lucida Console)�6F   6b   �� 5!      m� 5"      -   5        $��_Exit��5"      6*   5#      m� 5$      $
��Edit��5%      $��Lucida Console)�5&      #��[ 5'      $��15(�5(      $��Center=�6   $��Center=�6:   $��Center=�6\   $��Center=�6y   .@�5)      m� -   5        $
��_Cut��5)      $ Ctrl + X��6)   $��Lucida Console)�6E   6a   m� 5*      -   5        $��_Copy��5*      $ Ctrl + C��6*   $��Lucida Console)�6F   6b   m� 5+      -   5        $��_paste��5+      $ Ctrl + V��6+   $��Lucida Console)�6G   6c   5,      m� 5-      $
��View��5.      $��Lucida Console)�5/      #��[ 50      $��15(�51      $��Center=�52      $��Center=�53      $��Center=�54      .@�55      m� -   5        $��	_WrapText��55       m� IsCheckable$
 True��6.    m� 	IsChecked$ false��6A   6s   56      57      �� 58   
   $��1��6   #��[ 6!   �� 59   
   -	   5        $��textBox��5:      $��1��5;      
������ #��[ 5=      $��0q�5>      #��[ 5?       �� AcceptsReturn$
 True��5@      $��5q�5A      $��16(�5B      $��Lucida Console)�5C       �� 
CaretBrush
 �����	 �� TextWrapping$	 NoWrap=�5E      $
 �� HorizontalScrollBarVisibility$

 Auto=�5F      " �� VerticalScrollBarVisibility$
 Auto=�5G      5H      �� 5J   
   $��2��6   #��[  6"   � 5K   
   $��2��6    � ColumnDefinitions 5L      �� 5M      �� 5N      $	��120 �6#   �� 5O      $	��120 �6#   �� 5P      $	��120 �6#   .+�5R      ��  �� Orientation$ 
Horizontal=�5S      .+�5T      �� $
��Ln: ��6   $��Center=�6(   �� 5U      -
   5        $��lineTextBlock��5U      $��1��61   $��2,0,10,0q�6:   $��Center=�6L   6g   �� 5V      $��Col: ��6   $��Center=�6)   �� 5W      -   5        $��columnTextBlock��5W      $��1��63   $��Center=�6<   5X      �� 5Y      $��1��5Z      $
��100%��5[      $��Center=�5\      $
��Left=�5]      �� 5^      $��2��5_      $��Window (CTRLF)��5`      $��Center=�5a      $
��Left=�5b      �� 5d      $��3��5e      $��UTF-8��5f      $��Center=�5g      $
��Left=�5h      5j      5k      5l      