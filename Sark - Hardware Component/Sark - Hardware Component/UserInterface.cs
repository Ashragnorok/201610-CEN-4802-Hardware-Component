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
            

            lblElevatorName.Text = ElevatorAlpha.getName();
            tbxConsole.Text = ElevatorAlpha.ToString();
            cbxElevatorFloor.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElevatorFloor_Click(object sender, EventArgs e)
        {
            ElevatorAlpha.setDoorState("closed");
            tbxConsole.Clear();
            ElevatorAlpha.gotoFloor(int.Parse(cbxElevatorFloor.SelectedItem.ToString()));
            tbxConsole.Text = ElevatorAlpha.ToString();
        }

        private void btnGroundFloor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
