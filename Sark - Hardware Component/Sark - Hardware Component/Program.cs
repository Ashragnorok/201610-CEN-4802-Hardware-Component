using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sark___Hardware_Component
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserInterface testForm = new UserInterface();
            testForm.ShowDialog();

            Elevator elwood = new Elevator();
            //elwood.openElevator();
            Console.WriteLine(elwood);
            elwood.setDoorState("opened");
            //System.Threading.Thread.Sleep(2000);
            Console.Write("\nWhich Floor? : ");
            string x = Console.ReadLine();       
            elwood.setDoorState("closed");
            int floor = int.Parse(x);
            bool isValid;
            while (floor != -1)
            {
                elwood.gotoFloor(floor);
                Console.WriteLine(elwood.getElevatorState());
                Console.WriteLine(elwood);
                Console.Write("\nWhich Floor? (enter -1 to quit): ");
                x = Console.ReadLine();
                elwood.setDoorClear(true);
                elwood.closeElevator();
                isValid = int.TryParse(x, out floor);
            }
        }
    }
}
