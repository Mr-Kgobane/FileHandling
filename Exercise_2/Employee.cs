using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Employee
    {
        string name, surname, job;

        public Employee(string name, string surname, string job)
        {
            this.Name = name;
            this.Surname = surname;
            this.Job = job;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Job { get => job; set => job = value; }

        public string Display()
        {
            return $"{this.Name}, {this.Surname}, {this.Job}";
        }
        public override string ToString()
        {
            return $"First Name: {this.Name} | Last Name: {this.Surname} | Job Title: {this.Job} |";
        }
    }
}
