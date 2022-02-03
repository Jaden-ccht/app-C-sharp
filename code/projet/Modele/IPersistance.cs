using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public interface IPersistance
    {
        /*
         * but de la méthode : Charge des Donnees depuis un fichier de persistance
         * paramètres en entrée :   aucun
         * paramètre en sortie : -laGestionUtilisateur : GestionUtilisateur contenant tout les Utilisateurs chargés
         *                       -laGestionElement : GestionElement contenant tout les Elements chargés
         */
        (GestionUtilisateur laGestionUtilisateur, GestionElement laGestionElement) ChargeDonnees();

        /*
         * but de la méthode : sauvegarde des données dans un fichier de persistance
         * paramètres en entrée :   -GU : GestionUtilisateur contenant tout les Utilisateur à sauvegarder
         *                          -GE : GestionElement contenant tout les Element à sauvegarder
         * paramètre en sortie : aucun
         */
        void SauvegardeDonnees(GestionUtilisateur GU, GestionElement GE);
    }
}
