   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1     -     �Name$  	Sous_Menu�� � Title$ Inf'Eau��$	��450��$	��800��.��� ����  �� ImageSource$* $/Images;component/fond-bleu-full.jpg�� � ColumnDefinitions �� $	��10* ��� $	��40* �.+�� -    �Name$ grid2��$��1�� � RowDefinitions �� $��0.05* ��� $��0.95* �.+��� -    ��Name$
 Aide��$
��Aide��$��75��$
��Left=�$��30��$��Center=��� -   $ ajoutfav��$��favoris��$��1��$��0��$��75��$��30��$��Right=�$y�Visible=��� -    ��Name$ contentControl��$��1��$��1��.��   WpfApp1.UCMenuCirculaire  � $��0�� �� $��0.25* ��� $��0.25* ��� $��0.25* ��� $��0.25* �.+�   WpfApp1.UCBouton  $��0��   Texte$
 menu��	   NomIcon$$	 /Images;component/IconMenu.jpg��$��0q�
   Clique
 
Menu_Click  -     Name$ userControlFavoris��$ favoris��$'	 !/Images;component/IconFavoris.jpg��
 Favoris_Click$��20q�$��1��$y�Hidden=�  $ paramètres��$*	 $/Images;component/IconParametres.jpg��
 Param_Click$��10q�$��2��� $��3�� �� $
��0.5* ��� $
��0.5* �.+�  -   $ logInOut��$ Login��$$	 /Images;component/IconUser.jpg��
 LogInOut_Click$��10q�$��0��  $ quitter��$'	 !/Images;component/IconQuitter.jpg��
 quitter_Click$��10q�$��1��