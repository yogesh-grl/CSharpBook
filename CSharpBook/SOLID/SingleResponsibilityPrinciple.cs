using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.SOLID
{
    /// <summary>
    /// Class reponsible for the sending the Email 
    /// </summary>
    class Email
    {
        public Email(Employee empyData) { }

        public void SendEmail()
        {
            //Send the Employee data via mail to the respective target 
        }
    }

    /// <summary>
    /// Class responsible for adding new employee
    /// </summary>
    class EmployeeData
    {
        public EmployeeData(Employee empyData) { }

        public void AddEmployeeData()
        {
            //add employee 
        }
    }

    /// <summary>
    /// Main Employee model
    /// </summary>
    class Employee
    {
        public Employee()
        {
        }
    }


    internal class SingleResponsibilityPrinciple
    {
        public SingleResponsibilityPrinciple()
        {
        }

        public void MainMethod()
        {

        }
    }
}
