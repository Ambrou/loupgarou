using LoupGarou.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class ConnexionDesJoueursSteps
    {
        Joueur joueur;

       
        [When(@"je me connecte avec mon nom qui est Ambroise")]
        public void QuandJeMeConnecteAvecMonNomQuiEstAmbroise()
        {
            joueur = new Joueur("Ambroise");
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            joueur.seConnecte(jeuDuLoupGarou);
        }

        [Then(@"Ambroise fait partie de joueurs")]
        public void AlorsAmbroiseFaitPartieDeJoueurs()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            Assert.AreEqual(true, jeuDuLoupGarou.contientLejoueur("Ambroise"));
        }

    }
}
