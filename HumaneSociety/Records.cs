using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.FileIO;
using System.Text;

using System.Threading.Tasks;
using System.IO;

namespace HumaneSociety
{
    public class Records
    {
        List<Record> validRecords;
        public List<Record> ValidRecords { get { return validRecords; } }
        List<Record> noRoomRecords;
        private List<string[]> invalidRecords;
        public List<string[]> InvalidRecords { get { return invalidRecords; } }
        public Records()
        {
            validRecords = new List<Record>();
            noRoomRecords = new List<Record>();
            invalidRecords = new List<string[]>();
        }
        public List<Record> ReadInputFile(string file)
        {
            try
            {
                var cvsFile = File.ReadAllLines(file).Select(x => x.Split(',')).ToList(); ;
                Record aRecord;
                cvsFile.ForEach(r =>
                {
                    aRecord = new Record();
                    if (aRecord.ValidAddInput(r))
                    {
                        validRecords.Add(aRecord);
                    }
                    else
                    {
                        invalidRecords.Add(r);
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return validRecords;
        }
        public List<Record> AcceptAnimalsToHumaneSociety(List<Record> animalRecords)
        {
            Rooms rooms = new Rooms();
            foreach (var animalRecord in animalRecords)
            {
                if (rooms.RoomAvailable(animalRecord.ActivityLevel))
                {
                    Animal thisAnimal = IncludeAnimal(animalRecord);
                    rooms.PlaceAnimalInRoom(thisAnimal);
                }
                else
                    noRoomRecords.Add(animalRecord);
            }
            return noRoomRecords;
        }
        private Animal IncludeAnimal(Record record)
        {
            return new Animal(record.Name, record.Type, record.Price, record.ArrivalDate, record.Color, record.Height, record.Weight, record.ActivityLevel, record.Age, record.Shots, record.Food, record.Consumption, record.DishSize, record.SpaceNeeds);
        }
    }


}
