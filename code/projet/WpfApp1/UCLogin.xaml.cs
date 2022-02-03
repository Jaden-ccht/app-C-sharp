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
    /// Logique d'interaction pour UCLogin.xaml
    /// </summary>
    public partial class UCLogin : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCLogin => (App.Current as App).LeManager;

        public UCLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si les infomartions entrées correspondent à celles d'un utilisateur de la liste, ouvre une mainwindow avec les paramètres de l'utilisateur courant défini
        /// Sinon affiche le message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerUCLogin.GU.TrouverPosUtilisateur(Username.Text, mdp.Password) != -1)
            {
                ManagerUCLogin.SetUtilisateurCourant(new Utilisateur(Username.Text, mdp.Password));
                if (ManagerUCLogin.UtilisateurCourant.Theme == ThemeApp.Sombre)
                {
                    (App.Current as App).ThemeCourant = ThemeApp.Sombre;
                    App.PasserEnSombre();
                }
                else
                {
                    (App.Current as App).ThemeCourant = ThemeApp.Clair;
                    App.PasserEnClair();
                }
                MainWindow fenetre = new MainWindow();
                fenetre.Show();
                Window win = Window.GetWindow(this);
                win.Close();
            }
            else
            {
                incorrect.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Défini le content control avec UCRegister
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new UCRegister();
        }

        /// <summary>
        /// Ouvre une mainwindow sans définir d'utilisateur courant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Invite_Click(object sender, RoutedEventArgs e)
        {
            MainWindow fenetre = new MainWindow();
            fenetre.Show();
            Window win = Window.GetWindow(this);
            win.Close();
        }
    }
}
