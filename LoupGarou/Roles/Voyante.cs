using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Roles
{
    public class Voyante
    {
        WereWolfGame m_WereWolfGame = null;

        public Voyante(WereWolfGame wereWolfGame)
        {
            m_WereWolfGame = wereWolfGame;
        }
        //public override string name
        //{
        //    get
        //    {
        //        return "Voyante";
        //    }
        //}

        //public override roleTurnPhase1 rolePhase1
        //{
        //    get
        //    {
        //        return roleTurnPhase1.Voyante;
        //    }
        //}

        //public override roleTurnPhase2 rolePhase2
        //{
        //    get
        //    {
        //        return roleTurnPhase2.Voyante;
        //    }
        //}

        public string devoileLeRoleDe(string strNomDuJoueur)
        {
            return m_WereWolfGame.attributionDesRolesParJoueur[strNomDuJoueur];
        }
    }
}
