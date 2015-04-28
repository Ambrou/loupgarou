using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Roles
{
    public class LoupGarou
    {
        WereWolfGame m_WereWolfGame = null;

        public LoupGarou(WereWolfGame wereWolfGame)
        {
            m_WereWolfGame = wereWolfGame;
        }

        //public void mange(string strNomDuJoueur)
        //{
        //    m_WereWolfGame.resultatDElection[strNomDuJoueur] = m_WereWolfGame.resultatDElection[strNomDuJoueur] + 1;
        //}
        //public override bool isVillager()
        //{
        //    return true;
        //}

        //public override string name
        //{
        //    get
        //    {
        //        return "Loup Garou";
        //    }
        //}

        //public override roleTurnPhase1 rolePhase1
        //{
        //    get
        //    {
        //        return roleTurnPhase1.LoupsGarous;
        //    }
        //}

        //public override roleTurnPhase2 rolePhase2
        //{
        //    get
        //    {
        //        return roleTurnPhase2.LoupsGarous;
        //    }
        //}
    }
}
