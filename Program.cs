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

            try
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
            }

            /*while (true)
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
                break;
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
            }*/
            var gaming = new PC();
            gaming.Cooler = 0;
            gaming.CPU = 0;
            gaming.DriveDevice = 0;
            gaming.GraphicsCard = 0;
            gaming.Motherboard = 0;
            gaming.PowerSupply = 0;
            gaming.RAM = 0;
            try
            {
                var cpu = 1 / gaming.CPU;
                var cooler = 1 / gaming.Cooler;
                var drivedevice = 1 / gaming.DriveDevice;
                var graphicscard = 1 / gaming.DriveDevice;
                throw new MyOwnException();
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine("ЭЭЭЭ");
                throw ex;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("AAAA");
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("BBBB");
                throw ex;
            }
            finally
            {
                Console.WriteLine("Ты дурак, как может быть 0 вещей, учитывая, что без этого комп не будет работать");
            }
        }
    }
}
