   M S B A M L   `   `   `  ����J  FQLKHODevExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:QLKHODevExpress.ViewsQLKHODevExpress.Views  5      G(clr-namespace:QLKHODevExpress.ViewModelsQLKHODevExpress.ViewModels  5      E'clr-namespace:QLKHODevExpress.UtilitiesQLKHODevExpress.Utilities  5           QLKHODevExpress.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      /Views#clr-namespace:QLKHODevExpress.Views  5      1vm(clr-namespace:QLKHODevExpress.ViewModels  5      2Menu'clr-namespace:QLKHODevExpress.Utilities  5      c _DevExpress.Xpf.Charts.v22.2, Version=22.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts  5        � Title$  
MainWindow��5
      $	��600��6   $	��850��6%    � WindowStartupLocation$ CenterScreen=�5       � AllowsTransparency .  � WindowStyle$
 None=�5      
������  � DataContext 5      4  .QLKHODevExpress.ViewModels.NavigationViewModel  5   
   .��5      � .+�5   
   �� 
������� �� CornerRadius$ 20��5      � 5   
    � ColumnDefinitions 5      �� 5      $	��228 �6#   �� 5      $	��622 �6#   .+�5      � $
��Left=�6   $	��228��5      .+�5      �� 
����� �$ 	20,0,0,20��5       5"      �� 5#      $	��400��6   $	��228��5$      .+�5'      #   QLKHODevExpress.Utilities.Btn     BtnStyle#��[  6    d� 	IsChecked$
 TrueY�5)      ��5(      �� *UnitCommand+.��5*      � .+�5+      �� $8��2Images/Hopstarter-Mac-Folders-Applications.256.png��6$     Image_Style#��[ 5,   $   �� 5-      $
��Unit��6(     
Text_Style#��[ 5.   (   5/      51        54      #��[  6   $
 TrueY�56      ��55      �� *SuplierCommand+.��57      � .+�58      �� $8��2Images/Hopstarter-Mac-Folders-Applications.256.png��6$   #��[ 59   $   �� 5:      $��Suplier��6(   #��[ 5;   (   5<      5>        5B      #��[  6   $
 TrueY�5D      ��5C      �� *ObjectCommand+.��5E      � .+�5F      �� $8��2Images/Hopstarter-Mac-Folders-Applications.256.png��6$   #��[ 5G   $   �� 5H      $��Object��6(   #��[ 5I   (   5J      5L        5O      #��[  6   $
 TrueY�5Q      ��5P      �� *CustomerCommand+.��5R      � .+�5S      �� $8��2Images/Hopstarter-Mac-Folders-Applications.256.png��6$   #��[ 5T   $   �� 5U      $��Customer��6(   #��[ 5V   (   5W      5Y        5Z      #��[  6   $
 TrueY�5\      ��5[      �� *UserCommand+.��5]      � .+�5^      �� $8��2Images/Hopstarter-Mac-Folders-Applications.256.png��6$   #��[ 5_   $   �� 5`      $
��User��6(   #��[ 5a   (   5b      5d      5f      5h      � 5i      $��1��6   .+�5j      �� -   5         ��Name$ Pages��5j   !   ��5k   !   �� *CurrentView+5l      5n      �� 5o   
   -   5        	 ��Name$	 CloseApp��5o        ExitApp#��[ 5p      5q      5r      