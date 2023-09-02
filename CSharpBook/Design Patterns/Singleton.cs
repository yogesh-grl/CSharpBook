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
        static object lockObj = new object();

        static Singleton Instance;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (lockObj)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }
}
