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
using System.Windows.Shapes;
using Modele;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour loginpage.xaml
    /// </summary>
    public partial class Loginpage : Window
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager Mgr => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur défini l'utilisateur courant comme null, le thème de l'app en clair
        /// </summary>
        public Loginpage()
        {
            InitializeComponent();
            Mgr.UtilisateurCourant = null;
            App.PasserEnClair();
            (App.Current as App).ThemeCourant = ThemeApp.Clair;
        }
    }
}
