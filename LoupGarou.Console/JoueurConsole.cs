using LoupGarou.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Console
{
    class JoueurConsole : Joueur
    {
        public override void afficheInformationRole(string v)
        {
            System.Console.WriteLine(v);
        }
    }
}
