using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeBlog_1
{
    public delegate void MyDelegate();
    class Program
    {
        public static object locker = new object();

        public static int i1 = 0;
        public static int i2 = 0;

        static void M1()
        {
            for(int i = 0; i <= i1; i++)
            {

            }
        }
        static void M2()
        {
            for (int i = 0; i >= i1; i--)
            {

            }
        }
        static void Main(string[] args)
        {
            #region thread
            /*Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();

            Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            thread2.Start(int.MaxValue);
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("Main");
                }
            }*/
            #endregion

            #region async
            /*Console.WriteLine("Start");
            DoWorkAsync();
            Console.WriteLine("Continue");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main");
            }
            Console.WriteLine("End");*/
            #endregion
            var result = SaveFileAsync();
            Console.ReadLine();
            Console.WriteLine(result.Result);
        }

        static async Task<bool> SaveFileAsync()
        {
            var result = await Task<bool>.Run(() => SaveFile());
            return result;
        }

        static bool SaveFile()
        {
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for(int i = 0; i < 1000; i++)
                {
                    text += rnd.Next();
                }
                using (var sw = new StreamWriter("sync.txt", false, Encoding.UTF8))
                {
                    sw.WriteLine();
                }
                return true;
            }

        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("Start Async");
            await Task.Run(() => DoWork());
            Console.WriteLine("End Async");
            
        }

        static void DoWork()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("DoWork");
            }
        }
        static void DoWork2(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWork 2");
                }
            }
        }
    }

}
