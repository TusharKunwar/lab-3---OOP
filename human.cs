using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Human
    {
        public int no_of_finger;
        public string FoodType;

        // Constructor
        public Human(int noOfFinger)
        {
            no_of_finger = noOfFinger;
        }

        public void print_no_of_finger()
        {
            Console.WriteLine("No. of finger: " + no_of_finger);
        }

        public void DisplayBehaviour()
        {
            Console.WriteLine("He is " + FoodType);
        }
    }
}
