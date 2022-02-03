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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour UCBoutonxaml.xaml
    /// </summary>
    public partial class UCBouton : UserControl
    {
        /// <summary>
        /// Permet de créer un bouton réutilisable
        /// </summary>
        public UCBouton()
        {
            InitializeComponent();
        }

        public string Texte
        {
            set
            {
                Bouton.Content = value;
            }
        }

        public string NomIcon
        {
            set
            {
                Icon.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        public RoutedEventHandler Clique
        {
            set
            {
                Bouton.Click += value;
            }
        }
    }
}
