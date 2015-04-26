using JeuDuLoupGarou;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDuVillageoisSteps
    {

        [When(@"Maria vote contre Ambroise")]
        public void QuandMariaVoteContreAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.villageois["Maria"].voteContre("Ambroise");
        }

        [When(@"Maria vote contre Ambroise et Ambroise vote contre Maria")]
        public void QuandMariaVoteContreAmbroiseEtAmbroiseVoteContreMaria()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.villageois["Maria"].voteContre("Ambroise");
            wereWolfGame.villageois["Ambroise"].voteContre("Maria");
        }
    }
}
