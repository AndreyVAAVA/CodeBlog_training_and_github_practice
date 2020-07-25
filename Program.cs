using System;

namespace CodeBlog_1
{
    partial class Program
    {
        private const int V = 16;

        static void Main(string[] args)
        {
            /*var name = Console.ReadLine();
            Person p = new Person("Vasya", "Pupkin");*/
            /*p.SecondName = "Vasya";
            Console.WriteLine(p.SecondName);
            p.Name = "Pupkin";
            Console.WriteLine(p.FullName);*/
            /*Console.WriteLine(p.ShortName);
             Customer customer = new Customer("Andrey", "Volkov", 1);*/
            PrintHello("Andrew", V);
            var person1 = new Person("Ivanov", "Ivan");
            var person2 = new Person("Petrov", "Petr");

            for(var i = 0; i < 10; i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);
                var position2 = person2.Run();
                Console.WriteLine(position2);
                Console.WriteLine(person2.RunToPosition(10,9));
            }
            Console.WriteLine(Factorial(5));

        }
        public static void PrintHello(string name, int age)
        {
            Console.WriteLine($"Привет, {name}! Your age is {age}");
        }
        public static int Factorial(int value)
        {
            if (value <= 1) 
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
