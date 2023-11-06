using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task5
{
    public class Person
    {
        public Person() {  }
        public Person(string name,string surname,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsAdult = age >= 18;
        }
        public byte Age;
        public bool IsAdult;
        public string Name;
        public string Surname;
    }
}
