using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DisplayRoom
    {
        private string roomId;
        public string RoomId { get { return roomId; } }
        private string animalName;
        public string AnimalName { get { return animalName; } }
        private string animalType;
        public string AnimalType { get { return animalType; } }
        private string animalId;
        public string AnimalId { get { return animalId; } }

        public DisplayRoom(string roomId, string name, string type, int animalId)
        {
            this.roomId = roomId.ToUpper();
            if (animalId > 0)
            {
                this.animalName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                this.animalType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type.ToLower());
                this.animalId = animalId.ToString();
            }
            else
            {
                this.animalId = "";
                this.animalName = "";
                this.animalType = "";
            }

        }

    }
}
