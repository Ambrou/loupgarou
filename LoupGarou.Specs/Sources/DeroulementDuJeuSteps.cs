using JeuDuLoupGarou;
using JeuDuLoupGarou.Helpers;
using JeuDuLoupGarou.Roles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs
{
    


    [Binding]
    public class DeroulementDuJeuSteps
    {
        class MaNarration : Narration
        {
            public List<string> narration = new List<string>();
            public void narrer(string strHistoire)
            {
                narration.Add(strHistoire);
            }
        }

        Mock<WereWolfGame> wereWolfGameMock = new Mock<WereWolfGame>();
        static MaNarration maNarration = new MaNarration();
        MaitreDuJeu maitreDuJeu = new MaitreDuJeu(maNarration);


        [Given(@"le prochain mort Ambroise")]
        public void SoitLeProchainMortAmbroise()
        {
            wereWolfGameMock.Setup(jeu => jeu.estLeProchainMort()).Returns("Ambroise");
        }

        [Given(@"Ambroise est la voyante")]
        public void SoitAmbroiseEstLaVoyante()
        {
            wereWolfGameMock.Object.attribueLeRoleDeVoyanteA("Ambroise");
        }

        [When(@"le jour se léve")]
        public void QuandLeJourSeLeve()
        {
            WereWolfGame wereWolfGame = wereWolfGameMock.Object;
            wereWolfGame.leverDuSoleil(maitreDuJeu);
        }

        [Then(@"le maître du jeu annonce le lever du jour")]
        public void AlorsLeMaitreDuJeuAnnonceLeLeverDuJour()
        {
            Assert.AreEqual("Le jour se léve et le village se réveille", maNarration.narration[0]);
        }

        [Then(@"la mort d'Ambroise")]
        public void AlorsLaMortDAmbroise()
        {
            Assert.AreEqual("et Ambroise est retrouvé mort.", maNarration.narration[1]);
        }

        [Then(@"le role d'Ambroise")]
        public void AlorsLeRoleDAmbroise()
        {
            Assert.AreEqual("Le village vient de perdre Voyante", maNarration.narration[2]);
        }

    }
}
