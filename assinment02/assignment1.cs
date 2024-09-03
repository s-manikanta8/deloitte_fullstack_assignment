using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string job;
            int id1;
            int sal;

            Console.WriteLine("enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("enter your id : ");
            id1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your job: ");
            job = Console.ReadLine();
            Console.WriteLine("enter your salary:");
            sal = int.Parse(Console.ReadLine());


            Console.WriteLine("------- Employ Details -------");
            Console.WriteLine("Employ Name : " + name);
            Console.WriteLine("Employ Id : " + id1);
            Console.WriteLine("Employ Job : " + job);
            Console.WriteLine("Employ salary : " + sal);
            Console.ReadLine();
        }
    }
}