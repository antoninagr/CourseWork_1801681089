using System;

namespace _06_Task
{
    class Program
    {
        // стр. 219/395
        static double CelF(double f)         {             double c = 5.0 / 9.0 * (f - 32);             return c;         }         static double Tmax(double[] arr)         {             double max;             double n = arr.Length;             max = arr[0];             for (int i = 1; i < n; i++)              {                 if (arr[i] > max)                 {                     max = arr[i];                 }              }             return max;         }          static void Main()         {             Console.Write("Въведете темпертура във Фаренхайт: ");             double f = double.Parse(Console.ReadLine());             Console.WriteLine("\nТемпертурата в Целзий е: {0:F1}", CelF(f));               Console.Write("\nМесец: ");             string m = Console.ReadLine();             double[] arr = new double[31];              for (int i = 0; i < arr.Length; i++)             {                 Console.Write("Въведете среднодневната темпертура по дни във Фаренхайт(31 пъти): "); 
                double ft = double.Parse(Console.ReadLine());                  if (ft >= -100 && ft <= 100)                 {                     arr[i] = ft;                 }                 else                 {                     Console.WriteLine("Невалиднa температурa!");                 }             }               Console.WriteLine("\nМаксималната температура за месец {0} във Фаренхайт е: {1:F1}", m, Tmax(arr));             Console.WriteLine("Максималната температура за месец {0} в Целзий е: {1:F1}\n", m, CelF(Tmax(arr)));               double[] arr1 = new double[arr.Length]; ;             for (int i = 0; i < arr.Length; i++)             {                 arr1[i] = CelF(arr[i]);                 if (arr1[i] <= -10)                 {                     
                    Console.WriteLine("Среднодневните температури по-ниски от -10(по целзий) за {0} са: {1:F1} ", m, arr1[i]);                 }             }


        }
    }
}

