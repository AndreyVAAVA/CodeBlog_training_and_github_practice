using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeBlog_1
{
    public delegate void MyDelegate();
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var user_input = Console.ReadLine();
            using (var write_to_file = new StreamWriter("test.txt", true))
            {
                write_to_file.WriteLine(user_input);
            }
            Console.WriteLine("Хотите ли прочитать данные из файла(пишите да или нет(только lowercase))?");
            var command = Console.ReadLine();
            if(command == "да")
            {
                using (var read_file = new StreamReader("test.txt", true))
                {
                    Console.WriteLine(read_file.ReadToEnd()); 
                }
            }
            else if(command == "нет")
            {
                Console.WriteLine("Ок, понял, не буду");
            }
            else
            {
                Console.WriteLine("Сорян, ты сам виноват, неправильно ты написал");
            }

        }
    }

}
