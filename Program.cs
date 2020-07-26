using System;
using System.Linq;

namespace CodeBlog_1
{
    partial class Program
    {
        private const int V = 16;

        static void Main(string[] args)
        {
            Apple apple = new Apple("Red apple", 100, 100);
            Apple apple2 = new Apple("Green apple", 90, 110);
            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
            var sumApple3 = apple + 100;
            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);
            Console.WriteLine(apple==apple2);
            Console.WriteLine(sumApple == sumApple2);
        }
    }
}
