using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    public class EnumsProblem
    {
        public enum SOLIDPrinciples
        {
            SOLID_S,
            SOLID_O,
            SOLID_L,
            SOLID_I,
            SOLID_D,
        }

        public enum LINQEnums
        {
            Query,
            ProjectionOperation,
            SortingData,
            SetOperation,
            Join,
            Grup,
            None
        }


        public enum LINQJoins
        {
            InnerJoin,
            OuterJoin,
            LeftJoin,
            RightJoin
        }


        public enum Problem
        {
            AbstractClass = 1,
            Inheritance = 2,
            Interface = 3,
            Delegates = 4,
            MultiThreading = 5,
            AsyncAwait = 6,
            Events = 7,
            LooseCouplingVsTightCoupling = 8,
            SOLIDDesignPrinciples = 9,
            Workout = 10,
            LINQ = 11,
            DesignPatterns = 12,
            Overloading =13
        }
    }
}
