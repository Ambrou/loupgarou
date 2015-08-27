using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Core
{
    public class MaitreDuJeu
    {
        public virtual void conter(string texte)
        {
            throw new NotImplementedException();
        }

        public void chuchoter(Habitant habitant, string chuchotage)
        {
            habitant.afficheInformation(chuchotage);
        }
    }
}
