using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Record
    {
        private string name;
        public string Name { get { return name; } }
        private bool validName = false;
        private string type;
        public string Type { get { return type; } }
        private bool validType = false;
        private double price;
        public double Price { get { return price; } }
        private bool validPrice = false;
        private DateTime arrivalDate;
        public DateTime ArrivalDate { get { return arrivalDate; } }
        private bool validArrivalDate = false;
        private int age;
        public int Age { get { return age; } }
        private bool validAge = false;
        private DateTime? shots;
        public DateTime? Shots { get { return shots; } }
        private bool validShots = false;
        private string food;
        public string Food { get { return food; } }
        private bool validFood = false;
        private int consumption;
        public int Consumption { get { return consumption; } }
        private bool validConsumption = false;
        private string color;
        public string Color { get { return color; } }
        private bool validColor = false;
        private int height;
        public int Height { get { return height; } }
        private bool validHeight = false;
        private int weight;
        public int Weight { get { return weight; } }
        private bool validWeight = false;
        private int dishSize;
        public int DishSize { get { return dishSize; } }
        private bool validDishSize = false;
        private int activityLevel;
        public int ActivityLevel { get { return activityLevel; } }
        private bool validActivityLevel = false;
        private int spaceNeeds;
        public int SpaceNeeds { get { return spaceNeeds; } }
        private bool validSpaceNeeds = false;
        public bool ValidAddInput(string[] row)
        {
            CheckFromFields(row);
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
        private void CheckFromFields(string[] row)
        {

            CheckNameField(row.ElementAt(0));
            CheckTypeField(row.ElementAt(1));
            CheckPriceField(row.ElementAt(2));
            CheckArrivalDateField();
            CheckShotsField(row.ElementAt(7));
            CheckFoodField(row.ElementAt(8));
            CheckColorField(row.ElementAt(3));
            CheckAgeField(row.ElementAt(12));
            CheckDishSizeField(row.ElementAt(9));
            CheckConsumptionField(row.ElementAt(10));
            CheckSpaceNeededField(row.ElementAt(11));
            CheckActivityLevelField(row.ElementAt(6));
            CheckHeightField(row.ElementAt(5));
            CheckWeightField(row.ElementAt(4));

        }
        private void CheckNameField(string aName)
        {
            if (aName != null && aName != "")
            {
                name = aName;
                validName = true;
            }
            else
            {
                validName = false;
            }
        }
        private void CheckTypeField(string aType)
        {
            if (aType != null && aType != "")
            {
                type = aType;
                validType = true;
            }
            else
            {
                validType = false;
            }

        }
        private void CheckPriceField(string aPrice)
        {
            price = 0;
            if (aPrice != null && aPrice != "")
            {
                try
                {
                    price = Convert.ToDouble(aPrice);
                    if (price > 0)                   
                        validPrice = true;                    
                    else                    
                        validPrice = false;                   
                }
                catch
                {
                    validPrice = false;
                }
            }
            else            
                validPrice = false;            
        }
        private void CheckArrivalDateField()
        {
            arrivalDate = DateTime.Now;
            validArrivalDate = true;
        }
        private void CheckAgeField(string anAge)
        {
            if (anAge != null && anAge != "")
            {
                try
                {
                    age = Int32.Parse(anAge);
                    validAge = true;
                }
                catch
                {
                    validAge = false;
                }
            }
            else
            {
                validAge = false;
            }

        }
        private void CheckShotsField(string aShotDate)
        {
            if (aShotDate != "")
            {
                try
                {
                    shots = Convert.ToDateTime(aShotDate);
                    validShots = true;
                }
                catch
                {
                    validShots = false;
                }
            }
            else
            {
                validShots = true;
                shots = null;
            }
        }
        private void CheckFoodField(string aFood)
        {
            if (aFood != null && aFood != "")
            {
                validFood = true;
                food = aFood;
            }
            else
            {
                validFood = false;
            }
        }
        private void CheckDishSizeField(string aDish)
        {
            if (aDish != null && aDish != "")
            {
                try
                {
                    dishSize = Int32.Parse(aDish);
                    validDishSize = true;
                }
                catch
                {
                    validDishSize = false;
                }
            }
            else
            {
                validDishSize = false;
            }
        }
        private void CheckConsumptionField(string aConsumption)
        {
            if (aConsumption != null && aConsumption != "")
            {
                try
                {
                    consumption = Int32.Parse(aConsumption);
                    validConsumption = true;
                }
                catch
                {
                    validConsumption = false;
                }
            }
            else
            {
                validConsumption = false;
            }
        }
        private void CheckSpaceNeededField(string aSpaceNeed)
        {
            if (aSpaceNeed != null && aSpaceNeed != "")
            {
                try
                {
                    spaceNeeds = Int32.Parse(aSpaceNeed);
                    validSpaceNeeds = true;
                }
                catch
                {
                    validSpaceNeeds = false;
                }
            }
            else
            {
                validSpaceNeeds = false;
            }
        }
        private void CheckColorField(string aColor)
        {
            if (aColor != null && aColor != "")
            {
                color = aColor;
                validColor = true;
            }
            else
            {
                validColor = false;
            }
        }
        private void CheckActivityLevelField(string anActivityLevel)
        {
            if (anActivityLevel != null && anActivityLevel != "")
            {
                try
                {
                    activityLevel = Int32.Parse(anActivityLevel);
                    validActivityLevel = true;
                }
                catch
                {
                    validActivityLevel = false;
                }
            }
            else
            {
                validActivityLevel = false;
            }
        }
        private void CheckHeightField(string aHeight)
        {
            if (aHeight != null && aHeight != "")
            {
                try
                {
                    height = Int32.Parse(aHeight);
                    validHeight = true;
                }
                catch
                {
                    validHeight = false;
                }
            }
            else
            {
                validHeight = false;
            }

        }
        private void CheckWeightField(string aWeight)
        {
            if (aWeight != null)
            {
                try
                {
                    weight = Int32.Parse(aWeight);
                    validWeight = true;
                }
                catch
                {
                    validWeight = false;
                }
            }
            else
            {
                validWeight = false;
            }
        }

    }
}
