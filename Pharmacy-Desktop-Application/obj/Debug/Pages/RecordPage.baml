   M S B A M L   `   `   `  ����W  SPharmacy-Desktop-Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Pharmacy_Desktop_ApplicationPharmacy_Desktop_Application  5      -    'Pharmacy_Desktop_Application.RecordPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Pharmacy_Desktop_Application     5        N� Title$  
RecordPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ Content��5      $��0��6%   $��0��65   :8Pick a Product to display Sales for OR pick all products6|   �� 5   
   $��1��6   $��0��6"   61   �� 5   
   -   5         ��Name$ btnProductWeekly��5      $��1��6C   $��1��6S   $
��Left=�6`   .��6{   Display Weekly6�   �� 5   
   -   5        $ btnProductMonthly��5      $��1��6E   $��1��6U   $��Right=�6b   .��6~   Display Monthly6�   �� 5   
   $��0��6   $��2��6%    You Have Made this many Sales:6T   �� 5    
   $��1��6   $��2��6$   86Display Number of sales here until we work out graphs?6k   �� 5"   
   -   5        $ 	btnExport��5"      $��2��6<   $��4��6L   $��Right=�6Y   .��6u   Export to CSV6�   5(      5)      