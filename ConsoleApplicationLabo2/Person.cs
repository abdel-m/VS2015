using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public abstract class Person
    {
        
        public Person(String name, String lastName)
        {
            Name = name;
            Lastname = lastName;
        }
        public string Lastname
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
