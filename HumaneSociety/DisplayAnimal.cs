using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace HumaneSociety
{
    class DisplayAnimal
    {
        private int animalId;
        public int AnimalId { get { return animalId; } }
        private string name;
        public string Name { get { return name; } }
        private string type;
        public string Type { get { return type; } }
        private string price;
        public string Price { get { return price; }  }
        private string shots;
        public string Shots { get { return shots; } }
        private string color;
        public string Color { get { return color; } set { color = value; } }
        private string height;
        public string Height { get { return height; } }
        private string weight;
        public string Weight { get { return weight; } }

        public DisplayAnimal(Animal animal)
        {
            this.animalId = animal.AnimalId;
            this.name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(animal.Name.ToLower());
            this.type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(animal.Type.ToLower());
            this.price = $"${animal.Price.ToString("0.00")}";
            if (animal.ThisHealth.ShotsDate.HasValue && animal.ThisHealth.ShotsDate.Value != SqlDateTime.MinValue)
                this.shots = animal.ThisHealth.ShotsDate.Value.ToString("yyyy.mm.dd");
            else
                this.shots = "";
            this.color = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(animal.TheseTraits.Color.ToLower());
            this.height = animal.TheseTraits.Height.ToString() + " in.";
            this.weight = animal.TheseTraits.Weight.ToString() + " lb.";

        }
    }
}
