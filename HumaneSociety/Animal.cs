using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Animal
    {
        private int animalId;
        public int AnimalId { get { return animalId; } set { animalId = value; } }
        private string type;
        public string Type { get { return type; } set { type = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private double price;
        public double Price { get { return price; } set { price = value; } }
        private DateTime? arrival = new DateTime();
        public DateTime? Arrival { get { return arrival; } set { arrival = value; } }
        private Traits theseTraits;
        public Traits TheseTraits { get { return theseTraits; } }
        private Health thisHealth;
        public Health ThisHealth { get { return thisHealth; } }
        private bool adopted = false;
        public bool Adopted { get { return adopted; } set { adopted = value; } }

        public Animal(string name, string type, double price, DateTime arrival, string color, int height, int weight, int activityLevel, int age, DateTime? shotsDate, string foodType, int foodConsumptionPerWeek, int dishSize, int spaceNeeds)
        {
            this.name = name;
            this.type = type;
            if (arrival != null)
                this.arrival = arrival;
            else
                arrival = DateTime.Now;
            this.price = price;
            theseTraits = new Traits(color, height, weight, activityLevel);
            thisHealth = new Health(age, shotsDate, foodType, foodConsumptionPerWeek, dishSize, spaceNeeds);
            AnimalRepository myAnimalRepository = new AnimalRepository();
            myAnimalRepository.InsertAnimal(this);
        }
        public Animal(string name, string type, double price, DateTime arrival, string color, int height, int weight, int activityLevel, int age, DateTime? shotsDate, string foodType, int foodConsumptionPerWeek, int dishSize, int spaceNeeds, int animalId)
        {
            this.name = name;
            this.type = type;
            this.arrival = arrival;
            this.price = price;
            theseTraits = new Traits(color, height, weight, activityLevel);
            thisHealth = new Health(age, shotsDate, foodType, foodConsumptionPerWeek, dishSize, spaceNeeds);
            this.animalId = animalId;
        }
        public bool CheckMatchKids(Adopter person)
        {
            if (person.NumberOfKids > 0 && this.theseTraits.ActivityLevel > 1)
                return true;
            else if (person.NumberOfKids == 0 && this.theseTraits.ActivityLevel > 2)
                return false;
            else if (person.NumberOfKids > 0 && this.theseTraits.LowActive)
                return false;
            else
                return true;

        }
        public bool CheckMatchPets(Adopter person)
        {
            if (person.NumberOfPets > 0 && this.theseTraits.ActivityLevel > 1)
                return true;
            else if (person.NumberOfPets == 0 && this.theseTraits.ActivityLevel > 3)
                return false;
            else if (person.NumberOfPets > 0 && this.theseTraits.LowActive)
                return false;
            else
                return true;

        }
    }
}
