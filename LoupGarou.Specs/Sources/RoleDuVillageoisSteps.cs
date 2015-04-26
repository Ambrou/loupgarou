using JeuDuLoupGarou;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDuVillageoisSteps
    {
        WereWolfGame wereWolfGame = new WereWolfGame();

        [Given(@"Maria est un villageois")]
        public void SoitMariaEstUnVillageois()
        {
            wereWolfGame.attribueLeRoleDeVillageoisA("Maria");
        }

        [When(@"Maria vote contre Ambroise")]
        public void QuandMariaVoteContreAmbroise()
        {
            wereWolfGame.villageois.voteContre("Ambroise");
        }

        [Then(@"Ambroise est le prochain brulé")]
        public void AlorsAmbroiseEstLeProchainBrule()
        {
            Assert.AreEqual("Ambroise", wereWolfGame.NomDuProchainMort);
        }

    }
}
