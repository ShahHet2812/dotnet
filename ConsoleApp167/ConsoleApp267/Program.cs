using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp267
{
    public delegate int MathOperation(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathOperation Add = (x, y)=>x+y;
            //MathOperation Multiply =(x, y) => x*y;
            //Console.WriteLine(Add(50, 100));
            //Console.WriteLine(Multiply(2,3));

            //MathOperation Add = (x, y) => x + y;
            //Add += (x, y) => x * y;
            //Console.WriteLine(Add(50, 100));
            //Console.WriteLine(Add(2, 3));

            Alarm a=new Alarm();
            SafteySystem s=new SafteySystem();
            a.OnFire += s.Siren;
            a.OnFire += s.FireFighters;
            a.DetectFire();
        }
    }

    public delegate void AlarmDelegate();
    class Alarm {
        public event AlarmDelegate OnFire;

        public void DetectFire()
        {
            Console.WriteLine("fire detected");
            OnFire?.Invoke();
        }
    }

    class SafteySystem
    {
        public void Siren()
        {
            Console.WriteLine("Siren:WE-00-WE");
        }
        public void FireFighters()
        {
            Console.WriteLine("Calling Firefighters");
        }
    }

}
