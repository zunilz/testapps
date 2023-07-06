using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Interfaces
    {

    }


    interface IOne
    {
        void m1();
        void m2();
        void m3();
    }

    abstract class P : IOne
    {
        public void m1()
        {
            throw new NotImplementedException();
        }

        public void m2()
        {
            throw new NotImplementedException();
        }

        public abstract void m3();
    }

    class C: P
    {
        public override void m3() 
        { 
            throw new NotImplementedException();
        }
    }


    //
    interface ISameA
    {
        void methodA();
    }

    interface ISameB
    {
        void methodA();
    }

    class SameInterfaceMethods : ISameA, ISameB
    {
        public void methodA()
        {
            Console.WriteLine("Default: methodA");
        }

        // Explicit implementation
        void ISameA.methodA()
        {
            Console.WriteLine("ISameA.methodA");
        }

        // Explicit implementation
        void ISameB.methodA()
        {
            Console.WriteLine("ISameB.methodA");
        }
    }

 
    public static class Pyrmaid
    {
        public static void printPyramid()
        {
            int length = 30;
            string[] strings = new string[length+1];
            char[] array = new char[length+1];
            for (int i = 0; i < length; i++)
            {
                array[i] = '*';
            }

            for (int i = length; i > 0; i--)
            {
                int diff = length - i;
                for (int j = 0; j < diff; j++)
                {
                    array[j] = ' ';
                }
                for (int k = length; k > length-diff; k--)
                {
                    array[k] = ' ';
                }

                Console.WriteLine(string.Join("",array));
            }
        }
    }

    public class Galaxy
    {
        public string name_code;
        private Galaxy()
        {
            Console.WriteLine("New Star Private");
        }
 

        static Galaxy()
        {
            Console.WriteLine("New Star Static");
        }

        public Galaxy(string name)
        {
            name_code = name;
            Console.WriteLine("New Star Param Const");
        }
    }

    

}
