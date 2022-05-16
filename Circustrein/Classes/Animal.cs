using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Classes
{
    public enum enumSize
    {
        Groot,
        Middelgrote,
        klein
    }
    public class Animal
    {
        private int id;
        private enumSize size;
        private int point;
        private bool type;

        public int Id { get { return id; } }
        public enumSize Size { get { return size; } set { size = value; } }
        public int Point { get { return point; } set { point = value; } }
        public bool Type { get { return type; } set { type = value; } }

        public Animal(int i, enumSize s, bool t)
        {
            id = i;
            size = s;
            type = t;
            switch (size)
            {
                case enumSize.Groot:
                    point = 5;
                    break;
                case enumSize.Middelgrote:
                    point = 3;
                    break;
                case enumSize.klein:
                    point = 1;
                    break;
            }
        }
    }
}
