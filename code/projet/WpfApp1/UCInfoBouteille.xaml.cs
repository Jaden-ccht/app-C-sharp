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
    /// Logique d'interaction pour UCInfoBouteille.xaml
    /// </summary>
    public partial class UCInfoBouteille : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCInfoBouteille => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur défini la visibilité de certains boutons en fonction de la propriété Admin de l'utilisateur
        /// Désactive le bouton "Précédent" si l'ElementCourant est premier dans la ListeElem
        /// Désactive le bouton "Suivant" si l'ElementCourant est dernier dans la ListeElem
        /// </summary>
        public UCInfoBouteille()
        {
            InitializeComponent();
            ListeBouteilles.SelectedItem = ManagerUCInfoBouteille.ElementCourant;
            if(ManagerUCInfoBouteille.UtilisateurCourant != null && ManagerUCInfoBouteille.UtilisateurCourant.Admin == true)
            {
                Modifier.Visibility = Visibility.Visible;
                Supprimer.Visibility = Visibility.Visible;
                Add.Visibility = Visibility.Visible;
            }
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == ManagerUCInfoBouteille.GE.ListeElement.Count-1)
            {
                next.IsEnabled = false;

            }
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == 0)
            {
                previous.IsEnabled = false;
            }
        }

        /// <summary>
        /// Défini l'ElementCourant comme le precedent par rapport l'ancien ElementCourant
        /// Désactive le bouton "Précédent" si l'ElementCourant est premier dans la ListeElem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previous_Click(object sender, RoutedEventArgs e)
        {
            next.IsEnabled = true;
            ManagerUCInfoBouteille.SetElementCourant(ManagerUCInfoBouteille.GE.ListeElement[ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ListeBouteilles.SelectedItem as Element)-1]);
            ListeBouteilles.SelectedItem = ManagerUCInfoBouteille.ElementCourant;
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == 0)
            {
                previous.IsEnabled = false;
            }
        }

        /// <summary>
        /// Défini l'ElementCourant en fonction du selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeBouteilles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ManagerUCInfoBouteille.SetElementCourant(ListeBouteilles.SelectedItem as Element);
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == ManagerUCInfoBouteille.GE.ListeElement.Count - 1)
            {
                next.IsEnabled = false;
            }
            else
            {
                next.IsEnabled = true;
            }
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == 0)
            {
                previous.IsEnabled = false;
            }
            else
            {
                previous.IsEnabled = true;
            }
        }

        /// <summary>
        /// Défini l'ElementCourant comme le suivant par rapport l'ancien ElementCourant
        /// Désactive le bouton "Suivant" si l'ElementCourant est dernier dans la ListeElem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void next_Click(object sender, RoutedEventArgs e)
        {
            previous.IsEnabled = true;
            ManagerUCInfoBouteille.SetElementCourant(ManagerUCInfoBouteille.GE.ListeElement[ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ListeBouteilles.SelectedItem as Element) + 1]);
            ListeBouteilles.SelectedItem = ManagerUCInfoBouteille.ElementCourant;
            if (ManagerUCInfoBouteille.GE.ListeElement.IndexOf(ManagerUCInfoBouteille.ElementCourant) == ManagerUCInfoBouteille.GE.ListeElement.Count - 1)
            {
                next.IsEnabled = false;
            }
        }

        /// <summary>
        /// Défini l'element courant comme null
        /// change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCInfoBouteille.ElementCourant = null;
            this.Content = new UCAjoutModifBouteille();
        }

        /// <summary>
        /// Défini l'element courant comme null
        /// Supprime l'element selectionné de la ListeElem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCInfoBouteille.GE.ListeElement.Remove(ManagerUCInfoBouteille.ElementCourant);
            ManagerUCInfoBouteille.ElementCourant = null;
            this.Content = new UCInfoBouteille();
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new UCAjoutModifBouteille();
        }
    }
}
