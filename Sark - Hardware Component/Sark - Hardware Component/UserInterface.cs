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
        Elevator ElevatorAlpha = new Elevator("Sark", 0);

        public UserInterface()
        {
            InitializeComponent();
            ElevatorAlpha.SetProgress += SetProgress;
            ElevatorAlpha.ConsoleReadout += ConsoleReadout;
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            lblElevatorName.Text = ElevatorAlpha.Name;
            cbxElevatorFloor.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElevatorFloor_Click(object sender, EventArgs e)
        {
            pbarTimeToComplete.Value = 0;
            ElevatorAlpha.MoveToFloor(int.Parse(cbxElevatorFloor.SelectedItem.ToString()));
        }

        private void btnGroundFloor_Click(object sender, EventArgs e)
        {
            pbarTimeToComplete.Value = 0;
            ElevatorAlpha.MoveToFloor(0);
        }

        public void ConsoleReadout (Elevator console)
        {
            tbxConsole.Clear();
            tbxConsole.Text = "Elevator: " + console.Name + "\r\n" +
                    "\nStatus: " + console.Status + "\r\n" +
                    "\nLast Floor: " + console.lastFloor + "\r\n" +
                    "\nCurrent Floor: " + console.nextFloor + "\r\n" +
                    "\nDoorState" + console.doorState + "\r\n" +
                    "\nOccupied: " + console.Occupied + "\r\n" +
                    "\nWeight: " + console.currentCapacity + "\r\n";
            tbxConsole.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElevatorAlpha.ServiceToggle();
        }

        public void SetProgress(int progress)
        {
            pbarTimeToComplete.Value = progress;
        }
    }
}
 