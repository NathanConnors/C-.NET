using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name)
        {
            this.name = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeee Haaaaaeewww!");
            }
        }

        /* 
         * If you make a non-default constructor without defining
         * a default you lose the default constructor, however
         * if you do not create a custom constructor then you
         * get a 'free' default constructor.
         */

        // Default Constructor
        public Motorcycle() { }

        // Non-Default Constructor
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}
