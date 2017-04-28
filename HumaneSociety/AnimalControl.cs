﻿using System;
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


    }
}
