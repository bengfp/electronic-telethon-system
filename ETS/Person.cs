using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSClassLibrary
{
    abstract class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual string toString()
        {
            return "First Name: " + firstName + "\nLast Name: " + lastName;
        }


    }
}
