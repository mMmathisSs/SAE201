   M S B A M L   `   `   `  ���� E  ASAE_Sujet2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SAE_Sujet2
SAE_Sujet2      SAE_Sujet2.ShowWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:SAE_Sujet2     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Liste des affectations��$	��800��$	��450�� � Icon$ 	/star.png�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources    Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  Arrondi �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Value �� Property  caseACocher �� Orientation d� 	IsChecked �� Path �� RelativeSource �� AncestorType��%�  &	        &	      &	 *     &	 ?     &	 T     &	 i     &	 ~     &	 �     7   7  7  7  7  7  7  &	 �    �� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.R��� $ border��#��z��#��z��$��5q�$ 20,20,20,20 ��$
	 true��._��� $
 contentPresenter��#��z��#��z��#��z��$|�False��$
��True��#	 z	  P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8    � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� .R��� $ 
Horizontal=�.+��� -    �� $ 
IsSelected� �� *FindAncestor+" �� � DataContext     SAE_Sujet2.ApplicationData  .��� .+�&   System.Windows.Controls.DataGrid  -     Name$ 	dgSalarie��$	��780��$��
0,217,0,71q�$��Center=�   AutoGenerateColumns$ False��$��Microsoft YaHei UI)����� *listeMissions+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    Header$ Numero��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	IdMission+  $ * $ Libelle�� �� *LibelleMission+  $ * $ Date d'affectation�� �� *DateAffectation+ �� StringFormat$ 
dd/MM/yyyy��  $ * $ Commentaire�� �� *Commentaire+�� -    ��Name$ lvCorpsArmee��$	��195��$	��197��$��	10,10,0,0q�$
��Left=�$	��Top=�
���   �$��Microsoft YaHei UI)����� *listeCorpsArmees+ �� View �� .P���   �� Width$  30��! �� CellTemplate#! [ �� $	  150��$��Corps Armées��" �� DisplayMemberBinding" �� *NomCorpsArmee+�� -   $ 
lvDivision��$	��195��$	��197��$��
291,10,0,0q�$
��Left=�$	��Top=�
���   �$��Microsoft YaHei UI)����� *listeDivisions+ �� .P��� $  30��#! [ �� $	  130��$��	Divisions��" �� *LibelleDivision+�� -   # ��Name$# 	butRetour��$	��190��$��35��$��
76,368,0,0q�$
��Left=�$	��Top=�$��Retour��$��Microsoft YaHei UI)�#���  �� -   $# butSupprimer��$	��190��$��35��$��532,368,0,0q�$
��Left=�$	��Top=�$��	Supprimer��$��Microsoft YaHei UI)�$ J� RenderTransformOrigin$$ 0.442,0.473&�#���  �� -   $# butModif��$	��190��$��35��$��	0,368,0,0q�$��Center=�$	��Top=�$��Modifier��$��Microsoft YaHei UI)�#���  