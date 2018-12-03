using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //стр.100/163

            Console.Write("Въведете a=");             int a = int.Parse(Console.ReadLine());             Console.Write("Въведете b=");             int b = int.Parse(Console.ReadLine());             Console.Write("Въведете c=");             int c = int.Parse(Console.ReadLine());             Console.Write("Въведете d=");             int d = int.Parse(Console.ReadLine());             Console.Write("Въведете p=");             int p = int.Parse(Console.ReadLine());             Console.Write("Въведете q=");             int q = int.Parse(Console.ReadLine());               for (int x = p; x <= q; x++)

                for (int y = p; y <= q; y++)                     for (int z = p; z <= q; z++)                         if (a * x + b * y + c * z + d == 0)


                            Console.WriteLine(x + " " + y + " " + z);             Console.ReadKey(true); 
        }
    }
}
