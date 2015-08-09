using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoupGarou.Core;
using Moq;

namespace LoupGarou.Test
{


    [TestClass]
    public class JeuDuLoupGarouTest
    {

        internal class MonJoueur : Joueur
        {
            public string description;

            public override void afficheInformationRole(string v)
            {
                description = v;
            }
        }

        internal class MonMaitreDuJeu : MaitreDuJeu
        {
            public string description;

            public void conter(string texte)
            {
                description = texte;
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
            MonMaitreDuJeu maitreDuJeu = new MonMaitreDuJeu();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(maitreDuJeu);

            // Act
            jeuDuLoupGarou.commencerPartie();

            // Assert
            Assert.AreEqual("Au trés fond d'un forêt, à flan de montagne, un petit village est depuis peu devenu la proie de Loups Garous. Des meurtres ignobles sont commis chaque nuit par certains habitants du village, devenus Lycanthropes à cause d'un phénomène mystérieux... Les villageois doivent se ressaisir pour éradiquer ce nouveau fléau venu du fons des âges, avant que le village ne perde ses derniers habitants.", maitreDuJeu.description);
        }
    }
}
