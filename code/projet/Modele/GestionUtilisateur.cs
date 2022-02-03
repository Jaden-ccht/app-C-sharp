using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Linq;

namespace Modele
{
    [DataContract]
    public class GestionUtilisateur
    {

        /*
         * stocke les utilisateurs possédant un compte sur l'application
         */
        [DataMember]
        public List<Utilisateur> ListeUtilisateurs { get; set; }

        /*
         * but de la méthode : constructeur de GestionUtilisateur
         * paramètres en entrée :   aucun
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public GestionUtilisateur()
        {
            ListeUtilisateurs = new List<Utilisateur>();
        }

        /*
         * but de la méthode : ajouter un Utilisateur à ListeUtilisateurs
         * paramètres en entrée :   -utilisateur : utilisateur à ajouter
         * variables : -user : Utilisateur de ListeUtilisateurs
         * fonction appelées :  -ListeUtilisateurs.Add(utilisateur) de la classe List<>
         *                      -utilisateur.Pseudo.Equals(user.Pseudo) de la classe Utilisateur
         * paramètre en sortie : aucun
         */
        public void AjouterUtilisateur(Utilisateur utilisateur)
        {
            foreach (Utilisateur user in ListeUtilisateurs)
            {
                if (utilisateur.Pseudo.Equals(user.Pseudo))
                {
                    throw new Exception("Pseudo déjà existant dans la liste !");
                }
            }
            ListeUtilisateurs.Add(utilisateur); 
            ListeUtilisateurs = ListeUtilisateurs.OrderBy(Utilisateur => Utilisateur.Pseudo).ToList();
        }

        /*
         * but de la méthode : supprimer un utilisateur de ListeUtilisateurs
         * paramètres en entrée :   -utilisateur : Utilisateur à supprimer
         * variables : aucunes
         * fonction appelées :  -TrouverPosUtilisateur(utilisateur.Pseudo, utilisateur.MotDePasse) de la classe GestionUtilisateurs
         *                      -ListeUtilisateurs.RemoveAt(sup) de la classe List<>
         * paramètre en sortie : aucun
         */
        public void SupprimerUtilisateur(Utilisateur utilisateur)
        {
            int sup = TrouverPosUtilisateur(utilisateur.Pseudo, utilisateur.MotDePasse);
            if (sup == -1)
            {
                throw new Exception("Utilisateur inexistant dans la liste");
            }
            else
            {
                ListeUtilisateurs.RemoveAt(sup);
            }
        }

        /*
         * but de la méthode : retourne la valeur de l'attribut Admin d'un Utilisateur
         * paramètres en entrée :   -utilisateur : Utilisateur dont on veut connaître l'attribut Admin
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : -utilisateur.Admin : valeur de l'attribut Admin de utilisateur
         */
        public Boolean IsAdmin(Utilisateur utilisateur)
        {
            return utilisateur.Admin;
        }

        /*
         * but de la méthode : changer l'attribut Admin d'un Utilisateur de ListeUtilisateurs
         * paramètres en entrée :   -utilisateur : Utilisateur dont on veut changer l'attribut Admin
         * variables : -user : Utilisateur de ListeUtilisateurs
         * fonction appelées :  -utilisateur.Equals(user) de la classe Utilisateur
         * paramètre en sortie : aucun
         */
        public void ChangeAdmin(Utilisateur utilisateur)
        {
            foreach (Utilisateur user in ListeUtilisateurs)
            {
                if (utilisateur.Equals(user))
                {
                    if (user.Admin == true)
                    {
                        user.Admin = false;
                    }
                    else
                    {
                        user.Admin = true;
                    }
                }
            }
        }

        /*
         * but de la méthode : trouver un Utilisateur dans ListeUtilisateurs à partir d'un pseudo
         * paramètres en entrée :   -pseudo : pseudonyme de l'Utilisateur recherché
         * variables : -user : Utilisateur de ListeUtilisateurs
         * fonction appelées :  aucunes
         * paramètre en sortie : -user : Utilisateur avec un pseudo correspondant à celui entré en paramètres
         */
        public Utilisateur TrouverUtilisateur(String pseudo)
        {
            foreach (Utilisateur user in ListeUtilisateurs)
            {
                if (user.Pseudo == pseudo)
                {
                    return user;
                }
            }
            throw new Exception("Utilisateur non trouvé");
        }

        /*
         * but de la méthode : trouver la position d'un utilisateur dans ListeUtilisateurs à partie d'un pseudonyme et d'un mot de passe
         * paramètres en entrée :   -pseudo : pseudonyme de l'utilisateur recherché
         *                          -mdp : mot de passe de l'utilisateur recherché
         * variables : -user : Utilisateur de ListeUtilisateur
         * fonction appelées :  -ListeUtilisateurs.IndexOf(user) de la classe List<>
         * paramètre en sortie : -ListeUtilisateurs.IndexOf(user) : position de l'utilisateur recherché
         *                       - -1 : code d'erreur
         */
        public int TrouverPosUtilisateur(String pseudo, String mdp)
        {
            foreach (Utilisateur user in ListeUtilisateurs)
            {
                if (user.Pseudo == pseudo && user.MotDePasse == mdp)
                {
                    return ListeUtilisateurs.IndexOf(user);
                }
            }
            return -1;
        }

        /*
         * but de la méthode : modifier un Utilisateur de ListeUtilisateurs
         * paramètres en entrée :   -util : Utilisateur à modifier
         *                          -pseudo : nouveau pseudo de l'Utilisateur
         *                          -mdp : nouveau mot de passe de l'Utilisateur
         * variables : -user : Utilisateur de ListeUtilisateurs
         *             -utilisateur : Utilisateur de ListeUtilisateurs
         * fonction appelées :  -pseudo.Equals(user.Pseudo) de la classe String
         *                      -util.Equals(utilisateur) de la classe Utilisateur
         * paramètre en sortie : aucun
         */
        public void ModifierUtilisateur(Utilisateur util, String pseudo, String mdp)
        {
            foreach (Utilisateur user in ListeUtilisateurs)
            {
                if (pseudo.Equals(user.Pseudo) && pseudo != util.Pseudo)
                {
                    throw new Exception("Pseudo déjà existant dans la liste !");
                }
            }
            foreach (Utilisateur utilisateur in ListeUtilisateurs)
            {
                if (util.Equals(utilisateur))
                {
                    utilisateur.Pseudo = pseudo;
                    utilisateur.MotDePasse = mdp;
                }
            }
        }
    }
}
