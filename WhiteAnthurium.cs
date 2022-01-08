using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class WhiteAnthurium : Anthurium
    {
        public WhiteAnthurium()
        {
            color = "White";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Создать белый антуриум в ({0}, {1})", x, y);
        }
    }
}
