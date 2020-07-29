using System;

namespace CodeBlog_1
{
    class BMWXSeven : ICar
    {
        public void Create()
        {
            Console.WriteLine("Car Matters");
        }

        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
