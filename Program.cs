using System;

namespace CodeBlog_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "1";
            //int i = (string)s;
            //int j = (byte)5;
            //double d = j;
            //int k = (double)d;
            //int i = 5;
            //int j = 2048;
            //byte b = (byte)i;
            //byte bb = (byte)j;
            //Console.WriteLine(bb);

            //string s = "2048";
            //int jojo = Convert.ToInt32(s);
            //int huis = Int32.Parse("42");
            //Console.WriteLine(jojo);

            int.TryParse("123", out int z);
            Console.WriteLine(z);

            //byte b = 42;
            //int o = b;

        }
    }
}
