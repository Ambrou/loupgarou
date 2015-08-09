using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs
{
    [Binding]
    public class IntroductionSteps
    {
        [Given(@"une partie en cours de création")]
        public void SoitUnePartieEnCoursDeCreation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"tous les joueurs sont présents")]
        public void QuandTousLesJoueursSontPresents()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"le maitre du jeu commence la présentation du village aux villageois et de son histoire")]
        public void AlorsLeMaitreDuJeuCommenceLaPresentationDuVillageAuxVillageoisEtDeSonHistoire()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
