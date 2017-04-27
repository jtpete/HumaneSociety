using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AnimalControl
    {
        private List<Animal> ourAnimals = new List<Animal>();
        public List<Animal> OurAnimals { get { return ourAnimals; } }

        public AnimalControl()
        {
            AnimalRepository animals = new AnimalRepository();
            ourAnimals = animals.GetAllAnimals();
        }

    }
}
