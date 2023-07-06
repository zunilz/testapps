using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
 

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {



            SingletonDatabaseConnection.getInstance().getConnection();
            SingletonDatabaseConnection.getInstance().getConnection();
            SingletonDatabaseConnection.getInstance().getConnection();

            TestCalss testCalss = new TestCalss();
            testCalss = new TestCalss();

            TestCalss testCalss1 = new TestCalss();

        }

       
    }
}