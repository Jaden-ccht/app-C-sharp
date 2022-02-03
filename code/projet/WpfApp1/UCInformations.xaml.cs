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
    /// Logique d'interaction pour UCInformations.xaml
    /// </summary>
    public partial class UCInformations : UserControl
    {
        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCInformations => (App.Current as App).LeManager;

        /// <summary>
        /// défini le data context
        /// </summary>
        public UCInformations()
        {
            InitializeComponent();
            DataContext = ManagerUCInformations.ElementCourant;
        }
    }
}
