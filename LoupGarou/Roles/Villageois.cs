using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Roles
{
    public class Villageois
    {
        WereWolfGame m_WereWolfGame = null;

        public Villageois(WereWolfGame wereWolfGame)
        {
            m_WereWolfGame = wereWolfGame;
        }

        //public void voteContre(string strNomDuJoueur)
        //{
        //    m_WereWolfGame.voteContre(strNomDuJoueur);
        //    //m_WereWolfGame.resultatDElection[strNomDuJoueur] = m_WereWolfGame.resultatDElection[strNomDuJoueur] + 1;
        //}

        //public override bool isVillager()
        //{
        //    return true;
        //}

        //public override string name
        //{
        //    get
        //    {
        //        return "Villageois";
        //    }
        //}

        //public override roleTurnPhase1 rolePhase1
        //{
        //    get
        //    {
        //        return roleTurnPhase1.Villageois;
        //    }
        //}

        //public override roleTurnPhase2 rolePhase2
        //{
        //    get
        //    {
        //        return roleTurnPhase2.Villageois;
        //    }
        //}
    }
}
