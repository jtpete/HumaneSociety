using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Health
    {
        private int age;
        public int Age { get { return age; } set { age = value; } }
        private bool hadShots = false;
        public bool HadShots { get { return hadShots; } }
        private DateTime? shotsDate = new DateTime();
        public DateTime? ShotsDate { get { return shotsDate; } }
        private string foodType;
        public string FoodType { get { return foodType; } }
        private int foodConsumptionPerWeek;
        public int FoodConsumptionPerWeek { get { return foodConsumptionPerWeek; } }
        private int dishSize;
        public int DishSize { get { return dishSize; } }
        private bool isSmallDish = false;
        public bool IsSmallDish { get { return isSmallDish; } }
        private bool isMediumDish = false;
        public bool IsMediumDish { get { return isMediumDish; } }
        private bool isLargeDish = false;
        public bool IsLargeDish { get { return isLargeDish; } }
        private bool isXLDish = false;
        public bool IsXLDish { get { return isXLDish; } }
        private int spaceNeeds;
        public int SpaceNeeds { get { return spaceNeeds; } }
        private bool smallSpace = false;
        public bool SmallSpace { get { return smallSpace; } }
        private bool mediumSpace = false;
        public bool MediumSpace { get { return mediumSpace; } }
        private bool largeSpace = false;
        public bool LargeSpace { get { return largeSpace; } }
        private bool xlSpace = false;
        public bool XlSpace { get { return xlSpace; } }

        public Health(int age, DateTime? shotsDate, string foodType, int foodConsumptionPerWeek, int dishSize, int spaceNeeds)
        {
            this.age = age;
            this.shotsDate = shotsDate;
            if (this.shotsDate != null)
                hadShots = true;
            this.foodType = foodType;
            this.foodConsumptionPerWeek = foodConsumptionPerWeek;
            this.dishSize = dishSize;
            this.spaceNeeds = spaceNeeds;

            if (spaceNeeds == 1)
                smallSpace = true;
            else if (spaceNeeds == 2)
                mediumSpace = true;
            else if (spaceNeeds == 3)
                largeSpace = true;
            else if (spaceNeeds == 4)
                xlSpace = true;

            if (dishSize == 1)
                isSmallDish = true;
            else if (dishSize == 2)
                isMediumDish = true;
            else if (dishSize == 3)
                isLargeDish = true;
            else if (dishSize == 4)
                isXLDish = true;
        }
        public Health(int age, string foodType, int foodConsumptionPerWeek, int dishSize, int spaceNeeds)
        {
            this.age = age;
            this.foodType = foodType;
            this.foodConsumptionPerWeek = foodConsumptionPerWeek;
            this.dishSize = dishSize;
            this.spaceNeeds = spaceNeeds;

            if (spaceNeeds == 1)
                smallSpace = true;
            else if (spaceNeeds == 2)
                mediumSpace = true;
            else if (spaceNeeds == 3)
                largeSpace = true;
            else if (spaceNeeds == 4)
                xlSpace = true;

            if (dishSize == 1)
                isSmallDish = true;
            else if (dishSize == 2)
                isMediumDish = true;
            else if (dishSize == 3)
                isLargeDish = true;
            else if (dishSize == 4)
                isXLDish = true;
        }
    }
}
