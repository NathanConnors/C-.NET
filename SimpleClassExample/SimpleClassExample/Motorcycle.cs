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
        public string driverName;

        public void SetDriverName(string name)
        {
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
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

        // Constructor Chaining.
        public Motorcycle() { }
        public Motorcycle(int intensity)
            : this(intensity, "") { }
        public Motorcycle(string name)
            : this(0, name) { }

        // Master constructor
        public Motorcycle(int intensity, string name)
        {
            if(intensity > 5)
            {
                intensity = 5;
            }

            driverIntensity = intensity;
            driverName = name;
        }
    }
}
