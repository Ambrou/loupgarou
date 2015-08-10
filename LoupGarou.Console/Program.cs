using LoupGarou.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            JeuDuLoupGarou jeuDuLoupGarou = new JeuDuLoupGarou();
            jeuDuLoupGarou.avecCommeMaitreDuJeu(new MaitreDuJeuConsole());

            jeuDuLoupGarou.commencerPartie();
        }
    }
}
