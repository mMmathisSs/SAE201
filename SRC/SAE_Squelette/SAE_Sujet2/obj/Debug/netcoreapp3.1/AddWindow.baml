   M S B A M L   `   `   `  ����E  ASAE_Sujet2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SAE_Sujet2
SAE_Sujet2  5          SAE_Sujet2.AddWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SAE_Sujet2     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Ajouter une affectation��5      $	��450��5	      $	��600��5
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
 true��6/   . �51      �� $ border��6   8   � ��6G   �� 52      $ border��6   8   � ��6H   53      P� 54       � {�$ false��6/   . �55      �� $ border��6   8   � ��6G   �� 56      $ border��6   8   � ��6H   �� 57      $ contentPresenter��6   8   � ��6]   58      5:      5;       � DataContext 5<          SAE_Sujet2.ApplicationData  5=   
   .��5?      � $	��450��6   $	��600��6   .+�5@   
   �� $	��258��5A      $��48��5B      $��0,25,0,0q�5C      $��Center=�5D      $	��Top=�5E      $��Center=�5F      $��Center=�5G      
���   �$��AJOUTER��5I      $��72 Black)�5J      $��24(�5K      $��Normal"�5L      
�������5M      �� 5N   
   $	��158��5O      $��
30,195,0,0q�5P      $
��Left=�5Q      $	��Top=�5R      $��Nom de la mission :��5S      $��Microsoft YaHei UI Light)�5T      �� 5U   
   $	��158��5V      $��
30,115,0,0q�5W      $
��Left=�5X      $	��Top=�5Y      $��Division concernée :��5Z      $��Microsoft YaHei UI Light)�5[      $��Italic$�5\      $��
UltraBlack"�5]      �� 5^   
   -   5         ��Name$ 
cbDivision��5_      $	��187��5`      $��
30,146,0,0q�5a      $
��Left=�5b      $	��Top=�5c       �� DisplayMemberPath$ LibelleDivision��5d       �� SelectedValuePath$ 
IdDivision��5f      ��5e      �� 5g      �� 5h   
   -   5        $ 	cbMission��5i      $	��186��5j      $��
30,226,0,0q�5k      $
��Left=�5l      $	��Top=�5m      $ LibelleMission��5n      $ 	IdMission��5p      $y�Visible=�5r      ��5o      �� 5r      �� 5s   
   $	��158��5t      $��
30,273,0,0q�5u      $
��Left=�5v      $	��Top=�5w      $��Date affectation :��5x      $��Microsoft YaHei UI Light)�5y      (  "System.Windows.Controls.DatePicker  5z   
   -   5          Name$ dpicker��5{      $��30,304,233,268q�5|      $��Microsoft YaHei UI Light)�5}      �� 5~   
   $	��187��5      $��
30,365,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Commentaire  :��5�      $��Microsoft YaHei UI Light)�5�      �� 5�   
   -   5         ��Name$ tbAdd��5�      $	��332��5�      $��87��5�      $��
22,396,0,0q�5�      $
��Left=�5�      $	��Top=�5�       �� TextWrapping$
 Wrap=�5�      �� 5�   
   -   5         ��Name$ 
button_Add��5�      $	��126��5�      $��42��5�      $��250,512,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Ajouter��5�      $��Microsoft YaHei UI)�5�      $
��Bold"�5�      #���  5�      �� 5�   
   -   5        $	��126��5�      $��42��5�      $��
62,512,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Annuler��5�      $��Microsoft YaHei UI)�5�      #���  5�      �� 5�   
   -   5         ��Name$ MissionErrorLabel��5�      $	��163��5�      $��31��5�      $��225,221,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#FFFF9393$��Nom de la mission requise��5�      $
��Bold"�5�      $y�Hidden=�5�      �� 5�   
   -   5        $ DivisionErrorLabel��5�      $	��163��5�      $��31��5�      $��225,141,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#FFFF9393$ ��Nom de la division requise��5�      $
��Bold"�5�      $y�Hidden=�5�      �� 5�   
   -	   5        $ DatePickerErrorLabel��5�      $��88��5�      $��32��5�      $��225,302,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#FFFF9393$��Date requise��5�      $
��Bold"�5�      $y�Hidden=�5�      5�      5�      