   M S B A M L   `   `   `  ����W  SPharmacy-Desktop-Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Pharmacy_Desktop_ApplicationPharmacy_Desktop_Application  5      1    +Pharmacy_Desktop_Application.PredictionPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Pharmacy_Desktop_Application     5        N� Title$  PredictionPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��80 �6   �� 5      $��40 �6   �� 5      $��80 �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   Predition Page5      �� 5   
   $��0��6   $��1��6$   31Pick a Record to Display The Projected Sales for:5!      �� 5"   
   -   5         ��Name$ textPredictionList��5"      $��1��6.   $��1��6>   6M   �� 5$   
   -   5         ��Name$ btnProductWeekly��5$      $��1��6A   $��2��6Q   $
��Left=�6^   $
��Auto��6z   .��6�   Display Next Week6�   �� 5%   
   -   5        $ btnProductMonthly��5%      $��1��6C   $��2��6S   $��Right=�6`   $
��Auto��6}   .��6�   Display Next Month6�   �� 5'   
   $��0��6   $��3��6$   Product Combo5)      �� 5*   
   -   5        $ textComboPredictionList��5*      $��1��63   $��3��6C   6R   �� 5+   
   -   5        $ btnComboroductWeekly��5+      $��1��6J   $��4��6Z   $
��Left=�6g   $
��Auto��6�   .��6�   Display Next Week6�   �� 5,   
   -   5        $ btnComboProductMonthly��5,      $��1��6M   $��4��6]   $��Right=�6j   $
��Auto��6�   .��6�   Display Next Month6�   51      52      