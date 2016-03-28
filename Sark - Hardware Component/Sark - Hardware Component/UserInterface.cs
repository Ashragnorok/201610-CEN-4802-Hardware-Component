using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sark___Hardware_Component
{
    public partial class UserInterface : Form
    {
        Elevator ElevatorAlpha = new Elevator("Elevator Alpha", 0);

        public UserInterface()
        {
            InitializeComponent();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            //


            lblElevatorName.Text = ElevatorAlpha.Name;
            tbxConsole.Text = ElevatorAlpha.ToString();
            cbxElevatorFloor.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElevatorFloor_Click(object sender, EventArgs e)
        {
            tbxConsole.Clear();
            ElevatorAlpha.MoveToFloor(int.Parse(cbxElevatorFloor.SelectedItem.ToString()));
            ConsoleReadout();
            //tbxConsole.Text = ElevatorAlpha.ToString();
        }

        private void btnGroundFloor_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsoleReadout ()
        {
            tbxConsole.Text = "Elevator: " + ElevatorAlpha.Name +
                "\nLast Floor: " + ElevatorAlpha.lastFloor +
                "\nCurrent Floor: " + ElevatorAlpha.nextFloor +
                "\nDoorState" + ElevatorAlpha.doorState +
                "\nOccupied: " + ElevatorAlpha.Occupied +
                "\nWeight: " + ElevatorAlpha.currentCapacity;

        }
    }
}
