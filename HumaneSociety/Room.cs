using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Room
    {
        public string roomId;
        private int size;
        public int Size { get { return size; } }
        private bool small = false;
        public bool Small { get { return small; } }
        private bool medium = false;
        public bool Medium { get { return medium; } }
        private bool large = false;
        public bool Large { get { return large; } }
        private bool xLarge = false;
        public bool XLarge { get { return xLarge; } }
        private bool occupied = false;
        public bool Occupied { get { return occupied; } set { occupied = value; } }
        private int animalId;
        public int AnimalId { get { return animalId; } set { animalId = value; } }

        public Room(string roomId, int size, int animalId)
        {
            this.roomId = roomId;
            this.size = size;
            this.animalId = animalId;
            if (size == 1)
                small = true;
            else if (size == 2)
                medium = true;
            else if (size == 3)
                large = true;
            else if (size == 4)
                xLarge = true;
            if (AnimalId != 0)
                occupied = true;
            else
                occupied = false;
        }

    }
}
