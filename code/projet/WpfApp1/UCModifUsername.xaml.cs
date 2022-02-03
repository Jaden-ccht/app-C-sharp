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
    /// Logique d'interaction pour UCModifUsername.xaml
    /// </summary>
    public partial class UCModifUsername : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCModifUsername => (App.Current as App).LeManager;

        public UCModifUsername()
        {
            InitializeComponent();
            ManagerUCModifUsername.ElementCourant = null;
        }

        /// <summary>
        /// Permet la modification du pseud de l'utilisateur courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirmer_Click(object sender, RoutedEventArgs e)
        {
            if (NewUsername.Text != "" && ManagerUCModifUsername.UtilisateurCourant != null)
            {
                try
                {
                    ManagerUCModifUsername.GU.ModifierUtilisateur(ManagerUCModifUsername.UtilisateurCourant, NewUsername.Text, ManagerUCModifUsername.UtilisateurCourant.MotDePasse);
                    this.Content = null;
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Ferme le user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
