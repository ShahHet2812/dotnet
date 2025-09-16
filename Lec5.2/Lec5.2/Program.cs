using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 8;
            Console.Write(p.Age);
        }
    }
    class Person
    {
        private int _age = 15;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 15)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age is below 15");
                }
            }
        }
    }
}