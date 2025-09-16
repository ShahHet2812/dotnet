
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//namespace Lec1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            /*Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(ushort.MaxValue);
//            Console.WriteLine(uint.MaxValue);
//            Console.WriteLine(ulong.MaxValue);
//            Console.WriteLine(float.MaxValue);
//            Console.WriteLine(double.MaxValue);
//            Console.WriteLine(decimal.MaxValue);*/

//            //WAP to indentify whether the number is perfect square or not?
//            /*Console.WriteLine("Enter a Number");
//            int x = int.Parse(Console.ReadLine());
//            double y = Math.Sqrt(x);
//            if (y % 1 == 0)
//            {
//                Console.WriteLine("Perfect Square");
//            }
//            else
//            {
//                Console.WriteLine("Not a perfect Square.");
//            }*/
//            //Temperature Comparator
//            /*Nullable<float> t1 = null;
//            float? t2 = null;
//            Console.WriteLine("Enter First Value");
//            t1 = float.TryParse(Console.ReadLine(), out float str1) ? str1 : (float?)null;
//            Console.WriteLine("Enter Second Value");
//            t2 = float.TryParse(Console.ReadLine(),out float str2) ? str2 : (float?)null;
//            if (t1.HasValue && t2.HasValue)
//            {
//                Console.WriteLine(t1 > t2 ? t1 : t2);
//            }
//            else
//            {
//                Console.WriteLine("Enter Valid Value");
//            }*/
//            //Pallindrome Number
//            /* Console.WriteLine("Enter Your Number");
//             int x=int.Parse(Console.ReadLine());
//             int temp = x;
//             int rev = 0;
//             while (x != 0)
//             {
//                 int p = x % 10;
//                 rev= (rev)*10 + p;
//                 x = x / 10;

//             }
//             if (temp == rev)
//             {
//                 Console.WriteLine("Pallindrome");

//             }
//             else
//             {
//                 Console.WriteLine("Not");
//             }*/
//            //Print 0-9 without 5
//            /* int i = 0;
//             while (i < 10)
//             {
//                 if (i % 5 == 0 && i!=0)
//                 {
//                     i++;
//                     continue;
//                 }
//                 Console.WriteLine(i);
//                 i++;
//             }*/
//            //GoTo Statement
//            /*int i = 0;
//        outerloop: for (; i < 10; i++)
//            {
//                int j = 10;
//                for (; j >= 0; j--)
//                {
//                    if (i == j) {
//                        goto outerloop;
//                    }
//                    Console.WriteLine($"i={i},j={j}");
//                }
//            }
//            Console.WriteLine("Loop Ended");
//        }*/

//        Dictionary<int, string> students = new Dictionary<int, string>();

//            Console.WriteLine("Enter Your 5 names:");
//            int x = string.CompareOrdinal(Console.ReadLine());

//            students.Add(1, "qwe");
//           students.Add(2, "fhs");
//           students.Add(3, "yjswt");
//           students.Add(4, "wharghr");
//           students.Add(5, "rerer");
//           students.Add(6, "ffhhf");


//            foreach (var student in students)
//           {
//               Console.WriteLine($"{student.Key},{student.Value}");
//           }
//            // use the class and obj , consider class as car , c2 as obj ,
//            // carno, cusname,as attribute, and in the end show all the details.
//        }

//    }
//}
//class car
//{
//    public int carno;
//    public string uname;

//    public void display()
//    {
//        Console.WriteLine("uname:"+uname);
//        Console.WriteLine("car number:" + carno);

//    }

//}
//class program
//{
//    static void Main()
//    {
//        car c1 = new car();
//        c1.uname="abc";
//        c1.carno = 123;
//        c1.display();
//    }
//}

// to store stundents info each students has name ,rollno ,
// nand marks, u need to build a method a display their details ,
// create a class to represent the students and
// create 3 obj a s1,s2,s3, show how class and obj are used here


//class student
//{
//    public int rollno;
//    public int marks;
//    public string sname;


//    public void display()
//    {
//        Console.WriteLine("sname:" + sname);
//        Console.WriteLine("marks:" + marks);
//        Console.WriteLine("roll number: " + rollno);
//        Console.WriteLine();
//    }

//}
//class program
//{
//    static void Main()
//    {
//        student s1 = new student();
//        s1.sname = "abc";
//        s1.rollno = 1;
//        s1.marks = 50;
//        s1.display();

//        student s2 = new student();
//        s2.sname = "sfs";
//        s2.rollno = 2;
//        s2.marks = 507;
//        s2.display();

//        student s3 = new student();
//        s3.sname = "iyt";
//        s3.rollno = 3;
//        s3.marks = 500;
//        s3.display();
//    }
//}

//bank ac each acc should store acname,acnum,balance the should supprt two action
//1.deposit the money , 2. display the acc detials with balance.

class acc
{
    public int accno;
    public int balance;
    public string accname;


    public void display()
    {
        Console.WriteLine("sname:" + accname);
        Console.WriteLine("marks:" + balance);
        Console.WriteLine("roll number: " + accno);
        Console.WriteLine();
    }

}
class program
{
    static void Main()
    {
        acc s1 = new acc();
        s1.accname = "abc";
        s1.accno = 1;
        s1.balance = 50;
        s1.display();

        acc s2 = new acc();
        s2.accname = "sfs";
        s2.accno = 2;
        s2.balance = 507;
        s2.display();
    }
}


// over loading same method name with diff parameters
// abstract class = 

