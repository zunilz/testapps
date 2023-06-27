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
}
