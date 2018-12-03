using System;
using System.Text;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // стр.129/2 IIгр.)

            Console.OutputEncoding = Encoding.UTF8;             Console.WriteLine("Въведете ß: ");             double b = double.Parse(Console.ReadLine());             Console.WriteLine("Въведете у: ");             double y = double.Parse(Console.ReadLine());             double A;             A = (b + Math.Pow(Math.Sin(Math.Pow(Math.PI, 4)), 2)) / (Math.Pow(Math.Cos(6), 0.2) + Math.Abs(Math.Atan(y)));              Console.WriteLine("Решението на уравнението е : {0}", A); 
        }
    }
}
