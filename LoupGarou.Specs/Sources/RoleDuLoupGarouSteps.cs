using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuDuLoupGarou;

namespace LoupGarou.Specs
{
    [Binding]
    public class RoleDuLoupGarouSteps
    {
       
        [Given(@"(.*) un loup")]
        public void SoitBlondinUnLoup(string strNomDujoueur)
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.attribueLeRoleDeLoupA(strNomDujoueur);
        }

        [Given(@"(.*) est un villageois")]
        public void SoitAmbroiseUnVillageois(string strNomDujoueur)
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.attribueLeRoleDeVillageoisA(strNomDujoueur);
        }

        [When(@"Blondin mange Ambroise")]
        public void QuandBlondinMangeAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.loupGarou["Blondin"].mange("Ambroise");
        }

        [Then(@"Ambroise est le prochain mort")]
        public void AlorsAmbroiseEstLeProchainMort()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            Assert.AreEqual("Ambroise", wereWolfGame.estLeProchainMort());
        }

        [Then(@"il n'y a pas de mort")]
        public void AlorsIlNYAPasDeMort()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            Assert.AreEqual("", wereWolfGame.estLeProchainMort());
        }

        [When(@"Blondin mange Ambroise et Johanna mange Maria")]
        public void QuandBlondinMangeAmbroiseEtJohannaMangeMaria()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.loupGarou["Blondin"].mange("Ambroise");
            wereWolfGame.loupGarou["Johanna"].mange("Maria");
        }

        [When(@"Blondin mange Ambroise et Johanna mange Maria et Blondina mange Ambroise")]
        public void QuandBlondinMangeAmbroiseEtJohannaMangeMariaEtBlondinaMangeAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.loupGarou["Blondin"].mange("Ambroise");
            wereWolfGame.loupGarou["Johanna"].mange("Maria");
            wereWolfGame.loupGarou["Blondina"].mange("Ambroise");
        }

    }
}
