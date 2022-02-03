using System;
using Xunit;
using Modele;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_IsAmdin()
        {
            Manager ManagerTest = new Manager(new Stub.Stub());
            Utilisateur nouvelUti = new Utilisateur("pseudo", "mdp");
            ManagerTest.GU.AjouterUtilisateur(nouvelUti);

            Assert.False(ManagerTest.GU.IsAdmin(nouvelUti));
        }

        [Fact]
        public void Test_AjoutSuppressionUtilisateur()
        {
            Manager ManagerTest = new Manager(new Stub.Stub());
            Utilisateur nouvelUti = new Utilisateur("pseudo", "mdp");
            ManagerTest.GU.AjouterUtilisateur(nouvelUti);
            ManagerTest.GU.SupprimerUtilisateur(nouvelUti);

            Assert.Equal(-1, ManagerTest.GU.TrouverPosUtilisateur("pseudo", "mdp"));
        }

        [Fact]
        public void Test_PromotionUtilisateur()
        {
            Manager ManagerTest = new Manager(new Stub.Stub());
            Utilisateur nouvelUti = new Utilisateur("pseudo", "mdp");
            ManagerTest.GU.AjouterUtilisateur(nouvelUti);
            ManagerTest.GU.ChangeAdmin(nouvelUti);

            Assert.True(ManagerTest.GU.IsAdmin(nouvelUti));
        }

        [Fact]
        public void Test_RechercheUtilisateur()
        {
            Manager ManagerTest = new Manager(new Stub.Stub());
            Utilisateur nouvelUti = new Utilisateur("pseudo", "mdp");
            ManagerTest.GU.AjouterUtilisateur(nouvelUti);

            Assert.Equal(nouvelUti, ManagerTest.GU.TrouverUtilisateur("pseudo"));
        }
    }
}
