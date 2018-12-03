using System;

namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //стр.126/213а)

            int j, sum = 0;               Console.Write("Да се изчисли редицата:\n");             Console.Write("1+3+5+7+...+47+49");             Console.Write("\n\n");              Console.Write("\n");             for (j = 1; j <= 49; j += 2)             {                 sum = sum + j;                 Console.Write("{0} ", j);             }             Console.Write("\nСумата е: {0}\n", sum); 
        }
    }
}
