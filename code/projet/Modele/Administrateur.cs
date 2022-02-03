using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class Administrateur : Utilisateur 
    {
        /*
         * but de la méthode : constructeur pour la classe Administrateur à partir d'un pseudonyme et d'un mot de passe
         * paramètres en entrée :   -pseudo : pseudonyme de l'Administrateur
         *                          -mdp : mot de passe de l'administrateur
         * variables : aucunes
         * fonction appelées :  -public Utilisateur(String pseudo, String motDePasse) de la classe Utilisateur
         * paramètre en sortie : aucun
         */
        public Administrateur(String pseudo, String mdp) : base(pseudo, mdp)
        {
            Admin = true;
        }

        /*
         * but de la méthode : constructeur pour la classe Administrateur à partir d'un Utilisateur déjà existant
         * paramètres en entrée :   -utilisateur : Utilisateur existant qui sert de base à la création de l'Administrateur
         * variables : aucunes
         * fonction appelées :  - public Administrateur(String pseudo, String mdp) de la classe Administrateur
         * paramètre en sortie : aucun
         */
        public Administrateur(Utilisateur utilisateur) : this(utilisateur.Pseudo, utilisateur.MotDePasse)
        {
            Admin = true;
        }
    }
}
