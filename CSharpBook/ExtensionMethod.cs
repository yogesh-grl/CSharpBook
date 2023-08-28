using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    static class ExtensionMethod
    {
        public static int IntegerExtensionMethod(this int num)
        {
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                count++;
            }
            return count;
        }

        public static string StringExtensionMethod(this string str)
        {
            return str.ToString() + "Extension";
        }

        public static IEnumerable<T> CustomerFilter<T>(this IEnumerable<T> Source, Func<T, bool> predicate)
        {

            foreach (T source in Source)
            {
                if (predicate(source))
                {
                    yield return source;
                }
            }
        }

    }
}
