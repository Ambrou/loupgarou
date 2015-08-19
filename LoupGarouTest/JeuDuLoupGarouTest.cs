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

            public MonJoueur() : base ("JoueurLambda")
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
            MonJoueur joueur = new MonJoueur();

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
                Habitant habitant = new MonJoueur();
                habitant.emmenage(jeuDuLoupGarou);
            }
            int nombreDeVoyante = 0;
            int nombreDeVillageois = 0;
            int nombreDeLoup = 0;

            // Act
            jeuDuLoupGarou.commencerPartie();

            // Assert
            foreach (var habitant in jeuDuLoupGarou.listeDesHabitants)
            {
                if(habitant.Role == LoupGarou.Core.Properties.Resources.NomRoleVoyante)
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
        
    }
}
