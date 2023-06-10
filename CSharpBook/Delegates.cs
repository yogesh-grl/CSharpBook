using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    public class Calculation
    {
        public Calculation()
        {
        }

        public void Addition()
        {
            Console.WriteLine("Add");
        }

        public void Subtraction()
        {
            Console.WriteLine("Sub");
        }
    }

    public delegate void SampleDeleagte();

    internal class Delegates
    {
        Calculation calculation;

        public Delegates()
        {
            calculation = new Calculation();
        }

        public void MainMethod()
        {
            SampleDeleagte objSampleDelegate = new SampleDeleagte(calculation.Addition);
            objSampleDelegate.Invoke();

            objSampleDelegate += calculation.Subtraction;
            objSampleDelegate.Invoke();

            objSampleDelegate -= calculation.Addition;
            objSampleDelegate.Invoke();
        }
    }
}
