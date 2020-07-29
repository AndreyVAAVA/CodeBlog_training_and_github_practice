using System;

namespace CodeBlog_1
{
    class LadaSeven : ICar
    {
        public void Create()
        {
            Console.WriteLine("It always broken");
        }

        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
