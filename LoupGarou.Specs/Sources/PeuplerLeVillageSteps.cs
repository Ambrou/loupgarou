using LoupGarou.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class PeuplerLeVillageSteps
    {
        Habitant habitant;
        Mock<Habitant> habitantAmbroise;


        [Given(@"(.*) habitants sont attendus")]
        public void SoitHabitantsSontAttendus(int p0)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.creerUnVillageAvecHabitants(p0);
        }
        
        [Given(@"Il y a déjà (.*) habitants dans le village")]
        public void SoitIlYADejaHabitantsDansLeVillage(int p0)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            for (int iLoop = 0; iLoop < p0; ++iLoop)
            {
                habitant = new Habitant(iLoop.ToString());
                habitant.emmenage(jeuDuLoupGarou);
            }
        }
        
        [When(@"le (.*)em habitant arrive")]
        public void QuandLeEmHabitantArrive(int p0)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            habitant = new Habitant(p0.ToString());
            habitant.emmenage(jeuDuLoupGarou);
        }

        [Then(@"le maitre du jeu indique que tous les habitants sont présents")]
        public void AlorsLeMaitreDuJeuIndiqueQueTousLesHabitantsSontPresents()
        {
            var mock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            mock.Verify(mj => mj.conter("Le village est complet nous allons pouvoir commencer"));
        }

        [Then(@"le jeu peut commencer")]
        public void AlorsLeJeuPeutCommencer()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual(true, jeuDuLoupGarou.peutCommencer);
        }


        [Then(@"le maitre du jeu pose le decor")]
        public void AlorsLeMaitreDuJeuPoseLeDecor()
        {
            var mock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            mock.Verify(mj => mj.conter(It.IsAny<string>()));
        }

        [Given(@"le migrant (.*)")]
        public void SoitLeMigrantAmbroise(string p0)
        {
            habitantAmbroise = new Mock<Habitant>(p0);
        }

        [When(@"il emmenage dans le village")]
        public void QuandAmbroiseEmmenageDansLeVillage()
        {
            var jeu = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            habitantAmbroise.Object.emmenage(jeu);
        }

        [Then(@"(.*) est un habitant du village")]
        public void AlorsAmbroiseEstUnHabitantDuVillage(string p0)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual(true, jeuDuLoupGarou.contientLHabitant(p0));
        }

        [Then(@"le maitre du jeu salut (.*)")]
        public void AlorsLeMaitreDuJeuSalutAmbroise(string p0)
        {
            //var mock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            //mock.Verify(mj => mj.saluer(habitant, "Bienvenue dans notre village"));
            habitantAmbroise.Verify(habitant => habitant.afficheInformation(It.IsAny<string>()));
        }

        [Given(@"un village simplifiée")]
        public void SoitUnVillageSimplifiee()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.estUnePartieSimplifie();
        }

        [Given(@"il est peuplé de ses habitants")]
        public void SoitIlEstPeupleDeHabitants()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.creerUnVillageAvecHabitants(8);
            for (int iLoop = 0; iLoop < 8; ++iLoop)
            {
                Habitant habitant = new Habitant(iLoop.ToString());
                habitant.emmenage(jeuDuLoupGarou);
            }
        }

        [When(@"le village est crée")]
        public void QuandLeVillageEstCree()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.commencerPartie();
        }

        [Then(@"chaque habitant se retrouve avec un role")]
        public void AlorsChaqueHabitantSeRetrouveAvecUnRole()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();

            foreach(var habitant in jeuDuLoupGarou.listeDesHabitants)
            {
                Assert.AreNotEqual("", habitant.Role);
                Assert.IsNotNull(habitant.Role);
            }
        }



    }
}
