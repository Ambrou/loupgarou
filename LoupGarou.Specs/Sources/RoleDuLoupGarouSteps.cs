using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuDuLoupGarou;

namespace LoupGarou.Specs
{
    [Binding]
    public class RoleDuLoupGarouSteps
    {
        WereWolfGame wereWolfGame = new WereWolfGame();

        [Given(@"Blondin un loup")]
        public void SoitBlondinUnLoup()
        {
            wereWolfGame.attribueLeRoleDeLoupA("Blondin");
        }

        [Given(@"Ambroise un villageois")]
        public void SoitAmbroiseUnVillageois()
        {
            wereWolfGame.attribueLeRoleDeVillageoisA("Ambroise");
        }

        [When(@"le loup mange Ambroise")]
        public void QuandLeLoupMangeAmbroise()
        {
            wereWolfGame.loupGarou.mange("Ambroise");
        }

        [Then(@"Ambroise est le prochain mort")]
        public void AlorsAmbroiseEstLeProchainMort()
        {
            Assert.AreEqual("Ambroise", wereWolfGame.NomDuProchainMort);
        }
    }
}
