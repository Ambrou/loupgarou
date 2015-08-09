using LoupGarou.Core;
using Moq;
using TechTalk.SpecFlow;

namespace LoupGarou.Specs.Sources
{
    [Binding]
    public class PresentationDesCartesSteps
    {
        Mock<Joueur> mock;

        public Mock<Joueur> Mock
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

        [Given(@"le jeu du loup garou")]
        public void SoitLeJeuDuLoupGarou()
        {
            ScenarioContext.Current.Set<JeuDuLoupGarou>(new JeuDuLoupGarou());
        }
        
        [Given(@"moi un joueur novice")]
        public void SoitMoiUnJoueurNovice()
        {
            Mock = new Mock<Joueur>();
        }
        
        [When(@"je demande les informations d'un rôle")]
        public void QuandJeDemandeLesInformationsDUnRole()
        {
            Mock.Setup(joueur => joueur.afficheInformationRole("balbla"));
            Joueur joueurMock = Mock.Object;
            var jeuDuLoupGarou = ScenarioContext.Current.Get<JeuDuLoupGarou>();
            jeuDuLoupGarou.donneInformationRole("voyante", joueurMock);
        }
        
        [Then(@"le maitre du jeu me donne quand le rôle agit, son pouvoir et subtilité")]
        public void AlorsLeMaitreDuJeuMeDonneQuandLeRoleAgitSonPouvoirEtSubtilite()
        {
            Mock.Verify();
        }
    }
}
