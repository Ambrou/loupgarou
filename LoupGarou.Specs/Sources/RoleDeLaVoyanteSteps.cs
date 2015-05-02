using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuDuLoupGarou;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class RoleDeLaVoyanteSteps
    {
        string roleDecouvert;

        [Given(@"le jeu du loup garou")]
        public void SoitLeJeuDuLoupGarou()
        {
            ScenarioContext.Current.Set<WereWolfGame>(new WereWolfGame());
        }


        [Given(@"la voyante joue")]
        public void SoitLaVoyanteJoue()
        {
            
        }

        [Given(@"Maria est la voyante")]
        public void SoitMariaEstLaVoyante()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            wereWolfGame.attribueLeRoleDeVoyanteA("Maria");
        }

        [When(@"la voyante utilise son pouvoir sur Johanna")]
        public void QuandLaVoyanteUtiliseSonPouvoirSurJohanna()
        {
            var wereWolfGame = ScenarioContext.Current.Get<WereWolfGame>();
            roleDecouvert = wereWolfGame.devoileLeRoleDe("Johanna");
        }

        [Then(@"Maria découvre que Johanna est la sorcière")]
        public void AlorsMariaDecouvreQueJohannaEstLaSorciere()
        {
            Assert.AreEqual("Sorcière", roleDecouvert);
        }

        
    }
}
