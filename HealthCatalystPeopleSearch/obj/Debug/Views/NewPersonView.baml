   M S B A M L   `   `   `  ����U  QHealthCatalystPeopleSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:HealthCatalystPeopleSearch.Views HealthCatalystPeopleSearch.Views  5      Q2clr-namespace:HealthCatalystPeopleSearch;assembly=HealthCatalystPeopleSearch  5      4    .HealthCatalystPeopleSearch.Views.NewPersonView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:HealthCatalystPeopleSearch.Views     5      Bmed2clr-namespace:HealthCatalystPeopleSearch;assembly=     5      .��5
      �   � 	Resources  5   
   /   )HealthCatalystPeopleSearch.ImageConverter   imageConverter �� 
TargetType �� Property �� Value��%  &	        '��        5      6!   �� 5      textBoxStyle��" ��6.   .�5      ��  � ��$ 3q�6+   �� 5       � ��$ Center=�6=   �� 5       � ��$ 14(�6-   �� 5       � ��
 �iii�60   �� 5       � ��$	 1.5q�64   5      5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6    � ColumnDefinitions 5"   
   �� 5#      $
��Auto �6   �� 5$      $��* �6   .+�5'   
   �� $��0��6   $��0��6   .��6-   
First Name69   �� 5(   
   $��1��6   $��0��6   .��6-   	Last Name68   �� 5)   
   $��2��6   $��0��6   .��6-   Age62   �� 5*   
   $��3��6   $��0��6   .��6-   	Address66   �� 5+   
   $��4��6   $��0��6   .��6-   
Intrests67   �� 5,   
   $��5��6   $��0��6   .��6-   	Picture66   �� 5.   
   -   5         ��Name$ 	firstName��5.      $��0��6%   $��1��62   6D   �� 5/   
   -   5        $ lastName��5/      $��1��6$   $��1��61   6C   �� 50   
   -   5        $	 age��50      $��2��6   $��1��6,   6b   �� 51   
   -   5        $ address��51      $��3��6#   $��1��60   6B   �� 52   
   -   5        $ 	interests��52      $��4��6%   $��1��62   6D   �� 54   
   -   5         ��Name$ image��54      $��5��6   $��1��6-    �� BitmapScalingMode$ HighQuality=�6�   $	��275��6�   $	��200��6�   ��6=   �� *image+	 �� 	Converter#	 [  6�   �� 56   
   -   5        
 ��Name$
 Browse��56      $��6��6!   $��0��6.   $��Browse��6>   $��2q�6O   �� 58   
   -   5         ��Name$ message��58   1   $��7��6   $��2��6   $��Center=�6B   $�� ��6f   � 59   
   $��2��6   $��9��6#    5:      �� 5;      $��* �6#   �� 5<      $��2* �6#   �� 5=      $��* �6#   �� 5>      $��2* �6#   �� 5?      $��* �6#   .+�5A      �� -	   5        $
 Cancel��5A   2   $��0��6   $��1��6"    �� IsCancel . .��6S   Cancel6[   �� 5B      -
   5        $
 AddNewPerson��5B   2   $��0��6   $��3��6"    �� 	IsDefault . .��6Y   Add New Person6i   5C      5G      5J      