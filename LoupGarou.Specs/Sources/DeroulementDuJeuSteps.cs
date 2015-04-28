using JeuDuLoupGarou;
using JeuDuLoupGarou.Roles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs
{
    [Binding]
    public class DeroulementDuJeuSteps
    {
        WereWolfGame wereWolfGame = new WereWolfGame();

        [Given(@"tous les personnages sont présents dans le jeu")]
        public void SoitTousLesPersonnagesSontPresentsDansLeJeu()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"la partie se lance")]
        public void QuandLaPartieSeLance()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"le premier tour de jeu se déroule dans cet ordre:")]
        public void AlorsLePremierTourDeJeuSeDerouleDansCetOrdre(Table table)
        {
            ScenarioContext.Current.Pending();
            //int uiLoop = 0;
            //foreach (var row in table.Rows)
            //{
            //    Assert.AreEqual(row["ordre"], wereWolfGame.m_RoleList[uiLoop++].name);
            //}
        }

        [When(@"le premier tour de jeu est fini")]
        public void QuandLePremierTourDeJeuEstFini()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"les autres tours de jeu se déroule dans cet ordre:")]
        public void AlorsLesAutresToursDeJeuSeDerouleDansCetOrdre(Table table)
        {
            //int uiLoop = 0;
            foreach (var row in table.Rows)
            {
                //Assert.AreEqual(row["ordre"], wereWolfGame.m_RoleList[uiLoop++]);
                ScenarioContext.Current.Pending();
            }
        }

        [Given(@"le tour de jeu est le suivant:")]
        public void SoitLeTourDeJeuEstLeSuivant(Table table)
        {
            foreach (var row in table.Rows)
            {
                //wereWolfGame.addPlayerWithRole(row["Personnage"], row["Personnage"]);
                ScenarioContext.Current.Pending();
            }
            
        }

        [When(@"la Voyante meurt")]
        public void QuandLaVoyanteMeurt()
        {
            //wereWolfGame.killRole("Voyante");
            ScenarioContext.Current.Pending();
        }
    }
}
