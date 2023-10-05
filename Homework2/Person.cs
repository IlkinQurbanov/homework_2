using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Add null ola bilmez.");
            }

            this.Name = name;
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Position { get; set; }

        public Employee(string name, double salary, string position)
            : base(name)
        {
            this.Salary = salary;
            this.Position = position;
        }

        public override string ToString()
        {
            return $"Ad: {Name}, Maash: {Salary}, Pozisiya: {Position}";
        }
    }

}
