using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //стр.42/53

            Console.WriteLine(" Функция sgn(x)");             Console.Write("  x = ");             int x = int.Parse(Console.ReadLine());              double n;             if (x < 0)             {                 n = System.Math.Sign(x);                 Console.WriteLine(" sgn(x)= {0}", n);             }             else if (x == 0)             {                 n = System.Math.Sign(x);                 Console.WriteLine(" sgn(x) = {0}", n);             }             else if (x > 0)             {                 n = System.Math.Sign(x);                 Console.WriteLine(" sgn(x) = {0}", n);             }             else             {                 Console.WriteLine(" Невалидни стойности за функцията !");             } 
        }
    }
}
