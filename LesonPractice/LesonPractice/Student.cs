using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesonPractice
{
    internal class Student
    {

        public string name;
        public string surname;
        public int age;
        public string address;

        public string GetFullName()
        {
            return name+ " " + surname;
        }


    }
}
