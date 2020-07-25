using System;

namespace CodeBlog_1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Person p = new Person("Vasya", "Pupkin");
            /*p.SecondName = "Vasya";
            Console.WriteLine(p.SecondName);
            p.Name = "Pupkin";
            Console.WriteLine(p.FullName);*/
            Console.WriteLine(p.ShortName);
        }
    }
}
