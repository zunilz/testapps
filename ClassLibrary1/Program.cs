using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Oops;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {

            SameInterfaceMethods sameInterfaceMethods = new SameInterfaceMethods();
            sameInterfaceMethods.methodA();

            ISameA sameA = new SameInterfaceMethods();
            ISameB sameB = new SameInterfaceMethods();

            sameA.methodA();
            sameB.methodA();

            Pyrmaid.printPyramid();

            Galaxy milkyway = new Galaxy("ss");
            Galaxy andromeda = new Galaxy("ss");
        }

       
    }
}