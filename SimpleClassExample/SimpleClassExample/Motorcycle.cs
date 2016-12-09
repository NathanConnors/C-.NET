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

        public void displayName()
        {
            Console.WriteLine(driverName);
        }

        /* 
         * If you make a non-default constructor without defining
         * a default you lose the default constructor, however
         * if you do not create a custom constructor then you
         * get a 'free' default constructor.
         */

        // Constructor chaining.
        public Motorcycle()
        {
            Console.WriteLine("Defualt constructor");
        }
        public Motorcycle(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("Integer non-default constructor");
        }

        public Motorcycle(string name)
            : this(1, name)
        {
            Console.WriteLine("String non-default constructor");
        }

        // Master constructor
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("Master constructor called");
            if(intensity > 5)
            {
                intensity = 5;
            }

            driverIntensity = intensity;
            driverName = name;
        }
    }
}
