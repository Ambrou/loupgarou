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
    public partial class RoleDuLoupGarouFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoleDuLoupGarou.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("fr-FR"), "Role du loup garou", "Dans le but de ne pas mourir de faim\r\nEn tant que loup garou\r\nJe veux manger un v" +
                    "illageois avec mes potes loups", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Role du loup garou")))
            {
                LoupGarou.Specs.Features.RoleDuLoupGarouFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("le loup garou agit")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du loup garou")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("loup_garou")]
        public virtual void LeLoupGarouAgit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("le loup garou agit", new string[] {
                        "loup_garou"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 12
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 13
 testRunner.And("le tour des loups commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 14
 testRunner.When("Blondin mange Ambroise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 15
 testRunner.Then("Ambroise est le prochain mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les loups garous sont indécis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du loup garou")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("loup_garou")]
        public virtual void LesLoupsGarousSontIndecis()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les loups garous sont indécis", new string[] {
                        "loup_garou"});
#line 18
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 19
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 20
 testRunner.And("Johanna un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 21
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 22
 testRunner.And("Maria est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 23
 testRunner.And("le tour des loups commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 24
 testRunner.When("Blondin mange Ambroise et Johanna mange Maria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 25
 testRunner.Then("il n\'y a pas de mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les loups garous sont presque indécis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du loup garou")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("loup_garou")]
        public virtual void LesLoupsGarousSontPresqueIndecis()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les loups garous sont presque indécis", new string[] {
                        "loup_garou"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 29
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 30
 testRunner.And("Johanna un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 31
 testRunner.And("Blondina un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 32
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 33
 testRunner.And("Maria est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 34
 testRunner.And("le tour des loups commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 35
 testRunner.When("Blondin mange Ambroise et Johanna mange Maria et Blondina mange Ambroise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 36
 testRunner.Then("Ambroise est le prochain mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("les loups garous n\'ont pas tous voté")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du loup garou")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("loup_garou")]
        public virtual void LesLoupsGarousNOntPasTousVote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("les loups garous n\'ont pas tous voté", new string[] {
                        "loup_garou"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 40
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 41
 testRunner.And("Johanna un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 42
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 43
 testRunner.And("le tour des loups commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 44
 testRunner.When("Blondin mange Ambroise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line 45
 testRunner.Then("il n\'y a pas de mort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Alors ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("liste des joueurs loups devant voter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Role du loup garou")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("loup_garou")]
        public virtual void ListeDesJoueursLoupsDevantVoter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("liste des joueurs loups devant voter", new string[] {
                        "loup_garou"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 49
 testRunner.Given("Blondin un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Soit ");
#line 50
 testRunner.And("Johanna un loup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 51
 testRunner.And("Ambroise est un villageois", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Et ");
#line 52
 testRunner.When("le tour des loups commence", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Lorsque ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "joueur"});
            table1.AddRow(new string[] {
                        "Blondin"});
            table1.AddRow(new string[] {
                        "Johanna"});
#line 53
 testRunner.Then("les joueurs qui peuvent voter sont", ((string)(null)), table1, "Alors ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "joueur"});
            table2.AddRow(new string[] {
                        "Ambroise"});
#line 57
 testRunner.And("les joueurs qui ne peuvent pas voter sont", ((string)(null)), table2, "Et ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion