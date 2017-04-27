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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            List<DisplayAnimal> displayAnimals = new List<DisplayAnimal>();
            displayAnimals.AddRange(animals.OurAnimals.Select(a => { return new DisplayAnimal(a); }));
            SearchResultsTable.DataSource = displayAnimals;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefineButton_Click(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            List<DisplayAnimal> displayAnimals = new List<DisplayAnimal>();
            displayAnimals.AddRange(animals.OurAnimals.Where(a =>
            {
                if (!TypeCheckBox.Checked && !ColorCheckBox.Checked && !ShotsCheckBox.Checked)
                    return true;
                else if (TypeCheckBox.Checked && ColorCheckBox.Checked && ShotsCheckBox.Checked)
                {
                    if (TypeBox.Text.ToLower() == a.Type.ToLower() && ColorBox.Text.ToLower() == a.TheseTraits.Color.ToLower() && a.ThisHealth.HadShots)
                        return true;
                    else
                        return false;
                }
                else if (TypeCheckBox.Checked && ColorCheckBox.Checked)
                {
                    if (TypeBox.Text.ToLower() == a.Type.ToLower() && ColorBox.Text.ToLower() == a.TheseTraits.Color.ToLower())
                        return true;
                    else
                        return false;
                }
                else if (TypeCheckBox.Checked && ShotsCheckBox.Checked)
                {
                    if (TypeBox.Text.ToLower() == a.Type.ToLower() && a.ThisHealth.HadShots)
                        return true;
                    else
                        return false;
                }
                else if (TypeCheckBox.Checked && TypeBox.Text.ToLower() == a.Type.ToLower())
                    return true;
                else if (ColorCheckBox.Checked && ShotsCheckBox.Checked)
                {
                    if (ColorBox.Text.ToLower() == a.TheseTraits.Color.ToLower() && a.ThisHealth.HadShots)
                        return true;
                    else
                        return false;
                }
                else if (ColorCheckBox.Checked && ColorBox.Text.ToLower() == a.TheseTraits.Color.ToLower())
                    return true;
                else if (ShotsCheckBox.Checked && a.ThisHealth.HadShots)
                    return true;
                else
                    return false;
            }).Select(a => { return new DisplayAnimal(a); }));
            SearchResultsTable.DataSource = displayAnimals;
        }
    }
}
