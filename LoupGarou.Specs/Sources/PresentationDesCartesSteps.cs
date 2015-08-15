using System;
using LoupGarou.Core;
using Moq;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class PresentationDesCartesSteps
    {
        internal class JoueurNovice : Joueur
        {
            public string descriptionRole;

            public JoueurNovice() : base("Novice")
            {
            }

            public override void afficheInformationRole(string v)
            {
                descriptionRole = v;
            }
        }

        JoueurNovice joueurNovice;

        [Given(@"le jeu du loup garou")]
        public void SoitLeJeuDuLoupGarou()
        {
            ScenarioContext.Current.Set<JeuDuLoupGarou>(new JeuDuLoupGarou());
        }

        [Given(@"moi un joueur novice")]
        public void SoitMoiUnJoueurNovice()
        {
            joueurNovice = new JoueurNovice();
            joueurNovice.emmenage(ScenarioContext.Current.Get<JeuDuLoupGarou>());
        }

        [When(@"je demande les informations d'un rôle")]
        public void QuandJeDemandeLesInformationsDUnRole()
        {
            joueurNovice.demandeInformationRole("voyante");
        }

        [Then(@"le maitre du jeu me donne quand le rôle agit, son pouvoir et subtilité")]
        public void AlorsLeMaitreDuJeuMeDonneQuandLeRoleAgitSonPouvoirEtSubtilite()
        {
            Assert.AreEqual("La voyante, appelée la nuit. Chaque nuit, elle voit la carte d'un joueur de son choix. Elle doit aider les autres villageois mais rester discrète pour ne pas être demasquée par les Loups-Garous.", joueurNovice.descriptionRole);
        }
    }
}
