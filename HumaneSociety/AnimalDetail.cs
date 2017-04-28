using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumaneSociety
{
    public partial class AnimalDetailsForm : Form
    {
        AnimalControl animals;
        Animal thisAnimal;


        public AnimalDetailsForm(int animalId)
        {
            InitializeComponent();
            animals = new AnimalControl();
            thisAnimal = animals.OurAnimals.Where(a => a.AnimalId == animalId).Select(a => a).Single();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnimalDetailsForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = thisAnimal.Name;
            TypeLabel.Text = thisAnimal.Type;
            PriceLabel.Text = $"${thisAnimal.Price.ToString("0.00")}";
            ArrivalLabel.Text = thisAnimal.Arrival.Value.ToString("MM/dd/yyyy");
            AgeLabel.Text = thisAnimal.ThisHealth.Age.ToString();
            ColorLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(thisAnimal.TheseTraits.Color.ToLower());
            HeightLabel.Text = thisAnimal.TheseTraits.Height.ToString() + " in.";
            WeightLabel.Text = thisAnimal.TheseTraits.Weight.ToString() + " lb.";
            ConsumptionLabel.Text = thisAnimal.ThisHealth.FoodConsumptionPerWeek.ToString();
            FoodLabel.Text = thisAnimal.ThisHealth.FoodType;
            if (thisAnimal.ThisHealth.ShotsDate.HasValue)
                ShotsLabel.Text = thisAnimal.ThisHealth.ShotsDate.Value.ToString("MM/dd/yyyy");
            else
                ShotsLabel.Text = "No Shots";

            if (thisAnimal.TheseTraits.ActivityLevel == 1)
                ActivityLabel.Text = "Very Little Attention";
            else if (thisAnimal.TheseTraits.ActivityLevel == 2)
                ActivityLabel.Text = "Some Interaction";
            else if (thisAnimal.TheseTraits.ActivityLevel == 3)
                ActivityLabel.Text = "Daily Interaction";
            else if (thisAnimal.TheseTraits.ActivityLevel == 2)
                ActivityLabel.Text = "Much Attention";

            if (thisAnimal.ThisHealth.IsSmallDish)
                DishSizeLabel.Text = "2 oz.";
            else if (thisAnimal.ThisHealth.IsMediumDish)
                DishSizeLabel.Text = "8 oz.";
            else if (thisAnimal.ThisHealth.IsLargeDish)
                DishSizeLabel.Text = "16 oz.";
            else if (thisAnimal.ThisHealth.IsXLDish)
                DishSizeLabel.Text = "24 oz.";
        }

        private void ShotButton_Click(object sender, EventArgs e)
        {
            int animalId = thisAnimal.AnimalId;
            animals.GiveShot(animalId);
            thisAnimal = animals.OurAnimals.Where(a => a.AnimalId == animalId).Select(a => a).Single();
            if (thisAnimal.ThisHealth.ShotsDate.HasValue)
                ShotsLabel.Text = thisAnimal.ThisHealth.ShotsDate.Value.ToString("MM/dd/yyyy");
            else
                ShotsLabel.Text = "No Shots";
        }
    }

}
