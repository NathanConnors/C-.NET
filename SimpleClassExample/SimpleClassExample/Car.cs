using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;

        // Default Constructor.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Non-Default Constructors
        public Car(string petName)
        {
            this.petName = petName;
        }

        public Car(string petName, int currSpeed)
        {
            this.petName = petName;
            this.currSpeed = currSpeed;
        }

        // The functionality of the Car.
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
