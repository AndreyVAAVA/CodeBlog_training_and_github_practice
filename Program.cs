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
            list.AddRange(new int[] { 0, 1 });

            C[] cs = new C[10];
            List<C> css = new List<C>();

            Console.WriteLine(list[0]);
            Console.WriteLine(Days.Mon);
            List<string> lst5 = new List<string>() 
            {
                "AMD", "TOP", "YOU", "UNDERSTAND", "?" 
            };
            int[] amd = new int[5] 
            {
                1, 2, 3, 4, 5
            };
            int ling = 0;
            while (ling < 5) 
            {
                Console.WriteLine(lst5[ling]);
                Console.WriteLine(amd[ling]);
                ling++;
            }
            Console.WriteLine(lng5.first);
            Console.WriteLine(lng5.second);
            Console.WriteLine(lng5.third);
            Console.WriteLine(lng5.fourth);
            Console.WriteLine(lng5.fifth);
        }
        public class C
        {

        }
        enum lng5
        {
            first,
            second,
            third,
            fourth,
            fifth
        };
    }
}
