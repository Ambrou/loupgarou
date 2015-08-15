using LoupGarou.Core;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class PeuplerLeVillageSteps
    {
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
                Joueur joueur = new Joueur(iLoop.ToString());
                joueur.emmenage(jeuDuLoupGarou);
            }
        }
        
        [When(@"le (.*)em habitant arrive")]
        public void QuandLeEmHabitantArrive(int p0)
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Joueur joueur = new Joueur(p0.ToString());
            joueur.emmenage(jeuDuLoupGarou);
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
    }
}
