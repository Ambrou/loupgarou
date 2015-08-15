using LoupGarou.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class PeuplerLeVillageSteps
    {
        Habitant habitant;


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
        
        //[Then(@"le village est crée")]
        //public void AlorsLeVillageEstCree()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Then(@"le maitre du jeu pose le decor")]
        public void AlorsLeMaitreDuJeuPoseLeDecor()
        {
            var mock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            mock.Verify(mj => mj.conter(It.IsAny<string>()));
        }

        [Given(@"le migrant (.*)")]
        public void SoitLeMigrantAmbroise(string p0)
        {
            habitant = new Habitant(p0);
        }

        [When(@"il emmenage dans le village")]
        public void QuandAmbroiseEmmenageDansLeVillage()
        {
            habitant.emmenage(ScenarioContext.Current.Get<JeuDuLoupGarou>());
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
            var mock = ScenarioContext.Current.Get<Mock<MaitreDuJeu>>();
            mock.Verify(mj => mj.saluer(habitant, "Bienvenue dans notre village"));
        }


    }
}
