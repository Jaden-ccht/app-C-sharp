using System;
using System.Collections.Generic;
using Modele;

namespace Stub
{
    /// <summary>
    /// Le Stub utilise les méthodes de l'interface IPersistance pour "injecter" les premières données dans la vue
    /// </summary>
    public class Stub : IPersistance
    {
        public (GestionUtilisateur laGestionUtilisateur, GestionElement laGestionElement) ChargeDonnees()
        {
            GestionUtilisateur gestUti = ChargeUtilisateurs();

            GestionElement gestElem = ChargeElements();
            return (gestUti, gestElem);
        }

        public void SauvegardeDonnees(GestionUtilisateur GU, GestionElement GE)
        {
            throw new NotImplementedException();
        }

        public GestionUtilisateur ChargeUtilisateurs()
        {
            GestionUtilisateur gu = new GestionUtilisateur();

            Utilisateur[] liste = {
                new Utilisateur("utilisateur1","mdp1"),
                new Utilisateur("utilisateur2","mdp2"),
                new Administrateur("admin1","mdpadmin1"),
                new Administrateur("admin2","mdpadmin2"),
            };
            foreach (Utilisateur u in liste)
            {
                gu.AjouterUtilisateur(u);
            }
            return gu;
        }

        public GestionElement ChargeElements()
        {
            GestionElement ge = new GestionElement();

            Element[] laListe = {

                new Element("L'eau minérale en France", null, "Cette page contient une petite liste des marques françaises d'eau minérales les plus connues. La France est le premier exportateur mondial d’eaux minérales naturelles !", "info"),
                new Element("Aquarel", "/images;component/ImagesBouteilles/aquarel.jpg", "Aquarel offre une eau pure, saine. Son goût léger est apprécié par toute la famille.", "bouteille"),
                new Element("Carola", "/images;component/ImagesBouteilles/carola.jpg", "L’eau Carola tire toute sa richesse au plus profond de la terre d’Alsace depuis plus de 4 siècles. Une source précieuse, à l’abri dans son griffon traditionnel qui jaillit à quelques mètres du site Carola de Ribeauvillé.", "bouteille"),
                new Element("Celtic", "/images;component/ImagesBouteilles/celtic.jpg", "Celtic jaillit à Niederbronn-les-Bains, station thermale et cure d’air pur réputées, située au cœur du parc régional des Vosges du Nord, territoire de 110000 ha, protégé et classé réserve Mondiale de Biosphère depuis 1989.", "bouteille"),
                new Element("Contrex", "/images;component/ImagesBouteilles/contrex.jpg", "L’eau minérale naturelle Contrex jaillit au cœur des Vosges, espace sauvage réservé qui accueille la plus grande forêt naturelle de France.Contrex est reconnue par l’Académie de médecine qui lui a accordé l’appellation Eau Minérale Naturelle.", "bouteille"),
                new Element("Cristaline", "/images;component/ImagesBouteilles/cristaline.jpg", "Lancée en 1992, l’eau de source Cristaline est rapidement devenue l’eau la plus vendue, et la marque leader en France.", "bouteille"),
                new Element("Eau Royale", "/images;component/ImagesBouteilles/eauRoyale.jpg", "Eau Royale est une marque d’eau minérale de la Brasserie de Tahiti.", "bouteille"),
                new Element("Evian", "/images;component/ImagesBouteilles/evian.jpg", "L’origine de l’eau minérale naturelle Evian commence il y a plus de 100 millions d’années avec la création des Alpes. Au cours des différentes périodes de glaciation, va se constituer un filtre naturel unique au monde.", "bouteille"),
                new Element("Hepar", "/images;component/ImagesBouteilles/hepar.jpg", "La source Hépar, après un long périple au cœur du Bassin Vosgien, émerge à 3 kilomètres à l’est de la ville de Vittel. Découverte en 1873 par Louis Bouloumié, son exceptionnelle richesse en sels minéraux notamment en magnésium lui vaut à l’époque sa renommée.", "bouteille"),
                new Element("Rozana", "/images;component/ImagesBouteilles/rozana.jpg", "L’eau Rozana jaillit au pied des monts d’Auvergne, dans les terres du Puy-de-Dôme. Au pied des volcans, dans le hameau préservé de Rouzat, la source Rozana bénéficie naturellement de l’immense richesse minérale bien connue des sous-sols auvergnats.", "bouteille"),
                new Element("Vittel", "/images;component/ImagesBouteilles/vittel.jpg", "Source de Vitalité, Vittel vous accompagne à chaque instant de votre vie.", "bouteille"),
                new Element("Volvic", "/images;component/ImagesBouteilles/volvic.jpg", "L’eau minérale naturelle Volvic, est puisée au coeur des volcans d’Auvergne.", "bouteille"),

                new Element("20 choses à savoir sur l'eau", null, "1. L’eau est la seule substance que l’on retrouve naturellement en 3 formes sur Terre (solide, liquide et gazeuse). \n\n2. L’eau régule la température de la Terre. \n\n3. Environ 66% du corps humain est composé d’eau. \n\n4. Environ 80% de la surface de la Terre est de l’eau. \n\n5. Une personne peut survivre environ 1 semaine sans eau, selon les conditions. \n\n6. 2% de l’eau dans le monde est gelée et donc inutilisable. \n\n7. 97% de l’eau sur Terre se retrouve dans les océans et les mers. \n\n8. 1% de l’eau sur Terre est potable. \n\n9. Puisque l’eau se recycle constamment, il est techniquement possible de boire de l’eau datant de l’ère des dinosaures. \n\n10. Pour une douche d’environ 5 minutes, environ 200 litres d’eau sont utilisés. \n\n11. Un lave-vaisselle utilise en moyenne 34 à 45 litres d’eau par cycle. \n\n12. Une personne utilise en moyenne 34 à 76 litres d’eau en lavant la vaisselle à la main. \n\n 13. Environ 8 à 27 litres d’eau sont nécessaires lorsque l’on tire la chasse de la toilette. \n\n14. Une vache doit boire 15 litres d’eau pour produire 4 litres de lait. \n\n15. Environ 1514 litres d’eau sont nécessaires pour la croissance/production d’un poulet. \n\n16. Environ 147 972 litres d’eau sont nécessaires pour la production d’une seule automobile (incluant les pneus). \n\n17. Environ 52 litres d’eau sont nécessaires pour la croissance/production d’une seule orange. \n\n18. Environ 568 litres d’eau sont nécessaires pour la croissance/production d’une miche de pain. \n\n19. Environ 6810 litres d’eau dont nécessaire pour la croissance/production d’un bœuf. \n\n20. 12 000 litres d’eau sont nécessaires pour la confection d’une livre de chocolat.", "info"),
                new Element("Page de consommation d'eau", null, "Sur cette page, il est possible d'enregistrer votre consommation quotidienne d'eau ! Il est très important de boire réguilèrement ... Vous pouvez ici enregistrer le nombre de verre que vous avez bu aujourd'hui. Le nombre de verre suffisant pour l'organisme est de 10 (pour des vers de 15 cL environ).", "info"),
            };

            foreach(Element e in laListe)
            {
                ge.AjouterElement(e);
            }

            return ge;
        }
    }
}
