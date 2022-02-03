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
    /// Logique d'interaction pour UCListeUtilisateurs.xaml
    /// </summary>
    public partial class UCListeUtilisateurs : UserControl
    {
        public Utilisateur UtiSelected { get; private set; }

        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCListeUtilisateurs => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur permet de masquer tous les boutons concernant les modifications à apporter sur un utilisateur
        /// </summary>
        public UCListeUtilisateurs()
        {
            InitializeComponent();
            DataContext = ManagerUCListeUtilisateurs;
            NomActuel.Visibility = Visibility.Hidden;
            Nom.Visibility = Visibility.Hidden;
            NewUsername.Visibility = Visibility.Hidden;
            MdpActuel.Visibility = Visibility.Hidden;
            Mdp.Visibility = Visibility.Hidden;
            NewMdp.Visibility = Visibility.Hidden;
            Confirmer.Visibility = Visibility.Hidden;
            DelUser.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Défini un UtiSelected
        /// Rend visible tous les boutons concernant les modifications à apporter sur un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeUti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UtiSelected = ListeUti.SelectedItem as Utilisateur;
            if(UtiSelected != null)
            {
                NomActuel.Visibility = Visibility.Visible;
                Nom.Visibility = Visibility.Visible;
                NewUsername.Visibility = Visibility.Visible;
                MdpActuel.Visibility = Visibility.Visible;
                Mdp.Visibility = Visibility.Visible;
                NewMdp.Visibility = Visibility.Visible;
                Confirmer.Visibility = Visibility.Visible;
                DelUser.Visibility = Visibility.Visible;

                Nom.Text = UtiSelected.Pseudo;
                Mdp.Text = UtiSelected.MotDePasse;
                ChangeAdmin.Visibility = Visibility.Visible;
                if (UtiSelected.Admin == false)
                {
                    ChangeAdmin.Content = "Promouvoir";
                }
                else
                {
                    ChangeAdmin.Content = "Déstituer";
                }
            }
        }

        /// <summary>
        /// Permet de changer la propriété Admin de l'UtiSelected
        /// Change le contenu d'un bouton en fonction de la propriété Admin de l'UtiSelected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAdmin_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCListeUtilisateurs.GU.ChangeAdmin(UtiSelected);
            if (ChangeAdmin.Content as string == "Promouvoir")
            {
                ChangeAdmin.Content = "Déstituer";
            }
            else
            {
                ChangeAdmin.Content = "Promouvoir";
            }
        }

        /// <summary>
        /// Valide les modifications apportées sur l'utiselected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirmer_Click(object sender, RoutedEventArgs e)
        {
            if (NewUsername.Text != "" && NewMdp.Text == "")
            {
                try
                {
                    ManagerUCListeUtilisateurs.GU.ModifierUtilisateur(UtiSelected, NewUsername.Text, UtiSelected.MotDePasse);
                    UtiSelected.Pseudo = NewUsername.Text;
                    NewUsername.Text = "";
                    Nom.Text = UtiSelected.Pseudo;
                    this.Content = new UCListeUtilisateurs();
                }
                catch (Exception)
                {
                }
            }
            else if (NewUsername.Text == "" && NewMdp.Text != "")
            {
                try
                {
                    ManagerUCListeUtilisateurs.GU.ModifierUtilisateur(UtiSelected, UtiSelected.Pseudo, NewMdp.Text);
                    UtiSelected.MotDePasse = NewMdp.Text;
                    NewMdp.Text = "";
                    Mdp.Text = UtiSelected.Pseudo;
                    this.Content = new UCListeUtilisateurs();
                }
                catch (Exception)
                {
                }
            }
            else if (NewUsername.Text != "" && NewMdp.Text != "")
            {
                try
                {
                    ManagerUCListeUtilisateurs.GU.ModifierUtilisateur(UtiSelected, NewUsername.Text, NewMdp.Text);
                    UtiSelected.Pseudo = NewUsername.Text;
                    NewUsername.Text = "";
                    Nom.Text = UtiSelected.Pseudo;
                    UtiSelected.MotDePasse = NewMdp.Text;
                    NewMdp.Text = "";
                    Mdp.Text = UtiSelected.Pseudo;
                    this.Content = new UCListeUtilisateurs();
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Supprime l'UtiSelected de la ListeUtilisateur
        /// S'il s'agit de l'utilisateurCourant, défini l'utilisateurCourant commme nul et ouvre la login page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelUser_Click(object sender, RoutedEventArgs e)
        {
            if (UtiSelected.Equals(ManagerUCListeUtilisateurs.UtilisateurCourant))
            {
                ManagerUCListeUtilisateurs.GU.SupprimerUtilisateur(ManagerUCListeUtilisateurs.UtilisateurCourant);
                Loginpage loginpage = new Loginpage();
                loginpage.Show();
                Window win = Window.GetWindow(this);
                win.Close();
            }
            else
            {
                ManagerUCListeUtilisateurs.GU.SupprimerUtilisateur(UtiSelected);
                this.Content = new UCListeUtilisateurs();
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
