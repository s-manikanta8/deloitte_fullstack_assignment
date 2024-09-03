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
            int id;
            string pname;
            int price;
            int q;

            Console.WriteLine("enter product id : ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter product name : ");
            pname = Console.ReadLine();

            Console.WriteLine("enter unit price : ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter quantity :");
            q = int.Parse(Console.ReadLine());
            int d = 0;
            int ttlp = 0;
            int p = 0;
            if (q > 10)
            {
                p = 10;
            }
            if (q > 30)
            {
                p = 20;
            }
            if (q > 50)
            {
                p = 30;
            }
            if (q > 70)
            {
                p = 40;
            }
            d = (price * q) / p;
            ttlp = (price * q) - d;
            Console.WriteLine("------- bill -------");
            Console.WriteLine("product id : " + id);
            Console.WriteLine("product name : " + pname);
            Console.WriteLine("unit price : " + price);
            Console.WriteLine("quantity : " + q);
            Console.WriteLine("total price : " + q * price);
            Console.WriteLine("discount amount : " + d);
            Console.WriteLine("final amount : " + ttlp);
            Console.ReadLine();
        }
    }
}
