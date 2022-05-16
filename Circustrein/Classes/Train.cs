using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Classes
{
    public class Train
    {
        private int totalWagons;
        private List<Wagon> wagons;
        private List<Animal> animals;

        public int TotalWagons { get { return totalWagons; } }
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        public List<Wagon> Wagons { get { return wagons; } }

        public Train(List<Animal> a)
        {
            animals = a;
        }
        public void AddWagons()
        {
            List<Wagon> WagonsToAdd = new List<Wagon>();
            animals = animals.OrderByDescending(x => x.Type).ThenByDescending(x => x.Point).ToList();
            while (animals.Count != 0)
            {
                List<Animal> AnimalsForWagons = new List<Animal>();
                int count = 0;
                int space = 0;
                int minPoints = 0;
                foreach (var animal in animals)
                {
                    count = count + animal.Point;
                    if (count < 11 && animal.Point > minPoints)
                    {
                        if (animal.Type == enumType.Vlees)
                        {
                            minPoints = animal.Point;
                        }
                        AnimalsForWagons.Add(animal);
                        space = count;
                    }
                    count = space;
                }

                foreach (var animal in AnimalsForWagons)
                {
                    animals.RemoveAll(x => x.Id == animal.Id);
                }
                Wagon wagon = new Wagon(AnimalsForWagons);
                WagonsToAdd.Add(wagon);
            }
            wagons = WagonsToAdd;
        }
    }
}
