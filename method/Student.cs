using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04._2024_2_.method
{
    internal class Student
    {
        public int Id { get; private set; }
        public string Name { get; set; } 
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Id = Count++;
            Name = name;
            Surname = surname;
        }

        public string GetInfo()
        {
            return ($"Id: {Id}, Name: {Name}, Surname: {Surname}");
        }
    }
}
}
