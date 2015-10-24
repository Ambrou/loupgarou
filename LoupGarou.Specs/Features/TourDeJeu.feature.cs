﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LoupGarou.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TourDeJeuFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TourDeJeu.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Tour de jeu", "Dans le but de faire une partie compléte\r\nEn tant que maitre du jeu\r\nJe veux gére" +
                    "r les différentes phase du jeu", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Tour de jeu")))
            {
                LoupGarou.Specs.Features.TourDeJeuFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("le jeu du loup garou", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 8
 testRunner.And("un maitre du jeu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "habitant",
                        "role"});
            table1.AddRow(new string[] {
                        "un",
                        "villageois"});
            table1.AddRow(new string[] {
                        "deux",
                        "villageois"});
            table1.AddRow(new string[] {
                        "trois",
                        "voyante"});
            table1.AddRow(new string[] {
                        "quatre",
                        "loup-garou"});
            table1.AddRow(new string[] {
                        "cinq",
                        "villageois"});
            table1.AddRow(new string[] {
                        "six",
                        "loup-garou"});
            table1.AddRow(new string[] {
                        "sept",
                        "villageois"});
            table1.AddRow(new string[] {
                        "huit",
                        "villageois"});
#line 9
 testRunner.And("les habitants suivants:", ((string)(null)), table1, "Et ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Les loups garous mange une personne")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Tour de jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MaitreDuJeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("LoupGarou")]
        public virtual void LesLoupsGarousMangeUnePersonne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Les loups garous mange une personne", new string[] {
                        "Jeu",
                        "MaitreDuJeu",
                        "LoupGarou"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 23
 testRunner.Given("le tour des loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 24
 testRunner.When("les loups garous ont choisit leur victime", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 25
 testRunner.Then("le maitre du jeu rendort les loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 26
 testRunner.And("le maitre du jeu réveille le village", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 27
 testRunner.And("il annonce le joueur mort ainsi que son rôle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 28
 testRunner.And("c\'est le tour des villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 29
 testRunner.And("le joueur mort ne fait plus parti des habitants", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Les villageois désigne un coupable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Tour de jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MaitreDuJeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Villageois")]
        public virtual void LesVillageoisDesigneUnCoupable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Les villageois désigne un coupable", new string[] {
                        "Jeu",
                        "MaitreDuJeu",
                        "Villageois"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 33
 testRunner.Given("le tour des villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 34
 testRunner.When("les villageois ont choisi à la majorité leur coupable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 35
 testRunner.Then("le maitre du jeu annonce le joueur mort ainsi que son rôle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 36
 testRunner.And("il rendort le village", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 37
 testRunner.And("c\'est le tour de la voyante", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 38
 testRunner.And("le joueur mort ne fait plus parti des habitants", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("La voyante utilise son pouvoir de divination")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Tour de jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MaitreDuJeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Voyante")]
        public virtual void LaVoyanteUtiliseSonPouvoirDeDivination()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("La voyante utilise son pouvoir de divination", new string[] {
                        "Jeu",
                        "MaitreDuJeu",
                        "Voyante"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 42
 testRunner.Given("le tour de la voyante", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 43
 testRunner.When("la voyante utilise son pouvoir sur un habitant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 44
 testRunner.Then("le maitre du jeu l\'informe du rôle de l\'habitant dans le village", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 45
 testRunner.And("il rendort la voyante", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 46
 testRunner.And("c\'est le tour des loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Victoire des villageois")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Tour de jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MaitreDuJeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Victoire")]
        public virtual void VictoireDesVillageois()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Victoire des villageois", new string[] {
                        "Jeu",
                        "MaitreDuJeu",
                        "Victoire"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 50
 testRunner.Given("le tour des villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 51
 testRunner.When("les villageois ont choisi à la majorité leur coupable le dernier loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 52
 testRunner.Then("le maitre du jeu annonce le joueur mort ainsi que son rôle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 53
 testRunner.And("le joueur mort ne fait plus parti des habitants", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 54
 testRunner.And("les villageois ont gagné", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Victoire des loups garous")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Tour de jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Jeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("MaitreDuJeu")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Victoire")]
        public virtual void VictoireDesLoupsGarous()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Victoire des loups garous", new string[] {
                        "Jeu",
                        "MaitreDuJeu",
                        "Victoire"});
#line 57
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 58
 testRunner.Given("le tour des loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 59
 testRunner.When("les loups garous ont choisit le dernier villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 60
 testRunner.Then("le maitre du jeu rendort les loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 61
 testRunner.And("le maitre du jeu réveille le village", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 62
 testRunner.And("il annonce le joueur mort ainsi que son rôle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 63
 testRunner.And("les loup garous ont gagné", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
