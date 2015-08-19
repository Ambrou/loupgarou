using LoupGarou.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Console
{
    class MaitreDuJeuConsole : MaitreDuJeu
    {
        public void conter(string texte)
        {
            var color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Narrateur: ");
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(texte);
        }
    }
}
