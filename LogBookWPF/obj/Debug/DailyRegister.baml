   M S B A M L   `   `   `  ����  
LogBookWPF    LogBookWPF.DailyRegister   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  DailyRegister:��5   	   $	��420��6    $	��670��6-    � Icon$ 
logo-1.ico��69    � 
ResizeMode$ CanResizeWithGrip=�6K   .��5      � .+�5   
   � $
��Left=�6   $	��118��6*   $��	0,271,0,0q�67   $	��Top=�6J   $	��662��6b   ���	#FFEFAC20 � ColumnDefinitions 5      �� 5      .+�5
      �� -   5         ��Name$ txtTraining��5
   �   $
��Left=�6   $��73��61   $��	35,27,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��204��6�   
���   �6�   �� 5      -   5         ��Name$ btnSave��5   w   $��Save:��6   $
��Left=�6%   $��
426,54,0,0q�6@   $	��Top=�6T   $��83��6l   $��33��6�   $
��Bold"�6�   $��15(�6�   
���   �6�   �� 5      -   5        $ 	btnCancel��5   �   $��Cancel:��6   $
��Left=�6'   $��
543,54,0,0q�6B   $	��Top=�6V   $��83��6n   $��33��6y   $��15(�6�   $
��Bold"�6�   
���   �6�   5      � 5   
   $
��Left=�6   $	��194��6*   $��0,77,0,0q�67   $	��Top=�6I   $	��662��6a   ���	#FF2A398C 5      �� 5      .+�5      �� $��Date:��6   $
��Left=�6$   $��	35,23,0,0q�6?   $	��Top=�6R   $��80��6j   
�������$��15(�6�   $
��Bold"�6�   �� 5      $��Mentor:��6   $
��Left=�6&   $��	35,84,0,0q�6A   $	��Top=�6T   $��80��6l   
�������$��15(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DpDates��5   w   $
��Left=�6   $��	35,53,0,0q�64   $	��Top=�6G   $��26��6_   $	��129��6k   6�   �� 5      -   5         ��Name$ 
txtMentors��5   v   $
��Left=�6   $��
35,113,0,0q�62   $	��Top=�6F   $	��129��6^   $��29��6j   6v   &   System.Windows.Controls.DataGrid  5      -   5        	  Name$	 	datadrid1��5   v   $
��Left=�6   $��	366,8,0,0q�62   $	��Top=�6E   $	��165��6]   $	��270��6j   
   AutoGenerateColumns
 .     Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Names��6-   -   5        menteeCm��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 5         DisplayMemberPath 5   N   �� *Names+   SelectedItemBinding 6r   �� *Names+ �� Mode$ TwoWay=�   SelectedValuePath 5      �� *Names+0  *System.Windows.Controls.DataGridTextColumn  5      $ Hours��6)   $	 130 6`   -	   5        	Hours��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   8   �� *Hours+$ TwoWay=�6l   5      �� 5      $��Training on:��6   $
��Left=�6+   $��
35,164,0,0q�6F   $	��Top=�6Z   $	��102��6r   
�������$��15(�6�   $
��Bold"�6�   5       �� 5!   
   -
   5        $ btnBack��5!   �   $
��Back��6   $
��Left=�6    $��	564,0,0,0q�6;   $	��Top=�6N   $��77��6f   $��77��6q   $��0q�6}   
�������$��30(�6�   $
��Bold"�6�   ���	#FF2A398C6�   �� 5"   
   $��32,-2,428,319q�6   $��dvtlogo1.png��6'   $
��Fill=�6=   �� 5#   
   $��Daily Register��6   $
��Left=�6)   $��
376,12,0,0q�6D   $	��Top=�6X   $	��183��6p   ���	#FF2A398C$��25(�6�   $
��Bold"�6�   $��60��6�   5%      5&      