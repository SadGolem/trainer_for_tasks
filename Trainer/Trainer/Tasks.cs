using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    public class Tasks
    {
        public string[] _Entity = { "поезд", "тролейбус", "автобус", "грузовик", "фургон", "мотоцикл" };
        int _Type;
        Random rnd = new Random();

        //переменные для задач
        int _Speed1;
        int _Speed2;
        int _Time;
        int _Way;
        int _WayMeet;
        //////


        public string Make(int WayMeet, int Speed1, int Speed2, int Time, int Way, int Type)
        {
            string[] s;
            s = new string[5];
            int n = rnd.Next(5);

            s[0] = String.Format("На каком расстоянии от пункта встретились два {0}а, если известно, что скорость первого {0}а равна {1} км/ч, скорость второго равна {2} км/ч, время движения при этом составило {3} ч", _Entity[n], Speed1, Speed2, Time);
            s[1] = String.Format("Какое расстояние будет между {0}ами через {1} ч, если известно, что скорость первого {0}а равна {2} км/ч, скорость второго равна {3} км/ч.", _Entity[n], Time, Speed1, Speed2);
            s[2] = String.Format("Какое расстояние будет от пункта А  до места встречи двух {0}ов, если известно, что скорость первого {0}а равна {1} км/ч, скорость второго равна {2} км/ч, время движения при этом составило {3} ч", _Entity[n], Speed1, Speed2, Time);
            s[3] = String.Format("Когда произошло время встречи двух {0}ов, если известно, что скорость первого {0}а равна {1} км/ч, скорость второго равна {2} км/ч, при этом расстояние между ними изначально было {3} км", _Entity[n], Speed1, Speed2, Way);
            s[4] = String.Format("С какой скоростью должен двигаться второй {0}, чтобы встретиться через {1} км со вторым {0}ом, если известно, что скорость второго {0}а равна {2} км/ч, время движения при этом составило {3} ч., а расстояние между ними изначально было {4} км", _Entity[n], WayMeet, Speed2, Time, Way);

            return s[Type];
        }

        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public int Speed1
        {
            get { return _Speed1; }
            set { _Speed1 = value; }
        }
        public int Speed2
        {
            get { return _Speed2; }
            set { _Speed2 = value; }
        }
        public int Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        public int Way
        {
            get { return _Way; }
            set { _Way = value; }
        }
        public int WayMeet
        {
            get { return _WayMeet; }
            set { _WayMeet = value; }
        }

    }
}
