using LoupGarou.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Console
{
    class HabitantConsole : Habitant
    {
        public HabitantConsole(string nomHabitant) : base(nomHabitant)
        {
        }

        public override void afficheInformation(string v)
        {
            System.Console.WriteLine(v);
        }
    }
}
