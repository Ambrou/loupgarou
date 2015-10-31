using LoupGarou.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class TourDeJeuSteps
    {
        Mock<Habitant> habitant;
        List<Mock<Habitant>> listHabitant = new List<Mock<Habitant>>();
        string JoueurMort;

        [Given(@"les habitants suivants:")]
        public void SoitLesHabitantsSuivants(Table table)
        {
            foreach (var row in table.Rows)
            {
                habitant = new Mock<Habitant>(row["habitant"]);
                habitant.Object.Role = row["role"];
                listHabitant.Add(habitant);
                //ScenarioContext.Current.Get<JeuDuLoupGarou>().listeDesHabitants.Add(habitant)
                var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
                jeuDuLoupGarou.AjouterHabitant(habitant.Object);
            }
        }

        [Given(@"il reste comme joueurs:")]
        public void SoitIlResteCommeJoueurs(Table table)
        {
            foreach (var row in table.Rows)
            {
                habitant = new Mock<Habitant>(row["habitant"]);
                habitant.Object.Role = row["role"];
                listHabitant.Add(habitant);
                var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
                jeuDuLoupGarou.AjouterHabitant(habitant.Object);
            }
        }


        [Given(@"le tour des loups garous")]
        public void SoitLeTourDesLoupsGarous()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.auTourDe("loup-garou");

        }

        [When(@"les loups garous ont choisit leur victime")]
        public void QuandLesLoupsGarousOntChoisitLeurVictime()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            //jeuDuLoupGarou.listeDesHabitants[3].cibleLeJoueur("huit");
            //jeuDuLoupGarou.listeDesHabitants[5].cibleLeJoueur("huit");
            JoueurMort = "huit";
        }

        [Then(@"le maitre du jeu rendort les loups garous")]
        public void AlorsLeMaitreDuJeuRendortLesLoupsGarous()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Les loups garous se rendorment."));
        }

        [Then(@"le maitre du jeu réveille le village")]
        public void AlorsLeMaitreDuJeuReveilleLeVillage()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Le village se réveille."));
        }

        [Then(@"il annonce le joueur mort ainsi que son rôle")]
        public void AlorsIlAnnonceLeJoueurMortAinsiQueSonRole()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Et les habitants découvrent avec effroi le corps de " + JoueurMort + ", un villageois, sans vie."));
        }

        [Then(@"c'est le tour des villageois")]
        public void AlorsCEstLeTourDesVillageois()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual("villageois", jeuDuLoupGarou.estAuTourDe);

        }

        [Given(@"le tour des villageois")]
        public void SoitLeTourDesVillageois()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.auTourDe("villageois");
        }

        [When(@"les villageois ont choisi à la majorité leur coupable")]
        public void QuandLesVillageoisOntChoisiALaMajoriteLeurCoupable()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            //jeuDuLoupGarou.listeDesHabitants[0].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[1].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[2].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[3].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[4].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[5].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[6].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[7].cibleLeJoueur("quatre");
            JoueurMort = "quatre";
        }

        [Then(@"le maitre du jeu annonce le joueur mort ainsi que son rôle")]
        public void AlorsLeMaitreDuJeuAnnonceLeJoueurMortAinsiQueSonRole()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Les villageois ont donc jugé " + JoueurMort + " coupable, un loup-garou."));
            
        }

        [Then(@"il rendort le village")]
        public void AlorsIlRendortLeVillage()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Le village se rendort."));
        }

        [Then(@"c'est le tour de la voyante")]
        public void AlorsCEstLeTourDeLaVoyante()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual("voyante", jeuDuLoupGarou.estAuTourDe);
        }

        [Then(@"le joueur mort ne fait plus parti des habitants")]
        public void AlorsLeJoueurMortNeFaitPlusPartiDesHabitants()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            try
            {
                // EXECUTE
                jeuDuLoupGarou.listeDesHabitants.Single(h => h.Nom == JoueurMort);
                Assert.Fail();
            }
            catch (InvalidOperationException )
            {
                // ASSERT EXCEPTION DETAILS
            }
        }

        [Given(@"le tour de la voyante")]
        public void SoitLeTourDeLaVoyante()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.auTourDe("voyante");
        }

        [When(@"la voyante utilise son pouvoir sur un habitant")]
        public void QuandLaVoyanteUtiliseSonPouvoirSurUnHabitant()
        {
            listHabitant[2].Setup(h => h.cibleChoisie()).Returns("quatre");
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.activerRole(jeuDuLoupGarou.estAuTourDe);
        }

        [Then(@"le maitre du jeu l'informe du rôle de l'habitant dans le village")]
        public void AlorsLeMaitreDuJeuLInformeDuroleDeLHabitantDansLeVillage()
        {
            listHabitant[2].Verify(h => h.afficheInformation("loup-garou"));
        }

        //[Then(@"il rendort la voyante")]
        //public void AlorsIlRendortLaVoyante()
        //{
        //    var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
        //    maitreDuJeuMock.Verify(mj => mj.conter("La voyante se rendort."));
        //}

        //[Then(@"c'est le tour des loups garous")]
        //public void AlorsCEstLeTourDesLoupsGarous()
        //{
        //    var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
        //    Assert.AreEqual("loup-garou", jeuDuLoupGarou.estAuTourDe);
        //}

        [When(@"les villageois ont choisi à la majorité leur coupable le dernier loup")]
        public void QuandLesVillageoisOntChoisiALaMajoriteLeurCoupableLeDernierLoup()
        {
            JoueurMort = "quatre";
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.listeDesHabitants[5].Role = LoupGarou.Core.Properties.Resources.NomRoleVillageois;
            //jeuDuLoupGarou.listeDesHabitants[0].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[1].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[2].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[3].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[4].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[5].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[6].cibleLeJoueur("quatre");
            //jeuDuLoupGarou.listeDesHabitants[7].cibleLeJoueur("quatre");
        }

        [Then(@"les villageois ont gagné")]
        public void AlorsLesVillageoisOntGagne()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Les villageois ont gagné. Bravo !"));
        }

        [When(@"les loups garous ont choisit le dernier villageois")]
        public void QuandLesLoupsGarousOntChoisitLeDernierVillageois()
        {
            JoueurMort = "cinq";
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            //jeuDuLoupGarou.listeDesHabitants[0].cibleLeJoueur("cinq");
            //jeuDuLoupGarou.listeDesHabitants[2].cibleLeJoueur("cinq");
            
        }

        [Then(@"les loup garous ont gagné")]
        public void AlorsLesLoupGarousOntGagne()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter("Les loups garous ont gagné. Bravo !"));
        }

        [Given(@"une partie en cours")]
        public void SoitUnePartieEnCours()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.PartieEnCours = true;
        }

        [When(@"un rôle devient actif")]
        public void QuandUnRoleDevientActif()
        {
            habitant = new Mock<Habitant>("Voyante");
            habitant.Object.Role = "voyante";
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.AjouterHabitant(habitant.Object);
            jeuDuLoupGarou.activerRole("voyante");
        }

        [Then(@"je reveille les joueurs correspondant au rôle")]
        public void AlorsJeReveilleLesJoueursCorrespondantAuRole()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter(It.IsAny<string>()));
        }

        [Then(@"j'attends que les joueurs aient ciblé un autre joueur")]
        public void AlorsJAttendsQueLesJoueursAientCibleUnAutreJoueur()
        {
            habitant.Verify(h => h.cibleChoisie(), Times.AtMostOnce());
        }

        [When(@"tous les joueurs du rôle en cours ont désigné un autre joueur")]
        public void QuandTousLesJoueursDuRoleEnCoursOntDesigneUnAutreJoueur()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.activerRole("voyante");
        }

        [Then(@"je rendors les joueurs correspondant au rôle")]
        public void AlorsJeRendorsLesJoueursCorrespondantAuRole()
        {
            var maitreDuJeuMock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            maitreDuJeuMock.Verify(mj => mj.conter(It.IsAny<string>()));
        }

        [Then(@"j'active le rôle suivant")]
        public void AlorsJActiveLeRoleSuivant()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreNotEqual("voyante", jeuDuLoupGarou.estAuTourDe);
        }

        [Then(@"le jeu est fini")]
        public void AlorsLeJeuEstFini()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual(false, jeuDuLoupGarou.PartieEnCours);
        }

    }
}
