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
    public partial class WelcomeMenu : Form
    {
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAnimalForm form = new AddAnimalForm();
            form.Show();
        }

        private void MassAddButton_Click(object sender, EventArgs e)
        {
            MassAddAnimals form = new MassAddAnimals();
            form.Show();
        }
    }
}
