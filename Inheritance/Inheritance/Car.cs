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

		public int speed
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
}
