   M S B A M L   `   `   `  ����W  SPharmacy-Desktop-Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Pharmacy_Desktop_ApplicationPharmacy_Desktop_Application  5   	   -    'Pharmacy_Desktop_Application.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Pharmacy_Desktop_Application     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $
��Left=�6   $��0��60   $��1��6@   .+�5      �� $��40��6   .��6"   Peoples Health Pharmacy5      �� 5      -   5         ��Name$ btnHome��5      .��6;   Dan's Button6I   �� 5!      -   5        $ 
btnProduct��5!      .��6A   Product Page6O   �� 5$      -   5        $ btnSalePage��5$      .��6C   
Sales Page6O   �� 5)      -   5        $ btnPrediction��5)      .��6G   Predictions6T   �� 5,      -   5        $ btnSettings��5,      .��6C   
Settings6M   5-       � 50   
   -   5          �Name$
 Main��50        � NavigationUIVisibility$ Hidden=�6   $��1��6>   $��1��6N   52      53      