using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sark___Hardware_Component
{
    public class Elevator
    {
        private int MaxCapacity;
        private string Name;
        private int CurrentFloor;
        private Nullable<int> NextFloor, LastFloor;
        private int DoorState;
        private bool DoorClear, InService, Occupied;

        //default contructor
        public Elevator()
        {
            Name = "Debug Elevator";
            InService = true;
            MaxCapacity = 6;
            NextFloor = null;
            LastFloor = null;
            DoorState = 0;
            DoorClear = false;
        }

        //constructor public
        public Elevator(string elevatorName, int currentFloor)
        {
            Name = elevatorName;
            CurrentFloor = currentFloor;
            NextFloor = null;
            LastFloor = null;
            DoorState = 0;
            DoorClear = false;
            InService = true;
        }

        //contructor
        private Elevator(string elevatorName, int currentFloor, Nullable<int> nextFloor,
        Nullable<int> lastFloor, int doorState, bool doorClear, bool inService)
        {
            Name = elevatorName;
            CurrentFloor = currentFloor;
            NextFloor = nextFloor;
            LastFloor = lastFloor;
            DoorState = doorState;
            DoorClear = doorClear;
            InService = inService;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public int getCurrentFloor()
        {
            return CurrentFloor;
        }

        public void setCurrentFloor(int currentFloor)
        {
            CurrentFloor = currentFloor;
        }

        public int getNextFloor()
        {
            return (int)NextFloor;
        }

        public void setNextFloor(int nextFloor)
        {
            NextFloor = nextFloor;
        }

        public int getLastFloor()
        {
            return (int)LastFloor;
        }

        public void setLastFloor(int lastFloor)
        {
            LastFloor = lastFloor;
        }

        public bool getDoorClear()
        {
            return DoorClear;
        }

        public void setDoorClear(bool doorClear)
        {
            DoorClear = doorClear;
        }

        public bool getInService()
        {
            return InService;
        }

        public int getDoorState()
        {
            return DoorState;
        }

        public void setDoorState(int doorState)
        {
            if (doorState >= 0 && doorState <= 4)
            {
                DoorState = doorState;
            }
        }

        //toString()
        public override string ToString()
        {
            string s = "";
            s = "Name: " + Name + "\r\nInService: " + InService + "\r\nCurrentFloor: " + CurrentFloor
            + "\r\nNextFloor: " + NextFloor + "\r\nLastFloor: " + LastFloor
            + "\r\nDoorState: " + showDoorState() + "\r\nDoorClear: " + DoorClear;
            return s;
        }

        // setting the door state 
        public void setDoorState(string doorState)
        {
            switch (doorState)
            {
                case "closed":
                    setDoorState(0);
                    break;
                case "closing":
                    setDoorState(3);
                    break;
                case "opened":
                    setDoorState(2);
                    break;
                case "opening":
                    setDoorState(1);
                    break;
                default:
                    break;
            }
        }
        //display door state 
        public string showDoorState()
        {
            string s = "";
            if (DoorState == 0)
            { s = "DoorClosed"; }
            if (DoorState == 1)
            { s = "DoorOpening"; }
            if (DoorState == 2)
            { s = "DoorOpen"; }
            if (DoorState == 3)
            { s = "DoorClosing"; }
            return s;
        }

        public async void gotoFloor(int nextFloor)
        {
            if (getDoorState() == 0 && nextFloor <= 5)
            {
                NextFloor = nextFloor;
                await Task.Delay(ETA());
                openElevator();
                arrivedAtFloor();
                await Task.Delay(100);
            }

        }

        public void arrivedAtFloor()
        {
            Console.WriteLine("\nyou have arrived");
            LastFloor = CurrentFloor;
            CurrentFloor = (int)NextFloor;
            NextFloor = null;
        }

        public int ETA()
        {
            int t = 0;
            t = (int)NextFloor - CurrentFloor;
            t *= 100;
            if (t < 0)
            {
                t *= -1;
            }
            return t;
        }

        //this tells you if the elevator is headed up or down. 
        public string getElevatorState()
        {
            string s = "\nArrived_At_Floor";
            if (NextFloor != null)
            {
                if ((CurrentFloor - (int)NextFloor) < 0)
                { s = "\nGoing_UP"; }
                if ((CurrentFloor - (int)NextFloor) > 0)
                { s = "\nGoing_DOWN"; }
                if ((CurrentFloor - (int)NextFloor) == 0)
                { s = "\nyou're already there..."; }
            }
            return s;
        }


        public async void openElevator()
        {
            if (DoorState == 0 || DoorClear == true)
            {
                DoorState = 1;
                Console.WriteLine("\nthe door is opening. ");
                await Task.Delay(500);
                DoorState = 2;
                Console.WriteLine("\nthe door is opened. ");
            }
        }

        public async void closeElevator()
        {
            if (DoorState == 2 && DoorClear == true)
            {
                DoorState = 3;
                Console.WriteLine("\nthe door is closing. ");
                await Task.Delay(500);
                DoorState = 0;
                Console.WriteLine("\nthe door is closed. ");
            }
        }
    }
    /// <>
    /// this is the end of the elevator class
    /// </>
}
