using System;
using System.Collections.Generic;

namespace CodeBlog_1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0,100));
                continue;
                Console.WriteLine("AAAH");
            }
            var g = 0;
            while (g < 10)
            {
                Console.WriteLine(g);
                g++;
                if(g == 5)
                {
                    break;
                }
            }
            var z = 0;
            do
            {
                Console.WriteLine("Yep, Anders Colsefni");
                z++;
            }
            while (z < list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rnd.Next(0,100);
                    Console.WriteLine(array[i,j]);
                }
            }

            //HomeWork
            var hw = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                string ghw = Console.ReadLine(); ;
                if (int.TryParse(ghw, out int gg))
                {
                    hw.Add(gg);
                }
                else
                {
                    Console.WriteLine("Введите число, а не строку");
                    string agn = Console.ReadLine();
                    hw.Add(Convert.ToInt32(agn));
                }
            }
            int sum = 0;
            for (int i = 0; i < hw.Count; i++)
            {
                sum += hw[i];
            }
            Console.WriteLine(sum);

            int minus = 0;
            int l = 0;
            while (l < hw.Count)
            {
                minus -= hw[l];
                l++;
            }
            Console.WriteLine(minus);
            int multip = 1;
            int lm = 0;
            do
            {
                multip *= hw[lm];
                lm++;
            }
            while (lm < hw.Count);
            Console.WriteLine(multip);
            foreach (var item in hw)
            {
                Console.Write(item);
            }
        }
    }
}
