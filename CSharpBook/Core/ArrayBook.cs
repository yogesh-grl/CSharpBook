using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Core
{
    internal class ArrayBook
    {
        int[] intArray = null;
        public ArrayBook()
        {
            intArray = new int[] { 1, 2, 3, 4, 5, 6 };
        }

        public void IterateArray()
        {
            try
            {
                for (int i = 0; i < intArray.Length; i++)
                    Console.WriteLine(intArray[i]);
            }
            catch (Exception ex)
            {
            }
        }

        public void InsertElementAtPosition(int position, int elementToInsert)
        {
            try
            {
                int[] newArray = new int[intArray.Length + 1];

                for (int i = 0; i < intArray.Length; i++)
                {
                    newArray[i] = intArray[i];
                }

                newArray[position] = elementToInsert;

                for (int i = position + 1; i < newArray.Length; i++)
                {
                    newArray[i] = intArray[i - 1];
                }

                intArray = newArray;

            }
            catch (Exception ex)
            {
            }
        }
    }
}
