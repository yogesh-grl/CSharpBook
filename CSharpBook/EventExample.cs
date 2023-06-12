using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    public class CustomeArgs : EventArgs
    {
        public bool IsSuccessful = false;
        public string date = null;
    }


    public class Maths
    {
        public delegate void SampleDeleagte();

        //Event without Args 
        public event SampleDeleagte SampleEvent;

        //Event with Args 
        public delegate void SampleDelegateWithArgs(bool status);

        public event SampleDelegateWithArgs SampleEventWithArgs;

        // Event with custome Args
        public delegate void SampleDelegateWithCustomeArgs(CustomeArgs e) ;
        public event SampleDelegateWithCustomeArgs SampleEventWithCustomeArgs;

        public int a { get; set; }
        public int b { get; set; }

        CustomeArgs CustomeArgsobj { get; set; }
        public Maths(int A, int B)
        {
            this.a = A;
            this.b = B;
        }

        public void Addition()
        {
            SampleEvent();
            SampleEventWithArgs(true);

            CustomeArgsobj = new CustomeArgs();
            CustomeArgsobj.IsSuccessful = true;
            CustomeArgsobj.date = DateTime.Now.ToString();
            SampleEventWithCustomeArgs(CustomeArgsobj);

            Console.WriteLine($"Addition {a + b}");
        }

        public void Subtraction()
        {
            SampleEvent();
            SampleEventWithArgs(false);

            CustomeArgsobj = new CustomeArgs();
            CustomeArgsobj.IsSuccessful = true;
            CustomeArgsobj.date = DateTime.Now.ToString();
            SampleEventWithCustomeArgs(CustomeArgsobj);

            Console.WriteLine($"Subtraction {a - b}");
        }
    }


    internal class EventExample
    {
        Maths objMaths;
        public EventExample()
        {
            objMaths = new Maths(2, 1);
        }


        public void sampleEventAction()
        {
            Console.WriteLine("Event Action");
        }

        public void sampleEvenActionWithArgs(bool Status)
        {
            Console.WriteLine($"Event Action {Status}");
        }

        public void sampleEvenActionWithCustomeArgs(CustomeArgs e)
        {
            Console.WriteLine($"Event Action {e.IsSuccessful} and {e.date}");
        }

        public void MainMethod()
        {
            objMaths.SampleEvent += sampleEventAction;
            objMaths.SampleEventWithArgs += sampleEvenActionWithArgs;

            objMaths.SampleEventWithCustomeArgs += sampleEvenActionWithCustomeArgs;

            objMaths.Addition();
            objMaths.Subtraction();
        }

    }
}
