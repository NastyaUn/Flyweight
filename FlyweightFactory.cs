using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory  
    {
        Dictionary<string, Anthurium> anthurium = new Dictionary<string, Anthurium>();
        public FlyweightFactory()
        {
            anthurium.Add("Red", new RedAnthurium());
            anthurium.Add("White", new WhiteAnthurium());
        }
        public Anthurium GetParticle(string key) 
        {
            if (anthurium.ContainsKey(key))
                return anthurium[key];
            else
                return null;
        }
    }
}
