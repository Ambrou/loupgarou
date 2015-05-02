using System;
using TechTalk.SpecFlow;
using JeuDuLoupGarou;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDuChasseurSteps
    {
        [Given(@"Ambroise est le chasseur")]
        public void SoitAmbroiseEstLeChasseur()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.attribueLeRoleDeChasseurA("Ambroise");
        }

        [When(@"Ambroise choisit de tirer sur Maria")]
        public void QuandAmbroiseChoisitDeTirerSurMaria()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.voteContre("Ambroise", "Maria");
        }

        [Given(@"il vient d'être tué")]
        public void SoitIlVientDEtreTue()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.commencerLaChasse();
        }

    }
}
