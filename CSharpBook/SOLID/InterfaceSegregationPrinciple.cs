using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.SOLID
{

    public interface IEmployee
    {
        string Name { get; set; }
        double CalculateSalary();
    }


    public interface IManage
    {
        void AssignTask();
    }

    public class PermanentEployee : IEmployee, IManage
    {
        public string Name { get; set; }

        public double MonthlySalary { get; set; }
        public void AssignTask()
        {
            Console.WriteLine("Task Assigned");
        }

        public double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    public class TempEployee : IEmployee
    {
        public string Name { get; set; }

        public double HrsRate { get; set; }

        public double HrsWorked { get; set; }

        public double CalculateSalary()
        {
            return HrsRate * HrsWorked;
        }
    }


    internal class InterfaceSegregationPrinciple
    {
        public InterfaceSegregationPrinciple()
        {

        }

        public void MainMethod()
        {

        }
    }
}
