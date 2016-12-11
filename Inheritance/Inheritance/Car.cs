using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

		// default constructor.
		public Car()
        {
            maxSpeed = 55;
        }

		// constructors.
		public Car(int max)
        {
            maxSpeed = max;
        }

		public int Speed
        {
			get { return currSpeed; }
            set
            {
                currSpeed = value;
				if(currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }
    
    // if class is sealed it cannot be inherited.
    sealed class MiniVan : Car { }

    // this is an error.
    //class DeluxeMiniVan : MiniVan { }
}
