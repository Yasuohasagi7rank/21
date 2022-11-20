using System;

namespace _7._36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;       
            Console.Write("Введите кол-во чисел : ");
            int b = Convert.ToInt32(Console.ReadLine());
            double[] c = new double[b];
            int d = 0;
            while (d < b)
            {
                Console.Write("Введите число : ");
                c[d] = Convert.ToDouble(Console.ReadLine());
                d++;
            }
            for (int i = 1; i < b - 1; i++)
            {
                if ((c[i] > c[i - 1]) && (c[i] > c[i + 1]))
                    a++;
                i++;
            }
            Console.WriteLine($"Количество вещественных чисел больше = {a}  ");
            Console.ReadKey();
        }
    }
}
