using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.OOPS
{
    /// <summary>
    /// Polymorphism - Many form 
    /// It will treat the obj of diff classes to a common super class
    /// </summary>
    internal class Polymorphism
    {
        //Obj for TestCaase1 
        TestCase testCase1 = new TestCase1();
        //Obj for TestCaase
        TestCase testCase2 = new TestCase2();

        public void MainMethod()
        {
            testCase1.Configuration();
            testCase1.Validation();

            testCase2.Configuration();
            testCase2.Validation();
        }
    }

    /// <summary>
    /// Primary Class
    /// </summary>
    public abstract class TestCase
    {
        public abstract void Configuration();
        public abstract void Validation();

    }

    public class TestCase1 : TestCase
    {
        public TestCase1() { }

        public override void Configuration()
        {
            Console.WriteLine("$Class 1 - Config");
        }

        public override void Validation()
        {
            Console.WriteLine("$Class 1 - Validation");
        }
    }

    public class TestCase2 : TestCase
    {
        public TestCase2() { }

        public override void Configuration()
        {
            Console.WriteLine("$Class 1 - Config");
        }

        public override void Validation()
        {
            Console.WriteLine("$Class 1 - Validation");
        }
    }
}
