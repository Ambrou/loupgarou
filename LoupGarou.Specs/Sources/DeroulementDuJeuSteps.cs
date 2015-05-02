using JeuDuLoupGarou;
using JeuDuLoupGarou.Roles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs
{
    [Binding]
    public class DeroulementDuJeuSteps
    {
        [Given(@"le prochain mort Ambroise")]
        public void SoitLeProchainMortAmbroise()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"le jour se léve")]
        public void QuandLeJourSeLeve()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"le maître du jeu annonce la mort d'Ambroise")]
        public void AlorsLeMaitreDuJeuAnnonceLaMortDAmbroise()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
