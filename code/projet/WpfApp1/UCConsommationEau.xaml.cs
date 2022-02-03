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
    public partial class UCConsommationEau : UserControl 
    {
        int NbVerresDuJour { get; set; }

        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCConsommationEau => (App.Current as App).LeManager;

        /// <summary>
        /// Le constructeur de UCConsommationEau permet de définir le nombre de verres bus par l'utilisateur (s'il existe) sur le slider
        /// </summary>
        public UCConsommationEau()
        {
            InitializeComponent();
            foreach (DonneeConso donnee in ManagerUCConsommationEau.UtilisateurCourant.ListeDonneeConso)
            {
                if(donnee.Date == DateTime.Today)
                {
                    NbVerresDuJour = donnee.NbVerres;
                }
            }
            Slider.Value = NbVerresDuJour;
        }

        /// <summary>
        /// Permet d'enregistrer une commation d'eau définie avec le slider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            ManagerUCConsommationEau.AjouterConso((int)Slider.Value);
            this.Content = new UCConsommationEau();
        }

        /// <summary>
        /// Permet d'arrondir la valeur retournée par le slider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider.Value = Math.Round(Slider.Value,0);
        }
    }
}
