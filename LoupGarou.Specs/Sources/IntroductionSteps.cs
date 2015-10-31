using LoupGarou.Core;
using Moq;
using System;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs
{
    [Binding]
    public class IntroductionSteps
    {
        Mock<MaitreDuJeu> mock;

        public Mock<MaitreDuJeu> Mock
        {
            get
            {
                return mock;
            }

            set
            {
                mock = value;
            }
        }

        [Given(@"un maitre du jeu")]
        public void SoitUnMaitreDuJeu()
        {

            Mock = new Mock<MaitreDuJeu>();
            MaitreDuJeu maitreDuJeuMock = Mock.Object;
            ScenarioContext.Current.Set<Mock<MaitreDuJeu> >(Mock);
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(maitreDuJeuMock);
        }

        [When(@"la partie commence")]
        public void QuandLaPartieCommence()
        {
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.jouerPartie();
        }

        [Then(@"le maitre du jeu commence la présentation du village aux villageois et de son histoire")]
        public void AlorsLeMaitreDuJeuCommenceLaPresentationDuVillageAuxVillageoisEtDeSonHistoire()
        {
            Mock.Verify(mj => mj.conter(It.IsAny<string>()));
        }
    }
}
