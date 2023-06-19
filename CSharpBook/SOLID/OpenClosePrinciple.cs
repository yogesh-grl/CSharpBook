using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.SOLID
{

    public abstract class Shape
    {
        public abstract void CalculateArea();
    }

    public class Circle : Shape
    {
        public double radius { get; set; }
        public Circle() { }

        public override void CalculateArea()
        {
            Console.WriteLine(Math.PI * radius * radius);
        }
    }

    public class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }


        public override void CalculateArea()
        {
            Console.WriteLine(length * width);
        }
    }

    public class AreaCalculator
    {
        Shape shape;
        public AreaCalculator(Shape shape)
        {
            this.shape = shape;
        }

        public void AreaCalculation()
        {
            shape.CalculateArea();
        }
    }


    internal class OpenClosePrinciple
    {

        Shape objCircleShape;
        Shape objRectangleShape;


        public OpenClosePrinciple()
        {
            objCircleShape = new Circle() { radius = 5 };
            objRectangleShape = new Rectangle() { length = 4, width = 5 };
        }

        public void MainMethod()
        {
            AreaCalculator objCircleArea = new AreaCalculator(objCircleShape);
            objCircleArea.AreaCalculation();

            AreaCalculator objRectangleArea = new AreaCalculator(objRectangleShape);
            objRectangleArea.AreaCalculation();
        }
    }
}
