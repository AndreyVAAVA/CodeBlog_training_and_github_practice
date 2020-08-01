using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlog_1
{
    public delegate void MyDelegate();
    partial class Program
    {
        public delegate int ValueDelegate(int i);
        public event MyDelegate Event;
        public event Action EventAction;
        static void Main(string[] args)
        {
            #region delegate
            /*MyDelegate myDelegate = Method1;
            myDelegate += Method4;

            MyDelegate myDelegate2 = new MyDelegate(Method3);
            myDelegate2 += Method4;
            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate();
            myDelegate2.Invoke();
            myDelegate3.Invoke();

            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate -= MethodValue;
            valueDelegate((new Random()).Next(10,50));

            Action action = Method1;
            action();

            Predicate<int> predicate;

            Func<int, int> func = MethodValue;

            func?.Invoke(7);*/
            #endregion

            #region event
            /*Person person = new Person()
            {
                Name = "Vasya"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));*/
            #endregion

            Console.WriteLine(Sum(5, 5, Calc1));
            Console.WriteLine(Sum(5, 5, Calc2));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if(sender is Person)
            {
            Console.WriteLine($"{((Person)sender).Name} work");
            }

        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Human GoToSleep");
        }

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3()
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        private static int Sum(int a, int b, Func<int, int, int> calc)
        {
            return calc(a, b);
        }
        private static int Calc1(int i, int j)
        {
            return i + j;
        }
        private static int Calc2(int i, int j)
        {
            return i * j;
        }
    }

}
