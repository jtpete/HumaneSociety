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
        private List<DisplayRoom> ourRooms = new List<DisplayRoom>();
        public List<DisplayRoom> OurRooms {  get { return ourRooms; } }

        public AnimalControl()
        {
            AnimalRepository animals = new AnimalRepository();
            ourAnimals = animals.GetAllAnimals();
            RoomRepository rooms = new RoomRepository();
            ourRooms = rooms.GetAllRoomsWithAnimalNames();
        }

        public void GiveShot(int animalId)
        {
            Animal thisAnimal = ourAnimals.Where(a => a.AnimalId == animalId).Select(a =>
            {
                a.ThisHealth.ShotsDate = DateTime.Now;
                a.ThisHealth.HadShots = true;
                return a;

            }).Single();
            AnimalHealthRepository health = new AnimalHealthRepository();
            health.UpdateAnimalShot(thisAnimal);
        }

        public void Adopt(int animalId, Adopter person)
        {
            AnimalRepository theseAnimals = new AnimalRepository();
            Animal thisAnimal = ourAnimals.Where(a => a.AnimalId == animalId).Select(a => a).Single();
            ourAnimals.Remove(thisAnimal);
            UpdateAdopterInfoWithAnimal(person, thisAnimal);
            theseAnimals.UpdateAnimalAdoption(thisAnimal.AnimalId);
        }
        private void UpdateAdopterInfoWithAnimal(Adopter person, Animal animal)
        {
            person.AnimalId = animal.AnimalId;
            person.AdoptionPrice = animal.Price;
            person.AdoptionDate = DateTime.Now;
            AdopterRepository myAdopter = new AdopterRepository();
            myAdopter.InsertAnAdoption(person);
        }


    }
}
