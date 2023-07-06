using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MyClass
    {



    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }

    }
}
