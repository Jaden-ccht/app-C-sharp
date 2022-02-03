using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Modele
{
    [KnownTypeAttribute("KnownTypes")]
    [DataContract]
    public class Utilisateur : IEquatable<Utilisateur>
    {
        /*
         * notifie la vue d'une modification de Pseudo
         */
        public event PropertyChangedEventHandler PropertyChanged;

        /*
         * Types reconnus lors de la désérialisation d'un utilisateur
         */
        static Type[] KnownTypes()
        {
            return new Type[] { typeof(Administrateur), typeof(Utilisateur) };
        }

        /*
         * pseudonyme de l'Utilisateur
         */
        private String pseudo;

        /*
         * gestionnaire de pseudo
         */
        [DataMember]
        public String Pseudo
        {
           /*
            * but de la méthode : retourne la valeur de pseudo
            * paramètres en entrée :   aucun
            * variables : aucunes
            * fonction appelées :  aucunes
            * paramètre en sortie : -pseudo
            */
            get
            {
                return pseudo;
            }
            /*
            * but de la méthode : attribuer une valeur à pseudo
            * paramètres en entrée :   -value : valeur de type String
            * variables : aucunes
            * fonction appelées :  -PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pseudo")) de la classe PropertyChangedEventHandler
            * paramètre en sortie : aucun
            */
            set
            {
                pseudo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pseudo"));
            }
        }

        /*
         * mot de passe de l'Utilisateur
         */
        [DataMember]
        public String MotDePasse { get; set; }

        /*
         * indique si l'Utilisateur est un Administrateur
         */
        [DataMemberAttribute]
        public bool Admin { get; set; }

        /*
         * indique le thème de couleur sélectionné par l'Utilisateur
         */
        [DataMember]
        public ThemeApp Theme { get; set; }

        /*
         * liste des consommation journalières d'eau de cet Utilisateur
         */
        [DataMember]
        public List<DonneeConso> ListeDonneeConso { get; set; }
        
        /*
         * liste des Element favoris de l'Utilisateur
         */
        [DataMember]
        public List<Element> ListeFavoris { get; set; }

        /*
         * but de la méthode : constructeur de Utilisateur
         * paramètres en entrée :   -pseudo : pseudonyme de l'utilisateur
         *                          -motDePasse : mot de passe de l'utilisateur
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public Utilisateur(String pseudo, String motDePasse)
        {
            Pseudo = pseudo;
            MotDePasse = motDePasse;
            Theme = ThemeApp.Clair;
            ListeDonneeConso = new List<DonneeConso>();
            ListeFavoris = new List<Element>();
        }

        /*
         * but de la méthode : retourne une chaîne de caractères contenant des informations sur cet Utilisateur
         * paramètres en entrée :   aucun
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : -String : $"Pseudo : {Pseudo} / Mdp : {MotDePasse} / Admin : {Admin} / Theme : {Theme}"
         */
        public override String ToString()
        {
            return $"Pseudo : {Pseudo} / Mdp : {MotDePasse} / Admin : {Admin} / Theme : {Theme}";
        }

        /*
         * but de la méthode : compare un autre Utilisateur à celui-ci
         * paramètres en entrée :   -other : autre Utilisateur
         * variables : aucunes
         * fonction appelées :  -Pseudo.Equals(other.Pseudo) de la classe String
         *                      -MotDePasse.Equals(other.MotDePasse) de la classe String
         * paramètre en sortie : -bool : Pseudo.Equals(other.Pseudo) && MotDePasse.Equals(other.MotDePasse)
         */
        public bool Equals(Utilisateur other)
        {
            return Pseudo.Equals(other.Pseudo) && MotDePasse.Equals(other.MotDePasse);
        }

        /*
         * but de la méthode : compare un object quelconque à cet utilisateur
         * paramètres en entrée :   -obj : object quelconque
         * variables : aucunes
         * fonction appelées :  -ReferenceEquals(obj, null) de la classe Object
         *                      -ReferenceEquals(obj, this) de la classe Object
         *                      -GetType() de la classe Object
         *                      -obj.GetType() de la classe Object
         *                      -Equals(obj as Utilisateur) de la classe Utilisateur
         * paramètre en sortie :    -false : valeur retournée si ReferenceEquals(obj, null) == true ou GetType() != obj.GetType()
         *                          -true : valeur retournée si ReferenceEquals(obj, this) == true
         *                          -Equals(obj as Utilisateur) : retourné par défaut
         */
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals(obj as Utilisateur);
        }
    }
}
