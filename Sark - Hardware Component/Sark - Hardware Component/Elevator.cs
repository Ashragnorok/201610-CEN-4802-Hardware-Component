using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sark___Hardware_Component
{
    public class Elevator
    {
        private const double max_Capacity = 2000;
        private double current_Capacity;
        private string _Name;
        private int current_Floor;
        private Nullable<int> next_Floor, last_Floor;
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

        public int currentFloor {
            get { return current_Floor;}
            set { current_Floor = value ;}
        }

        public Nullable<int> nextFloor {
            get { return next_Floor;}
            set { next_Floor = value ;}
        }

        public Nullable<int> lastFloor {
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
            
            this.lastFloor = this.currentFloor;
            this.currentFloor = nextfloor;
        }

        //Door State will slide from 0 - 5
        //Where:
        //0 = Locked
        //1 = Closed
        //2 = Closing
        //3 = Opening
        //4 = Open
        //5 = Failed
        public void DoorOperator(int State)
        {
            switch (State)
            {
                case 0: // Locked

                    break;
                case 1: // Closed

                    break;
                case 2: // Closing

                    break;
                case 3: // Opening

                    break;
                case 4: // Open

                    break;
                case 5: // Failed

                    break;
                default: // 

                    break;
            }
        }



    }
    /// <>
    /// this is the end of the elevator class
    /// </>
}