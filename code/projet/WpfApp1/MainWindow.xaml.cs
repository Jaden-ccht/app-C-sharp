using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Modele;
using static WpfApp1.App;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour SousMenu.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerSousMenu => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur de main window permet le changement de différentes propriétés en fonction de si l'utilisateur courant est null ou non
        /// Défini la taille de la police comme normale
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ManagerSousMenu;
            if(ManagerSousMenu.UtilisateurCourant != null)
            {
                logInOut.Texte = "Déconnexion";
                userControlFavoris.Visibility = Visibility.Visible;
            }
            else
            {
                ajoutfav.Visibility = Visibility.Hidden;
                logInOut.Texte = "Se connecter";
            }
            (App.Current as App).LaTailleDeLaPolice = TaillePolice.Normale;
            ManagerSousMenu.ElementCourant = null;
        }

        /// <summary>
        /// permet l'ajout de l'ElementCourant en tant que favoris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutfav_Click(object sender, RoutedEventArgs e)
        {
            if(ManagerSousMenu.ElementCourant != null && ManagerSousMenu.UtilisateurCourant != null)
            {
                ManagerSousMenu.AjouterFavori();
            }
        }

        /// <summary>
        /// Permet de fermet l'application en sauvegardant les données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitter_Click(object sender, RoutedEventArgs e)
        {
            ManagerSousMenu.SauvegardeDonnees();
            this.Close();
        }

        /// <summary>
        /// Permet de changer le User Control du content control pour afficher la liste des favoris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Favoris_Click(object sender, RoutedEventArgs e)
        {
            ManagerSousMenu.ElementCourant = null;
            contentControl.Content = new UCFavoris();
        }

        /// <summary>
        /// Permet de changer le User Control du content control pour afficher les paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Param_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCParametres();
        }

        /// <summary>
        /// Permet de changer le User Control du content control pour afficher le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            ManagerSousMenu.ElementCourant = null;
            contentControl.Content = new UCMenuCirculaire();
        }

        /// <summary>
        /// Permet de retourner sur la loginpage pour se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInOut_Click(object sender, RoutedEventArgs e)
        {
            Loginpage fenetre = new Loginpage();
            fenetre.Show();
            ManagerSousMenu.SauvegardeDonnees();
            this.Close();
        }

        /// <summary>
        /// Affiche une message box d'aide à l'utilisation de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Aide_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("L'application est simple ! En cliquant sur \"Marques\", vous vous Retrouverez sur une liste de bouteilles d'eaux minérales françaises. En cliquant sur \"Conso'\" (uniquement accessible en possédant un compte), vous vous retrouverez sur une page où il est possible d'enregistrer et de suivre votre consommation d'eau quotidienne. Enfin, l'onglet \"Infos\" contient quelques infos sur l'eau. Vous pouvez ajouter et consulter les favoris en possèdant un compte alors N'HESITEZ PAS !","Aide", MessageBoxButton.OK, MessageBoxImage.Information);
        }

      
    }
}
