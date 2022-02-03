using Modele;
using System;

namespace Test_DataContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager LeManager = new Manager(new Stub.Stub());
            LeManager.ChargeDonnees();
            LeManager.Persistance = new DataContractPersistance.DataContractPers();
            LeManager.SauvegardeDonnees();
        }
    }
}
