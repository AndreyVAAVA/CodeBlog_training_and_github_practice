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
        static void Main(string[] args)
        {
            #region async
            /*var calc = new Perf_Calc();
            var result = calc.PerfAsync();
            Console.ReadLine();
            Console.WriteLine(result.Result);*/
            #endregion
            #region thread
            Thread thread = new Thread(Logo);
            Thread thread2 = new Thread(Logo);
            Thread thread3 = new Thread(Logo);

            // Set the priority of threads 
            thread.Priority = ThreadPriority.Highest;
            thread3.Priority = ThreadPriority.BelowNormal;
            thread3.Start();
            thread.Start();
            thread2.Start();
            //thread.Abort();

            // Display the priority of threads 
            Console.WriteLine("The priority of thread is: {0}",
                                              thread.Priority);

            Console.WriteLine("The priority of thread2 is: {0}",
                                              thread2.Priority);

            Console.WriteLine("The priority of thread3 is: {0}",
                                              thread3.Priority);
            Thread T = new Thread(new ParameterizedThreadStart(Logo2));
            T.Start("Extreme");
            // Creating and initializing threads 
            /*Thread T1 = new Thread(work);
            Thread T2 = new Thread(work);
            Thread T3 = new Thread(work);

            // Set the priority of threads 
            T2.Priority = ThreadPriority.Highest;
            T3.Priority = ThreadPriority.BelowNormal;
            T1.Start();
            T2.Start();
            T3.Start();

            // Display the priority of threads 
            Console.WriteLine("The priority of T1 is: {0}",
                                              T1.Priority);

            Console.WriteLine("The priority of T2 is: {0}",
                                              T2.Priority);

            Console.WriteLine("The priority of T3 is: {0}",
                                              T3.Priority);*/
        }
        /*public static void work()
        {

            // Sleep for 1 second 
            Thread.Sleep(1000);
        }*/
        /*public static void work()
        {

            // Sleep for 1 second 
            Thread.Sleep(1000);
        }*/
        public static void Logo()
        {
            Console.WriteLine( "Nvidia" + "AMD" + "Intel");
            Thread.Sleep(1000);
        }
        public static void Logo2(object max)
        {
            Console.WriteLine($"{max} Nvidia AMD Intel");
            Thread.Sleep(1000);
        }


        #endregion
    }

}
