using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Rooms
    {
        public List<Room> myRooms;
        public Rooms()
        {
            RoomRepository rooms = new RoomRepository();
            myRooms = rooms.GetAllRooms();
        }
        public bool RoomAvailable(int size)
        {
            bool availble = false;
            var results = myRooms.Where(r => (r.Size == size && !r.Occupied));
            if (results.Count() > 0 )
                availble = true;
            return availble;
        }
        public void PlaceAnimalInRoom(Animal animal)
        {
            RoomRepository societyRooms = new RoomRepository();
            var aRoom = myRooms.Where(r => animal.TheseTraits.ActivityLevel == r.Size && !r.Occupied).Select(r => { r.AnimalId = animal.AnimalId; r.Occupied = true; return r; } ).First();
            societyRooms.UpdateAnimalToRoom(aRoom.roomId, animal.AnimalId);
        }
        public string GetAnimalRoomId(int animalId)
        {
            Room room = myRooms.First(r => r.AnimalId == animalId);
            return room.roomId;
        }
        public void LoadRoomsForHumaneSociety()
        {
            RoomRepository myRooms = new RoomRepository();
            //20 X-Large Rooms
            for (int i = 100; i < 121; i++)
                myRooms.InsertIntoRooms("AD" + i, 4);
            //40 Large Rooms
            for (int i = 100; i < 141; i++)
                myRooms.InsertIntoRooms("AC" + i, 3);
            //50 Medium Rooms
            for (int i = 100; i < 151; i++)
                myRooms.InsertIntoRooms("AB" + i, 2);
            //100 Small Roooms
            for (int i = 100; i < 201; i++)
                myRooms.InsertIntoRooms("AA" + i, 1);
        }
    }
}
