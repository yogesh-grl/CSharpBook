using CSharpBook.SOLID;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    public class LINQ
    {
        List<string> words = null;

        public LINQ()
        {
            words = new List<string>();
            words.Add("Yogesh");
            words.Add("Balaji");
            words.Add("Gokul");
            words.Add("Saai");
            words.Add("Sivan");
        }

        public void IterateGeneric(dynamic query)
        {
            Console.WriteLine("---------------------------------------------------" +
                " \n" + "---------------------------------------------------");

            foreach (var str in query)
                Console.WriteLine(str);
        }

        /// <summary>
        /// Query Expression -
        /// Where | typeOf
        /// </summary>
        public void QueryExpression()
        {
            IEnumerable<string> strings = from word in words
                                          where word.Length > 5
                                          select word;
            //int count = strings.Count();

            List<string> lsStr = words.Where(s => s.Length > 5).ToList();

            IterateGeneric(strings);
        }

        /// <summary>
        /// Projection Operation -
        /// Select | SelectMany | Zip
        /// </summary>
        public void ProjectionOperation()
        {
            List<int> numbers = new List<int>()
            {
                1,2,3,4
            };

            List<string> strings = new List<string>()
            {
                "One", "Two", "Three"
            };

            var data = numbers.Zip(strings, (f, s) => f + " " + s);
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }
        }

        /// <summary>
        ///Sorting Operation -
        ///OrderBy | OrderBy descending | reverse 
        /// </summary>
        public void SortingData()
        {
            List<string> lsStr = new List<string>()
            {
               "D", "E", "F", "A", "B", "C", "D", "E", "F"
            };

            IEnumerable<string> orderBySample = from word in lsStr
                                                orderby word
                                                select word;
            IterateGeneric(orderBySample);
            IEnumerable<string> orderByDecSample = from word in lsStr
                                                   orderby word descending
                                                   select word;

            IterateGeneric(orderByDecSample);
        }

        /// <summary>
        /// Set Operation -
        /// Distinct | DistinctBy | 
        /// Union | UnionBy
        /// Intersect | IntersectBy 
        /// </summary>
        public void SetOperation()
        {
            //Distinct
            List<string> Planet = new List<string>()
            {
                "Mercury", "Venus", "Jupiter", "Earth", "Mercury", "Earth"
            };

            IEnumerable<string> updatedPlanet = from planet in Planet.Distinct()
                                                select planet;
            IterateGeneric(updatedPlanet);

            //DisticntBy
            List<PlanetClass> planetClasses = new List<PlanetClass>();
            planetClasses.Add(new PlanetClass() { Name = "Mercury", Type = PlanetTye.Gas });
            planetClasses.Add(new PlanetClass() { Name = "Earth", Type = PlanetTye.Gas });
            planetClasses.Add(new PlanetClass() { Name = "Venus", Type = PlanetTye.Rock });
            planetClasses.Add(new PlanetClass() { Name = "Pluto", Type = PlanetTye.Liquid });
            planetClasses.Add(new PlanetClass() { Name = "Moon", Type = PlanetTye.Liquid });
            IEnumerable<PlanetClass> planetClasses1 = from planet in planetClasses.DistinctBy(x => x.Type)
                                                      select planet;
            IterateGeneric(planetClasses1);

            List<string> AnotherPlanet = new List<string>()
            {
                 "Venus", "Jupiter", "Earth", "Mercury", "Mars"
            };


            //Intersect
            IEnumerable<string> updatePlanetIntersect = Planet.Intersect(AnotherPlanet);

            //Union
            IEnumerable<string> updatePlanetUnion = Planet.Union(AnotherPlanet);
        }

        /// <summary>
        /// Joins
        /// </summary>
        public void Joins()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Name= "Anand", EmployeeID= 1, EmployeeDepID = 1},
                new Employee() {Name= "Balaji", EmployeeID= 2, EmployeeDepID = 2},
                new Employee() {Name= "Gokul", EmployeeID= 3 , EmployeeDepID = 2},
                new Employee() {Name= "Sai", EmployeeID= 4 , EmployeeDepID = 3} ,
                new Employee() {Name= "Yogesh", EmployeeID= 5, EmployeeDepID = 2},
                new Employee() {Name= "Mannan", EmployeeID= 5, EmployeeDepID = 4}
            };


            List<Department> departments = new List<Department>()
            {
                new Department(){DepName = "FW", DepID= 1},
                new Department(){DepName = "SW", DepID= 2},
                new Department(){DepName = "QA", DepID= 3},
                new Department(){DepName = "None", DepID= 5}
            };

            var InnerJoinResult = from empl in employees
                                  join dept in departments on empl.EmployeeDepID equals dept.DepID
                                  select new { EmployeName = empl.Name, DepartmentName = dept.DepName };

            var leftJoinQuery = from dept in departments
                                join emp in employees on dept.DepID equals emp.EmployeeDepID into empGroup
                                from emp in empGroup.DefaultIfEmpty()
                                select new { DepartmentName = dept.DepName, EmployeeName = emp?.Name ?? "No employee" };

            var rightJoinQuery = from emp in employees
                                 join dept in departments on emp.EmployeeDepID equals dept.DepID into deptGroup
                                 from dept in deptGroup.DefaultIfEmpty()
                                 select new { EmployeeName = emp.Name, DepartmentName = dept?.DepName ?? "No department" };

            //var fullOuterJoinQuery = rightJoinQuery.Union(leftJoinQuery);
        }

        public void Grup()
        {
            List<Employee> employees = new List<Employee>()
            {

                new Employee(){Name= "Anand", EmployeeID= 1, EmployeeDepID = 1},
                new Employee() {Name= "Balaji", EmployeeID= 2, EmployeeDepID = 2},
                new Employee() {Name= "Gokul", EmployeeID= 3 , EmployeeDepID = 2},
                new Employee() {Name= "Sai", EmployeeID= 4 , EmployeeDepID = 3} ,
                new Employee() {Name= "Yogesh", EmployeeID= 5, EmployeeDepID = 2},
                new Employee() {Name= "Mannan", EmployeeID= 5, EmployeeDepID = 4}
            };


            var grupEmployee = (from emp in employees
                                group emp by emp.EmployeeDepID).ToList();
        }


        public void CustomeFilterExample()
        {
            List<int> lsInt = new List<int>()
            {
                1,2, 3, 4,
            };

            var filterData = lsInt.CustomerFilter(x => x % 2 == 0);

        }
    }


    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int EmployeeDepID { get; set; }
    }


    public class Department
    {
        public string DepName { get; set; }
        public int DepID { get; set; }
    }


    public enum PlanetTye
    {
        Gas,
        Liquid,
        Rock
    }

    public class PlanetClass
    {
        public string Name { get; set; }
        public PlanetTye Type { get; set; }
    }
}
