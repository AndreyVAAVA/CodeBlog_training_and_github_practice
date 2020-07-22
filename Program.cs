using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CodeBlog_1
{
    partial class Program
    {
        static void Main(string[] args)
        {

        int[] array = new int[10];
            int i = 0;
            while (i < 10)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
                i++;
            }
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            Console.WriteLine(list[0]);
            Console.WriteLine(Days.Mon);
        }
    }
}
