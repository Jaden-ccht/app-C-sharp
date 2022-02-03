using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Modele
{
    [DataContract]
    public class Element : INotifyPropertyChanged
    {
        /*
         * permet de notifier la vue d'un changement de la variable lienImage
         */
        public event PropertyChangedEventHandler PropertyChanged;

        /*
         * Nom de l'Element
         */
        [DataMember]
        public String Nom { get; set; }

        /*
         * lien vers l'image affiché par l'Element
         */
        private String lienImage;

        /*
         * gestionnaire de la variable lienImage
         */
        [DataMember]
        public String LienImage
        {
            /*
            * but de la méthode : retourne lienImage
            * paramètres en entrée :   aucun
            * variables : aucunes
            * fonction appelées :  aucune
            * paramètre en sortie : -lienImage
            */
            get
            {
                return lienImage;
            }
            /*
            * but de la méthode : attribuer une valeur à lienImage
            * paramètres en entrée :   -value : valeur de type string
            * variables : aucunes
            * fonction appelées :  -PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LienImage")) de la classe PropertyChangedEventHandler
            * paramètre en sortie : -lienImage
            */
            set
            {
                lienImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LienImage"));
            }
        }

        /*
         * texte contenu dans l'Element
         */
        [DataMember]
        public String Contenu { get; set; }

        /*
         * permet de trier les éléments en deux type ("info" ou "bouteille") afin d'en faciliter la gestion
         */
        [DataMember]
        public String TypeElem { get; set; }

        /*
         * but de la méthode : constructeur de Element à partir d'un nom, lien d'image, texte contenu et du type d'élément
         * paramètres en entrée :   -nom : nom de l'Element
         *                          -lienImage : lien de l'image de l'Element
         *                          -contenu : texte affiché par l'Element
         *                          -typeElem : type de l'élément ("info" ou "bouteille")
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public Element(String nom, String lienImage, String contenu, String typeElem)
        {
            Nom = nom;
            LienImage = lienImage;
            Contenu = contenu;
            TypeElem = typeElem;
        }

        /*
         * but de la méthode : retourne une chaîne de caractères contenant des informations sur cette instance de Element
         * paramètres en entrée :   aucune
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : -String : $"{Nom} / {LienImage} / {Contenu}"
         */
        public override String ToString()
        {
            return $"{Nom} / {LienImage} / {Contenu}";
        }
    }
}
