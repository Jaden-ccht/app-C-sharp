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
using Modele;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UCMenuCirculaire : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCMenuCirculaire => (App.Current as App).LeManager;

        /// <summary>
        /// Si l'utilisateur courant est null, désactive un bouton
        /// Change la couleur en fonction de la propriété ThemeApp de App
        /// </summary>
        public UCMenuCirculaire()
        {
            InitializeComponent();
            ManagerUCMenuCirculaire.ElementCourant = null;
            if (ManagerUCMenuCirculaire.UtilisateurCourant == null)
            {
                conso.IsEnabled = false;
            }
            if((App.Current as App).ThemeCourant == ThemeApp.Sombre)
            {
                gridMenu.Color = Colors.Black;
            }
            else
            {
                gridMenu.Color = Colors.White;
            }
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Conso_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCMenuCirculaire.SetElementCourant(ManagerUCMenuCirculaire.GE.TrouverElement(3));
            this.Content = new UCConsommationEau();
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Marques_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCMenuCirculaire.SetElementCourant(ManagerUCMenuCirculaire.GE.TrouverElement(1));
            this.Content = new UCListeBouteilles();
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCMenuCirculaire.SetElementCourant(ManagerUCMenuCirculaire.GE.TrouverElement(2));
            this.Content = new UCInformations();
        }
    }
}
