   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  	Sous_Menu��5   	    � Title$ Inf'Eau��5	   	   $	��450��6   $	��800��6&   .��5
      � ��5   
   �� 5       �� ImageSource$* $/Images;component/fond-bleu-full.jpg��6    � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��40* �6   .+�5   
   � -   5         �Name$ grid2��5      $��1��6    � RowDefinitions 5      �� 5      $��0.05* �6    �� 5      $��0.95* �6    .+�5      �� -   5         ��Name$
 Aide��5      $
��Aide��6#   $��75��62   $
��Left=�6=   $��30��6X   $��Center=�6g   6�   �� 5      -   5        $ ajoutfav��5      $��favoris��6'   $��1��69   $��0��6I   $��75��6V   $��30��6a   $��Right=�6q   $y�Visible=�6�   �� 5      -   5         ��Name$ contentControl��5      $��1��65   $��1��6E   .��5         WpfApp1.UCMenuCirculaire  5      5      � 5   
   $��0��6    5      �� 5       $��0.25* �6    �� 5!      $��0.25* �6    �� 5"      $��0.25* �6    �� 5#      $��0.25* �6    .+�5&         WpfApp1.UCBouton  $��0��6      Texte$
 menu��6*   	   NomIcon$$	 /Images;component/IconMenu.jpg��67   $��0q�6`   
   Clique
 
Menu_Click6k     5(      -   5          Name$ userControlFavoris��5(      $ favoris��69   $'	 !/Images;component/IconFavoris.jpg��6I   
 Favoris_Click6u   $��20q�6�   $��1��6�   $y�Hidden=�6�     5*      $ paramètres��6   $*	 $/Images;component/IconParametres.jpg��60   
 Param_Click6_   $��10q�6t   $��2��6�   � 5,      $��3��6    5-      �� 5.      $
��0.5* �6'   �� 5/      $
��0.5* �6'   .+�51        -   5        $ logInOut��51   !   $ Login��63   $$	 /Images;component/IconUser.jpg��6A   
 LogInOut_Click6j   $��10q�6�   $��0��6�     52      $ quitter��6!   $'	 !/Images;component/IconQuitter.jpg��61   
 quitter_Click6]   $��10q�6t   $��1��6�   53      54      55      56      