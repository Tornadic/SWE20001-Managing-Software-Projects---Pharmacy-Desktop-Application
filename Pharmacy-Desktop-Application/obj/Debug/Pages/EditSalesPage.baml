   M S B A M L   `   `   `  ����W  SPharmacy-Desktop-Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Pharmacy_Desktop_ApplicationPharmacy_Desktop_Application  5      0    *Pharmacy_Desktop_Application.EditSalesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Pharmacy_Desktop_Application     5        N� Title$  EditSalesPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��Content��5      $��0��6#   $��0��63   This the Sales Page5      �� 5    
   $��0��6   $��1��6$   Date:68   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ txtSaleDate��5!      $��1��6*   $��1��6:      DisplayDate$ 
2021-09-24��6G      SelectedDateFormat$
 Long=�6`   6|   �� 5#   
   $��0��6   $��2��6$   
Product:6;   �� 5$   
   -   5        $��cmxItemProduct��5$      $��3,3,3,3q�6)   $��Stretch=�6:   $��1��6X   $��2��6h   5&      �� 5(   
   $��0��6   $��3��6$   	Quantity:6<   �� 5)   
   -   5         ��Name$ txtItemQuantity��5)      $��1��6+   $��3��6;   6J   �� 5+   
   -   5         ��Name$ 
btnItemAdd��5+      $��1��69   $��4��6I   $
��Auto��6V   .��6c   Add Edited Item5-      �� 5.   
   -   5        $ btnItemEdit��5.      $��1��6:   $��4��6J   $
��Auto��6W   .��6d   Add Edited Item50      �� 52   
   $��0��6   $��5��6$   
Item List:6=   �� 53   
   -   5         ��Name$ txtItemList��53      $��1��6W   $��5��6g   6v   �� 55   
   -   5        $ btnSaleSubmit��55      $��1��6?   $��6��6O   $
��Auto��6\   .��6i   Update Sale57      58      59      