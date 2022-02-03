using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class DonneeConso
    {
        /*
         * permet de notifier la vue des changements de la variable nbVerres ou de la création d'une nouvelle DonneeConso
         */
        public event PropertyChangedEventHandler PropertyChanged;

        /*
         * nombre de verres bu à la date représentée par la variable Date
         */
        private int nbVerres;

        /*
         * gestionnaire de la variable nbVerres
         */
        [DataMember]
        public int NbVerres
        {

            /*
            * but de la méthode : retourne nbVerres
            * paramètres en entrée :   aucun
            * variables : aucunes
            * fonction appelées :  aucune
            * paramètre en sortie : -nbVerres
            */
            get
            {
                return nbVerres;
            }

            /*
            * but de la méthode : attribuer une valeur à nbVerres
            * paramètres en entrée :   -value : valeur de type int 
            * variables : aucunes
            * fonction appelées :  - PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("create")) de la classe PropertyChangedEventHandler
            * paramètre en sortie : aucun
            */
            set
            {
                nbVerres = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NbVerres"));
            }
        }

        /*
         * date de création de cette instance de DonneeConso
         */
        [DataMember]
        public DateTime Date { get; private set; }

        /*
         * but de la méthode : constructeur pour la classe DonneeConso à partir d'un nombre de verres
         * paramètres en entrée :   -nbVerres : représente le nombre de verres bu 
         * variables : aucunes
         * fonction appelées :  -PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("create")) de la classe PropertyChangedEventHandler
         * paramètre en sortie : aucun
         */
        public DonneeConso(int nbVerres)
        {
            NbVerres = nbVerres;
            Date = DateTime.Today;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("create"));
        }

        /*
         * but de la méthode : retourne une chaîne de caractère contenant des informations sur l'Objet
         * paramètres en entrée :   aucun 
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie :    -String: $"{NbVerres} verres bus le {Date}"
         */
        public override String ToString()
        {
            return $"{NbVerres} verres bus le {Date}";
        }
    }
}
