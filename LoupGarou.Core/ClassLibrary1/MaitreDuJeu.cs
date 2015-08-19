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

        public void saluer(Habitant habitant, string salutation)
        {
            habitant.afficheInformation(salutation);
        }
    }
}
