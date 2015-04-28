using JeuDuLoupGarou;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDuVillageoisSteps
    {

        [When(@"Maria vote contre Ambroise et Ambroise vote contre Ambroise")]
        public void QuandMariaVoteContreAmbroiseEtAmbroiseVoteContreAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.voteContre("Maria", "Ambroise");
            wereWolfGame.voteContre("Ambroise", "Ambroise");

        }

        [When(@"Maria vote contre Ambroise et Ambroise vote contre Maria")]
        public void QuandMariaVoteContreAmbroiseEtAmbroiseVoteContreMaria()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.voteContre("Maria", "Ambroise");
            wereWolfGame.voteContre("Ambroise", "Maria");
        }

        [When(@"Maria vote contre Ambroise")]
        public void QuandMariaVoteContreAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.voteContre("Maria", "Ambroise");
        }

        [When(@"le tour des villageois commence")]
        [Given(@"le tour des villageois commence")]
        public void QuandLeTourDesVillageoisCommence()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.commencerLeDebat();
        }
    }
}
