using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class GestionElement
    {
        /*
         * stocke des Element de type info associé à une clé afin de les reconnaître plus précisément
         */
        [DataMember]
        public Dictionary<int, Element> DicoElement { get; private set; }

        /*
         * stocke des Element de type bouteille
         */
        [DataMember]
        public List<Element> ListeElement { get; private set; }

        /*
         * but de la méthode : constructeur de GestionElement
         * paramètres en entrée :   aucun
         * variables : aucunes
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public GestionElement()
        {
            DicoElement = new Dictionary<int, Element>(); ;
            ListeElement = new List<Element>();
        }

        /*
         * but de la méthode : ajouter un Element dans DicoElement ou ListeElement
         * paramètres en entrée :   -elem : Element à ajouter
         * variables : aucunes
         * fonction appelées :  -ListeElement.Add(elem) de la classe List<>
         *                      -DicoElement.Add(DicoElement.Count+1, elem) de la classe Dictionary<>
         * paramètre en sortie : aucun
         */
        public void AjouterElement(Element elem)
        {
            if(elem.TypeElem == "bouteille")
            {
                ListeElement.Add(elem);
            }

            else if(elem.TypeElem == "info")
            {
                DicoElement.Add(DicoElement.Count+1, elem);
            }
        }

        /*
         * but de la méthode : supprimer un Element de ListElement
         * paramètres en entrée :   -element : Element à supprimer
         * variables : aucunes
         * fonction appelées :  -ListeElement.Remove(element) de la classe List<>
         * paramètre en sortie : aucun
         */
        public void SupprimerElement(Element element)
        {
            ListeElement.Remove(element);
        }

        /*
         * but de la méthode : modifier un Element de ListeElement
         * paramètres en entrée :   -element : Element à modifier
         *                          -nom : nouveau nom de l'Element
         *                          -lienImage : nouveau lien d'image de l'Element
         *                          -contenu : nouveau texte contenu dans l'Element
         * variables : -elem : Element de ListeElement
         * fonction appelées :  aucunes
         * paramètre en sortie : aucun
         */
        public void ModifierElement(Element element, String nom, String lienImage, String contenu)
        {
            foreach (Element elem in ListeElement)
            {
                if (elem.Equals(element))
                {
                    elem.Nom = nom;
                    elem.LienImage = lienImage;
                    elem.Contenu = contenu;
                }
            }
        }

        /*
         * but de la méthode : trouver un Element dans DicoElement à partir du nombre qui lui est associé "key"
         * paramètres en entrée :   -num : numéro de clé à chercher
         * variables : -paire : paire de int+Element dans DicoElement
         * fonction appelées :  aucunes
         * paramètre en sortie : -paire.value : Element associé à la "key" en entrée
         */
        public Element TrouverElement(int num)
        {
            foreach (KeyValuePair<int, Element> paire in DicoElement)
            {
                if (paire.Key == num)
                {
                    return paire.Value;
                }
            }
            throw new Exception("Element absent dans la liste");
        }
    }
}
