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


    public partial class AdoptAnimalForm : Form
    {
        AnimalControl animals;
        Animal thisAnimal;
        private string name;
        private bool validName = false;
        private string phone;
        private bool validPhone = false;
        private string email;
        private bool validEmail = false;
        private int numberOfKids;
        private bool validNumberOfKids = false;
        private int numberOfPets;
        private bool validNumberOfPets = false;
        public AdoptAnimalForm(int animalId)
        {
            InitializeComponent();
            animals = new AnimalControl();
            thisAnimal = animals.OurAnimals.Where(a => a.AnimalId == animalId).Select(a => a).Single();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdoptAnimalForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = thisAnimal.Name;
            TypeLabel.Text = thisAnimal.Type;
            PriceLabel.Text = $"${thisAnimal.Price.ToString("0.00")}";
        }

        private void IsMatchButton_Click(object sender, EventArgs e)
        {
            AdoptedLabel.Visible = false;
            if (ValidAdopterInput())
            {
                Adopter person = new Adopter(name, phone, email, numberOfKids, numberOfPets);
                if (thisAnimal.CheckMatchKids(person) && thisAnimal.CheckMatchPets(person))
                {
                    AdoptedLabel.Visible = true;
                    AdoptedLabel.Text = "Good Fit";
                }
                else
                {
                    AdoptedLabel.Visible = true;
                    AdoptedLabel.Text = "Poor Fit";
                }
            }
        }
        private bool ValidAdopterInput()
        {
            VerifyInputFields();
            if (validName &&
                validEmail &&
                validPhone &&
                validNumberOfKids &&
                validNumberOfPets)
                return true;
            else
                return false;
        }
        private void VerifyInputFields()
        {
            CheckNameField();
            CheckEmailField();
            CheckPhoneField();
            CheckNumberOfKidsField();
            CheckNumberOfPetsField();
        }
        private void CheckNameField()
        {
            name = "";
            validName = false;
            if (NameTextBox.Text != null && NameTextBox.Text != "")
            {
                NameLabel.ForeColor = Color.Black;
                name = NameTextBox.Text;
                validName = true;
            }
            else
            {
                NameLabel.ForeColor = Color.Red;
                validName = false;
            }
        }
        private void CheckEmailField()
        {
            email = "";
            validEmail = false;
            if (EmailTextBox.Text != null && EmailTextBox.Text != "")
            {
                EmailHeading.ForeColor = Color.Black;
                email = EmailTextBox.Text;
                validEmail = true;
            }
            else
            {
                EmailHeading.ForeColor = Color.Red;
                validEmail = false;
            }
        }
        private void CheckPhoneField()
        {
            phone = "";
            validPhone = false;
            if (PhoneTextBox.Text != null && PhoneTextBox.Text != "")
            {
                PhoneHeading.ForeColor = Color.Black;
                phone = PhoneTextBox.Text;
                validPhone = true;
            }
            else
            {
                PhoneHeading.ForeColor = Color.Red;
                validPhone = false;
            }
        }
        private void CheckNumberOfKidsField()
        {
            numberOfKids = 0;
            validNumberOfKids = false;
            if (NumKidsTextBox.Text != null)
            {
                try
                {
                    numberOfKids = Int32.Parse(NumKidsTextBox.Text);
                    NumKidsHeading.ForeColor = Color.Black;
                    validNumberOfKids = true;
                }
                catch
                {
                    NumKidsHeading.ForeColor = Color.Red;
                    validNumberOfKids = false;
                }
            }
            else
            {
                NumKidsHeading.ForeColor = Color.Red;
                validNumberOfKids = false;
            }
        }
        private void CheckNumberOfPetsField()
        {
            numberOfPets = 0;
            validNumberOfPets = false;
            if (NumPetsTextBox.Text != null)
            {
                try
                {
                    numberOfPets = Int32.Parse(NumPetsTextBox.Text);
                    NumPetsHeading.ForeColor = Color.Black;
                    validNumberOfPets = true;
                }
                catch
                {
                    NumPetsHeading.ForeColor = Color.Red;
                    validNumberOfPets = false;
                }
            }
            else
            {
                NumPetsHeading.ForeColor = Color.Red;
                validNumberOfPets = false;
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            AdoptedLabel.Visible = false;
            if (ValidAdopterInput())
            {
                Adopter person = new Adopter(name, phone, email, numberOfKids, numberOfPets);
                animals.Adopt(thisAnimal.AnimalId, person);
                AdoptedLabel.Visible = true;
                AdoptedLabel.Text = "Adopted";
            }
        }
    }
}
