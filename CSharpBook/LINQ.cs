using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            foreach (var str in query)
                Console.WriteLine(str);
        }

        //Query Expression 
        public void QueryExpression()
        {
            IEnumerable<string> strings = from word in words
                                          where word.Length > 5
                                          select word;
            IterateGeneric(strings);
        }

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


    }
}
