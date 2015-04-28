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
            wereWolfGame.voteContre("Blondin", "Ambroise");
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
            wereWolfGame.voteContre("Blondin", "Ambroise");
            wereWolfGame.voteContre("Johanna", "Maria");
        }

        [When(@"Blondin mange Ambroise et Johanna mange Maria et Blondina mange Ambroise")]
        public void QuandBlondinMangeAmbroiseEtJohannaMangeMariaEtBlondinaMangeAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.voteContre("Blondin", "Ambroise");
            wereWolfGame.voteContre("Johanna", "Maria");
            wereWolfGame.voteContre("Blondina", "Ambroise");
        }

        [When(@"le tour des loups commence")]
        [Given(@"le tour des loups commence")]
        public void QuandLeTourDesLoupsCommence()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.activerLesLoups();
        }

        [Then(@"les joueurs qui peuvent voter sont")]
        public void AlorsLesJoueursQuiPeuventVoterSont(Table table)
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(wereWolfGame.villageoisAyantVote.ContainsKey(row["joueur"]));
            }
        }

        [Then(@"les joueurs qui ne peuvent pas voter sont")]
        public void AlorsLesJoueursQuiNePeuventPasVoterSont(Table table)
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            foreach (var row in table.Rows)
            {
                Assert.IsFalse(wereWolfGame.villageoisAyantVote.ContainsKey(row["joueur"]));
            }
        }


    }
}
