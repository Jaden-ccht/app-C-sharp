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
    /// Logique d'interaction pour UCRegister.xaml
    /// </summary>
    public partial class UCRegister : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCRegister => (App.Current as App).LeManager;

        public UCRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ferme le User Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new UCLogin();
        }

        /// <summary>
        /// Créer un utilisateur et l'ajoute à la liste en fonction de certains paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (motdepasse.Password == confirmer.Password)
            {
                Utilisateur util = new Utilisateur(pseudo.Text, motdepasse.Password);
                try
                {
                    ManagerUCRegister.GU.AjouterUtilisateur(util);
                    this.Content = new UCLogin();
                }
                catch (Exception)
                {
                    different.Visibility = Visibility.Hidden;
                    existant.Visibility = Visibility.Visible;
                }
            }
            else
            {
                existant.Visibility = Visibility.Hidden;
                different.Visibility = Visibility.Visible;
            }

        }
    }
}
