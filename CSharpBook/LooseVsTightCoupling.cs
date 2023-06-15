using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    public class Engine : IEngine
    {
        public Engine() { }
        public void Start()
        {
            Console.WriteLine("Engine Start");
        }
    }

    //Tight Coupling 
    public class Car_TightCoupling
    {
        public Engine engine;
        public Car_TightCoupling()
        {
            engine = new Engine();
        }
        public void Start()
        {
            engine.Start();
        }
    }

    //Loose Coupling 

    interface IEngine
    {
        void Start();
    }


    class Car_LooseCoupling
    {
        IEngine _engine;
        public Car_LooseCoupling(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }



    internal class LooseVsTightCoupling
    {
        public LooseVsTightCoupling()
        {
        }

        public void MainMethod()
        {
            //Tight Coupling 
            Car_TightCoupling obj1 = new Car_TightCoupling();
            obj1.Start();


            IEngine objEng = new Engine();
            Car_LooseCoupling obj2 = new Car_LooseCoupling(objEng);
            obj2.Start();

        }

    }
}
