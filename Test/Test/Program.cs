using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate void BankHandler();
    class Bank
    {
        public static int an = 12345;
        public static int bal = 15000;
        public event BankHandler OnLowBalance;
        public void withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw");
            int with=int.Parse(Console.ReadLine());
            bal -= with;
            if (bal < 1000) {
                OnLowBalance?.Invoke();
            }
            else
            {
                Console.WriteLine($"Transaction successful.Remaining Balance is {bal}");
            }
        }
    }
    class Customer
    {
        public void Warning()
        {
            Console.WriteLine($"Alert:Account{Bank.an} has Low Balance and Rs {Bank.bal}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create c# console app that demonstrate use of deligate
            //and events through bank acc notification system.
            //Requirements
            //1) Bank Handler is a deligate type
            //2)Class is Bank
            //3)Within the class define fields as acc no.,balance
            //4)Define event on low balance
            //5)Define method withdraw
            //Class customer define method warning
            //When balance goes below 1000 display alert account:acc.no. has low balance
            Bank b=new Bank();
            Customer c=new Customer();
            b.OnLowBalance += c.Warning;
            b.withdraw();
        }
    }
}