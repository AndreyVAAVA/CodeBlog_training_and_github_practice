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


        }
    }
}
