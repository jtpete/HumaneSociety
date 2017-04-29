using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string phone;
        public string Phone { get { return phone; } set { phone = value; } }
        private string email;
        public string Email { get { return email; } set { email = value; } }
        private int numberOfKids;
        public int NumberOfKids { get { return numberOfKids; } set { numberOfKids = value; } }
        private int numberOfPets;
        public int NumberOfPets { get { return numberOfPets; } set { numberOfPets = value; } }
        private int animalId;
        public int AnimalId { get { return animalId; } set { animalId = value; } }
        private DateTime adoptionDate;
        public DateTime AdoptionDate { get { return adoptionDate; } set { adoptionDate = value; } }
        private double adoptionPrice;
        public double AdoptionPrice { get { return adoptionPrice; } set { adoptionPrice = value; } }
        public Adopter(string name, string phone, string email, int numberOfKids, int numberOfPets, int animalId, double adoptionPrice)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.numberOfPets = numberOfPets;
            this.numberOfKids = numberOfKids;
            adoptionDate = DateTime.Now;
            this.adoptionPrice = adoptionPrice;
            this.animalId = animalId;

        }
        public Adopter(string name, string phone, string email, int numberOfKids, int numberOfPets)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.numberOfPets = numberOfPets;
            this.numberOfKids = numberOfKids;


        }
    }
    
}
