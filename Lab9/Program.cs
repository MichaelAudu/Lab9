using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Circle Tester");

            bool continueOn =true;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter A Radius");
                double radius;
                bool isValid = double.TryParse(Console.ReadLine(), out radius);

                if (!isValid)
                {
                    Console.WriteLine("Invalid Entry");
                }

                else
                {
                    Circle circle = new Circle(radius);
                    Console.WriteLine("Circumference: {0}",circle.getFormattedCircumference());
                    Console.WriteLine("Area: {0}",circle.getFormattedArea());
                    Console.WriteLine("Continue (Y/N?)");

                    string goOn = Console.ReadLine();
                    continueOn = goOn.ToLower() == "y" ? true : false;
                }

            } while (continueOn);

            Console.WriteLine("Goodbye, You Created {0} Circles",Circle.NumberOfCircles);

        }
    }

   

    class Circle
    {
        public static int NumberOfCircles;

        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        double Circumference;
        double Area;


        public Circle(double radius)


        {
            Circumference = 2 * Math.PI * radius;
            Area = Math.PI * radius * radius;
            NumberOfCircles += 1;

        }

            public double getCircumference()
        {
            return Circumference;
        }

        public string getFormattedCircumference()
        {
            return Circumference.ToString("0.00");
        }

        public double getArea()
        {
            return Area;    
        }

        public string getFormattedArea()
        {
            return Area.ToString("0.00");
        }
        }


}
