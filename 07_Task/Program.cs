using System;

namespace _07_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //стр.206/361

            Console.WriteLine("A*A, B*B, C*C, D*D, E*E, A*A, G*G, A*A");             string S = "A*A, B*B, C*C, D*D, E*E, A*A, G*G, A*A";             string z = S.Replace("A*A", "sqr(A)");             Console.WriteLine(z);
        }
    }
}
