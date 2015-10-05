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

            public MonJoueur(JeuDuLoupGarou jeuDuLoupGarou) : base ("JoueurLambda", jeuDuLoupGarou)
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
            MonJoueur joueur = new MonJoueur(jeuDuLoupGarou);

            // Act
            jeuDuLoupGarou.donneInformationRole(TestContext.DataRow["Role"].ToString(), joueur);

            // Assert
            Assert.AreEqual(TestContext.DataRow["Description"].ToString(), joueur.description);
        }

        [TestMethod]
        public void commencerLaPartie()
        {
            // Arrange
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            var mock = new Mock<MaitreDuJeu>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);

            // Act
            jeuDuLoupGarou.commencerPartie();

            // Assert
            mock.Verify(mj => mj.conter("Au trés fond d'un forêt, à flan de montagne, un petit village est depuis peu devenu la proie de Loups Garous. Des meurtres ignobles sont commis chaque nuit par certains habitants du village, devenus Lycanthropes à cause d'un phénomène mystérieux... Les villageois doivent se ressaisir pour éradiquer ce nouveau fléau venu du fons des âges, avant que le village ne perde ses derniers habitants."));
        }


        [TestMethod]
        [DeploymentItem("\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data\\JeuDuLoupGarou.Test.DonneInformationRole.Data.xml",
            "DistributionRole", DataAccessMethod.Sequential)]
        public void commencerUnePartieSimplifieAvec8Joueurs()
        {
            // Arrange
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            var mock = new Mock<MaitreDuJeu>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);
            jeuDuLoupGarou.estUnePartieSimplifie();
            jeuDuLoupGarou.creerUnVillageAvecHabitants(8);
            for (int i = 0; i < int.Parse(TestContext.DataRow["NombreHabitant"].ToString()); i++)
            {
                Habitant habitant = new MonJoueur(jeuDuLoupGarou);
                habitant.emmenage();
            }
            int nombreDeVoyante = 0;
            int nombreDeVillageois = 0;
            int nombreDeLoup = 0;

            // Act
            jeuDuLoupGarou.commencerPartie();

            // Assert
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
        }

        class MyHabitant : Habitant
        {
            public MyHabitant(string nomHabitant, JeuDuLoupGarou jeuDuLoupGarou) : base(nomHabitant, jeuDuLoupGarou)
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
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            var mock = new Mock<MaitreDuJeu>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);
            jeuDuLoupGarou.estUnePartieSimplifie();
            Habitant Hloup1 = new MyHabitant("loup1", jeuDuLoupGarou);
            Habitant Hloup2 = new MyHabitant("loup2", jeuDuLoupGarou);
            Habitant HVillageois1 = new MyHabitant("habitant1", jeuDuLoupGarou);
            Habitant HVillageois2 = new MyHabitant("habitant2", jeuDuLoupGarou);
            Hloup1.emmenage();
            HVillageois1.emmenage();
            HVillageois2.emmenage();
            Hloup2.emmenage();
            Hloup1.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.auTourDe(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);

            // Act
            Hloup1.cibleLeJoueur("habitant2");
            Hloup2.cibleLeJoueur("habitant2");

            // Assert
            Assert.AreEqual(3, jeuDuLoupGarou.listeDesHabitants.Count);
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup1));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup2));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois1));
            Assert.AreEqual(false, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois2));

        }

        [TestMethod]
        public void unHabitantEstLaCibleDeDeuxLoupsEtUnAutreDUnTroisiemeLoup()
        {

            // Arrange
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            var mock = new Mock<MaitreDuJeu>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);
            jeuDuLoupGarou.estUnePartieSimplifie();
            Habitant Hloup1 = new MyHabitant("loup1", jeuDuLoupGarou);
            Habitant Hloup2 = new MyHabitant("loup2", jeuDuLoupGarou);
            Habitant Hloup3 = new MyHabitant("loup3", jeuDuLoupGarou);
            Habitant HVillageois1 = new MyHabitant("habitant1", jeuDuLoupGarou);
            Habitant HVillageois2 = new MyHabitant("habitant2", jeuDuLoupGarou);
            Hloup1.emmenage();
            HVillageois1.emmenage();
            HVillageois2.emmenage();
            Hloup2.emmenage();
            Hloup3.emmenage();
            Hloup1.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup3.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.auTourDe(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);

            // Act
            Hloup1.cibleLeJoueur("habitant2");
            Hloup2.cibleLeJoueur("habitant1");
            Hloup3.cibleLeJoueur("habitant2");

            // Assert
            Assert.AreEqual(4, jeuDuLoupGarou.listeDesHabitants.Count);
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup1));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup2));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup3));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois1));
            Assert.AreEqual(false, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois2));

        }
        
        [TestMethod]
        public void chaqueHabitantEstLaCibleDUnLoup()
        {

            // Arrange
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            var mock = new Mock<MaitreDuJeu>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(mock.Object);
            jeuDuLoupGarou.estUnePartieSimplifie();
            Habitant Hloup1 = new MyHabitant("loup1", jeuDuLoupGarou);
            Habitant Hloup2 = new MyHabitant("loup2", jeuDuLoupGarou);
            Habitant HVillageois1 = new MyHabitant("habitant1", jeuDuLoupGarou);
            Habitant HVillageois2 = new MyHabitant("habitant2", jeuDuLoupGarou);
            Hloup1.emmenage();
            HVillageois1.emmenage();
            HVillageois2.emmenage();
            Hloup2.emmenage();
            Hloup1.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            Hloup2.Role = LoupGarou.Core.Properties.Resources.NomRoleLoupGarou;
            HVillageois1.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            HVillageois2.Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            jeuDuLoupGarou.auTourDe(LoupGarou.Core.Properties.Resources.NomRoleLoupGarou);

            // Act
            Hloup1.cibleLeJoueur("habitant2");
            Hloup2.cibleLeJoueur("habitant1");

            // Assert
            Assert.AreEqual(4, jeuDuLoupGarou.listeDesHabitants.Count);
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup1));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(Hloup2));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois1));
            Assert.AreEqual(true, jeuDuLoupGarou.listeDesHabitants.Contains(HVillageois2));

        }
    }
}
