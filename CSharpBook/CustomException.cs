using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{
    internal class CustomException : Exception
    {
        public CustomException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
