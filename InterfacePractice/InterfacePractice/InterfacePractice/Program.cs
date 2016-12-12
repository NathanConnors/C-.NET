using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }

        static void Main(string[] args)
        {
            Point p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
        }
    }
}
