   M S B A M L   `   `   `  ����E  ASAE_Sujet2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SAE_Sujet2
SAE_Sujet2  5          SAE_Sujet2.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SAE_Sujet2     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$   Interface d'administration��5      $	��800��5	      $	��450��5
       � Icon$ 	/star.png��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5         Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  Arrondi �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Value �� Property��%7  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     7   7  7  7  7  7  7  �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6*   .R�5      �� $ border��5      #��z��5      #��z��5      $��5q�5      $ 20,20,20,20 ��5      $
	 true��5      ._�5      �� $
 contentPresenter��5       #��z��5!      #��z��5"      #��z��5#      $|�False��5$      $
��True��5%      #	 z	 5&      5'       5(      P� 5)       �@��IsDefaulted$
 true��68   . �5*      �� $ border��6   # � ��6H    � ��5+      P� 5,       �@J�IsMouseOver$
 true��61   . �5-      �� $ border��6   8    � ��6G   �� 5.      $ border��6   8   � ��6H   5/      P� 50       � ��$
 true��6/   . �51      �� $ border��6   8   � ��6G   �� 52      $ border��6   8   � ��6H   53      P� 54       � {�$ false��6/   . �55      �� $ border��6   8   � ��6G   �� 56      $ border��6   8   � ��6H   �� 57      $ contentPresenter��6   8   � ��6]   58      5:      5;      .��5<      � ��5=   
   
� 5>      .��5?      �  � Offset$ 1Q�6    � Color$ 	#FFDFFFE5��6*   � 5@      $ 0Q�6   $ White��6*   5A      .+�5C   
   �� $	��758��5D      $��68��5E      $��0,38,0,0q�5F      $��Center=�5G      $	��Top=�5H      $��Center=�5I      $1��+Interface d'administration des affectations��5J      $��Kozuka Gothic Pr6N B)�5K      $��36(�5L      �� 5M   
   -   5         ��Name$ 
butAjouter��5N      $	��250��5O      $��94��5P      $��110,284,0,0q�5Q      $
��Left=�5R      $	��Top=�5S      $��Center=�5T      ���	#FFC4FFE7���	#FF004B0E$��Ajouter affectation��5X      $��Kozuka Gothic Pr6N B)�5Y      $��22(�5Z      
���   �#���  5\      ��5]      �� 5^      5`      �� 5b   
   -   5        $ butConsulter��5c      $	��250��5d      $��94��5e      $��0,284,110,0q�5f      $��Right=�5g      $	��Top=�5h      $��Center=�5i      ���	#FFC4FFE7���	#FF004B0E$��Consulter affectations��5m      $��Kozuka Gothic Pr6N B)�5n      $��22(�5o      $��Medium&�5p      $��Normal$�5q      $��Normal"�5r      #���  5s      ��5t      �� 5u      5w      �� 5x   
   $	��144��5y      $	��124��5z      $��Center=�5{      $��	/star.png��5|      5~      5      