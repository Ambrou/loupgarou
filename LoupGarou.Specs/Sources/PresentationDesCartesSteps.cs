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
        //internal class HabitantNovice : Habitant
        //{
        //    public string descriptionRole;

        //    public HabitantNovice(JeuDuLoupGarou jeuDuLoupGarou) : base("Novice", jeuDuLoupGarou)
        //    {
        //    }

        //    public override void afficheInformation(string v)
        //    {
        //        descriptionRole = v;
        //    }
        //}

        //HabitantNovice habitantNovice;

        //[Given(@"le jeu du loup garou")]
        //public void SoitLeJeuDuLoupGarou()
        //{
        //    ScenarioContext.Current.Set<JeuDuLoupGarou>(new JeuDuLoupGarou());
        //}

        //[Given(@"moi un habitant novice du village")]
        //public void SoitMoiUnHabitantNoviceDuVillage()
        //{
        //    habitantNovice = new HabitantNovice(ScenarioContext.Current.Get<JeuDuLoupGarou>());
        //    habitantNovice.emmenage();
        //}

        //[When(@"je demande les informations d'un rôle au maitre du jeu")]
        //public void QuandJeDemandeLesInformationsDUnRole()
        //{
        //    habitantNovice.demandeInformationRole("voyante");
        //}

        //[Then(@"le maitre du jeu me donne quand le rôle agit, son pouvoir et subtilité")]
        //public void AlorsLeMaitreDuJeuMeDonneQuandLeRoleAgitSonPouvoirEtSubtilite()
        //{
        //    Assert.AreEqual("La voyante, appelée la nuit. Chaque nuit, elle voit la carte d'un joueur de son choix. Elle doit aider les autres villageois mais rester discrète pour ne pas être demasquée par les Loups-Garous.", habitantNovice.descriptionRole);
        //}
    }
}
