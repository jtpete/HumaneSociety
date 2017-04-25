using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumaneSociety
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (ValidAddInput())
            {
                IncludeAnimal();
                //response box validating Animal Included
            }
        }
        private bool ValidAddInput()
        {
            return true;
        }
        private void IncludeAnimal()
        {
            Animal myAnimal = LoadInfoForNextAnimal();
            //insert animal to database
            //find room for animal
        }
        private Animal LoadInfoForNextAnimal()
        {

            int activityLevel = 1;
            if (ActivityComboBox.Text.Contains("Low"))
                activityLevel = 1;
            else if (ActivityComboBox.Text.Contains("Medium"))
                activityLevel = 2;
            else if (ActivityComboBox.Text.Contains("High"))
                activityLevel = 3;
            else if (ActivityComboBox.Text.Contains("Needy"))
                activityLevel = 4;

            int dishSize = 1;
            if (DishSizeComboBox.Text.Contains("Small"))
                dishSize = 1;
            else if (DishSizeComboBox.Text.Contains("Medium"))
                dishSize = 2;
            else if (DishSizeComboBox.Text.Contains("Large"))
                dishSize = 3;
            else if (DishSizeComboBox.Text.Contains("X-Large"))
                dishSize = 4;

            int spaceNeeds = 1;
            if (SpaceNeedsComboBox.Text.Contains("Small"))
                spaceNeeds = 1;
            else if (SpaceNeedsComboBox.Text.Contains("Medium"))
                spaceNeeds = 2;
            else if (SpaceNeedsComboBox.Text.Contains("Large"))
                spaceNeeds = 3;
            else if (SpaceNeedsComboBox.Text.Contains("X-Large"))
                spaceNeeds = 4;

            Animal myAnimal = new Animal(AnimalNameText.Text, AnimalTypeText.Text, ArrivalDatePicker.Value, ColorTextBox.Text, Int32.Parse(HeightTextBox.Text), Int32.Parse(WeightTextBox.Text), activityLevel, Int32.Parse(AgeTextBox.Text), ShotsPicker.Value, FoodTextBox.Text, Int32.Parse(DishesPerWeekText.Text), dishSize, spaceNeeds);

            return myAnimal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
