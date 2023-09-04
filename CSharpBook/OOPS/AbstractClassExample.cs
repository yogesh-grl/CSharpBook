using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpBook.OOPS
{
    public abstract class Vehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }       

        public Vehicle(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public abstract void Brand();

        public abstract void Model();

        public virtual void VehicleNumber()
        {
            Console.WriteLine("Vehicle Number");
        }
    }

    public class Nissan : Vehicle
    {
        public int ID = 0;
        public string Name = "";


        public Nissan(int iD, string name) : base(iD, name)
        {
            ID = iD;
            Name = name;
        }

        public override void Brand()
        {
            Console.WriteLine($"Brand - {Name}");
        }

        public override void Model()
        {
            Console.WriteLine("Model - XL");
        }

        //Calling virtual method
        public override void VehicleNumber()
        {
            Console.WriteLine("TN 30 AB 1234");
        }
    }

    public class Suzuki : Vehicle
    {

        public int ID = 0;
        public string Name = "";

        public Suzuki(int iD, string name) : base(iD, name)
        {
            ID = iD;
            Name = name;
        }

        public override void Brand()
        {
            Console.WriteLine($"Brand - {Name}");
        }

        public override void Model()
        {
            Console.WriteLine("Model - GT");
        }

        //Calling virtual method
        public override void VehicleNumber()
        {
            Console.WriteLine("TN 30 AB 5678");
        }
    }

    public class AbstractClassExample
    {
        public AbstractClassExample()
        {

        }

        public void MainMethod()
        {
            //Vehicle vehicle = new Vehicle(1, "Vehicle"); // we cannt create the instance for the abstract class :: Becoz no implementation for the members 

            Suzuki objSuzuki = new Suzuki(1, "Suzuki");
            objSuzuki.Brand();
            objSuzuki.Model();
            objSuzuki.VehicleNumber();

            Console.WriteLine("");
            Console.WriteLine("");

            Nissan objNissan = new Nissan(1, "Nissan");
            objNissan.Brand();
            objNissan.Model();
            objNissan.VehicleNumber();
        }
    }

}
