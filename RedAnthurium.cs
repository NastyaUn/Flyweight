using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class RedAnthurium : Anthurium
    {
        public RedAnthurium()
        {
            color = "Red";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Создать красный антуриум в ({0}, {1})", x, y);
        }
    }
}
