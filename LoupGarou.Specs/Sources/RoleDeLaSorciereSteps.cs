using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using JeuDuLoupGarou;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDeLaSorciereSteps
    {

        [Given(@"(.*) est la sorcière")]
        public void SoitJohannaEstLaSorciere(string strNomDuJoueur)
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.attribueLeRoleDeSorciereA(strNomDuJoueur);
        }

        [When(@"les loups ont choisit Ambroise")]
        public void QuandLesLoupsOntChoisitAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            ScenarioContext.Current.Pending();
        }

        [Then(@"elle découvre que la victime est Ambroise")]
        public void AlorsElleDecouvreQueLaVictimeEstAmbroise()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            ScenarioContext.Current.Pending();
        }



        //WereWolfGame wereWolfGame = new WereWolfGame();
        //String strPlayerName;
        //Role witch = new Sorciere();

        //[Given(@"la joueuse Johanna")]
        //public void SoitLaJoueuseJohanna()
        //{
        //    strPlayerName = "Johanna";
        //}

        //[When(@"le personnage de la sorcière est attribué à Johanna")]
        //public void QuandLePersonnageDeLaSorciereEstAttribueAJohanna()
        //{
        //    wereWolfGame.addPlayerWithRole(strPlayerName, "Sorcière");
        //}

        ////[Then(@"Johanna est une villageoise")]
        ////public void AlorsJohannaEstUneVillageoise()
        ////{
        ////    Assert.AreEqual("Sorcière", wereWolfGame.m_CharacterList[strPlayerName]);
        ////}

        ////[Then(@"Johanna est la sorcière")]
        ////public void AlorsJohannaEstLaSorciere()
        ////{
        ////    Assert.AreEqual("Sorcière", wereWolfGame.m_CharacterList[strPlayerName]);
        ////}

        //[Given(@"([A-Z][a-z]+) jouant le personnage de (.*)")]
        //public void SoitJohannaJouantLaSorciere(string strName, string Role)
        //{
        //    wereWolfGame.addPlayerWithRole(strName, Role);
        //}

    }
}
