using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Design_Patterns
{
    public class Singleton
    {
        private static Singleton singleton = null;

        private object objLock = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}
