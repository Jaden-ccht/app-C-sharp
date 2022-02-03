using Modele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests fonctionnels

            Manager LeManager = new Manager(new Stub.Stub());

            LeManager.ChargeDonnees();

            //Test cas d'inscription d'un nouvel utilisateur
            Console.WriteLine("Test cas d'inscription d'un nouvel utilisateur");
            foreach (Utilisateur user in LeManager.GU.ListeUtilisateurs)
            {
                Console.WriteLine(user);
            }
            Utilisateur nouvelUti = new Utilisateur("UtilisateurInscription", "SonMDP");
            LeManager.GU.AjouterUtilisateur(nouvelUti);
            
            Console.WriteLine("Après inscription du nouvel utilisateur :");

            foreach (Utilisateur user in LeManager.GU.ListeUtilisateurs)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test identification
            Console.WriteLine("Test identification d'un utilisateur");

            LeManager.SetUtilisateurCourant("pseudo", "mdp");
            LeManager.SetUtilisateurCourant("UtilisateurInscription", "SonMDP");
            //ou
            LeManager.SetUtilisateurCourant(nouvelUti);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test paramètres
            Console.WriteLine("Test modif luminosité paramètres");
            Console.WriteLine(LeManager.UtilisateurCourant);
            LeManager.UtilisateurCourant.Theme = ThemeApp.Sombre;
            Console.WriteLine(LeManager.UtilisateurCourant);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test consommation quotidienne d'eau
            Console.WriteLine("Test consommation quotidienne d'eau");
            foreach (DonneeConso donnee in LeManager.UtilisateurCourant.ListeDonneeConso)
            {
                Console.WriteLine(donnee);
            }
            LeManager.AjouterConso(2);
            foreach (DonneeConso donnee in LeManager.UtilisateurCourant.ListeDonneeConso)
            {
                Console.WriteLine(donnee);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test afficher liste + ajouter élément
            Console.WriteLine("Test afficher liste + ajouter élément");
            Element elementajouté = new Element("elemajouté", "chemin invalide", "chemin invalide", "bouteille");
            LeManager.GE.AjouterElement(elementajouté);
            foreach (Element element in LeManager.GE.ListeElement)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test afficher les informations
            Console.WriteLine("Test afficher les informations d'un élément choisi");
            foreach (Element element in LeManager.GE.ListeElement)
            {
                if (element.Equals(elementajouté))
                {
                    Console.WriteLine(element);
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test ajout au favoris et affichage liste favoris de l'utilisateur courant
            Console.WriteLine("Test ajout au favoris et affichage liste favoris de l'utilisateur courant");
            LeManager.SetElementCourant(elementajouté);
            LeManager.AjouterFavori();
            foreach (Element elem in LeManager.UtilisateurCourant.ListeFavoris)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test modif élément
            Console.WriteLine("Test modif element");
            Console.WriteLine(LeManager.ElementCourant);
            LeManager.GE.ModifierElement(LeManager.ElementCourant, "modif nom de l'elem", "toujours pas de lien", "contenu innexistant");
            Console.WriteLine(LeManager.ElementCourant);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test suppression d'élément
            Console.WriteLine("Test suppression element de la liste");
            LeManager.GE.ListeElement.Remove(LeManager.ElementCourant);
            foreach (Element element in LeManager.GE.ListeElement)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //test modif utilisateur
            Console.WriteLine("Test modif d'un utilisateur");
            Console.WriteLine(LeManager.UtilisateurCourant);
            LeManager.GU.ModifierUtilisateur(LeManager.UtilisateurCourant, "MODIF", "MDPMODIF");
            Console.WriteLine(LeManager.UtilisateurCourant);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
