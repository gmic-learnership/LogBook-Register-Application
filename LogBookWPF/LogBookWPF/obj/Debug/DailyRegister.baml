   M S B A M L   `   `   `  ����  
LogBookWPF    LogBookWPF.DailyRegister   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  DailyRegister��5   	   $	��300��6   $��622.68��6,   .��5      � .+�5   
   �� -   5         ��Name$ btnSave��5   s   $
��Save��6   $
��Left=�6    $��277,225,0,0q�6;   $	��Top=�6P   $��75��6h   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DpDates��5   [   $
��Left=�6   $��	10,19,0,0q�60   $	��Top=�6C   6l   �� 5	   
   -   5         ��Name$ 
txtMentors��5	   f   $
��Left=�6   $��
10,118,0,0q�6.   $	��Top=�6B   $	��120��6Z   6z   �� 5
   
   -   5         ��Name$ txtTraining��5
   �   $
��Left=�6   $��23��6-   $��
10,211,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	datadrid1��5   s   $
��Left=�6   $��
323,28,0,0q�6.   $	��Top=�6B   $	��165��6Z   $	��260��6g      AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Names��6)   -   5        menteeCm��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 130 5         DisplayMemberPath 5   J   �� *
menteeCm+   SelectedItemBinding 6q   �� *
menteeCm+ �� Mode$ TwoWay=�5      0  *System.Windows.Controls.DataGridTextColumn  5      $	 Hours��6%   $	
 130 6]   -   5        	Hours��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   4   �� *Hours+$ TwoWay=�6i   5      5      5      