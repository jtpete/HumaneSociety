using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Traits
    {
        private int activityLevel;
        public int ActivityLevel { get { return activityLevel; } }
        private bool lowActive = false;
        public bool LowActive { get { return lowActive; } }
        private bool medActive = false;
        public bool MedActive { get { return medActive; } }
        private bool highActive = false;
        public bool HighActive { get { return highActive; } }
        private bool isNeedy = false;
        public bool IsNeedy { get { return isNeedy; } }
        private int weight;
        public int Weight { get { return weight; } set { weight = value; } }
        private int height;
        public int Height { get { return height; } set { height = value; } }
        private string color;
        public string Color { get { return color; } set { color = value; } }

        public Traits(string color, int height, int weight, int activityLevel)
        {
            this.color = color;
            this.height = height;
            this.weight = weight;
            this.activityLevel = activityLevel;
            if (activityLevel == 1)
                lowActive = true;
            else if (activityLevel == 2)
                medActive = true;
            else if (activityLevel == 3)
                highActive = true;
            else if (activityLevel == 4)
                isNeedy = true;
        }
    }
}
