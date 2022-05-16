using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Classes
{
    public class Wagon
    {
        private int space = 10;
        private List<Animal> animals;
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        public int Space { get { return space; } set { space = value; } }

        public Wagon(List<Animal> a)
        {
            animals = a;
        }
    }
}
