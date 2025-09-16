using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 5, 8, 10, 11 };
            int[] num = new int[]{5,20,25,60};
            int[] y = new int[4] { 100, 45, 65, 90 };
            y[0] = 45;
            y[1] = 60;
            y[2] = 40;
            y[3] = 150;
            int[] z = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for(int i = 0; i < 5; i++)
            {
                z[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",",z));
            foreach(var item in z)
            {
                Console.WriteLine(item);
            }
            Array.Sort(y);
            Console.WriteLine(string.Join(",", y));
            Array.Reverse(num);
            Console.WriteLine(string.Join(",", num));
            Console.WriteLine(Array.IndexOf(z, 300));
            Array.Resize(ref x, 10);
            Console.WriteLine(string.Join(",", x));
            Array.Copy(x, y, 4);
            Console.WriteLine(string.Join(",", x));
        }
    }
}