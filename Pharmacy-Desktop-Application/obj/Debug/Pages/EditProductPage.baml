   M S B A M L   `   `   `  ����W  SPharmacy-Desktop-Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Pharmacy_Desktop_ApplicationPharmacy_Desktop_Application  5      2    ,Pharmacy_Desktop_Application.EditProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Pharmacy_Desktop_Application     5        N� Title$  EditProductPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��Content��5      $��0��6#   $��0��63   !This the Product View/Edit Page5      �� 5!   
   $��0��6   $��1��6$   Product SKU:6@   �� 5"   
   -   5         ��Name$ 
txtProdSKU��5"      $��1��6&   $��1��66   {�.  6C   �� 5$   
   $��0��6   $��2��6$   Product Name:6@   �� 5%   
   -   5        $ txtProdName��5%      $��1��6'   $��2��67   6F   �� 5'   
   $��0��6   $��3��6$   Product Stock:6A   �� 5(   
   -   5        $ txtProdStock��5(      $��1��6(   $��3��68   6G   �� 5*   
   $��0��6   $��4��6$   Product Price:6A   �� 5+   
   -   5        $ txtProdPrice��5+      $��1��6(   $��4��68   6G   �� 5.   
   -   5         ��Name$ btnProductSubmit��5.      $��1��6C   $��5��6S   $
��Auto��6`   $��10q�6m   .��6y   Update Product in DataBase50      53      54      