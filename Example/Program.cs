using System;
using Figures;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            var circleArea = circle.GetArea();

            Console.WriteLine(circleArea);

            Shape triangle1 = new Triangle(3, 4, 5);
            var triangleArea1 = triangle1.GetArea();

            Console.WriteLine(triangleArea1);

            Triangle triangle2 = new Triangle(6, 8, 10);
            var triangleArea2 = triangle2.GetArea();
            var isRightTriangle = triangle2.IsRightTriangle();

            Console.WriteLine(triangleArea2);
            Console.WriteLine(isRightTriangle);

        }
    }
}
