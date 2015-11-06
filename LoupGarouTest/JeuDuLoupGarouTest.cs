using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoupGarou.Core;
using Moq;

namespace LoupGarou.Test
{


    [TestClass]
    public class JeuDuLoupGarouTest
    {

        internal class MonJoueur : Habitant
        {
            public string description;

            public MonJoueur(string nomJoueur) : base(nomJoueur)
            {
            }

            public override void afficheInformation(string v)
            {
                description = v;
            }
        }

        public JeuDuLoupGarouTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [DeploymentItem("\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml",
            "Row", DataAccessMethod.Sequential)]
        public void donneInformationRole()
        {
            // Arrange
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            MonJoueur joueur = new MonJoueur("lambda");

            // Act
            jeuDuLoupGarou.donneInformationRole(TestContext.DataRow["Role"].ToString(), joueur);

            // Assert
            Assert.AreEqual(TestContext.DataRow["Description"].ToString(), joueur.description);
        }


        internal class MonJeuDuLoupGarou : JeuDuLoupGarou
        {
            internal new void attribuerRole()
            {
                base.attribuerRole();
            }
            internal new void choisirCibleParLeRole()
            {
                base.choisirCibleParLeRole();
            }

            internal new void remiseAZeroDesCompteurDeVote()
            {
                base.remiseAZeroDesCompteurDeVote();
            }

            internal new string quiEstElu()
            {
                return base.quiEstElu();
            }

            internal new void passerAuRoleSuivant()
            {
                base.passerAuRoleSuivant();
            }
        }

        [TestMethod]
        [DeploymentItem("\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml",
            "DistributionRole", DataAccessMethod.Sequential)]
        public void commencerUnePartieSimplifieAvec8Joueurs()
        {

            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            for (int i = 0; i < int.Parse(TestContext.DataRow["NombreHabitant"].ToString()); i++)
            {
                jeuDuLoupGarou.listeDesHabitants.Add(new MonJoueur(i.ToString()));
            }
            // Act
            jeuDuLoupGarou.attribuerRole();

            // Assert
            int nombreDeVoyante = 0;
            int nombreDeVillageois = 0;
            int nombreDeLoup = 0;
            foreach (var habitant in jeuDuLoupGarou.listeDesHabitants)
            {
                if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleVoyante)
                {
                    nombreDeVoyante++;
                }
                else if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleVillageois)
                {
                    nombreDeVillageois++;
                }
                else if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleLoupGarou)
                {
                    nombreDeLoup++;
                }
            }
            Assert.AreEqual(int.Parse(TestContext.DataRow["NombreVoyante"].ToString()), nombreDeVoyante);
            Assert.AreEqual(int.Parse(TestContext.DataRow["NombreVillageois"].ToString()), nombreDeVillageois);
            Assert.AreEqual(int.Parse(TestContext.DataRow["NombreLoupGarou"].ToString()), nombreDeLoup);

            //// Arrange
            //JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            //var mock = new Mock<MaitreDuJeu>();
            //jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);
            //jeuDuLoupGarou.estUnePartieSimplifie();
            //jeuDuLoupGarou.creerUnVillageAvecHabitants(8);
            //for (int i = 0; i < int.Parse(TestContext.DataRow["NombreHabitant"].ToString()); i++)
            //{
            //    jeuDuLoupGarou.AjouterHabitant(new MonJoueur(i.ToString()));
            //}
            //int nombreDeVoyante = 0;
            //int nombreDeVillageois = 0;
            //int nombreDeLoup = 0;

            //// Act
            //jeuDuLoupGarou.jouerPartie();

            //// Assert
            //foreach (var habitant in jeuDuLoupGarou.listeDesHabitants)
            //{
            //    if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleVoyante)
            //    {
            //        nombreDeVoyante++;
            //    }
            //    else if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleVillageois)
            //    {
            //        nombreDeVillageois++;
            //    }
            //    else if (habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleLoupGarou)
            //    {
            //        nombreDeLoup++;
            //    }
            //}
            //Assert.AreEqual(int.Parse(TestContext.DataRow["NombreVoyante"].ToString()), nombreDeVoyante);
            //Assert.AreEqual(int.Parse(TestContext.DataRow["NombreVillageois"].ToString()), nombreDeVillageois);
            //Assert.AreEqual(int.Parse(TestContext.DataRow["NombreLoupGarou"].ToString()), nombreDeLoup);
        }

        class MyHabitant : Habitant
        {
            public MyHabitant(string nomHabitant) : base(nomHabitant)
            {
            }

            public override void afficheInformation(string v)
            {

            }
        }

        [TestMethod]
        public void unHabitantEstLaCibleDeDeuxLoups()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estUnePartieSimplifie();
            var Hloup1 = new Mock<Habitant>("loup1");
            var Hloup2 = new Mock<Habitant>("loup2");
            Habitant HVillageois1 = new MyHabitant("habitant1");
            Habitant HVillageois2 = new MyHabitant("habitant2");
            Hloup1.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.estAuTourDe = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup1.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup2.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois1);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois2);
            Hloup1.Setup(h => h.cibleChoisie()).Returns("habitant2");
            Hloup2.Setup(h => h.cibleChoisie()).Returns("habitant2");
            jeuDuLoupGarou.remiseAZeroDesCompteurDeVote();
            // Act
            jeuDuLoupGarou.choisirCibleParLeRole();

            // Assert
            Assert.AreEqual("habitant2", jeuDuLoupGarou.quiEstElu());

        }

        [TestMethod]
        public void unHabitantEstLaCibleDeDeuxLoupsEtUnAutreDUnTroisiemeLoup()
        {

            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estUnePartieSimplifie();
            var Hloup1 = new Mock<Habitant>("loup1");
            var Hloup2 = new Mock<Habitant>("loup2");
            var Hloup3 = new Mock<Habitant>("loup3");
            Habitant HVillageois1 = new MyHabitant("habitant1");
            Habitant HVillageois2 = new MyHabitant("habitant2");
            Hloup1.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup3.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.estAuTourDe = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup1.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup2.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois1);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois2);
            Hloup1.Setup(h => h.cibleChoisie()).Returns("habitant2");
            Hloup2.Setup(h => h.cibleChoisie()).Returns("habitant2");
            Hloup3.Setup(h => h.cibleChoisie()).Returns("habitant1");
            jeuDuLoupGarou.remiseAZeroDesCompteurDeVote();
            // Act
            jeuDuLoupGarou.choisirCibleParLeRole();

            // Assert
            Assert.AreEqual("habitant2", jeuDuLoupGarou.quiEstElu());
        }

        [TestMethod]
        public void chaqueHabitantEstLaCibleDUnLoup()
        {

            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estUnePartieSimplifie();
            var Hloup1 = new Mock<Habitant>("loup1");
            var Hloup2 = new Mock<Habitant>("loup2");
            Habitant HVillageois1 = new MyHabitant("habitant1");
            Habitant HVillageois2 = new MyHabitant("habitant2");
            Hloup1.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Object.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.estAuTourDe = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup1.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(Hloup2.Object);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois1);
            jeuDuLoupGarou.listeDesHabitants.Add(HVillageois2);
            Hloup1.Setup(h => h.cibleChoisie()).Returns("habitant1");
            Hloup2.Setup(h => h.cibleChoisie()).Returns("habitant2");
            jeuDuLoupGarou.remiseAZeroDesCompteurDeVote();
            // Act
            jeuDuLoupGarou.choisirCibleParLeRole();

            // Assert
            Assert.AreEqual("", jeuDuLoupGarou.quiEstElu());

        }

        [TestMethod]
        public void roleSuivantSansRolePrecedent()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();

            // Act
            jeuDuLoupGarou.passerAuRoleSuivant();
            
            // Assert
            Assert.AreEqual("voyante", jeuDuLoupGarou.estAuTourDe);

        }

        [TestMethod]
        public void roleSuivantAvecRolePrecedentVoyante()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estAuTourDe = "voyante";

            // Act
            jeuDuLoupGarou.passerAuRoleSuivant();
            
            // Assert
            Assert.AreEqual("loup-garou", jeuDuLoupGarou.estAuTourDe);

        }

        [TestMethod]
        public void roleSuivantAvecRolePrecedentLoupGarou()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estAuTourDe = "loup-garou";

            // Act
            jeuDuLoupGarou.passerAuRoleSuivant();

            // Assert
            Assert.AreEqual("villageois", jeuDuLoupGarou.estAuTourDe);

        }

        [TestMethod]
        public void roleSuivantAvecRolePrecedentVillageois()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estAuTourDe = "villageois";
            Habitant h = new Habitant("un");
            h.Role = "voyante";
            jeuDuLoupGarou.listeDesHabitants.Add(h);

            // Act
            jeuDuLoupGarou.passerAuRoleSuivant();

            // Assert
            Assert.AreEqual("voyante", jeuDuLoupGarou.estAuTourDe);

        }

        [TestMethod]
        public void roleSuivantAvecRolePrecedentVillageoisMaisSansVoyante()
        {
            // Arrange
            MonJeuDuLoupGarou jeuDuLoupGarou = new MonJeuDuLoupGarou();
            jeuDuLoupGarou.estAuTourDe = "villageois";

            // Act
            jeuDuLoupGarou.passerAuRoleSuivant();

            // Assert
            Assert.AreEqual("loup-garou", jeuDuLoupGarou.estAuTourDe);
        }
        
    }
}