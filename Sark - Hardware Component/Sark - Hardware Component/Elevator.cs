using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//
namespace Sark___Hardware_Component
{
    public class Elevator
    {
        internal delegate void SetProgressDelegate(int progress);
        internal event SetProgressDelegate SetProgress;
        
        private const double max_Capacity = 2000;
        private double current_Capacity;
        private string _Name, _Status;
        private int current_Floor;
        private int? next_Floor, last_Floor;
        private int door_State;
        private bool door_Clear, in_Service, _Occupied;

        public Elevator(){
            Name = "De-Fault";
            inService = true;
            currentCapacity = 0;
            currentFloor = 1;
            nextFloor = null;
            lastFloor = null;
            doorState = 0;
            doorClear = false;
        }

        public Elevator(string name, int currentfloor)
        {
            Name = name;
            inService = true;
            currentCapacity = 0;
            currentFloor = currentfloor;
            nextFloor = null;
            lastFloor = null;
            doorState = 0;
            doorClear = false;
        }

        public Elevator(string name)
        {
            Name = name;
            inService = true;
            currentCapacity = 0;
            currentFloor = 1;
            nextFloor = null;
            lastFloor = null;
            doorState = 0;
            doorClear = false;
        }

        public double maxCapacity {
            get { return max_Capacity;}
        }

        public string Name {
            get { return _Name;}
            set { _Name = value ;}
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public int currentFloor {
            get { return current_Floor;}
            set { current_Floor = value ;}
        }

        public int? nextFloor {
            get { return next_Floor;}
            set { next_Floor = value ;}
        }

        public int? lastFloor {
            get { return last_Floor; }
            set { last_Floor = value ;}
        }

        public int doorState {
            get { return door_State; }
            set { door_State = value ;}
        }

        public bool doorClear {
            get { return door_Clear; }
            set { door_Clear = value ;}
        }

        public bool inService {
            get { return in_Service; }
            set { in_Service = value ;}
        }

        public bool Occupied {
            get { return _Occupied; }
            set { _Occupied = value ;}
        }

        public double currentCapacity {
            get { return current_Capacity; }
            set { current_Capacity = value ;}
        }

        public void MoveToFloor(int nextfloor)
        {
            if (inService == false)
            {
                Status = "Elevator not in Service";
            }
            else if (currentFloor == nextfloor)
            {
                Status = "Elevator is already on the correct floor";
            }
            else
            {

                this.lastFloor = this.currentFloor;
                Status = "Elevator Moving to " + nextFloor.ToString();
                FloorTime(currentFloor, nextfloor);
                this.currentFloor = nextfloor;
            }
        }

        //Door State will slide from 0 - 3
        //Where:
        //0 = Locked
        //1 = Closed
        //2 = Open
        //3 = Failed
        public int DoorState(int State)
        {
            switch (State)
            {
                case 0: // Locked 
                    Timer(1);
                    Status = "Door is locked.";
                    doorState = State;
                    break;

                case 1: // Closed
                    Timer(2);
                    Status = "Door is closed.";
                    doorState = State;
                    break;

                case 2: // Open
                    Timer(2);
                    Status = "Door Is Open.";
                    doorState = State;
                    break;

                case 3: // Failed
                    Timer(10);
                    Status = "Door has Failed";
                    inService = false;
                    doorState = State;
                    break;

                default: // 
                    Timer(0);
                    Status = "Critical Logic Error Occured, Closing Door";
                    DoorState(1);
                    MoveToFloor(0);
                    ServiceToggle();
                    break;
            }
            return doorState;
        }

        public void ServiceToggle()
        {
            if(inService == true)
            {
                inService = false;
            }
            else
            {
                inService = true;
            }
        }

        private void Timer(int multiplier)
        {
            int interval = 100 / multiplier;
            for (int i = 0; i < multiplier; i++)
            {
                System.Threading.Thread.Sleep(100);
                SetProgress(interval);
            }
        }
    
        private void FloorTime (int crrntFlr, int? nxtFlr)
        {
            if (nxtFlr == null)
            {
                nxtFlr = 0;
            }

            int temp = (int)nxtFlr - crrntFlr;
            temp = Math.Abs(temp);
            this.Timer(temp);
        }

    }
    /// <>
    /// this is the end of the elevator class
    /// </>
}