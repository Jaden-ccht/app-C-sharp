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
    /// Logique d'interaction pour UCListeBouteilles.xaml
    /// </summary>
    public partial class UCListeBouteilles : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCListe => (App.Current as App).LeManager;

        public UCListeBouteilles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Défini l'elementcourant
        /// change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeElem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ManagerUCListe.SetElementCourant(ListeElem.SelectedItem as Element);
            this.Content = new UCInfoBouteille();
        }
    }
}
