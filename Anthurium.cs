using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract class Anthurium
    {
        protected string color;
        public abstract void Create(double x, double y);
    }
}
