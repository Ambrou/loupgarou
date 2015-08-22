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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Tour de jeu", "Dans le but de faire une partie compléte\nEn tant que maitre du jeu\nJe veux gérer " +
                    "les différentes phase du jeu", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 36
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 37
 testRunner.Given("le tour des loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 38
 testRunner.When("les loups garous ont choisit leur victime", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quand ");
#line 39
 testRunner.Then("le maitre du jeu rendort les loups garous", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line 40
 testRunner.And("le maitre du jeu réveille le village", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 41
 testRunner.And("il annonce le joueur mort ainsi que son rôle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 42
 testRunner.And("c\'est le tour des villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion