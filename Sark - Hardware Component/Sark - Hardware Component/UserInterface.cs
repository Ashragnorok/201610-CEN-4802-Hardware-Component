﻿using System;
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
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            //


            lblElevatorName.Text = ElevatorAlpha.Name;
            ConsoleReadout();
            cbxElevatorFloor.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElevatorFloor_Click(object sender, EventArgs e)
        {
            ElevatorAlpha.MoveToFloor(int.Parse(cbxElevatorFloor.SelectedItem.ToString()));
            ConsoleReadout();
            //tbxConsole.Text = ElevatorAlpha.ToString();
        }

        private void btnGroundFloor_Click(object sender, EventArgs e)
        {
            ElevatorAlpha.MoveToFloor(0);
            ConsoleReadout();
        }

        private void ConsoleReadout ()
        {
            tbxConsole.Clear();
            tbxConsole.Text = "Elevator: " + ElevatorAlpha.Name + "\r\n" +
                "\nStatus: " + ElevatorAlpha.Status + "\r\n" +
                "\nLast Floor: " + ElevatorAlpha.lastFloor + "\r\n" +
                "\nCurrent Floor: " + ElevatorAlpha.nextFloor + "\r\n" +
                "\nDoorState" + ElevatorAlpha.doorState + "\r\n" +
                "\nOccupied: " + ElevatorAlpha.Occupied + "\r\n" +
                "\nWeight: " + ElevatorAlpha.currentCapacity + "\r\n";

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
