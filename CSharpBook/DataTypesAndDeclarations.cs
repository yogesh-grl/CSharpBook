using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    internal class DataTypesAndDeclarations
    {
        public DataTypesAndDeclarations()
        {

        }

        public void MainMethod()
        {
            try
            {
                // int 
                int num = 0;

                // float 
                float floatNum = 2;

                //double
                double doubleNum = 3.0;

                //byte 
                byte a = 1;

                //byte array 
                byte[] array = new byte[4] { 1, 2, 3, 4 };//new byte[4];
                array[0] = 1; array[1] = 2; array[2] = 3; array[3] = 4;

                //bool 
                bool boolNum = false;

                //string 
                string sampleString = "Hello";

                //String Builder 
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(sampleString);

            }
            catch (Exception ex) { }
        }
    }
}
