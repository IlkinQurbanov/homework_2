using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine());
                string position = Console.ReadLine();

                employees.Add(new Employee(name, salary, position));
            }

            int filter = int.Parse(Console.ReadLine());

            if (filter == 1)
            {
                string search = Console.ReadLine();

                List<Employee> filteredEmployees = employees.Where(e => e.Name.ToLower().Contains(search.ToLower())).ToList();

                foreach (Employee employee in filteredEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
