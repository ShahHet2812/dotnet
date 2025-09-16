using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(Temp.Mathup(150, 185));
            Temp.Mathup(150.0, 185.0);*/
            /*Car C1 = new Car();
            Car C2 = new Car();
            Car.number=9340;
            C1.name="Tigor";
            C1.Display();*/
            /*Example e = new Example();
            e.SecretMethod();
            e.callsecret();*/
            /*Parent p = new Parent();
            Child c = new Child();
            p.ProtectedMethod();
            c.callProtected();*/
            /*Animal a = new Animal();
            Dog d = new Dog();
            Cat c = new Cat();
            a.Speak();
            d.Speak();
            c.Speak();
            Animal e = new Dog();
            Animal f = new Cat();
            e.Speak();
            f.Speak();*/
            /*Animall a = new Dogg();
            Animall c = new Catt();
            a.Speak();
            a.Run();
            a.Eat();
            c.Speak();
            c.Run();
            c.Eat();*/

        }
    }
    class Temp
    {
        public static int Mathup(int x, int y)
        {
            return x + y;
        }
        public static void Mathup(double x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
    class Car
    {
        public static int number = 1234;
        public string name = "Punch";
        public readonly int x = 85;
        public const int wheels = 4;
        public static int roofinstance = 0;
        public Car()
        {
            x = 9340;
            roofinstance++;
        }
        public void Display()
        {
            Console.WriteLine(number + " " + name + " " + x + " " + wheels + " ");
            Console.WriteLine($"No of Instances:{roofinstance}");
        }
    }
    class Example
    {
        private void SecretMethod()
        {
            Console.WriteLine("Its a Secret");
        }
        public void callsecret()
        {
            SecretMethod();
        }
    }
    //Protected
    class Parent
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("Its Protected");
        }
    }
    class Child : Parent
    {
        public void callProtected()
        {
            ProtectedMethod();
        }
    }
    //Method Modifiers MIMP
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Hello");
        }
    }
    class Dog : Animal
    {
        public sealed override void Speak()
        {
            Console.WriteLine("Bark");
        }
    }
    class Cat : Animal
    {
        public  override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
    //Error 
    /*class Golden : Dog
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }*/
    abstract class Animall
    {
        public abstract void Speak();
        public abstract void Run();
        public void Eat()
        {
            Console.WriteLine("Pizza");
        }
    }
    class Dogg : Animall
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
        public override void Run()
        {
            Console.WriteLine("Fast");
        }
    }
    class Catt : Animall
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
        public override void Run()
        {
            Console.WriteLine("Slow");
        }
    }

}