using DecoratorPattern.Classes;
using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            circle.Draw();
            Console.WriteLine("\n");

            Console.WriteLine("Circle of red border");
            redCircle.Draw();
            Console.WriteLine("\n");

            Console.WriteLine("Rectangle of red border");
            redRectangle.Draw();
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
