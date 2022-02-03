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
using static WpfApp1.App;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour UCParametres.xaml
    /// </summary>
    public partial class UCParametres : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCParametres => (App.Current as App).LeManager;

        /// <summary>
        /// Défini la visibilité des boutons en fonction de l'utilisateur courant (null, admin=true ...)
        /// </summary>
        public UCParametres()
        {
            InitializeComponent();
            if (ManagerUCParametres.UtilisateurCourant != null && ManagerUCParametres.UtilisateurCourant.Admin == true)
            {
                utilisateurs.Visibility = Visibility.Visible;
            }
            if(ManagerUCParametres.UtilisateurCourant == null)
            {
                changermdp.Visibility = Visibility.Hidden;
                changerpseudo.Visibility = Visibility.Hidden;
                if ((App.Current as App).ThemeCourant == ThemeApp.Sombre)
                {
                    clair.IsChecked = false;
                    sombre.IsChecked = true;
                }
                else
                {
                    clair.IsChecked = true;
                    sombre.IsChecked = false;
                }
            }
            if (ManagerUCParametres.UtilisateurCourant != null)
            {
                if (ManagerUCParametres.UtilisateurCourant.Theme == ThemeApp.Sombre)
                {
                    (App.Current as App).ThemeCourant = ThemeApp.Sombre;
                    clair.IsChecked = false;
                    sombre.IsChecked = true;
                }
                else
                {
                    (App.Current as App).ThemeCourant = ThemeApp.Clair;
                    clair.IsChecked = true;
                    sombre.IsChecked = false;
                }
                DelUser.Visibility = Visibility.Visible;
            }

            if ((App.Current as App).LaTailleDeLaPolice == TaillePolice.Normale)
            {
                grosse.IsChecked = false;
                normale.IsChecked = true;
            }
            else
            {
                grosse.IsChecked = true;
                normale.IsChecked = false;
            }
            DataContext = ManagerUCParametres.UtilisateurCourant;
            
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Changerpseudo_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCModifUsername();
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Changermdp_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCModifierPassword();
        }

        /// <summary>
        /// Change le content control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void utilisateurs_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCListeUtilisateurs();
        }

        /// <summary>
        /// Supprime l'utilisateur de la ListeUtilisateur
        /// Défini l'utilisateur courant comme null
        /// Ouvre une login page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelUser_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCParametres.GU.SupprimerUtilisateur(ManagerUCParametres.UtilisateurCourant);
            Loginpage loginpage = new Loginpage();
            loginpage.Show();
            Window win = Window.GetWindow(this);
            win.Close();
        }

        /// <summary>
        /// Change le thème pour clair en appelant la méthode de App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clair_Checked(object sender, RoutedEventArgs e)
        {
            if(ManagerUCParametres.UtilisateurCourant != null)
            {
                ManagerUCParametres.UtilisateurCourant.Theme = ThemeApp.Clair;
                (App.Current as App).ThemeCourant = ThemeApp.Clair;
            }
            else
            {
                (App.Current as App).ThemeCourant = ThemeApp.Clair;
            }
            sombre.IsChecked = false;
            App.PasserEnClair();
        }

        /// <summary>
        /// Change le thème pour sombre en appelant la méthode de App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sombre_Checked(object sender, RoutedEventArgs e)
        {
            if (ManagerUCParametres.UtilisateurCourant != null)
            {
                ManagerUCParametres.UtilisateurCourant.Theme = ThemeApp.Sombre;
                (App.Current as App).ThemeCourant = ThemeApp.Sombre;
            }
            else
            {
                (App.Current as App).ThemeCourant = ThemeApp.Sombre;
            }
            clair.IsChecked = false;
            App.PasserEnSombre();
        }

        /// <summary>
        /// Change la police pour normale en appelant la méthode de App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Normale_Checked(object sender, RoutedEventArgs e)
        {
            (App.Current as App).LaTailleDeLaPolice = TaillePolice.Normale;
            grosse.IsChecked = false;
            App.PasserEnNormal();
        }

        /// <summary>
        /// Change la police pour grosse en appelant la méthode de App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grosse_Checked(object sender, RoutedEventArgs e)
        {
            (App.Current as App).LaTailleDeLaPolice = TaillePolice.Grosse;
            normale.IsChecked = false;
            App.PasserEnGros();
        }
    }
}
