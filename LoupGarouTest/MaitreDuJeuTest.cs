using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuDuLoupGarou.Roles;
using Moq;
using System.Speech.Synthesis;
using JeuDuLoupGarou.Helpers;

namespace LoupGarouTest
{
    [TestClass]
    public class MaitreDuJeuTest
    {
        class MaNarration : Narration
        {
            public string narration;
            public void narrer(string strHistoire)
            {
                narration = strHistoire;
            }
        }
        [TestMethod]
        public void TestAnnonceLeProchainMort()
        {
            MaNarration maNarration = new MaNarration();
            MaitreDuJeu maitreDuJeu = new MaitreDuJeu(maNarration);
            maitreDuJeu.annonceLeProchainMort("Ambroise");
            Assert.AreEqual("et Ambroise est retrouvé mort.", maNarration.narration);
        }
    }
}
