using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Modele
{
    /*
     * énumère les différents thèmes de couleur disponible pour l'application
     */
    [DataContract]
    public enum ThemeApp
    {
        [EnumMember]
        Clair,
        [EnumMember]
        Sombre
    }
}
