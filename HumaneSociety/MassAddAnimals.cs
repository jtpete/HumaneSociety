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
    public partial class MassAddAnimals : Form
    {
        string cvsFile;
        public MassAddAnimals()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileNameBox.Text = FD.FileName;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Records theseRecords = new Records();
            List<Record> noRoom = new List<Record>();
            List<Record> validRecords = new List<Record>();
            cvsFile = FileNameBox.Text;
            validRecords = theseRecords.ReadInputFile(cvsFile);
            if(validRecords.Count() > 0)
            {
               DialogResult result = MessageBox.Show($"There were {validRecords.Count()} with proper paperwork.  Add these animals to your Humane Society facility if there is space?", "Mass Add", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    noRoom = theseRecords.AcceptAnimalsToHumaneSociety(validRecords);
                }
                else
                {
                    this.Close();
                    MessageBox.Show("No animals were added to your Humane Society.");
                }
                if(noRoom.Count()>0)
                {
                    MessageBox.Show($"We were not able to find rooms for {noRoom.Count()} animals. ");
                }
                else
                    MessageBox.Show($"We accepted {validRecords.Count()} animals.");
            }
        }
    }
}
