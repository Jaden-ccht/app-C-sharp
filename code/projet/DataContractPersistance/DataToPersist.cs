using Modele;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance
{
    /// <summary>
    /// Défini le type de données à sauvegarder (GestionElement ET GestionUtilisateurs)
    /// </summary>
    [DataContract]
    class DataToPersist
    {
        [DataMember]
        public GestionUtilisateur gestU { get; set; } = new GestionUtilisateur();

        [DataMember]
        public GestionElement gestE { get; set; } = new GestionElement();
    }
}
