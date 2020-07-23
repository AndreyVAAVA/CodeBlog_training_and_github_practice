using System;
using System.Collections.Generic;

namespace CodeBlog_1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 10 && input > 0)
            {
                Console.WriteLine("Smaller");
            }
            else if (input < 0)
            {
                Console.WriteLine("Lower than zero");
            }
            else
            {
                Console.WriteLine("Bigger");
            }

            string s = "Hi!";
            if (s.Equals("hi"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            switch (input)
            {
                case 999:
                    Console.WriteLine("WTF");
                    break;
                case 777:
                    Console.WriteLine("Oh God");
                    break;
                case 666:
                    Console.WriteLine("You are a fucking demon!");
                    break;
                default:
                    Console.WriteLine("And what?");
                    break;
            }
            Console.WriteLine(input == 333 ? "Yeah" :"OOPS");

            int rl1 = int.Parse(Console.ReadLine());
            int rl2 = int.Parse(Console.ReadLine());
            int rl3 = int.Parse(Console.ReadLine());
            int rl;
            if(rl1 > rl2 && rl1 > rl3)
            {
                rl = rl1;
            }
            else if(rl2 > rl1 && rl2 > rl3)
            {
                rl = rl2;
            }
            else
            {
                rl = rl3;
            }
            Console.WriteLine(rl);

            float rlch = rl % 2;

            switch (rlch)
            {
                case 0:
                    Console.WriteLine("Чётное число");
                    break;
                default:
                    Console.WriteLine("Не чётное число");
                    break;
            }

            Console.WriteLine(rl<100?"Меньше 100" : "Больше 100, ну или 100");
        }
    }
}
