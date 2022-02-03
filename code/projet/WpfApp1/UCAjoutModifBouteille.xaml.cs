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
    /// Logique d'interaction pour UCAjoutModifBouteille.xaml
    /// </summary>
    public partial class UCAjoutModifBouteille : UserControl
    {
        /// <summary>
        /// Propriété utilisée uniquement par cette classe
        /// </summary>
        private string LienImage { get; set; }

        /// <summary>
        /// Défini un manager correspondant au Manager de App.xaml.cs
        /// </summary>
        public Manager ManagerUCAjoutModif => (App.Current as App).LeManager;

        /// <summary>
        /// Si l'ElementCourant est nul change le contenu du bouton "Modifier" pour "Ajouter"
        /// Sinon, défini toutes l'image comme celle de l'ElementCourant
        /// </summary>
        public UCAjoutModifBouteille()
        {
            InitializeComponent();
            if (ManagerUCAjoutModif.ElementCourant == null)
            {
                ChangeAdd.Content = "Ajouter";
            }
            else
            {
                if(ManagerUCAjoutModif.ElementCourant.LienImage != null)
                {
                    LienImage = ManagerUCAjoutModif.ElementCourant.LienImage;
                    try
                    {
                        var bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.UriSource = new Uri(LienImage, UriKind.Relative);
                        bitmap.EndInit();
                        ImageBouteille.Source = bitmap;
                    }
                    catch (System.IO.DirectoryNotFoundException e)
                    {
                        ImageBouteille.Source = new BitmapImage(new Uri(ManagerUCAjoutModif.ElementCourant.LienImage, UriKind.Relative));
                    }
                }
            }
        }

        /// <summary>
        /// Permet l'ajout d'un nouvel Element si ElementCourant est null
        /// Sinon permet la modification de l'ElementCourant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerUCAjoutModif.ElementCourant == null)
            {
                Element ajout = new Element(Nom.Text, LienImage, Contenu.Text, "bouteille");
                ManagerUCAjoutModif.GE.AjouterElement(ajout);
                ManagerUCAjoutModif.SetElementCourant(ajout);
                this.Content = new UCInfoBouteille();
            }
            else
            {
                ManagerUCAjoutModif.GE.ModifierElement(ManagerUCAjoutModif.ElementCourant, Nom.Text, LienImage, Contenu.Text);
                this.Content = new UCInfoBouteille();
            }
        }

        /// <summary>
        /// Permet l'ouverture d'un explorateur de dossier puis de définir l'image présente sur la fenetre avec celle choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\Public\Pictures";
            dialog.DefaultExt = ".jpg | .png";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                LienImage = dialog.FileName;
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.UriSource = new Uri(LienImage, UriKind.Relative);
                bitmap.EndInit();
                ImageBouteille.Source = bitmap;
            }
        }

        /// <summary>
        /// permet le retour sur la liste des bouteilles en changeant l'UC du contentControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new UCInfoBouteille();
        }
    }
}
