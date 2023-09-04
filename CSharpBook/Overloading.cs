using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    public class Complex
    {
        private int Real = 0;
        private int Imaginary = 0;
        public Complex(int R, int I)
        {
            Real = R;
            Imaginary = I;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real, a.Imaginary * b.Imaginary);
        }

        public override string ToString()
        {
            return ($"{Real} + {Imaginary}i");
        }
    }

    internal class Overloading
    {
        public Overloading()
        {

        }

        public void MainMethod()
        {
            //Operator Overloading 
            Complex ComplexItem1 = new Complex(1, 2);
            Console.WriteLine(ComplexItem1.ToString());

            Complex ComplexItem2 = new Complex(2, 3);
            Console.WriteLine(ComplexItem2.ToString());

            Complex ComplexAddition = ComplexItem1 + ComplexItem2;
            Console.WriteLine(ComplexAddition.ToString());

            Complex ComplexMultiply = ComplexItem1 * ComplexAddition;
            Console.WriteLine(ComplexMultiply.ToString());

        }

    }
}
