using System;
using System.Linq;

namespace CodeBlog_1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            /*Apple apple = new Apple("Red apple", 100, 100);
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
            Console.WriteLine(sumApple == sumApple2);*/
            Customer Andrew = new Customer("Volkov", "Andrey", 150000);
            Customer Anna = new Customer("Andurbina", "Anna", 110000);

            Seller seller1 = new Seller("Nudon", "Veidron", 1, 80000, 20000);
            Seller seller2 = new Seller("Aputan", "Yutan", 2, 130000, 10000);

            var and_prc = seller2.PC_price + seller2.Setup_price;
            var ann_prc = seller1.PC_price + seller1.Setup_price;

            var sel1_sal = Andrew.PC_Buy(and_prc);
            var sel2_sal = Anna.PC_Buy(ann_prc);

            seller1.SalaryCount(sel1_sal);
            seller2.SalaryCount(sel2_sal);

            Console.WriteLine(seller1 + seller2);
            Console.WriteLine(seller1 == seller2);
            Console.WriteLine(seller1 != seller2);
            Console.WriteLine(seller2 > seller1);
            Console.WriteLine(seller1 < seller2);
            Console.WriteLine(Andrew <= Anna);
            Console.WriteLine(Andrew >= Anna);
        }
    }
}
