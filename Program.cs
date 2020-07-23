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
        }
    }
}
