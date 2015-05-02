using JeuDuLoupGarou;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuLoupGarou.Roles
{
    public class Chasseur
    {
        WereWolfGame m_WereWolfGame = null;

        public Chasseur(WereWolfGame wereWolfGame)
        {
            m_WereWolfGame = wereWolfGame;
        }
    }
}
