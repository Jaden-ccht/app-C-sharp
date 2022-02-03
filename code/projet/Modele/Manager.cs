using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Modele;

namespace Modele
{
    public class Manager
    {
        /*
         * instance d'une classe implémentant IPersistance utilisée pour la persistance
         */
        public IPersistance Persistance { get; set; }

        /*
         * Utilisateur actuellement connecté
         */
        public Utilisateur UtilisateurCourant { get; set; }

        /*
         * Element actuellement affiché à l'écran
         */
        public Element ElementCourant { get; set; }

        /*
         * Contient la liste de tout les Utilisateur
         */
        public GestionUtilisateur GU { get; private set; }

        /*
         * Contient la liste de tout les Element
         */
        public GestionElement GE { get; private set; }

        /*
         * but de la méthode : constructeur de Manager
         * paramètres en entrée :   -persistance : instance d'une classe implémentant IPersistance utilisée pour la persistance
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public Manager(IPersistance persistance)
        {
            Persistance = persistance;
            GU = new GestionUtilisateur();
            GE = new GestionElement();
        }

        /*
         * but de la méthode : transférer les données depuis un fichier de persistance vers les attributs de Manager
         * paramètres en entrée :   aucun
         * variables : -données : données chargées depuis le fichier de persistance
         * fonction appelées :  -Persistance.ChargeDonnees() de l'interface IPersistance
         * paramètre en sortie : aucun
         */
        public void ChargeDonnees()
        {
            var données = Persistance.ChargeDonnees();
            GU = données.laGestionUtilisateur;
            GE = données.laGestionElement;
        }

        /*
         * but de la méthode : appelle la fonction SauvegardeDonnees de l'interface IPersistance
         * paramètres en entrée :   aucun
         * variables : aucunes
         * fonction appelées :  -Persistance.SauvegardeDonnees(GU, GE) de l'interface IPersistance
         * paramètre en sortie : aucun
         */
        public void SauvegardeDonnees()
        {
            Persistance.SauvegardeDonnees(GU, GE);
        }

        /*
         * but de la méthode : modifier la valeur de UtilisateurCourant
         * paramètres en entrée :   -pseudo : pseudonyme de l'Utilisateur qui deviendra utilisateur courant
         *                          -mdp : mot de passe de l'Utilisateur qui deviendra utilisateur courant
         * variables :  -check : valeur servant à vérifier le bon fonctionnement de la fonction
         *              -user : Utilisateur de GU.ListeUtilisateurs
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public void SetUtilisateurCourant(String pseudo, String mdp)
        {
            int check = 0;
            foreach (Utilisateur user in GU.ListeUtilisateurs)
            {
                if (user.Pseudo == pseudo && user.MotDePasse == mdp)
                {
                    check = 1;
                    UtilisateurCourant = user;
                }
            }
            if (check == 0)
            {
                throw new Exception("Utilisateur non trouvé");
            }
        }

        /*
         * but de la méthode : modifier la valeur de UtilisateurCourant
         * paramètres en entrée :   -util : Utilisateur qui deviendra utilisateur courant 
         * variables : -check : valeur servant à vérifier le bon fonctionnement de la fonction
         *              -user : Utilisateur de GU.ListeUtilisateurs
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public void SetUtilisateurCourant(Utilisateur util)
        {
            int check = 0;
            foreach (Utilisateur user in GU.ListeUtilisateurs)
            {
                if (user.Equals(util))
                {
                    check = 1;
                    UtilisateurCourant = user;
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Utilisateur non trouvé");
            }
        }

        /*
         * but de la méthode : modifier la valeur de ElementCourant 
         * paramètres en entrée :   -element : Element qui deviendra élement courant
         * variables : -check : valeur servant à vérifier où est stocké l'Element
         *              -elem : Element de GE.ListeElement
         *              -paire : entrée dans GE.DicoElement
         * fonction appelées :  -elem.Equals(element) de la classe Element
         *                      -paire.Value.Equals(element) de la classe Element
         * paramètre en sortie : aucun
         */
        public void SetElementCourant(Element element)
        {
            int check = 0;
            foreach (Element elem in GE.ListeElement)
            {
                if (elem.Equals(element))
                {
                    check = 1;
                    ElementCourant = elem;
                }
            }
            if (check == 0)
            {
                foreach (KeyValuePair<int, Element> paire in GE.DicoElement)
                {
                    if (paire.Value.Equals(element))
                    {
                        ElementCourant = paire.Value;
                    }
                }
            }
        }

        /*
         * but de la méthode : retourne la valeur de la clé associé à l'ElementCourant
         * paramètres en entrée :   aucun
         * variables : -paire : entrée dans GE.DicoElement 
         * fonction appelées :  paire.Value.Equals(ElementCourant) de la classe Element
         * paramètre en sortie : -paire.key : valeur de la clé associée à l'ElementCourant
         */
        public int GetKeyElementCourant()
        {
            foreach (KeyValuePair<int, Element> paire in GE.DicoElement)
            {
                if (paire.Value.Equals(ElementCourant))
                {
                    return paire.Key;
                }
            }
            return 0;
        }

        /*
         * but de la méthode : ajouter l'ElementCourant à la ListeFavoris de l'UtilisateurCourant
         * paramètres en entrée :   aucun
         * variables : -elem : Element de UtilisateurCourant.ListeFavoris
         * fonction appelées :  -elem.Equals(ElementCourant) de la classe Element
         *                      -UtilisateurCourant.ListeFavoris.Add(ElementCourant) de la classe List<>
         * paramètre en sortie : aucun
         */
        public void AjouterFavori()
        {
            foreach (Element elem in UtilisateurCourant.ListeFavoris)
            {
                if (elem.Equals(ElementCourant))
                {
                    Console.WriteLine("Favori déjà enregistré");
                    return;
                }
            }
            UtilisateurCourant.ListeFavoris.Add(ElementCourant) ;
        }

        /*
         * but de la méthode : supprimer un Element de UtilisateurCourant.ListeFavoris
         * paramètres en entrée :   -element : Element à supprimer de UtilisateurCourant.ListeFavoris
         * variables : -elem : Element de UtilisateurCourant.ListeFavoris
         * fonction appelées :  -elem.Equals(element) de la classe Element
         * paramètre en sortie : aucun
         */
        public void SupprimerFavori(Element element)
        {
            foreach (Element elem in UtilisateurCourant.ListeFavoris)
            {
                if (elem.Equals(element))
                {
                    UtilisateurCourant.ListeFavoris.Remove(elem);
                }
            }
        }

        /*
         * but de la méthode : ajouter une DonneeConso à UtilisateurCourant.ListeDonneeConso
         * paramètres en entrée :   -nbVerres : nombre de verres d'eau consommer aujourd'hui par l'utilisateur
         * variables :  -check : valeur vérifiant le bon fonctionnement de la fonction
         *              -donnee : DonneeConso de UtilisateurCourant.ListeDonneeConso
         * fonction appelées :  -UtilisateurCourant.ListeDonneeConso.Add(new DonneeConso(nbVerres)) de la classe List<>
         * paramètre en sortie : aucun
         */
        public void AjouterConso(int nbVerres)
        {
            int check = 0;
            foreach (DonneeConso donnee in UtilisateurCourant.ListeDonneeConso)
            {
                if (donnee.Date == DateTime.Today)
                {
                    check = 1;
                    donnee.NbVerres = nbVerres;
                }
            }
            if (check == 0)
            {
                UtilisateurCourant.ListeDonneeConso.Add(new DonneeConso(nbVerres));
            }
        }
    }
}
