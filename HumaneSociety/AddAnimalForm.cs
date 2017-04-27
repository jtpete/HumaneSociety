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
        private string name;
        private bool validName = false;
        private string type;
        private bool validType = false;
        private double price;
        private bool validPrice = false;
        private DateTime arrivalDate;
        private bool validArrivalDate = false;
        private int age;
        private bool validAge = false;
        private DateTime? shots;
        private bool validShots = false;
        private string food;
        private bool validFood = false;
        private int consumption;
        private bool validConsumption = false;
        private string color;
        private bool validColor = false;
        private int height;
        private bool validHeight = false;
        private int weight;
        private bool validWeight = false;
        private int roomSize;
        private bool validRoomSize = false;
        private int dishSize;
        private bool validDishSize = false;
        private int activityLevel;
        private bool validActivityLevel = false;
        private int spaceNeeds;
        private bool validSpaceNeeds = false;
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (ValidAddInput())
            {
                ErrorLabel.Visible = false;
                Rooms rooms = new Rooms();
                if (rooms.RoomAvailable(roomSize))
                {
                    Animal thisAnimal = IncludeAnimal();
                    rooms.PlaceAnimalInRoom(thisAnimal);
                    ClearFields();
                    MessageBox.Show($"{thisAnimal.Name} was taken to room: {rooms.GetAnimalRoomId(thisAnimal.AnimalId)}");
                }
                else
                {
                    ClearFields();
                    MessageBox.Show("There are no rooms available for this animal at this time, sorry.");
                }
            }
            else
            {
                InitializeValues();
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Please fix and Submit.";
            }

        }
        private bool ValidAddInput()
        {
            CheckFromFields();
            if (validName &&
                validType &&
                validPrice &&
                validAge &&
                validArrivalDate &&
                validFood &&
                validDishSize &&
                validConsumption &&
                validSpaceNeeds &&
                validActivityLevel &&
                validHeight &&
                validWeight)
                return true;
            else
                return false;
        }
        private Animal IncludeAnimal()
        {
            return new Animal(name, type, price, arrivalDate, color, height, weight, activityLevel, age, shots, food, consumption, dishSize, spaceNeeds);
        }
        private void CheckFromFields()
        {
            CheckNameField();
            CheckTypeField();
            CheckPriceField();
            CheckArrivalDateField();
            CheckFoodField();
            CheckColorField();
            CheckAgeField();
            CheckDishSizeField();
            CheckConsumptionField();
            CheckSpaceNeededField();
            CheckActivityLevelField();
            CheckHeightField();
            CheckWeightField();

        }
        private void CheckNameField()
        {
            name = "";
            validName = false;
            if (AnimalNameText.Text != null && AnimalNameText.Text != "")
            {
                NameLabel.ForeColor = Color.Black;
                name = AnimalNameText.Text;
                validName = true;
            }
            else
            {
                NameLabel.ForeColor = Color.Red;
                validName = false;
            }
        }
        private void CheckTypeField()
        {
            if (AnimalTypeText.Text != null && AnimalTypeText.Text != "")
            {
                AnimalTypeLabel.ForeColor = Color.Black;
                type = AnimalTypeText.Text;
                validType = true;
            }
            else
            {
                AnimalTypeLabel.ForeColor = Color.Red;
                validType = false;
            }

        }
        private void CheckPriceField()
        {
            price = 0;
            if (AdoptionPriceText.Text != null)
            {
                try
                {
                    price = Convert.ToDouble(AdoptionPriceText.Text);
                    if (price > 0)
                    {
                        PriceLabel.ForeColor = Color.Black;
                        validPrice = true;
                    }
                    else
                    {
                        PriceLabel.ForeColor = Color.Red;
                        validPrice = false;
                    }
                }
                catch
                {
                    PriceLabel.ForeColor = Color.Red;
                    validPrice = false;
                }
            }
            else
            {
                PriceLabel.ForeColor = Color.Red;
                validPrice = false;
            }
        }
        private void CheckArrivalDateField()
        {
            ArrivalDatePicker.Value = DateTime.Now;
            arrivalDate = ArrivalDatePicker.Value;
            validArrivalDate = true;
        }
        private void CheckAgeField()
        {
            if (AgeTextBox.Text != null)
            {
                try
                {
                    age = Int32.Parse(AgeTextBox.Text);
                    AgeLabel.ForeColor = Color.Black;
                    validAge = true;
                }
                catch
                {
                    AgeLabel.ForeColor = Color.Red;
                    validAge = false;
                }
            }
            else
            {
                AgeLabel.ForeColor = Color.Red;
                validAge = false;
            }

        }
        private void CheckShotsField()
        {
            if (ShotsCheckBox.Checked)
            {
                if (ShotsPicker.Value <= DateTime.Today)
                {
                    shots = ShotsPicker.Value;
                    ShotsCheckBox.ForeColor = Color.Black;
                    validShots = true;
                }
                else
                {
                    ShotsCheckBox.ForeColor = Color.Red;
                    validShots = false;
                }
            }
            else
            {
                ShotsCheckBox.ForeColor = Color.Black;
                validShots = true;
                shots = null;
            }
        }
        private void CheckFoodField()
        {
            if (FoodTextBox.Text != null && FoodTextBox.Text != "")
            {
                validFood = true;
                FoodLabel.ForeColor = Color.Black;
                food = FoodTextBox.Text;
            }
            else
            {
                FoodLabel.ForeColor = Color.Red;
                validFood = false;
            }
        }
        private void CheckDishSizeField()
        {

            if (SmallDishRadio.Checked)
                dishSize = 1;
            else if (MediumDishRadio.Checked)
                dishSize = 2;
            else if (LargeDishRadio.Checked)
                dishSize = 3;
            else if (XLDishRadio.Checked)
                dishSize = 4;
            validDishSize = true;

        }
        private void CheckConsumptionField()
        {
            if (DishesPerWeekText.Text != null)
            {
                try
                {
                    consumption = Int32.Parse(DishesPerWeekText.Text);
                    DishPerWeekLabel.ForeColor = Color.Black;
                    validConsumption = true;
                }
                catch
                {
                    DishPerWeekLabel.ForeColor = Color.Red;
                    validConsumption = false;
                }
            }
            else
            {
                DishPerWeekLabel.ForeColor = Color.Red;
                validConsumption = false;
            }
        }
        private void CheckSpaceNeededField()
        {
            if (SmallSpaceRadio.Checked)
                spaceNeeds = 1;
            else if (MedSpaceRadio.Checked)
                spaceNeeds = 2;
            else if (LargeSpaceRadio.Checked)
                spaceNeeds = 3;
            else if (XLSpaceRadio.Checked)
                spaceNeeds = 4;
            roomSize = spaceNeeds;
            validSpaceNeeds = true;
        }
        private void CheckColorField()
        {
            if (ColorTextBox.Text != null && ColorTextBox.Text != "")
            {
                color = ColorTextBox.Text;
                ColorLabel.ForeColor = Color.Black;
                validColor = true;
            }
            else
            {
                ColorLabel.ForeColor = Color.Red;
                validColor = false;
            }
        }
        private void CheckActivityLevelField()
        {
            if (LowActivityRadio.Checked)
                activityLevel = 1;
            else if (MediumRadio.Checked)
                activityLevel = 2;
            else if (HighRadio.Checked)
                activityLevel = 3;
            else if (NeedyRadio.Checked)
                activityLevel = 4;
            activityLevel = roomSize;
            validActivityLevel = true;
        }
        private void CheckHeightField()
        {
            if (HeightTextBox.Text != null)
            {
                try
                {
                    height = Int32.Parse(HeightTextBox.Text);
                    HeightLabel.ForeColor = Color.Black;
                    validHeight = true;
                }
                catch
                {
                    HeightLabel.ForeColor = Color.Red;
                    validHeight = false;
                }
            }
            else
            {
                HeightLabel.ForeColor = Color.Red;
                validHeight = false;
            }

        }
        private void CheckWeightField()
        {
            if (WeightTextBox.Text != null)
            {
                try
                {
                    weight = Int32.Parse(WeightTextBox.Text);
                    WeightLabel.ForeColor = Color.Black;
                    validWeight = true;
                }
                catch
                {
                    WeightLabel.ForeColor = Color.Red;
                    validWeight = false;
                }
            }
            else
            {
                HeightLabel.ForeColor = Color.Red;
                validWeight = false;
            }
        }

        private void ShotsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShotsCheckBox.Checked)
                ShotsPicker.Visible = true;
            else
                ShotsPicker.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            InitializeValues();
            ErrorLabel.Text = "";
            ErrorLabel.Visible = false;
            ArrivalDatePicker.Value = DateTime.Today;
            ArrivalLabel.ForeColor = Color.Black;
            AnimalNameText.Text = "";
            NameLabel.ForeColor = Color.Black;
            AnimalTypeText.Text = "";
            AnimalTypeLabel.ForeColor = Color.Black;
            AdoptionPriceText.Text = "";
            PriceLabel.ForeColor = Color.Black;
            AgeTextBox.Text = "";
            AgeLabel.ForeColor = Color.Black;
            ShotsPicker.Value = DateTime.Today;
            ShotsCheckBox.ForeColor = Color.Black;
            ShotsCheckBox.Checked = false;
            FoodTextBox.Text = "";
            FoodLabel.ForeColor = Color.Black;
            DishesPerWeekText.Text = "";
            DishPerWeekLabel.ForeColor = Color.Black;
            ColorTextBox.Text = "";
            ColorLabel.ForeColor = Color.Black;
            HeightTextBox.Text = "";
            HeightLabel.ForeColor = Color.Black;
            WeightTextBox.Text = "";
            WeightLabel.ForeColor = Color.Black;
          
        }
        private void InitializeValues()
        {
            name = "";
            validName = false;
            type = "";
            validType = false;
            arrivalDate = default(DateTime);
            validArrivalDate = false;
            shots = null;
            validShots = false;
            age = 0;
            validAge = false;
            food = "";
            validFood = false;
            dishSize = 0;
            validDishSize = false;
            consumption = 0;
            validConsumption = false;
            price = 0;
            validPrice = false;
            spaceNeeds = 0;
            validSpaceNeeds = false;
            color = "";
            validColor = false;
            activityLevel = 0;
            validActivityLevel = false;
            validHeight = false;
            height = 0;
            validWeight = false;
            weight = 0;
            roomSize = 0;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
