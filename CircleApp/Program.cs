using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();

            Console.Write(" Enter your Input Radious Value ");
            aCircle.radious = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(" Area is " + aCircle.GetArea(aCircle.radious));

            Console.ReadKey();

        }
    }
}
