using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlog_1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            /*int a = 200000000;
            int b = 200000000;
            int c = checked(a * b);*/

            /*try
            {
                var i = 5;
                var j = i / 0;
                Console.WriteLine(j);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception");
                throw;

            }
            finally
            {
                Console.WriteLine("Application closed");
            }*/

            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }
            }
            int i = 5;
            try
            {
                throw new MyOwnException();
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine("My Own Excpetion");
            }
            catch (DivideByZeroException ex) when (i == 5)
            {
                Console.WriteLine("Деление на 0 (i = 5)");
                throw;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Work finished");
            }
            finally
            {
                Console.WriteLine("Work ended");
            }


        }
    }
}
