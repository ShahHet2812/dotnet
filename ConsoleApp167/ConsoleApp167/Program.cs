using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp167
{
    public delegate void ProcessOrder(String s);
    internal class Program
    {
        static void Main()
        {
            //List<String> list = new List<String>(){ "Hi", "Mango", "Orange" };
            //list.Add("New Mango");
            //list.Add("Kiwi");
            //list.Insert(0, "Hello");
            //Console.WriteLine(String.Join(",",list));
            //list[2] = "New Hello";
            //list.Remove("Orange");
            //list.RemoveAt(0);
            //Console.WriteLine(String.Join(",",list));
            //list.RemoveAll(n => n.Length > 4);
            //Console.WriteLine(String.Join(",",list));
            //list.Sort();
            //Console.WriteLine(String.Join(",", list));
            //list.Sort((a,b)=>b.CompareTo(a));
            //Console.WriteLine(String.Join(",", list));
            //list.Reverse();
            //Console.WriteLine(list.Contains("Kiwi"));
            //list.FindAll(n => n.Contains("H"));
            //Console.WriteLine(String.Join(",", list.FindAll(n => n.Contains("i"))));
            //Console.WriteLine(String.Join(",", list.FindAll(n => n.StartsWith("H"))));
            //Array a=list.ToArray();

            //Dictionary<int, String> d= new Dictionary<int,String>{ { 1, "banana" }, { 2, "Mango" }, { 3, "kiwi" }, { 4,"PM"} };
            //d.Add(5, "New Mango");
            //d[3] = "New Kiwi";
            //d[6] = "New Mango";
            //d.Remove(5);
            //if (d.ContainsKey(5))
            //{
            //    Console.WriteLine(d[5]);
            //}
            //else
            //{
            //    Console.WriteLine("no value at 5");
            //}
            //String x=d.TryGetValue(6, out String y)?y:"Null";
            //Console.WriteLine(x);

            //int[] a = new int[] { 2, 4, 5, 1, 3 };
            //String[] b = new String[] { "A", "B", "C", "D", "E" };
            //var d= new Dictionary<int, String>();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    d.Add(a[i], b[i]);
            //}
            //foreach(var item in d)
            //{
            //    Console.WriteLine($"Key:{item.Key} Value:{item.Value}");
            //}

            //store roll no and students name in dictionary 
            //1.add at least 3 entries
            //2.
            //3.check if key exist
            //4.display all key value pairs using Foreach loop

            //ProcessOrder PO = Processing;
            //PO += Packing;
            //PO += Dispaching;
            //PO("Laptop");

            //ProcessOrder PO=(String s) =>  Console.WriteLine($"{s} is under process");
            //PO += (String s) => Console.WriteLine($"[packing]{s}");
            //PO += (String s) => Console.WriteLine($"[dispaching]{s}");
            //PO("laptop");

            ProcessOrder PO = delegate (String s) { Console.WriteLine($"{s} is under process"); };
            PO += (String s) => Console.WriteLine($"[packing]{s}");
            PO += (String s) => Console.WriteLine($"[dispaching]{s}");
            PO("laptop");

        }

            //static void Processing(String str)
            //{
            //    Console.WriteLine($"{str} is under process");
            //}
            //static void Packing(String str)
            //{
            //    Console.WriteLine($"[packing]{str}");
            //}
            //static void Dispaching(String str)
            //{
            //    Console.WriteLine($"[dispaching]{str}");
            //}
        
    }
}
