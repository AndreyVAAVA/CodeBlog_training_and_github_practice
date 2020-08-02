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

            using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8))
            {
                sw.Write("Hello World");
                sw.WriteLine("Hello, User");
            }
            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + " end of string");
                }

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }
    }

}
