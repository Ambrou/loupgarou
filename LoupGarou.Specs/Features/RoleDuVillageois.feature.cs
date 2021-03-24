﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
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
    public partial class RoleDuVillageoisFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoleDuVillageois.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Role du villageois", "Dans le but d\'éradiquer les loups garous\r\nEn tant que villeagois\r\nJe veux voter c" +
                    "ontre un autre joueur", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Role du villageois")))
            {
                LoupGarou.Specs.Features.RoleDuVillageoisFeature.FeatureSetup(null);
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
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les villageois votent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du villageois")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("villageois")]
        public virtual void LesVillageoisVotent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les villageois votent", new string[] {
                        "villageois"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
 testRunner.Given("Maria est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 12
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 13
 testRunner.And("le tour des villageois commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 14
 testRunner.When("Maria vote contre Ambroise et Ambroise vote contre Ambroise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 15
 testRunner.Then("Ambroise est le prochain mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les villageois sont indécis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du villageois")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("villageois")]
        public virtual void LesVillageoisSontIndecis()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les villageois sont indécis", new string[] {
                        "villageois"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 19
 testRunner.Given("Maria est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 20
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 21
 testRunner.And("le tour des villageois commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 22
 testRunner.When("Maria vote contre Ambroise et Ambroise vote contre Maria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 23
 testRunner.Then("il n\'y a pas de mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les villageois n\'ont pas tous voté")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du villageois")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("villageois")]
        public virtual void LesVillageoisNOntPasTousVote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les villageois n\'ont pas tous voté", new string[] {
                        "villageois"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 27
 testRunner.Given("Maria est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 28
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 29
 testRunner.And("le tour des villageois commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 30
 testRunner.When("Maria vote contre Ambroise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 31
 testRunner.Then("il n\'y a pas de mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("liste des joueurs villageois devant voter le jour")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du villageois")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("villageois")]
        public virtual void ListeDesJoueursVillageoisDevantVoterLeJour()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("liste des joueurs villageois devant voter le jour", new string[] {
                        "villageois"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 35
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 36
 testRunner.And("Johanna un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 37
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 38
 testRunner.And("Maria est la voyante", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 39
 testRunner.When("le tour des villageois commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "joueur"});
            table1.AddRow(new string[] {
                        "Blondin"});
            table1.AddRow(new string[] {
                        "Johanna"});
            table1.AddRow(new string[] {
                        "Ambroise"});
            table1.AddRow(new string[] {
                        "Maria"});
#line 40
 testRunner.Then("les joueurs qui peuvent voter sont", ((string)(null)), table1, "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion