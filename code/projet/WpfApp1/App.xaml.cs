using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Modele;
using Stub;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// Instancie un Manager commun à toutes les fenêtres/User Control
        public Manager LeManager { get; private set; } = new Manager(new DataContractPersistance.DataContractPers());

        /// <summary>
        /// Enum correspondant au thème de l'application, en lien avec la propriété de l'utilisateur
        /// </summary>
        public ThemeApp ThemeCourant { get; set; }

        /// <summary>
        /// Enum correspondant à la taille de la police dans l'application
        /// </summary>
        public TaillePolice LaTailleDeLaPolice { get; set; }

        public enum TaillePolice
        {
            Normale,
            Grosse
        }

        /// <summary>
        /// Le constructeur de app utilise la méthode de chargement de données du manager
        /// </summary>
        public App()
        {
            LeManager.ChargeDonnees();
        }

        /// <summary>
        /// Méthode permettant de passer le thème de l'application en sombre (static pour être utilisée dans les autres fenêtres)
        /// </summary>
        public static void PasserEnSombre()
        {
            Application.Current.Resources["CouleurBackGround"] = new SolidColorBrush(Colors.Black);
            Application.Current.Resources["CouleurContenus"] = new SolidColorBrush(Colors.White);
        }

        /// <summary>
        /// Méthode permettant de passer le thème de l'application en clair (static pour être utilisée dans les autres fenêtres)
        /// </summary>
        public static void PasserEnClair()
        {
            Application.Current.Resources["CouleurBackGround"] = new SolidColorBrush(Colors.White);
            Application.Current.Resources["CouleurContenus"] = new SolidColorBrush(Colors.DimGray);
        }

        /// <summary>
        /// Méthode permettant de passer la police de l'application en taille normale (static pour être utilisée dans les autres fenêtres)
        /// </summary>
        public static void PasserEnNormal()
        {
            Application.Current.Resources["fontSize"] = (double)15;
            Application.Current.Resources["fontSizeTitres"] = (double)18;
        }

        /// <summary>
        ///  Méthode permettant de passer la police de l'application en taille normale (static pour être utilisée dans les autres fenêtres)
        /// </summary>
        public static void PasserEnGros()
        {
            Application.Current.Resources["fontSize"] = (double)18;
            Application.Current.Resources["fontSizeTitres"] = (double)21;
        }
    }
}
