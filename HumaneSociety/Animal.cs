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
        private DateTime arrival = new DateTime();
        public DateTime Arrival { get { return arrival; } set { arrival = value; } }
        private Traits theseTraits;
        public Traits TheseTraits { get { return theseTraits; } }
        private Health thisHealth;
        public Health ThisHealth { get { return thisHealth; } }

        public Animal(string name, string type, DateTime arrival, string color, int height, int weight, int activityLevel, int age, DateTime shotsDate, string foodType, int foodConsumptionPerWeek, int dishSize, int spaceNeeds)
        {
            this.name = name;
            this.type = type;
            if (arrival != null)
                this.arrival = arrival;
            else
                arrival = DateTime.Today;
            theseTraits = new Traits(color, height, weight, activityLevel);
            thisHealth = new Health(age, shotsDate, foodType, foodConsumptionPerWeek, dishSize, spaceNeeds);

        }


    }
}
