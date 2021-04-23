using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFiller.Model
{
    public class Person
    {
        public Person(string firstName,string lastName,int age)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
