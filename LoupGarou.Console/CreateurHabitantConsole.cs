using LoupGarou.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou.Console
{
    class CreateurHabitantConsole : CreateurHabitant
    {
        public Habitant creerHabitant()
        {
            return new HabitantConsole(System.Console.ReadLine());
        }
    }
}
