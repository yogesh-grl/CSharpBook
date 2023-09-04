using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    #region Delegate without Param
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

    #endregion

    #region Delegate with Param 

    public class Cal
    {
        public Cal()
        {
        }

        public void Addition(int a, int b)
        {
            Console.Write(a + b);
        }
    }


    public delegate void SampleDelegateWithParam(int num1, int num2);

    public class DelegatesWithParam
    {
        Cal cal;
        public DelegatesWithParam()
        {
            cal = new Cal();
        }

        public void MainMethod()
        {
            SampleDelegateWithParam delegateObj = new SampleDelegateWithParam(cal.Addition);
            delegateObj.Invoke(1, 2);
        }
    }

    #endregion
}
