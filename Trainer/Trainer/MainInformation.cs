using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    internal class MainInformation
    {
        Random rnd = new Random();

        public MainInformation()
        {
            int Speed1 = rnd.Next(40, 80);
            int Speed2 = rnd.Next(40, 80);
            int Time = rnd.Next(1, 2);
            int Way = rnd.Next(120, 500);
            int WayMeet = Way - rnd.Next(60, 100);
            int Type = rnd.Next(0, 4);
        }

    }
}
