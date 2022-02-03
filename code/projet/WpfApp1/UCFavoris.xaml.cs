using Modele;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour UCFavoris.xaml
    /// </summary>
    public partial class UCFavoris : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCFavoris => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur défini l'ElementCourant comme null
        /// </summary>
        public UCFavoris()
        {
            InitializeComponent();
            ManagerUCFavoris.ElementCourant = null;
        }

        /// <summary>
        /// Permet d'afficher les boutons "Supprimer" et "Y aller"
        /// défini l'ElementCourant avec le selectedItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Listefavoris_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Del.Visibility = Visibility.Visible;
            GoTo.Visibility = Visibility.Visible;
            ManagerUCFavoris.SetElementCourant(Listefavoris.SelectedItem as Element);
        }

        /// <summary>
        /// Supprime le selected item/ElementCourant de la liste favoris de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCFavoris.UtilisateurCourant.ListeFavoris.Remove(ManagerUCFavoris.ElementCourant);
            this.Content = new UCFavoris();
        }

        /// <summary>
        /// Utilise un switch qui permet changer le content Control en fonction de la Key de l'element courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoTo_Click(object sender, RoutedEventArgs e)
        {
            int Clé = ManagerUCFavoris.GetKeyElementCourant();
            switch (Clé)
            {
                case 0:
                    this.Content = new UCInfoBouteille();
                    break;
                case 1:
                    this.Content = new UCListeBouteilles();
                    break;
                case 2:
                    this.Content = new UCInformations();
                    break;
                case 3:
                    this.Content = new UCConsommationEau();
                    break;
                default:
                    break;
            }
        }
    }
}
