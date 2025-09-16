using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    //Create a class named person with fields id,name,job,salary and than create a list of person object with 4 different entries
    //with above list write lin1 query/*
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>
            {
                new Person() { Id = 1, Name = "ABC", Job = "Developer", Salary = 84000 },
                new Person() { Id = 2, Name = "XYZ", Job = "Designer", Salary = 64000 },
                new Person(){Id = 3, Name = "PQR", Job = "UI Developer", Salary = 48000},
                new Person(){Id = 4, Name = "LLM", Job = "Professor", Salary = 90000}
            };
            var Q = p.Where(n => n.Salary > 50000);
            foreach (var item in Q)
            {
                Console.WriteLine($"Name is:{item.Name} Salary is:{item.Salary}");
            }
            var m = p.Where(n=>n.Salary>50000).Average(n=>n.Salary);
            Console.WriteLine(m);
            var x = p.Where(n => n.Name.Contains("A"));
            foreach(var item in x)
            {
                Console.WriteLine(item.Name);
            }
            var maxval=p.Max(n=>n.Salary);
            Console.WriteLine(maxval);
            var minval = p.Min(n => n.Salary);
            Console.WriteLine(minval);
            var sort = p.OrderBy(n => n.Salary).ThenBy(n=>n.Name);
            foreach(var item in sort)
            {
                Console.WriteLine($"Name:{item.Name} Salary:{item.Salary}");
            }
        }
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Job { get; set; }
            public double Salary { get; set; }
        }
    }
}
