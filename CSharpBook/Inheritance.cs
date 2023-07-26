using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    public class BaseClass
    {
        public BaseClass()
        {
        }

        public void Method1()
        {
            Console.WriteLine($"Base Class - Method 1");
        }

        public virtual void Method2()
        {
            Console.WriteLine($"Base Class - Method 2");
        }
    }


    public class DerivedClass1 : BaseClass
    {
        public DerivedClass1()
        {
        }

        public void Method3()
        {
            Console.WriteLine("Dervied1 Class - Method 3");
        }
        public new void Method2()
        {
            Console.WriteLine("Dervied1 Class - Method 2");
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public DerivedClass2()
        {
        }

        public void Method3()
        {
            Console.WriteLine("Dervied2 Class - Method 3");
        }

        public override void Method2()
        {
            Console.WriteLine("Dervied2 Class - Method 2");
        }
    }


    public class InheritanceExample
    {
        public InheritanceExample()
        {
        }

        public void MainMethod()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Method1();
            baseClass.Method2();

            Console.WriteLine();
            Console.WriteLine();

            DerivedClass1 derivedClass = new DerivedClass1();
            derivedClass.Method1();
            derivedClass.Method2();
            derivedClass.Method3();

            Console.WriteLine();
            Console.WriteLine();

            BaseClass base1Class = new DerivedClass1();
            base1Class.Method1();
            base1Class.Method2();
            //base1Class.Method3(); it will throw error 

            Console.WriteLine();
            Console.WriteLine();

            BaseClass base2Class = new DerivedClass2();
            base2Class.Method1();
            base2Class.Method2();
            //base2Class.Method3(); it will throw error 

            //derivedClass = new BaseClass(); it will thorw error
        }
    }
}
