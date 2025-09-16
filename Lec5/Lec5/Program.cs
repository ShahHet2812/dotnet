using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action greet = () => { Console.WriteLine("Hello Students"); };
            greet();
            Action<int, int> NoofStudents = (x, y) => { Console.WriteLine($"There are {x + y} Students"); };
            NoofStudents(20,30);
            Func<int, int, int> Add = (x, y) =>  x + y;
            Console.WriteLine(Add(25, 125));
            Predicate<int> Iseven = (x) =>  x % 2 == 0 ;
            Console.WriteLine(Iseven(20));
        }

    }
}