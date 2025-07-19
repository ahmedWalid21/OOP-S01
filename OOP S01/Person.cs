using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal struct Person
    {
        private string name;
        private int  age;
        
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }










    }
}
