using LoupGarou.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class TourDeJeuSteps
    {
        Mock<Habitant> habitant;
        List<Mock<Habitant>> listHabitant = new List<Mock<Habitant>>();

        [Given(@"les habitants suivants:")]
        public void SoitLesHabitantsSuivants(Table table)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            foreach (var row in table.Rows)
            {
                habitant = new Mock<Habitant>(row["habitant"]);
                habitant.Object.Role = row["role"];
                habitant.Object.emmenage(jeuDuLoupGarou);
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
            jeuDuLoupGarou.listeDesHabitants[3].cibleLeJoueur("huit");
            jeuDuLoupGarou.listeDesHabitants[5].cibleLeJoueur("huit");
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
            maitreDuJeuMock.Verify(mj => mj.conter("Et les habitants découvrent avec effroi le corps de huit, un villageois, sans vie."));
        }

        [Then(@"c'est le tour des villageois")]
        public void AlorsCEstLeTourDesVillageois()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual("villageois" ,jeuDuLoupGarou.estAuTourDe);

        }
    }
}
