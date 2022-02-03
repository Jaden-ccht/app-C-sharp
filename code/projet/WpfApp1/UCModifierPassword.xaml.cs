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
    public partial class UCModifierPassword : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCModifPassword => (App.Current as App).LeManager;


        public UCModifierPassword()
        {
            InitializeComponent();
            ManagerUCModifPassword.ElementCourant = null;
        }

        /// <summary>
        /// Permet la modification du mot de passe de l'utilisateur courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirmer_Click(object sender, RoutedEventArgs e)
        {
            if(OldPassword.Password == ManagerUCModifPassword.UtilisateurCourant.MotDePasse && NewPassword.Password == Confirm.Password && NewPassword.Password != "")
            {
                ManagerUCModifPassword.UtilisateurCourant.MotDePasse = NewPassword.Password;
                this.Content = null;
              
            }
        }

        /// <summary>
        /// "Ferme" le User Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }
    }
}
