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
    public partial class ViewRooms : Form
    {
        public ViewRooms()
        {
            InitializeComponent();
        }

        private void ViewRooms_Load(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            RoomsDataGrid.DataSource = animals.OurRooms.Where(r => r.AnimalId != "").OrderBy(r => r.RoomId).Select(r => r).ToArray();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OccupiedRadio_CheckedChanged(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            RoomsDataGrid.DataSource = animals.OurRooms.Where(r => r.AnimalId != "").OrderBy(r => r.RoomId).Select(r => r).ToArray();
        }

        private void EmptyRadio_CheckedChanged(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            RoomsDataGrid.DataSource = animals.OurRooms.Where(r => r.AnimalId == "").Select(r => r).ToArray();
        }

        private void AllRadio_CheckedChanged(object sender, EventArgs e)
        {
            AnimalControl animals = new AnimalControl();
            RoomsDataGrid.DataSource = animals.OurRooms.OrderBy(r => r.RoomId).Select(r => r).ToArray();
        }

    }
}
