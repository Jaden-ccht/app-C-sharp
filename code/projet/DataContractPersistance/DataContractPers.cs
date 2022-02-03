using Modele;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace DataContractPersistance
{
    /// <summary>
    /// Classe qui permet la sérialisation de l'application
    /// </summary>
    public class DataContractPers : IPersistance
    {
        /// <summary>
        /// Défini le chemin où sauvegarder les données dans un fichier
        /// </summary>
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "Persistance");

        /// <summary>
        /// Défini le nom du fichier où sauvegarder les données
        /// </summary>
        public string FileName { get; set; } = "donnees.xml";

        /// <summary>
        /// Propriété calculée définissant le nom complet du fichier où sauvegarder les données
        /// </summary>
        string MyFile => Path.Combine(FilePath, FileName);

        /// <summary>
        /// Permet le chargement des données du type DataToPersist
        /// </summary>
        /// <returns> GestionUtilisateur laGestionUtilisateur, GestionElement laGestionElement </returns>
        public (GestionUtilisateur laGestionUtilisateur, GestionElement laGestionElement) ChargeDonnees()
        {
            if (!File.Exists(MyFile))
            {
                throw new FileNotFoundException("Persistance file missing");
            }

            var serializer = new DataContractSerializer(typeof(DataToPersist));

            DataToPersist data;

            using (Stream stream = File.OpenRead(MyFile))
            {
                data = serializer.ReadObject(stream) as DataToPersist;
            }

            return (data.gestU, data.gestE);
        }

        /// <summary>
        /// Permet la sauvegarde des données dans le fichier donnees.xml
        /// </summary>
        /// <param name="GU"></param>
        /// <param name="GE"></param>
        public void SauvegardeDonnees(GestionUtilisateur GU, GestionElement GE)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            var serializer = new DataContractSerializer(typeof(DataToPersist),
                new DataContractSerializerSettings() { PreserveObjectReferences = true });

            DataToPersist data = new DataToPersist();
            data.gestU = GU;
            data.gestE = GE;

            using (Stream stream = File.Create(MyFile))
            {
                serializer.WriteObject(stream, data);
            }
        }
    }
}
