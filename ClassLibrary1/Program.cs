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

            Child c = new Child();
            c.Foo(10);
            Parent p = new Child();
            p.Foo(10);
            p.LoadFoo(5);
            p.LoadFoo(5, 9);
            p.LoadFoo2(4,5,3);
            p.LoadFoo2(4, 5);
            //p.LoadFoo2(4);
            p.NamedParamFoo(z: "wfsdfsfd");
            p.NamedParamFoo(x: 1);
            Parent pp = new Parent();
            pp.Foo(10);
        }

       
    }

    class Parent
    {
        public virtual void Foo(int x)
        {
            Console.WriteLine("Parent.Foo(int x)");
        }

        public int LoadFoo(int x)
        {
            Console.WriteLine("LoadFoo(int x)");
            return 0;
        }
        public int LoadFoo(int z, int r = 0)
        {
            Console.WriteLine("LoadFoo(int z, int r = 0)");
            return 0;
        }

        public void LoadFoo2(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("Foo(int x, int y = 5, int z = 10)");
        }

        public void LoadFoo2(int x, int y = 5)
        {
            Console.WriteLine("Foo(int x, int y = 5)");
        }

        public int NamedParamFoo(int x)
        {
            Console.WriteLine("NamedParamFoo(int x)");
            return 0;
        }
        public int NamedParamFoo(string z)
        {
            Console.WriteLine("NamedParamFoo(string z)");
            return 0;
        }
    }

    class Child : Parent
    {
        public override void Foo(int x)
        {
            Console.WriteLine("Child.Foo(int x)");
        }

        public void Foo(double y)
        {
            Console.WriteLine("Child.Foo(double y)");
        }
    }

 
}