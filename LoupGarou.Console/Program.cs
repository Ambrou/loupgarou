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
            jeuDuLoupGarou.estUnePartieSimplifie();
            jeuDuLoupGarou.creerUnVillageAvecHabitants(8);

            for (int i = 0; i < 8; i++)
            {
                Habitant habitant = new HabitantConsole(System.Console.ReadLine(), jeuDuLoupGarou);
                habitant.emmenage();
            }

            jeuDuLoupGarou.commencerPartie();
        }
    }
}
