   M S B A M L   `   `   `  ���� E  ASAE_Sujet2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SAE_Sujet2
SAE_Sujet2      SAE_Sujet2.AddWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:SAE_Sujet2     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Ajouter une affectation��$	��450��$	��600�� � Icon$ 	/star.png�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources    Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  Arrondi �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Value �� Property��%1  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     7   7  7  7  7  7  7  �� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.R��� $ border��#��z��#��z��$��5q�$ 20,20,20,20 ��$
	 true��._��� $
 contentPresenter��#��z��#��z��#��z��$|�False��$
��True��#	 z	  P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8    � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � �� � DataContext     SAE_Sujet2.ApplicationData  .��� $	��450��$	��600��.+��� $	��258��$��48��$��0,25,0,0q�$��Center=�$	��Top=�$��Center=�$��Center=�
���   �$��AJOUTER��$��72 Black)�$��24(�$��Normal"�
��������� $	��158��$��
30,195,0,0q�$
��Left=�$	��Top=�$��Nom de la mission :��$��Microsoft YaHei UI Light)��� $	��158��$��
30,115,0,0q�$
��Left=�$	��Top=�$��Division concernée :��$��Microsoft YaHei UI Light)�$��Italic$�$��
UltraBlack"��� -    ��Name$ 
cbDivision��$	��187��$��
30,146,0,0q�$
��Left=�$	��Top=� �� DisplayMemberPath$ LibelleDivision�� �� SelectedValuePath$ 
IdDivision������ �� -   $ 	cbMission��$	��186��$��
30,226,0,0q�$
��Left=�$	��Top=�$ LibelleMission��$ 	IdMission��$y�Visible=����� �� $	��158��$��
30,273,0,0q�$
��Left=�$	��Top=�$��Date affectation :��$��Microsoft YaHei UI Light)�(  "System.Windows.Controls.DatePicker  -     Name$ dpicker��$��30,304,233,268q�$��Microsoft YaHei UI Light)��� $	��187��$��
30,365,0,0q�$
��Left=�$	��Top=�$��Commentaire  :��$��Microsoft YaHei UI Light)��� -    ��Name$ tbAdd��$	��332��$��87��$��
22,396,0,0q�$
��Left=�$	��Top=� �� TextWrapping$
 Wrap=��� -    ��Name$ 
button_Add��$	��126��$��42��$��250,512,0,0q�$
��Left=�$	��Top=�$��Ajouter��$��Microsoft YaHei UI)�$
��Bold"�#���  �� -   $	��126��$��42��$��
62,512,0,0q�$
��Left=�$	��Top=�$��Annuler��$��Microsoft YaHei UI)�#���  �� -    ��Name$ MissionErrorLabel��$	��163��$��31��$��225,221,0,0q�$
��Left=�$	��Top=����	#FFFF9393$��Nom de la mission requise��$
��Bold"�$y�Hidden=��� -   $ DivisionErrorLabel��$	��163��$��31��$��225,141,0,0q�$
��Left=�$	��Top=����	#FFFF9393$ ��Nom de la division requise��$
��Bold"�$y�Hidden=��� -	   $ DatePickerErrorLabel��$��88��$��32��$��225,302,0,0q�$
��Left=�$	��Top=����	#FFFF9393$��Date requise��$
��Bold"�$y�Hidden=�